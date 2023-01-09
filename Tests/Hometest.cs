using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.BrowserConfig;
using PageObjectModel.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Source.Pages;


namespace TestProject1.Tests
{
    [TestClass]
    public class Hometest
    {
        IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentTest Test;
        public static ExtentTest Test2;
        public static string dirpath;
        public static void reportlogger(string testcasename)
        {
            extent = new ExtentReports();
            var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            Directory.CreateDirectory(dir + "\\Test_execution_reports\\");
            Random rand = new Random();
            String randomno = rand.Next(1000).ToString();
            dirpath = @"C:\Users\k.kirubakaran\source\repos\PageObjectModel\PageObjectModel\\"+ testcasename+".html";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);
            htmlReporter.Config.ReportName = "Automation report";
            htmlReporter.Config.Theme = Theme.Dark;

            extent.AttachReporter(htmlReporter);
        }
        [TestInitialize]
        public void Setup()
        {

            driver = Browserconfig.GetDriver("https://www.amazon.in");
        }
        [TestMethod] 
        public void SearchBook()
        {
            reportlogger("test");
            Test=extent.CreateTest("test1");
            Test2 = Test.CreateNode("checking google search box");



            Homepage hp = new Homepage(driver);
            //hp.search("Webdriver book");
            Assert.IsTrue(hp.Searchtxtbox().Enabled);
            Test2.Log(Status.Pass, "passed");
        }
        [TestMethod]
        public void SearchBook2()
        {
            Homepage hp = new Homepage(driver);
            hp.search("Webdriver book");
            
        }
        [TestCleanup] 
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
