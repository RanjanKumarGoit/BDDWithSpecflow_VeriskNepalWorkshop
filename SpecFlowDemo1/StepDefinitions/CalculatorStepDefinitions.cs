using CalculatorApp;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowDemo1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, _result);
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [Given(@"the first and second number are:")]
        public void GivenTheFirstAndSecondNumberAre(Table table)
        {
            var numbers = table.CreateSet<CalculateorInput>();
            _calculator.FirstNumber = numbers.First().Number1;
            _calculator.SecondNumber = numbers.First().Number2;

        }
    }

    public class CalculateorInput
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
    }
}
