using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Automation
{
	class Program
	{
		static void Main(string[] args)
		{
            //IWebDriver driver = new ChromeDriver("C:/Users/shubham.mukherjee/Downloads/chromedriver_win32");

            //// This will open up the URL
            //driver.Url = "https://www.geeksforgeeks.org/";

            Guru99Demo guru99Demo = new Guru99Demo();
            guru99Demo.startBrowser();
            guru99Demo.test();
            guru99Demo.closeBrowser();


        }
    }

    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:/Users/shubham.mukherjee/Downloads/chromedriver_win32");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
