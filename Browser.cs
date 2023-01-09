using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public enum Browsertype
    {
        Chrome,
        Firefox,
        Edge
    }
    public class Browser
    {
        public Browsertype Type { get; set; }
        public IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoToUrl(string url)
        {
            DriverContext.driver.Url = url;  
        }

    }
}
