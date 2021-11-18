using OpenQA.Selenium;
using QAssistant.Extensions;


namespace SND_TH.POM
{
  public  class Details : BasePOM
    {
        IWebDriver driver;
        public Details(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement StorageCoverPhoto => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Main site cover']"));
        public IWebElement FirstThumbnail => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='thumbnail'])[last()]"));
        public IWebElement LastThumbnail => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='thumbnail'])[1]"));
        public IWebElement FifthThumbnail => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='thumbnail'])[5]"));
        public IWebElement CloseXSlideView => driver.FindElement(By.XPath("//*[@alt='close_white']"));
        public IWebElement SecondaryStorageCoverPhoto => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='Secondary small cover']"));
        public IWebElement SmallCoverPhoto => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='Small site'])[2]"));
        public IWebElement LeftSlide => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@alt='arrow-left']"));
        public IWebElement RightSlide => driver.WaitUntilElementIsDisplayed(By.XPath("(//*[@alt='arrow-right'])[2]"));
        public IWebElement DisableChatPopup => driver.FindElement(By.XPath("//*[@data-test-id='popup_close_button']"));
        public IWebElement HelcrunchIframe => driver.FindElement(By.XPath("//*[@name='helpcrunch-iframe']"));
        public IWebElement DisablePopupOnDetails => driver.FindElement(By.XPath("//*[@src='https://static.spacenextdoor.com/images/close-popup.png']"));
        public IWebElement iFramePoPuP => driver.FindElement(By.XPath("//*[@id='wiz-iframe-intent']"));


    }
}
