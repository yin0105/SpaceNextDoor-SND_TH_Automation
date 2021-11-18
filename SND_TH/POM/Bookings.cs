using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND_TH.POM
{
  public class Bookings : BasePOM
    {
        IWebDriver driver;

        public Bookings(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        IWebElement n1 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n2 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n3 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n4 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n5 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n6 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n7 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n8 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n9 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n10 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n11 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n12 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n13 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n14 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
        IWebElement n15 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath-here"));
    }
}
