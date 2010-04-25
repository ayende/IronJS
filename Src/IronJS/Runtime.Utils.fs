﻿namespace IronJS.Runtime.Utils

open IronJS
open IronJS.Aliases
open IronJS.Tools
open IronJS.Runtime
open IronJS.Parser

module Type = 

  let isObject (typ:ClrType) = 
    typ = Runtime.Object.TypeDef || typ.IsSubclassOf(Runtime.Object.TypeDef)

module Box = 

  let nullBox = 
    let mutable box = new Box()
    box.Type <- TypeCodes.null'
    box