using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace specflow_2.StepDefinitions
{
    [Binding]
    public class Pizza_Privacy_PolicyStepDefinitions
    {
        private ChromeDriver chromeDriver;

        public Pizza_Privacy_PolicyStepDefinitions() => chromeDriver = new ChromeDriver("C:/Users/shubham.mukherjee/Downloads/chromedriver_win32");

        [Given(@"I have navigate to pizza website")]
        public void GivenIHaveNavigateToPizzaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joepizzaazure.azurewebsites.net/");
           
        }

        [When(@"I click on privacy button")]
        public void WhenIClickOnPrivacyButton()
        {

            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var PrivacyButton = chromeDriver.FindElement(By.XPath("/ html / body / header / nav / div / div / ul / li[2] / a"));
            PrivacyButton.Click();
        }

        [Then(@"Privacy details page shows up")]
        public void ThenPrivacyDetailsPageShowsUp()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(2000));
        }
    }
}
