Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowDemo1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@add
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@Multiply
Scenario: Multiply two numbers
	Given the first number is 4
	And the second number is 5
	When the two numbers are multiplied
	Then the result should be 20


@add
Scenario: Add two numbers using data table
	Given the first and second number are:
		| Number1 | Number2 |
		| 10      | 20      |
		When the two numbers are added
		Then the result should be 30




