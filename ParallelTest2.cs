using System;
using System.Threading;
using AutoIt;
using NUnit.Framework;
using OpenQA.Selenium;

using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;


namespace BrowserStack
{
    [TestFixture("parallel", "chrome")]
    //[TestFixture("parallel", "safari")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ParallelTest2 : BrowserStackNUnitTest
    {
        public ParallelTest2(string profile, string environment)
                 : base(profile, environment) { }

        [Test]
        public void iphonesStreamVideo2()
        {
            driver.Navigate().GoToUrl("https://google.com");
            //driver.Navigate().GoToUrl(url);

            driver.FindElement(By.Name("q")).SendKeys("BrowserSatck");

            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            //System.Windows.Forms.SendKeys.SendWait("{ENTER}");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Thread.Sleep(20000);


        }
    }
}

