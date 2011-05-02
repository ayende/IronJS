// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter15._15_2._15_2_3
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _15_2_3_4_Tests : IE9TestFixture
    {
        public _15_2_3_4_Tests() : base(@"chapter15\15.2\15.2.3\15.2.3.4") { }

        [Test(Description = "Object.getOwnPropertyNames must exist as a function")] public void _15_2_3_4__0__1() { RunFile(@"15.2.3.4-0-1.js"); }
        [Test(Description = "Object.getOwnPropertyNames must exist as a function taking 1 parameter")] public void _15_2_3_4__0__2() { RunFile(@"15.2.3.4-0-2.js"); }
        [Test(Description = "Object.getOwnPropertyNames throws TypeError if type of first param is not Object")] public void _15_2_3_4__1() { RunFile(@"15.2.3.4-1.js"); }
        [Test(Description = "Object.getOwnPropertyNames throws TypeError if \'O\' is undefined")] public void _15_2_3_4__1__2() { RunFile(@"15.2.3.4-1-2.js"); }
        [Test(Description = "Object.getOwnPropertyNames throws TypeError if \'O\' is null")] public void _15_2_3_4__1__3() { RunFile(@"15.2.3.4-1-3.js"); }
        [Test(Description = "Object.getOwnPropertyNames throws TypeError if \'O\' is a boolean")] public void _15_2_3_4__1__4() { RunFile(@"15.2.3.4-1-4.js"); }
        [Test(Description = "Object.getOwnPropertyNames throws TypeError if \'O\' is a string")] public void _15_2_3_4__1__5() { RunFile(@"15.2.3.4-1-5.js"); }
        [Test(Description = "Object.getOwnPropertyNames - returned array is an array according to Array.isArray")] public void _15_2_3_4__2__1() { RunFile(@"15.2.3.4-2-1.js"); }
        [Test(Description = "Object.getOwnPropertyNames - returned array is an instance of Array")] public void _15_2_3_4__2__2() { RunFile(@"15.2.3.4-2-2.js"); }
        [Test(Description = "Object.getOwnPropertyNames - length of returned array is initialized to 0")] public void _15_2_3_4__2__3() { RunFile(@"15.2.3.4-2-3.js"); }
        [Test(Description = "Object.getOwnPropertyNames - returned array is the standard built-in constructor")] public void _15_2_3_4__2__4() { RunFile(@"15.2.3.4-2-4.js"); }
        [Test(Description = "Object.getOwnPropertyNames - elements of the returned array start from index 0")] public void _15_2_3_4__3__1() { RunFile(@"15.2.3.4-3-1.js"); }
        [Test(Description = "Object.getOwnPropertyNames returns array of property names (Global)")] public void _15_2_3_4__4__1() { RunFile(@"15.2.3.4-4-1.js"); }
        [Test(Description = "Object.getOwnPropertyNames returns array of property names (Object)")] public void _15_2_3_4__4__2() { RunFile(@"15.2.3.4-4-2.js"); }
        [Test(Description = "Object.getOwnPropertyNames - inherited data properties are not pushed into the returned array")] public void _15_2_3_4__4__36() { RunFile(@"15.2.3.4-4-36.js"); }
        [Test(Description = "Object.getOwnPropertyNames - inherited accessor properties are not pushed into the returned array")] public void _15_2_3_4__4__37() { RunFile(@"15.2.3.4-4-37.js"); }
        [Test(Description = "Object.getOwnPropertyNames - own data properties are pushed into the returned array")] public void _15_2_3_4__4__38() { RunFile(@"15.2.3.4-4-38.js"); }
        [Test(Description = "Object.getOwnPropertyNames - own accessor properties are pushed into the returned array")] public void _15_2_3_4__4__39() { RunFile(@"15.2.3.4-4-39.js"); }
        [Test(Description = "Object.getOwnPropertyNames - inherited data property of String object \'O\' is not pushed into the returned array")] public void _15_2_3_4__4__40() { RunFile(@"15.2.3.4-4-40.js"); }
        [Test(Description = "Object.getOwnPropertyNames - inherited accessor property of String object \'O\' is not pushed into the returned array")] public void _15_2_3_4__4__41() { RunFile(@"15.2.3.4-4-41.js"); }
        [Test(Description = "Object.getOwnPropertyNames - own data property of String object \'O\' is pushed into the returned array")] public void _15_2_3_4__4__42() { RunFile(@"15.2.3.4-4-42.js"); }
        [Test(Description = "Object.getOwnPropertyNames - own accessor property of String object \'O\' is pushed into the returned array")] public void _15_2_3_4__4__43() { RunFile(@"15.2.3.4-4-43.js"); }
        [Test(Description = "Object.getOwnPropertyNames - own index properties of String object are pushed into the returned Array")] public void _15_2_3_4__4__44() { RunFile(@"15.2.3.4-4-44.js"); }
        [Test(Description = "Object.getOwnPropertyNames - inherited data property of Array object \'O\' is not pushed into the returned array.")] public void _15_2_3_4__4__45() { RunFile(@"15.2.3.4-4-45.js"); }
        [Test(Description = "Object.getOwnPropertyNames - inherited accessor property of Array object \'O\' is not pushed into the returned array.")] public void _15_2_3_4__4__46() { RunFile(@"15.2.3.4-4-46.js"); }
        [Test(Description = "Object.getOwnPropertyNames - own data property of Array object \'O\' is pushed into the returned array")] public void _15_2_3_4__4__47() { RunFile(@"15.2.3.4-4-47.js"); }
        [Test(Description = "Object.getOwnPropertyNames - own accessor property of Array object \'O\' is pushed into the returned array.")] public void _15_2_3_4__4__48() { RunFile(@"15.2.3.4-4-48.js"); }
        [Test(Description = "Object.getOwnPropertyNames - own index properties of Array objcect are pushed into the returned Array")] public void _15_2_3_4__4__49() { RunFile(@"15.2.3.4-4-49.js"); }
        [Test(Description = "Object.getOwnPropertyNames - non-enumerable own property of \'O\' is pushed into the returned Array")] public void _15_2_3_4__4__50() { RunFile(@"15.2.3.4-4-50.js"); }
        [Test(Description = "Object.getOwnPropertyNames - descriptor of resultant array is all true")] public void _15_2_3_4__4__b__1() { RunFile(@"15.2.3.4-4-b-1.js"); }
        [Test(Description = "Object.getOwnPropertyNames - all own properties are pushed into the returned array")] public void _15_2_3_4__4__b__2() { RunFile(@"15.2.3.4-4-b-2.js"); }
        [Test(Description = "Object.getOwnPropertyNames - own property named empty(\'\') is pushed into the returned array")] public void _15_2_3_4__4__b__3() { RunFile(@"15.2.3.4-4-b-3.js"); }
        [Test(Description = "Object.getOwnPropertyNames - elements of the returned array are writable")] public void _15_2_3_4__4__b__4() { RunFile(@"15.2.3.4-4-b-4.js"); }
        [Test(Description = "Object.getOwnPropertyNames - elements of the returned array are enumerable")] public void _15_2_3_4__4__b__5() { RunFile(@"15.2.3.4-4-b-5.js"); }
        [Test(Description = "Object.getOwnPropertyNames - elements of the returned array are configurable")] public void _15_2_3_4__4__b__6() { RunFile(@"15.2.3.4-4-b-6.js"); }
    }
}