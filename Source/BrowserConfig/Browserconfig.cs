using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PageObjectModel.Source.BrowserConfig
{
    public class Browserconfig
    {
        public static IWebDriver GetDriver(String url)
        {
            ChromeOptions options= new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("--disable-notifications");
            IWebDriver driver= new ChromeDriver(options);
            driver.Navigate().GoToUrl(url);
            return driver;
        }
    }
}
