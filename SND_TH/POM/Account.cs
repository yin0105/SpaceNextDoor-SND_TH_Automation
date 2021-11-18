using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND_TH.POM
{
   public class Account : BasePOM
    {
        IWebDriver driver;

        public Account(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement bb1 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb2 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb3 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb4 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb5 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb6 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb7 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb8 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb9 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb10 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb11 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb12 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb13 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb14 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        public IWebElement bb15 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        
    }      
}
