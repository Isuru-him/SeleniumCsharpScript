using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpScript
{
     public class BaseTest
    {
        public static IWebDriver driver;

        public static void initDriver()
        {
            driver = new ChromeDriver();
        }

        public static void goTo(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void maximizeWindow()
        {
            driver.Manage().Window.FullScreen();
        }

        public static void closeBrowser()
        {

            driver.Quit();
        }

    }
}
