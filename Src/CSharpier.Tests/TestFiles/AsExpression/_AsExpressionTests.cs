using CSharpier.Tests.TestFileTests;
using NUnit.Framework;

namespace CSharpier.Tests.TestFiles
{
    public class AsExpressionTests : BaseTest
    {
        [Test]
        public void AsExpressions()
        {
            this.RunTest("AsExpression", "AsExpressions");
        }
    }
}
