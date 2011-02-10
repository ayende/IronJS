﻿namespace IronJS

open IronJS
open IronJS.Dlr.Operators

module Expr = 

  //----------------------------------------------------------------------------
  module Patterns =
    
    let (|IsBox|IsRef|IsVal|) (expr:Dlr.Expr) =
      if expr.Type = typeof<BoxedValue>
        then IsBox
        elif Dlr.Utils.isT<double> expr || Dlr.Utils.isT<bool> expr
          then IsVal
          else IsRef

    let (|IsIndex|_|) (expr:Dlr.Expr) =
      if expr.Type = typeof<uint32> then Some () else None
    
  //----------------------------------------------------------------------------
  module BoxedConstants =

    let zero = Dlr.propertyInfoStatic Utils.BoxedConstants.Reflected.zero
    let undefined = Dlr.propertyInfoStatic Utils.BoxedConstants.Reflected.undefined
      
  //----------------------------------------------------------------------------
  module Box =
    
    let tag expr = Dlr.field expr "Tag"
    let marker expr = Dlr.field expr "Marker"
    
    let isBool (expr:Dlr.Expr) = Dlr.eq (tag expr) !!!TypeTags.Bool
    let isNumber (expr:Dlr.Expr) = Dlr.lt (marker expr) !!!Markers.Tagged
    let isClr (expr:Dlr.Expr) = Dlr.eq (tag expr) !!!TypeTags.Clr
    let isString (expr:Dlr.Expr) = Dlr.eq (tag expr) !!!TypeTags.String
    let isUndefined (expr:Dlr.Expr) = Dlr.eq (tag expr) !!!TypeTags.Undefined
    let isObject (expr:Dlr.Expr) = Dlr.gtEq (tag expr) !!!TypeTags.Object
    let isFunction (expr:Dlr.Expr) = Dlr.eq (tag expr) !!!TypeTags.Function

    let unboxNumber box = Dlr.field box BoxFields.Number
    let unboxBool box = Dlr.field box BoxFields.Bool
    let unboxClr box = Dlr.field box BoxFields.Clr
    let unboxString box = Dlr.field box BoxFields.String
    let unboxUndefined box = Dlr.field box BoxFields.Undefined
    let unboxObject box = Dlr.field box BoxFields.Object
    let unboxFunction box = Dlr.field box BoxFields.Function

    let setTag expr t =
      match t with
      | TypeTags.Number -> Dlr.void'
      | _ -> Dlr.assign (tag expr) !!!t

    let setTagOf expr (of':Dlr.Expr) = 
      setTag expr (of'.Type |> Utils.type2tag)

    let setValue (expr:Dlr.Expr) (value:Dlr.Expr)= 
      let bf = value.Type |> Utils.type2field
      Dlr.assign (Dlr.field expr bf) value
      
  //----------------------------------------------------------------------------
  module Object =
    let prototype expr = Dlr.field expr "Prototype"
      
  //----------------------------------------------------------------------------
  let num_1 = !!! -1.0
  let num0 = !!! 0.0
  let num1 = !!! 1.0
  let num2 = !!! 2.0
        
  //----------------------------------------------------------------------------
  let undefined = Dlr.propertyStaticT<Undefined> "Instance"
  let errorValue error = Dlr.field error "JsValue"
  let isBoxed (expr:Dlr.Expr) = Dlr.Utils.isT<BoxedValue> expr
    
  let voidAsUndefined (expr:Dlr.Expr) =
    if Dlr.Utils.isVoid expr
      then Dlr.blockSimple [expr; BoxedConstants.undefined]
      else expr
  
  let normalizeVal (expr:Dlr.Expr) =
    if Dlr.Utils.isT<bool> expr 
      then Dlr.ternary expr !!!TaggedBools.True !!!TaggedBools.False
      else expr
    
  let box value = 
    if isBoxed value then value
    else
      Dlr.blockTmpT<IronJS.BoxedValue> (fun tmp ->
        [
          (Box.setTagOf tmp value)
          (Box.setValue tmp value)
          (tmp :> Dlr.Expr)
        ] |> Seq.ofList
      )

  //----------------------------------------------------------------------------
  let blockTmp (expr:Dlr.Expr) (f:Dlr.Expr -> Dlr.Expr list) = 
    if Dlr.Ext.isStatic expr then
      Dlr.blockSimple (f expr)
    else
      let tmp = Dlr.param (Dlr.tmpName()) expr.Type
      Dlr.block [tmp] (Dlr.assign tmp expr :: f (Dlr.Ext.static' tmp))
        
  let blockTmpType (type':System.Type) (expr:Dlr.Expr) f =
    if expr.Type = type' then
      if Dlr.Ext.isStatic expr then
        let exprs : Dlr.Expr list = f expr
        if exprs.Length = 0 
          then exprs.[0] 
          else Dlr.blockSimple exprs

      else
        let tmp = Dlr.param (Dlr.tmpName()) expr.Type
        Dlr.block [tmp] (Dlr.assign tmp !@expr :: f (Dlr.Ext.static' tmp))

    elif isBoxed expr then
      let unboxed = unbox type' (Dlr.Ext.unwrap expr)

      if Dlr.Ext.isStatic unboxed then
        let exprs = f unboxed
        if exprs.Length = 0
          then exprs.[0]
          else Dlr.blockSimple exprs

      else
        let tmp = Dlr.param (Dlr.tmpName()) type'
        Dlr.block [tmp] (Dlr.assign tmp unboxed :: f (Dlr.Ext.static' tmp))

    else
      let tmp = Dlr.param (Dlr.tmpName()) type'
      let casted = Dlr.cast type' expr
      Dlr.block [tmp] (Dlr.assign tmp casted :: f (Dlr.Ext.static' tmp))
        
  let blockTmpT<'a> expr f = 
    blockTmpType typeof<'a> expr f

  //----------------------------------------------------------------------------
  let assign (lexpr:Dlr.Expr) rexpr = 

    let setBoxClrNull expr = 
      Dlr.assign (Dlr.field (Dlr.Ext.unwrap expr) BoxFields.Clr) Dlr.null'

    let assignBox (lexpr:Dlr.Expr) (rexpr:Dlr.Expr) =
      if isBoxed rexpr then 
        Dlr.assign (Dlr.Ext.unwrap lexpr) rexpr

      else
        let typeCode = rexpr.Type |> Utils.type2tag
        let box = Dlr.Ext.unwrap lexpr
        let val' = Dlr.Ext.unwrap rexpr
        if typeCode <= TypeTags.Number then
          Dlr.blockSimple
            [setBoxClrNull box; Box.setTagOf box val'; Box.setValue box val']

        else
          Dlr.blockSimple 
            [Box.setTagOf box val'; Box.setValue box val']

    if isBoxed lexpr 
      then assignBox lexpr rexpr 
      else Dlr.assign (Dlr.Ext.unwrap lexpr) rexpr