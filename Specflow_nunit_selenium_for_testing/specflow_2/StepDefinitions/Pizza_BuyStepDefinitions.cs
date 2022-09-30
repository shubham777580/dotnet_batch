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
    public class Pizza_BuyStepDefinitions
    {
        private ChromeDriver chromeDriver;
        public Pizza_BuyStepDefinitions() => chromeDriver = new ChromeDriver("C:/Users/shubham.mukherjee/Downloads/chromedriver_win32");


        [Given(@"navigate to pizzaa website")]
        public void GivenNavigateToPizzaaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joepizzaazure.azurewebsites.net/");
        }

        [When(@"click on buy button of respective pizza")]
        public void WhenClickOnBuyButtonOfRespectivePizza()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var Pizza_buy_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div[2]/div[1]/div/div/div[4]/div/p/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Pizza_buy_Button);
        }

        [Then(@"opens up order checkout page")]
        public void ThenOpensUpOrderCheckoutPage()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(2000));
        }

        [When(@"click on confirm order button")]
        public void WhenClickOnConfirmOrderButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var Pizza_confirm_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div[3]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Pizza_confirm_Button);
        }

        [Then(@"opens up order confirmed page")]
        public void ThenOpensUpOrderConfirmedPage()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(2000));
        }
    }
}
