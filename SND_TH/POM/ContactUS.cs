using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND_TH.POM
{
   public class ContactUS : BasePOM
    {
        IWebDriver driver;

        public ContactUS(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }


        public IWebElement v1 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v2 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v3 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v4 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v5 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v6 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v7 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v8 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v9 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v10 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v11 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v12 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v13 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v14 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement v15 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));

    }
}
