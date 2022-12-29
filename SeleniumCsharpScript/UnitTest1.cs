using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharpScript
{
    public class Tests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
           
            initDriver();
            goTo("https://landabeta.sana-cloud.net/admin/profile/login");

        }

        [Test]
        public void Test1()
        {
           AdminLoginPage adminLoginPage= new AdminLoginPage();
           adminLoginPage.login("landabeta@sana-commerce.com", "5Jj*D{9nG}q9w6=");

        }

        [TearDown]
        public void TearDown()
        {

           closeBrowser();

        }
    }
}