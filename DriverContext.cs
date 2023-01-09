using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public static class DriverContext
    {
        public static IWebDriver _driver;

        public static IWebDriver driver
        {
            get { return _driver; }
            set { _driver = value; }
        }

        public static Browser Browser { get; set; }

        enum BrowserType
        {
            Chrome,
            Firefox,
            Edge
        }
    }
}
