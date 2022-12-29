using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpScript
{
    internal class TestBase
    {
        public static IWebDriver driver;

        public  void initDriver()
        {
            driver = new ChromeDriver();
        }

        public  void goTo(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void maximizeWindow()
        {
            driver.Manage().Window.FullScreen();
        }

        public void closeBrowser()
        {

            driver.Quit();
        }
    }
}
