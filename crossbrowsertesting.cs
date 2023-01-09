using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PageObjectModel
{
    [TestClass]
    public class crossbrowsertesting
    {
        string url = "https://www.google.com";
        public void OpenBrowser(Browsertype browsertype)
        {
            switch(browsertype)
            {
                case Browsertype.Chrome:
                    DriverContext.driver = new ChromeDriver();
                    DriverContext.Browser=new Browser(DriverContext.driver);
                    break;
                case Browsertype.Firefox:
                    //new DriverManager().SetUpDriver(new FirefoxConfig());
                    FirefoxDriver firefoxDriver = new FirefoxDriver("C:\\Users\\k.kirubakaran\\Downloads\\geckodriver-v0.32.0-win64\\geckodriver.exe");
                    DriverContext.driver = firefoxDriver;
                    DriverContext.Browser = new Browser(DriverContext.driver);
                    break;
                case Browsertype.Edge:
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    DriverContext.driver = new EdgeDriver();
                    DriverContext.Browser = new Browser(DriverContext.driver);
                    break;
            }
        }
        [TestMethod]
        public void chrometest()
        {
            OpenBrowser(Browsertype.Chrome);
            DriverContext.Browser.GoToUrl(url);
        }
        [TestMethod]
        public void EdgeTest()
        {

            OpenBrowser(Browsertype.Edge);
            DriverContext.Browser.GoToUrl(url);
        }
       
       
       
    }
}
