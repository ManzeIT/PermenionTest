using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using PermenionTestTask.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PermenionTestTask
{
    [Binding]
    class CalculatorStepDefintions
    {
        Setup setupObj = new Setup();

        [Given(@"that an application is successfully loaded")]
        public void GivenThatAnApplicationIsSuccessfullyLoaded()
        {
            setupObj.LaunchApplication();
        }

        [When(@"a user navigates to the first field and fill-in '(.*)'")]
        public void WhenAUserNavigatesToTheFirstFieldAndFill_In(string firstNumber)
        {
            setupObj.FieldOneOperation(firstNumber);
        }

        [When(@"a user navigates to the second field and fill-in '(.*)'")]
        public void WhenAUserNavigatesToTheSecondFieldAndFill_In(string secondNumber)
        {
            setupObj.FieldTwoOperation(secondNumber);
        }

        [When(@"a user clicks on Divide button")]
        public void WhenAUserClicksOnDivideButton()
        {
            setupObj.DivisionButtonOperation();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            int actualResult = setupObj.ActualResult();
            Assert.IsTrue(actualResult.Equals(expectedResult));            
            setupObj.ShutDown();
        }
    }
}
