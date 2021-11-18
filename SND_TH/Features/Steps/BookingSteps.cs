using FluentAssertions;
using OpenQA.Selenium;
using SND_TH.Driver;
using SND_TH.Helpers;
using SND_TH.POM;
using System;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SND_TH.Features.Steps
{
    [Binding]
    public class BookingSteps : Methods
    {

        ScenarioContext _sc;
        BrowserDriver driver;

        public BookingSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }

        HomePage homePage = null;

        ReadOnlyCollection<IWebElement> ListiFrame = null;


        [Given(@"I navigate on ""(.*)"" main page")]
        public void GivenINavigateOnMainPage(string urlOption)
        {
            homePage = new HomePage(driver.Current);
            driver.Current.Url.Should().Be(urlOption, "Url is passed form outside and im just verifying");
        }
        
        [Given(@"I search ""(.*)"" and select it in main search field")]
        public void GivenISearchAndSelectItInMainSearchField(string option)
        {
            homePage = new HomePage(driver.Current);
            homePage.SearchField.Click();
            Sleep(2200);
            homePage.FirstResultOfSearchField.Click();
        }
        
        [Given(@"I Choose ""(.*)"" size estimator")]
        public void GivenIChooseSizeEstimator(string option)
        {
            if (option == "XS")
            {
                Sleep(2500);
                homePage.XS_Estimator.Click();
            }
            else if (option == "XXS")
            {
                //here will be inputed all sizes of the estimators
            }
            else if (option == "S")
            {
                Sleep(2500);
                homePage.S_Estimator.Click();
            }
        }
        
        [Given(@"I click ""(.*)"" View All button")]
        public void GivenIClickViewAllButton(string option)
        {
            if(option == "First")
            {
                Sleep(18000);
                homePage.ViewAllofFirstStorge.Click();
            }
            else if (option == "Second")
            {
                Sleep(18000);
                homePage.ViewAllofSecondtStorge.Click();

            }
            SwitchToTab(driver.Current, 1);
        }
        
        [Given(@"I click ""(.*)"" storage unit")]
        public void GivenIClickStorageUnit(string option)
        {
            homePage = new HomePage(driver.Current);
            if (option == "First")
            {
                Sleep(6000);
                homePage.FirstStorageUnit.Click();
            }
            else if (option == "Second")
            {
                Sleep(6000);
                homePage.SecondStorageUnit.Click();
            }
        }
        
        [Given(@"I click book now button")]
        public void GivenIClickBookNowButton()
        {
            Sleep(5000);
            homePage.BookNowBtn.Click();
        }
        
        [Given(@"I input following parameters into your details")]
        public void GivenIInputFollowingParametersIntoYourDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            homePage.FullnameYourDetail.SendKeys(data.Fullname.ToString());
            homePage.EmailYourDetail.SendKeys(data.Email.ToString());
            homePage.PhoneNumberYourDetail.SendKeys(data.Phonenumber.ToString());
        }
        
        [Given(@"I click reserve unit button")]
        public void GivenIClickReserveUnitButton()
        {
            Sleep();
            homePage.ReserveThisUnitBtn.Click();
        }
        
        [Given(@"I click continue button")]
        public void GivenIClickContinueButton()
        {
            Sleep(3500);
            homePage.ContinueBtn.Click();
        }
        
        [Given(@"I select ""(.*)"" insurance plan")]
        public void GivenISelectInsurancePlan(string option)
        {
            if (option == "First")
            {
                Sleep(760);
                homePage.RadioInsuranceBtn1.Click();
            }
            else if (option == "Second")
            {
                Sleep(760);
                homePage.RadioInsuranceBtn2.Click();
            }
            else if (option == "Third")
            {
                Sleep(760);
                homePage.RadioInsuranceBtn3.Click();
            }
            else if (option == "Fourth")
            {
                Sleep(760);
                homePage.RadioInsuranceBtn4.Click();
            }
            else if (option == "Fifth")
            {
                Sleep(760);
                homePage.RadioInsuranceBtn5.Click();
            }
        }
        
        [Given(@"I input card number parameters into payment method")]
        public void GivenIInputCardNumberParametersIntoPaymentMethod(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ListiFrame = getAlliFrames(driver.Current);
            //SwitchiFrame(driver.Current, homePage.iFramePayment);
            SwitchiFrame(driver.Current, ListiFrame[0]);
            homePage.CardNumberInPaymentMethod.SendKeys(data.CardNumber);
            homePage.MMYYInPaymentMethod.SendKeys(data.MMYY.ToString());
            homePage.CVCInPaymentMethod.SendKeys(data.CVV.ToString());
        }
        
        [When(@"I click pay button")]
        public void WhenIClickPayButton()
        {
            driver.Current.SwitchTo().DefaultContent();
            homePage.PayBtn.Click();
        }
        
        [Then(@"The booking confirmation page should be displayed")]
        public void ThenTheBookingConfirmationPageShouldBeDisplayed()
        {
            homePage.IsBookingConfirmed.Text.Should().Be("การจองของคุณได้รับการยืนยันแล้ว!", "This verifies if booking succesfully done");
        }
    }
}
