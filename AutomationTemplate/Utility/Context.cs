using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using System.Threading;
using System.Threading.Tasks;

namespace AutomationTemplate.Utility
{
    public class Context
    {
        public Context(IWebDriver d)
        {
            _driver = d;
        }

        private IWebDriver _driver;
        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }

        public const string user = "";
        public const string password = "";

        public const string user_prod = "";
        public const string password_prod = "";

    }

}
