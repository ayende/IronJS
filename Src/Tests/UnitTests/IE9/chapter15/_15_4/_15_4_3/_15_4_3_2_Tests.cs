// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter15._15_4._15_4_3
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _15_4_3_2_Tests : IE9TestFixture
    {
        public _15_4_3_2_Tests() : base(@"chapter15\15.4\15.4.3\15.4.3.2") { }

        [Test(Description = "Array.isArray must exist as a function")] public void _15_4_3_2__0__1() { RunFile(@"15.4.3.2-0-1.js"); }
        [Test(Description = "Array.isArray must exist as a function taking 1 parameter")] public void _15_4_3_2__0__2() { RunFile(@"15.4.3.2-0-2.js"); }
        [Test(Description = "Array.isArray return true if its argument is an Array")] public void _15_4_3_2__0__3() { RunFile(@"15.4.3.2-0-3.js"); }
        [Test(Description = "Array.isArray return false if its argument is not an Array")] public void _15_4_3_2__0__4() { RunFile(@"15.4.3.2-0-4.js"); }
        [Test(Description = "Array.isArray return true if its argument is an Array (Array.prototype)")] public void _15_4_3_2__0__5() { RunFile(@"15.4.3.2-0-5.js"); }
        [Test(Description = "Array.isArray return true if its argument is an Array (new Array())")] public void _15_4_3_2__0__6() { RunFile(@"15.4.3.2-0-6.js"); }
        [Test(Description = "Array.isArray returns false if its argument is not an Array")] public void _15_4_3_2__0__7() { RunFile(@"15.4.3.2-0-7.js"); }
        [Test(Description = "Array.isArray applied to boolean primitive")] public void _15_4_3_2__1__1() { RunFile(@"15.4.3.2-1-1.js"); }
        [Test(Description = "Array.isArray applied to RegExp object")] public void _15_4_3_2__1__10() { RunFile(@"15.4.3.2-1-10.js"); }
        [Test(Description = "Array.isArray applied to the JSON object")] public void _15_4_3_2__1__11() { RunFile(@"15.4.3.2-1-11.js"); }
        [Test(Description = "Array.isArray applied to Error object")] public void _15_4_3_2__1__12() { RunFile(@"15.4.3.2-1-12.js"); }
        [Test(Description = "Array.isArray applied to Arguments object")] public void _15_4_3_2__1__13() { RunFile(@"15.4.3.2-1-13.js"); }
        [Test(Description = "Array.isArray applied to the global object")] public void _15_4_3_2__1__15() { RunFile(@"15.4.3.2-1-15.js"); }
        [Test(Description = "Array.isArray applied to Boolean Object")] public void _15_4_3_2__1__2() { RunFile(@"15.4.3.2-1-2.js"); }
        [Test(Description = "Array.isArray applied to number primitive")] public void _15_4_3_2__1__3() { RunFile(@"15.4.3.2-1-3.js"); }
        [Test(Description = "Array.isArray applied to Number object")] public void _15_4_3_2__1__4() { RunFile(@"15.4.3.2-1-4.js"); }
        [Test(Description = "Array.isArray applied to string primitive")] public void _15_4_3_2__1__5() { RunFile(@"15.4.3.2-1-5.js"); }
        [Test(Description = "Array.isArray applied to String object")] public void _15_4_3_2__1__6() { RunFile(@"15.4.3.2-1-6.js"); }
        [Test(Description = "Array.isArray applied to Function object")] public void _15_4_3_2__1__7() { RunFile(@"15.4.3.2-1-7.js"); }
        [Test(Description = "Array.isArray applied to the Math object")] public void _15_4_3_2__1__8() { RunFile(@"15.4.3.2-1-8.js"); }
        [Test(Description = "Array.isArray applied to Date object")] public void _15_4_3_2__1__9() { RunFile(@"15.4.3.2-1-9.js"); }
        [Test(Description = "Array.isArray applied to an object with an array as the prototype")] public void _15_4_3_2__2__1() { RunFile(@"15.4.3.2-2-1.js"); }
        [Test(Description = "Array.isArray applied to an object with Array.prototype as the prototype")] public void _15_4_3_2__2__2() { RunFile(@"15.4.3.2-2-2.js"); }
        [Test(Description = "Array.isArray applied to an Array-like object with length and some indexed properties")] public void _15_4_3_2__2__3() { RunFile(@"15.4.3.2-2-3.js"); }
    }
}