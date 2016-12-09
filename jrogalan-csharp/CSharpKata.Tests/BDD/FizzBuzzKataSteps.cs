using CSharpKata.Katas;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CSharpKata.Tests.BDD
{
    [Binding]
    public class FizzBuzzKataSteps
    {
        [Given(@"the input number (.*)")]
        public void GivenTheInputNumber(int value) =>        
            ScenarioContext.Current.Add("target", new FizzBuzzKata());        
        
        [When(@"FizzBuzzKata is invoked with the input (.*)")]
        public void WhenFizzBuzzKataIsInvokedWithTheInput(int value) =>
            ScenarioContext.Current.Add("result", 
                ScenarioContext.Current.Get<FizzBuzzKata>("target").Verify(value));

        [Then(@"the result should be equal to (.*)")]
        public void ThenTheResultShouldBeEqualTo(string expected) =>
            Assert.That(ScenarioContext.Current.Get<string>("result"), Is.EqualTo(expected));      
    }
}
