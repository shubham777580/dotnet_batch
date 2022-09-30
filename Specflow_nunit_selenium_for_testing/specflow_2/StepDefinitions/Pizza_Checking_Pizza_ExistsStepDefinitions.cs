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
    public class Pizza_Checking_Pizza_ExistsStepDefinitions
    {
        private ChromeDriver chromeDriver;
        public Pizza_Checking_Pizza_ExistsStepDefinitions() => chromeDriver = new ChromeDriver("C:/Users/shubham.mukherjee/Downloads/chromedriver_win32");


        [Given(@"open pizzaa website")]
        public void GivenOpenPizzaaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://joepizzaazure.azurewebsites.net/");
        }

        [Then(@"check whether given pizza exist")]
        public void ThenCheckWhetherGivenPizzaExist()
        {
            chromeDriver.PageSource.Contains("Pizza Name : Deluxe Veggie");
        }
            
        }
    }

