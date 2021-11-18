using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND_TH.POM
{
  public  class BasePOM
    {
        IWebDriver driver;

        public BasePOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public BasePOM()
        {

        }



        #region ALL Xpath which are needed everywhere

        public IWebElement x1 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x2 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x3 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x4 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x5 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x6 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x7 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x8 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x9 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x10 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x11 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement x12 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));

        #endregion ALL Xpath which are needed everywhere
    }
}
