using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using static AutomationTemplate.Utility.Utilities;
using System.Threading;
using OpenQA.Selenium.Remote;
using System.IO;

namespace AutomationTemplate.Test
{

    [TestClass]
    public class GoToGoogleTest
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public string site = "https://www.google.com/";
        public IWebDriver driver;
        public string texts = "Youtube";
        [TestMethod]
        public void google()
        {
            driver = new ChromeDriver();
            Utility.Utilities.Start(site, driver);
            GotoGoogle google = new GotoGoogle(driver);
            google.Searching(texts);
            Utility.Utilities.WaitTimer(3000);
            EndDriverProcess(driver);

            driver = new FirefoxDriver();
            google = new GotoGoogle(driver);
            Utility.Utilities.Start(site, driver);
            google.Searching(texts);
            Utility.Utilities.WaitTimer(3000);
            EndDriverProcess(driver);

            /*
            driver = new EdgeDriver(@"C:\Microsoft Web Driver");
            Utility.Utilities.Start(site, driver);
            google.Searching(texts);
            Utility.Utilities.WaitTimer(3000);
            EndDriverProcess(driver);*/
        }
    }
}
