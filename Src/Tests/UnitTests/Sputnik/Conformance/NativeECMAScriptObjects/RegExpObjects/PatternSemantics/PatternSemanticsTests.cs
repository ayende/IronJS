// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.RegExpObjects.PatternSemantics
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class PatternSemanticsTests : SputnikTestFixture
    {
        public PatternSemanticsTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.10_RegExp_Objects\15.10.2_Pattern_Semantics")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.10.2")]
        [TestCase("S15.10.2_A1_T1.js", Description = "XML Shallow Parsing with Regular Expressions")]
        public void XMLShallowParsingWithRegularExpressions(string file)
        {
            RunFile(file);
        }
    }
}