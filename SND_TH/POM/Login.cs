using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND_TH.POM
{
   public class Login : BasePOM
    {
        IWebDriver driver;

        public Login(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement LoginSlide => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@class='MuiButtonBase-root MuiIconButton-root']"));
        public IWebElement LoginButtonOnSlider => driver.WaitUntilElementIsDisplayed(By.XPath("//span[contains(@class,'MuiButton-label') and text() = 'เข้าสู่ระบบ']")); //adjustment need on id.
        public IWebElement Email => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='Email']"));
        public IWebElement LoginButton => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='submit']"));
        public IWebElement IAgreeCheckBox => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(text(),'การลงชื่อเข้าใช้แสดงว่าฉันยอมรับข้อกำหนดการใช้งานและนโยบายความเป็นส่วนตัว')]"));
        public IWebElement PhoneNumberWith => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='viaPhoneNumber']"));
        public IWebElement InputPhoneNumber => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='text']"));
        public IWebElement LoginBtnViaPhoneNumber => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='loginButton']"));
        public IWebElement OTPField => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='tel']"));
        public IWebElement VerifyOTP => driver.WaitUntilElementIsDisplayed(By.XPath("//div[contains(text(),'VERIFY')]"));
        public IWebElement PopupText => driver.WaitUntilElementIsDisplayed(By.XPath("//p[contains(text(),'Are you sure you want to Sign Out?')]"));
        public IWebElement YesPopup => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'YES')])[2]"));
        public IWebElement NoPupop => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'NO')])[2]"));
        public IWebElement Signout => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='signOut']"));
        public IWebElement xx16 => driver.WaitUntilElementIsDisplayed(By.XPath("xpath here"));
    }
}
