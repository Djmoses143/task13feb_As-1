using task13feb;
using TechTalk.SpecFlow.CommonModels;
using Xunit;
using Calsi;
using System.Collections.Generic;

namespace Calsi.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        public readonly ScenarioContext scenarioContext;
        public readonly Calculator calculator;
        private int result;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            this.calculator = new Calculator();
        }
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.n1 = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.n2 = number;
        }

        [When("we subtract second number from first number")]
        public void Whenwesubtractsecondnumberfromfirstnumber()
        {
            result = calculator.sub();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(result);
        }

       
        [When("we multiply first and second number")]
        public void Whenwemultiplyfirstandsecondnumber()
        {
            result = calculator.mul();
        }

        [Then("the mulresult should be (.*)")]
        public void ThenTheMulResultShouldBe(int result)
        {
            result.Should().Be(result);
        }

         [When("we divide first number by second number")]
         public void Whenwedividefirstnumberbysecondnumber()
         {
             result = calculator.div();
         }

         [Then("the divresult should be (.*)")]
         public void ThenTheDivResultShouldBe(int result)
         {
             result.Should().Be(result);
         }
    }
}
