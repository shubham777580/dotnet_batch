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
    public class Pizza_Title_CheckStepDefinitions
    {
        private ChromeDriver chromeDriver;
        public Pizza_Title_CheckStepDefinitions() => chromeDriver = new ChromeDriver("C:/Users/shubham.mukherjee/Downloads/chromedriver_win32");

        [Given(@"open pizza site")]
        public void GivenOpenPizzaSite()
        {
            chromeDriver.Navigate().GoToUrl("https://joepizzaazure.azurewebsites.net/");
        }

        [Then(@"check the title")]
        public void ThenCheckTheTitle()
        {
            
                //nunit assert function for checking title
                Assert.IsTrue(chromeDriver.Title.Contains("Home Page - joe_pizza_mvc"));
            }

            
           
        }
    }

