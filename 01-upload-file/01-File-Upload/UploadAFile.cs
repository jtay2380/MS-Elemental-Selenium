using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace _01_upload_file
{
    [TestClass]
    public class UploadAFile
    {
        public static IWebDriver Driver { get; set; }
        private TestContext testContextInstance;

        #region Test Context Setup
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #endregion


        [TestMethod]
        public void UploadFile()
        {
            //Am I pushing to Git
        }

        [TestInitialize]
        public void StartTest()
        {
            Driver = new FirefoxDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");
        }

        [TestCleanup]
        public void EndTest()
        {
            Driver.Quit();
        }



    }
}
