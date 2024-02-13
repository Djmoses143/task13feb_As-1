Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](Calsi/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Subtracting two numbers
	Given the first number is 10
	And the second number is 5
	When we subtract second number from first number
	Then the result should be 5

Scenario: Multiplying two numbers
	Given the first number is 10
	And the second number is 5
	When we multiply first and second number
	Then the mulresult should be 50

Scenario: Dividing two numbers
	Given the first number is 10
	And the second number is 5
	When we divide first number by second number
	Then the divresult should be 5