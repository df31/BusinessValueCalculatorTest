using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace BusinessValueCalculaterTest.PageObjects
{
    public class PageObjectBase
    {
        public readonly IWebDriver _webDriver;

        public PageObjectBase(IWebDriver webDriver)
        {
           _webDriver = webDriver;
        }

        protected void Wait(int timeOut = 100)
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(timeOut));
        }

        public IWebElement WaitForElement(By by, int timeOut = 120)
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(timeOut));
            var element = wait.Until(d => d.FindElement(by));
            return element;
        }

        public IWebElement WaitForActiveElement(By by, int timeOut = 80)
        {
            try
            {
                var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(timeOut));
                var element = wait.Until(ExpectedConditions.ElementToBeClickable(by));

                return element;
            }
            catch (Exception)
            {
                var screenshot = (_webDriver as ITakesScreenshot).GetScreenshot();
                screenshot.SaveAsFile(@$"c:\temp\selenium-screendump.png");
                throw;
            }
        }
    }
}
