using FluentAssertions;
using SND_TH.Driver;
using SND_TH.Helpers;
using SND_TH.POM;
using System;
using TechTalk.SpecFlow;

namespace SND_TH.Features.Steps
{
    [Binding]
    public class LoginSteps : Methods
    {
        ScenarioContext _sc;
        BrowserDriver driver;


        public LoginSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }

        HomePage homePage = null;
        Login loginPage = null;

        [Given(@"I log in with hardcoded ""(.*)"" and ""(.*)""")]
        public void GivenILogInWithHardcodedAnd(int phoneNumber, int OTP)
        {
            homePage = new HomePage(driver.Current);
            loginPage = new Login(driver.Current);
            loginPage.LoginSlide.Click();
            loginPage.LoginButtonOnSlider.Click();
            loginPage.PhoneNumberWith.Click();
            loginPage.InputPhoneNumber.SendKeys(phoneNumber.ToString());
            loginPage.IAgreeCheckBox.Click();
            loginPage.LoginBtnViaPhoneNumber.Click();
            loginPage.OTPField.SendKeys(OTP.ToString());
            loginPage.VerifyOTP.Click();

        }

        [Given(@"I sign out")]
        public void GivenISignOut()
        {
            loginPage = new Login(driver.Current);
            Sleep(2500);
            loginPage.LoginSlide.Click();
            Sleep(2500);
            loginPage.Signout.Click();
        }
        
        [Given(@"The popup is displayed with ""(.*)""")]
        public void GivenThePopupIsDisplayedWith(string popupText)
        {
            loginPage.PopupText.Text.Should().Be(popupText, "This verifies if popup text is displayed correctly");
        }
        
        [Given(@"I click ""(.*)"" on popup")]
        public void GivenIClickOnPopup(string option)
        {
            if (option == "Yes")
            {
                loginPage.YesPopup.Click();
            }
            else if (option == "No")
            {
                loginPage.NoPupop.Click();
            }
        }
        
        [Then(@"I am signed out")]
        public void ThenIAmSignedOut()
        {
            loginPage.LoginSlide.Click();
            loginPage.LoginButtonOnSlider.Click();
        }
    }
}
