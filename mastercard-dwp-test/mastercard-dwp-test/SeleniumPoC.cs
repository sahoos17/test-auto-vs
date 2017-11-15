using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace mastercard_dwp_test
{
    [TestClass]
    public class SeleniumPoC
    {
        private string baseURL = "https://dev.sharepoint.com/";
        


        [TestMethod]
        public void OpenSharePointSite()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();

            
            driver.Navigate().GoToUrl(this.baseURL);
            
            driver.Quit();
        }

        [TestMethod]
        public void TestToFail1()
        {
            Assert.AreEqual(12, 13);
        }


        [TestMethod]
        public void TestToFail2()
        {
            Assert.AreEqual(13, 14);
        }
    }
}
