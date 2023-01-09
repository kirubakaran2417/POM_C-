using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium.DevTools.V106.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Source.Utilities
{
    public class Reportconfig
    {
        public static ExtentReports extent;
        public static ExtentTest Test;
        public static ExtentTest Test2;
        public static string dirpath;

        public static void reportlogger(string testcasename)
        {
            extent = new ExtentReports();
            var dir=AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            Directory.CreateDirectory(dir+"\\Test_execution_reports\\");
            Random rand=new Random();
            String randomno=rand.Next(1000).ToString();
            dirpath = dir + "\\Test_execution_reports\\Test_execution_reports" + "_" + testcasename;
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);
            htmlReporter.Config.ReportName = "Automation report";
            htmlReporter.Config.Theme = Theme.Dark;

            extent.AttachReporter(htmlReporter);
        }
    }
}
