using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessValueCalculaterTest.PageObjects
{
    public class CalculatorPageObject : PageObjectBase
    {
        //The URL of the calculator to be opened in the browser
        private const string CalculatorUrl = "https://www.flexera.com/flexera-one/business-value-calculator#vroi";


        //The default wait time in seconds for wait.Until
        public const int DefaultWaitInSeconds = 5;

        public CalculatorPageObject(IWebDriver webDriver) : base(webDriver)
        {
        }

        //Finding elements by ID
        private IWebElement CookiesSettingsCloseButton => WaitForActiveElement(By.Id("cookiescript_close"));
        private IWebElement QaGuideSideBarButton => WaitForActiveElement(By.Id("qa-guide-sidebar"));

        private IWebElement iframeElement => WaitForElement(By.Id("vroi"));
        private IWebElement AnnualRevenueElement => WaitForActiveElement(By.Id("AnnualRevenue"));
        private IWebElement HeadQuaterElement => WaitForActiveElement(By.Id("Headquarters_Country"));
        private IWebElement NumberofEmployeesElement => WaitForActiveElement(By.Id("NumberofEmployees"));
        private IWebElement AnnualItBudgetElement => WaitForActiveElement(By.XPath("//*[@id=\"app_user_form\"]/div[1]/div[1]/div[1]/div/div[5]/div/input"));
        private IWebElement NumberOfYearsElement => WaitForActiveElement(By.Id("Number_of_Years"));
        private IWebElement SavingLowElement => WaitForActiveElement(By.XPath("//*[@id=\"app_user_form\"]/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/span/span[1]"));
        private IWebElement SavingHighElement => WaitForActiveElement(By.XPath("//*[@id=\"app_user_form\"]/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/span/span[2]"));

        public void EnterAnnualRevenue(string number)
        {
            //Clear text box
            AnnualRevenueElement.Clear();
            //Enter text
            AnnualRevenueElement.SendKeys(number);
        }

        public void SelectHeadQuater(string location)
        {
            SelectElement select = new SelectElement(HeadQuaterElement);

            switch (location)
            {
                case "canada":
                    select.SelectByValue("1");
                    break;

                case "france":
                    select.SelectByValue("2");
                    break;

                case "germany":
                    select.SelectByValue("3");
                    break;

                case "nordic":
                    select.SelectByValue("4");
                    break;

                case "uk":
                    select.SelectByValue("5");
                    break;

                case "us":
                    select.SelectByValue("6");
                    break;

                default:
                    select.SelectByValue("7");
                    break;
            }

        }

        public void EnterNumberOfEmployee(string number)
        {
            //Clear text box
            NumberofEmployeesElement.Clear();
            //Enter text
            NumberofEmployeesElement.SendKeys(number);
        }

        public void EnterAnnualItBudget(string number)
        {
            //Clear text box
            AnnualItBudgetElement.Clear();
            //Enter text
            AnnualItBudgetElement.SendKeys(number);
        }

        public void SelectNumberOfYears(string number)
        {
            SelectElement select = new SelectElement(NumberOfYearsElement);

            switch (number)
            {
                case "1":
                    select.SelectByValue("1");
                    break;

                case "2":
                    select.SelectByValue("2");
                    break;

                case "3":
                    select.SelectByValue("3");
                    break;

                case "4":
                    select.SelectByValue("4");
                    break;

                case "5":
                    select.SelectByValue("5");
                    break;

                default:
                    select.SelectByValue("5");
                    break;

            }
        }

        public string getSavingLowValue()
        {
            return SavingLowElement.Text;
        }

        public string getSavingHighValue()
        {
            return SavingHighElement.Text;
        }
        public void EnsureCalculatorIsOpenAndReset()
        {
            //Open the calculator page in the browser 
            _webDriver.Url = CalculatorUrl;

            //Close cookies settings
            CookiesSettingsCloseButton.Click();

            //Hide QA Guide Sidebar
            var expand = QaGuideSideBarButton.GetAttribute("aria-expanded");
            if (expand.Equals("true"))
            {
                QaGuideSideBarButton.Click();
            }

            //Scoll page to show Calculator UI
            IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriver;
            js.ExecuteScript("window.scrollTo(0, 500);");

            //Goto iFrame
            _webDriver.SwitchTo().Frame(iframeElement);
        }
    }
}
