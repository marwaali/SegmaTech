using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Test
{
    public class DriverOperations
    {
        private IWebDriver _driver;

        public DriverOperations(IWebDriver driver)
        {
            _driver = driver;
        }

        public void CloseDriver()
        {
            _driver.Dispose();
        }

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ScrollHorizontal(IWebElement element)
        {
            Actions action = new Actions(_driver);
            action.DragAndDropToOffset(element,0,30).Build().Perform();
        }
    }
}