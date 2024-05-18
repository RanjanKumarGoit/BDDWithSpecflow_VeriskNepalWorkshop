Feature: ScenarioOutlineExample

A short summary of the feature

@tag1
Scenario Outline: Add two numbers using scenario outline
	Given the first number is <number>
	And the second number is <number>
	When the two numbers are added
	Then the result should be <expectedSum>


@positive
Examples: 1 add positive numbers
	| number1 | number2 | expectedSum |
	| 10      | 20      | 20          |
	| 50      | 70      | 120         |
	| 100     | 5       | 105         |



@positive
Examples: 2 add positive numbers
	| number1 | number2 | expectedSum |
	| -50     | -70     | -120        |
	| -10     | -3      | -13         |
	| -100    | -3      | -103        |
