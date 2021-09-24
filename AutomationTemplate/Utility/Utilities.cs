using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

using System.Threading;
using System.Threading.Tasks;

using System.Diagnostics;

/**
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AutomationTemplate.Utility;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

using System.Threading.Tasks;
using System.Threading;

For importing to a new C# TEST class 
 */

/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

using System.Threading;

For importing to a new C# class 
 */
namespace AutomationTemplate.Utility
{
        public static class Utilities
        {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        private static WebDriverWait wait;
            public static IWebElement WaitForElementToBeVisible(this IWebDriver driver, By locator, int timeoutInSeconds = 30)
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.IgnoreExceptionTypes(typeof(UnhandledAlertException));
                return wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }

        /// <summary>
        /// Start the website
        /// </summary>
        /// <param name="site">URL</param>
        /// <param name="driver">Browser</param>
        public static void Start(string site,IWebDriver driver)
        {
            driver.Navigate().GoToUrl(site);
            driver.Manage().Window.Maximize();
        }


        /*====== WAIT TIMERS======*/
        /// <summary>
        /// Wait for page to load
        /// </summary>
        /// <param name="waittime">how long you want to wait ex:1000 = 1sec</param>
        public static void WaitTimer(int waittime)
        {
            Thread.Sleep(waittime);
        }


        public static void DriverWaitTimerByText(IWebDriver driver, int minutes, string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, minutes, 0));
            wait.Until(drv => drv.FindElement(By.XPath("//*[contains(text(), '" + value + "')]")));

        }
        /// <summary>
        /// Wait until the id is loaded on the page and is visible
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="minutes"></param>
        /// <param name="value"></param>
        /// <param name="idName"></param>
        public static void DriverWaitTimerByID(IWebDriver driver,int minutes, string value, string idName)
        {
            WebDriverWait wait = new WebDriverWait(driver,new TimeSpan(0,minutes,0));
            wait.Until(drv => drv.FindElement(By.Id("'"+ idName +"'")).FindElement(By.XPath("//*[contains(text(), '"+ value + "')]")));

        }

        /// <summary>
        /// Wait until the class is loaded on the page and is visible
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="minutes"></param>
        /// <param name="value"></param>
        /// <param name="className"></param>
        public static void DriverWaitTimerByClass(IWebDriver driver, int minutes, string value, string className)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, minutes, 0));
            wait.Until(drv => drv.FindElement(By.Id("'" + className + "'")).FindElement(By.XPath("//*[contains(text(), '" + value + "')]")));

        }

        /// <summary>
        /// Wait until the href path is loaded on the page and is visible
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="minutes"></param>
        /// <param name="hrefPath"></param>
        public static WebDriverWait DriverWaitTimerByHref(IWebDriver driver, int minutes, string hrefPath)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, minutes, 0));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(@href, '" + hrefPath + "')]")));
            return wait;
            
        }

                                                        /*======END WAIT TIMERS======*/

        /// <summary>
        /// End the driver process
        /// </summary>
        /// <param name="d">The driver that will be ended</param>
        public static void EndDriverProcess(IWebDriver d)
        {
            d.Close();
            d.Quit();
            d.Dispose();
        }

        /// <summary>
        /// Get text value of a specific tag
        /// </summary>
        /// <param name="text"></param>
        /// <param name="driver"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public static IWebElement GetTextValue(string text, IWebDriver driver, string tagName)
        {
            log.Info("Text: " + text);
            string xpath = "//" + tagName + "[contains(text(),'" + text + "')]";
            log.Info("xpath: " + xpath);
            return driver.FindElement(By.XPath(xpath));
        }

        public static string GetHrefToRealURL(IWebDriver driver, string hrefpath)
        {
            string path = "a[href='" +hrefpath+ "']";
            log.Info("href" + path);
            string href = driver.FindElement(By.CssSelector(path)).GetAttribute("href");
            return href;
        }

        public static IWebElement GetDataFromCustomXPath(string text, IWebDriver driver)
        {
            log.Info("Text: " + text);
            string xpath = text;
            log.Info("xpath: " + xpath);
            return driver.FindElement(By.XPath(xpath));
        }
    }

}
