using System;
using CalculatorExample;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CalculatorTests.Steps
{
    [Binding]
    public sealed class SubstractionStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        public SubstractionStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the minuend is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the subtrahend is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the minuend is substract from the subtrahend")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Substract();
        }

        [Then("the substraction result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

    }
}
