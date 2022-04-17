using OpenQA.Selenium;
using Test;

namespace Task.Pages
{
    public class DemoPage
    {
        private IWebDriver _driver;
        private IWebElement _columnFilterMenu;
        private IWebElement _filterTab;
        private IWebElement _searchBox;
        private IWebElement _mayBreakDown;
        private IWebElement _cloumnFilterMenu;
        private IWebElement _horizontalScroll;
        DriverOperations op;
        

        public DemoPage(IWebDriver driver)
        {
            _driver = driver;
            op = new DriverOperations(_driver);
            _cloumnFilterMenu = _driver.FindElement(By.CssSelector("button[ref='eToggleButton']"));
            _horizontalScroll = _driver.FindElement(By.CssSelector("div[ref='eViewport'][class*='horizontal-scroll']"));
        }

        public void OpenFilterMenuForColumn(string columnName)
        {
            _columnFilterMenu = _driver.FindElement(By.XPath($"//span[text()='{columnName}']/../../span[@ref='eMenu']"));
            _columnFilterMenu.Click();
        }

        private void toggleFilter()
        {
            _filterTab = _driver.FindElement(By.CssSelector("div[class*='ag-tabs'] span[class*='ag-icon-filter']"));
            _filterTab.Click();
        }

        public void FilterByText(string text)
        {
            toggleFilter();
            _searchBox = _driver.FindElement(By.CssSelector("div[ref='eMiniFilter'] input"));
            _searchBox.SendKeys(text);
            _searchBox.SendKeys(Keys.Enter);
            toggleFilter();
        }
        
        public string GetMayBreadkDown()
        {
            _cloumnFilterMenu.Click();
            op.ScrollHorizontal(_horizontalScroll);
            _mayBreakDown = _driver.FindElement(By.CssSelector("div[class='ag-center-cols-container'] div[col-id='may']"));
            return _mayBreakDown.Text;
        }
    }
}