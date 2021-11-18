using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QAssistant.Extensions;
using SND_TH.Helpers;
using SND_TH.POM;

namespace SND.Initialize_and_Clean
{
    //this class and unit tests will be used for mobile automation with browser capability change.
    public class TestInitializer : Methods 
    {
        public IWebDriver driver;

        [TestInitialize()]
        public void BeforeTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            GoToUrl(driver, "https://spacenextdoor.com/login");
            System.Console.WriteLine("This is before test runs!");
        }

        [TestCleanup]
        public void AfterTest()
        {
            driver.CloseAndDispose();
            System.Console.WriteLine("This is after test ends");
        }

        public static void LoginToSND(IWebDriver driver, string email = "", string password = "")
        {

            var login = new BasePOM();
            //email hardcoding need for verification.
            //here we need login xpath-s which will be placed in basePOM for frequently use. 


        }
    }
}
