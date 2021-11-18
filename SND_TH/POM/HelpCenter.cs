using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND_TH.POM
{
    public class HelpCenter : BasePOM
    {
        IWebDriver driver;

        public HelpCenter(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement vv1 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv2 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv3 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv4 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv5 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv6 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv7 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv8 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv9 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv10 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv11 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv12 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv13 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv14 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
        public IWebElement vv15 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
    }
}
