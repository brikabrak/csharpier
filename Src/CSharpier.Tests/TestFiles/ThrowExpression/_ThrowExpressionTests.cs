using CSharpier.Tests.TestFileTests;
using NUnit.Framework;

namespace CSharpier.Tests.TestFiles
{
    public class ThrowExpressionTests : BaseTest
    {
        [Test]
        public void ThrowExpressions()
        {
            this.RunTest("ThrowExpression", "ThrowExpressions");
        }
    }
}
