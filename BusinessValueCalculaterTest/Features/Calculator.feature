Feature: Flexera Business Value Calculator
![Flexera Business Valure Calculator](https://www.flexera.com/flexera-one/business-value-calculator#vroi)
Calculate the ROI for company's technology investments

Link to a feature: [Calculator](BusinessValueCalculaterTest/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Calculator
Scenario Outline: Calculate ROI for technology investment
	Given organization’s annual revenue is <amount> USD
	And organization’s headquarters is located at <location>
	And organization has <number> of employees
	And organization’s annual IT budget is <quantity> USD
	And years for the analysis is <period> years
	When processing the organization's input values
	Then the total projected savings should between <savingLow> and <savingHigh>

Examples:
	| amount        | location | number | quantity  | period | savingLow | savingHigh |
	| 5,000,000,000 | US       | 10,000 | 3,500,000 | 3      | $8.5M     | $22.5M     |
	| 9,876,543,210 | Germany  | 700    | 1,234,567 | 2      | $6.6M     | $16.8M     |
	| 3000          | Nordic   | 700    | 120       | 1      | $3.6M     | $9.7M      |