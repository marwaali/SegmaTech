using NUnit.Framework;
using Task.Pages;
using Test;

namespace Task.TestCases
{
    public  class TestCase: BaseTest
    {
        [Test]
        public void DynamicFilteration()
        {
            DriverOperations op = new DriverOperations(driver);
            op.NavigateToUrl(dl.url);
            AcceptAllCookies();
            DemoPage demo = new DemoPage(driver);
            demo.OpenFilterMenuForColumn(dl.column);
            demo.FilterByText(dl.game);
            Assert.AreEqual(dl.mayValue, demo.GetMayBreadkDown(), "Values aren't equal");
        }
    }
}