﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BusinessValueCalculaterTest.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class FlexeraBusinessValueCalculatorFeature : object, Xunit.IClassFixture<FlexeraBusinessValueCalculatorFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Calculator.feature"
#line hidden
        
        public FlexeraBusinessValueCalculatorFeature(FlexeraBusinessValueCalculatorFeature.FixtureData fixtureData, BusinessValueCalculaterTest_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Flexera Business Value Calculator", @"![Flexera Business Valure Calculator](https://www.flexera.com/flexera-one/business-value-calculator#vroi)
Calculate the ROI for company's technology investments

Link to a feature: [Calculator](BusinessValueCalculaterTest/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Calculate ROI for technology investment")]
        [Xunit.TraitAttribute("FeatureTitle", "Flexera Business Value Calculator")]
        [Xunit.TraitAttribute("Description", "Calculate ROI for technology investment")]
        [Xunit.TraitAttribute("Category", "Calculator")]
        [Xunit.InlineDataAttribute("5,000,000,000", "US", "10,000", "3,500,000", "3", "$8.5M", "$22.5M", new string[0])]
        [Xunit.InlineDataAttribute("9,876,543,210", "Germany", "700", "1,234,567", "2", "$6.6M", "$16.8M", new string[0])]
        [Xunit.InlineDataAttribute("3000", "Nordic", "700", "120", "1", "$3.6M", "$9.7M", new string[0])]
        public void CalculateROIForTechnologyInvestment(string amount, string location, string number, string quantity, string period, string savingLow, string savingHigh, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Calculator"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("amount", amount);
            argumentsOfScenario.Add("location", location);
            argumentsOfScenario.Add("number", number);
            argumentsOfScenario.Add("quantity", quantity);
            argumentsOfScenario.Add("period", period);
            argumentsOfScenario.Add("savingLow", savingLow);
            argumentsOfScenario.Add("savingHigh", savingHigh);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate ROI for technology investment", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
 testRunner.Given(string.Format("organization’s annual revenue is {0} USD", amount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
 testRunner.And(string.Format("organization’s headquarters is located at {0}", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("organization has {0} of employees", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And(string.Format("organization’s annual IT budget is {0} USD", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("years for the analysis is {0} years", period), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.When("processing the organization\'s input values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then(string.Format("the total projected savings should between {0} and {1}", savingLow, savingHigh), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                FlexeraBusinessValueCalculatorFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                FlexeraBusinessValueCalculatorFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
