// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter15._15_4._15_4_4
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _15_4_4_12_Tests : IE9TestFixture
    {
        public _15_4_4_12_Tests() : base(@"chapter15\15.4\15.4.4\15.4.4.12") { }

        [Test(Description = "Array.prototype.splice - \'from\' is the result of ToString(actualStart+k) in an Array")] public void _15_4_4_12__9__a__1() { RunFile(@"15.4.4.12-9-a-1.js"); }
        [Test(Description = "Array.prototype.splice will splice an array even when Array.prototype has index \'0\' set to read-only and \'fromPresent\' less than \'actualDeleteCount (Step 9.c.ii)")] public void _15_4_4_12__9__c__ii__1() { RunFile(@"15.4.4.12-9-c-ii-1.js"); }
    }
}