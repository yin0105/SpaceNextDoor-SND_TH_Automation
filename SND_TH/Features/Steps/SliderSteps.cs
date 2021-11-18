using FluentAssertions;
using QAssistant.Extensions;
using SND_TH.Driver;
using SND_TH.Helpers;
using SND_TH.POM;
using System;
using TechTalk.SpecFlow;

namespace SND_TH.Features.Steps
{
    [Binding]
    public class SliderSteps : Methods
    {

        ScenarioContext _sc;
        BrowserDriver driver;
        public SliderSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            _sc = scenarioContext;
        }


        HomePage homePage = null;
        Details detailsPage = null;

        [Given(@"I scroll down to features listings")]
        public void GivenIScrollDownToFeaturesListings()
        {
            homePage = new HomePage(driver.Current);
            Sleep(3500);
            driver.Current.ScrollIntoView(homePage.FeaturedListingInSingapore);
        }

        [When(@"I Click all right sliders  ""(.*)"" times")]
        public void WhenIClickAllRightSlidersTimes(int slidingTimes)
        {
            for (int i = 0; i < slidingTimes; i++)
            {
                Sleep(3500);
                homePage.RightSlider1.Click();
                Sleep(760);
                homePage.RightSlider2.Click();
                Sleep(760);
                homePage.RightSlider3.Click();
                Sleep(760);
                //homePage.RightSlider4.Click();

            }
        }
        
        [Then(@"I click all left sliders ""(.*)"" times")]
        public void ThenIClickAllLeftSlidersTimes(int slidingTimes)
        {
            for (int i = 0; i < slidingTimes; i++)
            {
                Sleep();
                homePage.LeftSlider1.Click();
                Sleep(760);
                homePage.LeftSlider2.Click();
                Sleep(760);
                homePage.LeftSlider3.Click();
                Sleep(760);
               // homePage.LeftSlider4.Click();

            }
        }




        [Given(@"I navigate on ""(.*)""")]
        public void GivenINavigateOn(string URL)
        {
            homePage = new HomePage(driver.Current);
            GoToUrl(driver.Current, URL);
        }

        [Given(@"I disable popup on details page")]
        public void GivenIDisablePopupOnDetailsPage()
        {
            detailsPage = new Details(driver.Current);
            Sleep();
            SwitchiFrame(driver.Current, detailsPage.iFramePoPuP);
            detailsPage.DisablePopupOnDetails.Click();
            driver.Current.SwitchTo().DefaultContent();
        }


        [Given(@"I Click ""(.*)"" photo")]
        public void GivenIClickPhoto(string photoOpion)
        {
            
            detailsPage = new Details(driver.Current);
            if (photoOpion == "storage cover")
            {
                detailsPage.StorageCoverPhoto.Click();
            }
            else if (photoOpion == "storage seconday cover")
            {
                detailsPage.SecondaryStorageCoverPhoto.Click();
            }
            else if (photoOpion == "storage small cover")
            {
                detailsPage.SmallCoverPhoto.GetParent().Click();
            }
        }

        [Given(@"I Click ""(.*)"" thumbnail to slide")]
        public void GivenIClickThumbnailToSlide(string thumbnailOption)
        {
            if (thumbnailOption == "last")
            {
                detailsPage.LastThumbnail.Click();
            }
            else if (thumbnailOption == "first")
            {
                detailsPage.FirstThumbnail.Click();
            }
            else if (thumbnailOption == "5th")
            {
                detailsPage.FifthThumbnail.Click();
            }
        }

        [Given(@"I Slide right ""(.*)"" times")]
        public void GivenISlideRightTimes(int slidingCount)
        {
            for (int i = 0; i < slidingCount; i++)
            {
                detailsPage.RightSlide.Click();
                Sleep(400);
            }
        }

        [Given(@"I Slide left ""(.*)"" times")]
        public void GivenISlideLeftTimes(int slidingCount)
        {
            detailsPage.LeftSlide.Click();
            Sleep(400);
        }

        [Given(@"I Close sliding view popup")]
        public void GivenICloseSlidingViewPopup()
        {
            detailsPage.CloseXSlideView.GetParent().Click();
        }

        [Then(@"I Validate if ""(.*)"" is unchangable after these actions")]
        public void ThenIValidateIfIsUnchangableAfterTheseActions(string URL)
        {
            driver.Current.Url.Should().Be(URL, "We made few clicks but URL should be unchangable");
        }


    }
}
