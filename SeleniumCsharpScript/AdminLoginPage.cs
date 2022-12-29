using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpScript
{
    internal class AdminLoginPage :BaseTest
    {
         IWebElement uName = driver.FindElement(By.CssSelector("#email"));
         IWebElement pword = driver.FindElement(By.CssSelector("#password"));
         IWebElement loginBtn = driver.FindElement(By.CssSelector(".btn-login"));

        public AdminLoginPage()
        {



        }

        public void login(String uname, String pwd)
        {

            uName.SendKeys(uname);
            pword.SendKeys(pwd);
            loginBtn.Click();
           
            

        }



    }
}
