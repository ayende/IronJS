// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter12
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _12_10_Tests : IE9TestFixture
    {
        public _12_10_Tests() : base(@"chapter12\12.10") { }

        [Test(Description = "with does not change declaration scope - vars in with are visible outside")] public void _12_10__0__1() { RunFile(@"12.10-0-1.js"); }
        [Test(Description = "with introduces scope - name lookup finds function parameter")] public void _12_10__0__10() { RunFile(@"12.10-0-10.js"); }
        [Test(Description = "with introduces scope - name lookup finds inner variable")] public void _12_10__0__11() { RunFile(@"12.10-0-11.js"); }
        [Test(Description = "with introduces scope - name lookup finds property")] public void _12_10__0__12() { RunFile(@"12.10-0-12.js"); }
        [Test(Description = "with introduces scope - that is captured by function expression")] public void _12_10__0__3() { RunFile(@"12.10-0-3.js"); }
        [Test(Description = "with introduces scope - scope removed when exiting with statement")] public void _12_10__0__7() { RunFile(@"12.10-0-7.js"); }
        [Test(Description = "with introduces scope - var initializer sets like named property")] public void _12_10__0__8() { RunFile(@"12.10-0-8.js"); }
        [Test(Description = "with introduces scope - name lookup finds outer variable")] public void _12_10__0__9() { RunFile(@"12.10-0-9.js"); }
        [Test(Description = "with - expression being Number")] public void _12_10__2__1() { RunFile(@"12.10-2-1.js"); }
        [Test(Description = "with - expression being Boolean")] public void _12_10__2__2() { RunFile(@"12.10-2-2.js"); }
        [Test(Description = "with - expression being string")] public void _12_10__2__3() { RunFile(@"12.10-2-3.js"); }
        [Test(Description = "with introduces scope - restores the earlier environment on exit")] public void _12_10__7__1() { RunFile(@"12.10-7-1.js"); }
    }
}