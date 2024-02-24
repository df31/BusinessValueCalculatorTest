using BusinessValueCalculaterTest.Drivers;
using BusinessValueCalculaterTest.PageObjects;
using Shouldly;

namespace BusinessValueCalculaterTest.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        //Page Object for Calculator
        private readonly CalculatorPageObject _calculatorPageObject;

        public CalculatorStepDefinitions(BrowserDriver browserDriver)
        {
            _calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
        }

        [Given(@"organization’s annual revenue is (.*) USD")]
        public void GivenOrganizationSAnnualRevenueIsUSD(string amount)
        {
            _calculatorPageObject.EnterAnnualRevenue(amount);
        }

        [Given(@"organization’s headquarters is located at (.*)")]
        public void GivenOrganizationSHeadquartersIsLocatedAtCanada(string location)
        {
            location = location.ToLower();
            _calculatorPageObject.SelectHeadQuater(location);
        }

        [Given(@"organization has (.*) of employees")]
        public void GivenOrganizationHasOfEmployees(string number)
        {
            _calculatorPageObject.EnterNumberOfEmployee(number);
        }

        [Given(@"organization’s annual IT budget is (.*) USD")]
        public void GivenOrganizationSAnnualITBudgetIsUSD(string amount)
        {
            _calculatorPageObject.EnterAnnualItBudget(amount);
        }

        [Given(@"years for the analysis is (.*) years")]
        public void GivenYearsForTheAnalysisIsYears(string number)
        {
            _calculatorPageObject.SelectNumberOfYears(number);
        }

        [When(@"processing the organization's input values")]
        public void WhenProcessingTheOrganizationsInputValues()
        {
           
        }

        [Then(@"the total projected savings should between (.*) and (.*)")]
        public void ThenTheTotalProjectedSavingsShouldBetweenAnd(string expectedlow, string expectedHigh)
        {
            var actualLow = _calculatorPageObject.getSavingLowValue();
            var actualHigh = _calculatorPageObject.getSavingHighValue();

            actualLow.ShouldBe(expectedlow);
            actualHigh.ShouldBe(expectedHigh);
        }

    }
}
