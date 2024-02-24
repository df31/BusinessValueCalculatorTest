using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BusinessValueCalculaterTest.Drivers
{
    public class BrowserDriver : IDisposable
    {
        private readonly Lazy<IWebDriver> _currentWebDriverLazy;
        private bool _isDisposed;


        public BrowserDriver()
        {
            _currentWebDriverLazy = new Lazy<IWebDriver>(CreateWebDriver);
        }

        /// <summary>
        /// The Selenium IWebDriver instance
        /// </summary>
        public IWebDriver Current => _currentWebDriverLazy.Value;


        /// <summary>
        /// Creates the Selenium web driver (opens a browser)
        /// </summary>
        /// <returns></returns>
        private IWebDriver CreateWebDriver()
        {
            //We use the Chrome browser
            var chromeDriverService = ChromeDriverService.CreateDefaultService();

            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("no-sandbox");
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArguments("disable-extensions");
            chromeOptions.AddArgument("ignore-certificate-errors");
            chromeOptions.AddAdditionalOption("useAutomationExtension", false);

            var chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions);

            return chromeDriver;
        }

        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }


            if (_currentWebDriverLazy.IsValueCreated)
            {
                Current.Close();
                Current.Quit();
                Current.Dispose();
            }

            _isDisposed = true;
        }
    }
}
