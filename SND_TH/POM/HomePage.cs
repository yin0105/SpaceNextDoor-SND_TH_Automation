using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SND_TH.POM
{
   public class HomePage : BasePOM
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchField => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='ค้นหาจากตำแหน่งสถานีรถไฟ  บริเวณ หรือสถานที่ใกล้เคียง']"));
        public IWebElement FirstResultOfSearchField => driver.WaitUntilElementIsDisplayed(By.XPath("((//div[contains(text(),'Bangkok')]))[1]"));
        public IWebElement XS_Estimator => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@class='MuiGrid-root MuiGrid-container MuiGrid-spacing-xs-6']/div)[2]"));
        public IWebElement S_Estimator => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@class='MuiGrid-root MuiGrid-container MuiGrid-spacing-xs-6']/div)[3]"));
        public IWebElement ViewAllofFirstStorge => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'ดูทั้งหมด')])[1]"));
        public IWebElement ViewAllofSecondtStorge => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'ดูทั้งหมด')])[2]"));
        public IWebElement FirstStorageUnit => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@class='MuiGrid-root MuiGrid-container']/div)[17]"));
        public IWebElement SecondStorageUnit => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@class='MuiGrid-root MuiGrid-container']/div)[16]"));
        public IWebElement BookNowBtn => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'จองตอนนี้')])[1]"));
        public IWebElement FullnameYourDetail => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='ชื่อ-นามสกุล']"));
        public IWebElement EmailYourDetail => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@placeholder='ที่อยู่อีเมล']"));
        public IWebElement PhoneNumberYourDetail => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='number']"));
        public IWebElement ReserveThisUnitBtn => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='submit'])[1]"));
        public IWebElement ContinueBtn => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='submit'])[1]"));
        public IWebElement RadioInsuranceBtn1 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='radio'])[1]"));
        public IWebElement RadioInsuranceBtn2 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'5000')])[2]"));
        public IWebElement RadioInsuranceBtn3 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='radio'])[3]"));
        public IWebElement RadioInsuranceBtn4 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='radio'])[4]"));
        public IWebElement RadioInsuranceBtn5 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@type='radio'])[5]"));
        public IWebElement CardNumberInPaymentMethod => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@name='cardnumber']"));
        public IWebElement MMYYInPaymentMethod => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@name='exp-date']"));
        public IWebElement CVCInPaymentMethod => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@name='cvc']"));
        public IWebElement PayBtn => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@type='submit'][@tabindex='0']"));
        public IWebElement iFramePayment => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@allow='payment *'])[1]']"));
        public IWebElement IsBookingConfirmed => driver.WaitUntilElementIsDisplayed(By.XPath("//*[text() = 'การจองของคุณได้รับการยืนยันแล้ว!']"));

        public IWebElement FeaturedListingInSingapore => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[contains(text(),'พื้นที่เก็บของแนะนำ')])"));

        public IWebElement RightSlider1 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-right'])[1]"));
        public IWebElement RightSlider2 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-right'])[2]"));
        public IWebElement RightSlider3 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-right'])[3]"));
        public IWebElement RightSlider4 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-right'])[4]"));

        public IWebElement LeftSlider1 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-left'])[1]"));
        public IWebElement LeftSlider2 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-left'])[2]"));
        public IWebElement LeftSlider3 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-left'])[3]"));
        public IWebElement LeftSlider4 => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-left'])[4]"));

    }
}
