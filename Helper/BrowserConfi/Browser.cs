using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helper.BrowserConfi
{
   public class Browser_Launch
   {
        public static IWebDriver driver { get; set; }

        public static void StartBrowser(string BrowserType, string url)
        {
            if (BrowserType.Equals("chrome"))
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
            }

            else if (BrowserType.Equals("Firefox"))
            {
                driver = new FirefoxDriver();
                driver.Navigate().GoToUrl(url);
            }
        }

    }
}