using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND_TH.POM
{
   public class Hosts : BasePOM
    {
        IWebDriver driver;
        public Hosts(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }


        public IWebElement z1 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z2 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z3 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z4 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z5 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z6 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z7 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z8 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z9 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z10 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z11 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z12 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z13 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z14 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
        public IWebElement z15 => driver.WaitUntilElementIsDisplayed(By.XPath("Xpath here"));
    }
}
