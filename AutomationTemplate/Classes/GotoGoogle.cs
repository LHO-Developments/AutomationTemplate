using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;

namespace AutomationTemplate
{
    class GotoGoogle
    {
        private IWebDriver driver;

        public GotoGoogle(IWebDriver d)
        {
            driver = d;

        }

        private IWebElement searchbar => driver.FindElement(By.ClassName("gLFyf"));

        private IWebElement texts => driver.FindElement(By.ClassName("gLFyf"));

        private IWebElement searchButton => driver.FindElement(By.ClassName("gNO89b"));

        public IWebDriver getDriver()
        {
            return driver;
        }

        public void setDriver(IWebDriver d)
        {

            driver = d;

        }

        public void ClickSearchBar()
        {
            searchbar.Click();
        }

        public void InputTexts(string text)
        {
            texts.SendKeys(text);
        }

        public void ClickSearchButton()
        {
            searchButton.Click();
        }

        public void Searching(string text)
        {
            ClickSearchBar();
            InputTexts(text);
            ClickSearchButton();
        }
    }
}
