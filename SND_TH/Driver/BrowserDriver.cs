using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace SND_TH.Driver
{

    public class BrowserDriver : IBrowserDriver
    {
        private readonly TestContext _testRunContext;
        private readonly string _baseUrl;
        public IWebDriver Current;

        public BrowserDriver(TestContext testContext)
        {
            _testRunContext = testContext;
            _baseUrl = "https://stag-th.spacenextdoor.com/";
            Current = StartDriver("chrome"); //-headless
        }

        private IWebDriver StartDriver(string browser)
        {
            return browser switch
            {
                "chrome" => GetChromeDriver(false),
                "chrome-headless" => GetChromeDriver(true),
                "firefox" => GetFirefoxDriver(),
                "edge" => GetEdgeDriver(),

            };

        }
        public void Navigate(string urlPart)
        {
            if (!Current.Url.EndsWith(urlPart))
            {
                Current.Navigate().GoToUrl($"{_baseUrl}{urlPart}");
                //RetryHelper.WaitFor(() => Current.Url.EndsWith(urlPart));
            }
        }

        #region Cross-Browser-Implementation

        private IWebDriver GetEdgeDriver()
        {
            var edgeDriverServices = EdgeDriverService.CreateDefaultService(_testRunContext.DeploymentDirectory);
            var edgeDriverOptions = new EdgeOptions();
            edgeDriverOptions.PageLoadStrategy = PageLoadStrategy.Eager;

            var edgeDriver = new EdgeDriver(edgeDriverServices, edgeDriverOptions)
            {
                Url = _baseUrl
            };
            edgeDriver.Manage().Window.Maximize();
            return edgeDriver;
        }


        private IWebDriver GetFirefoxDriver()
        {
            var firefoxDriverService = FirefoxDriverService.CreateDefaultService(_testRunContext.DeploymentDirectory);
            firefoxDriverService.Host = "::1";
            var firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArgument("--start-maximized");
            //firefoxOptions.BrowserExecutableLocation = @"input this if there is a custom location";
            var firefoxDriver = new FirefoxDriver(firefoxDriverService, firefoxOptions)
            {
                Url = _baseUrl
            }; 
            return firefoxDriver;
        }
        
        private IWebDriver GetChromeDriver(bool isHeadless)
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            if (isHeadless)
            {
                chromeOptions.AddArgument("headless");
            }
            var chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions)
            {
                Url = _baseUrl
            };

            if (isHeadless) chromeDriver.Manage().Window.Size = new Size(1920, 1080);

            return chromeDriver;
        }
        #endregion Cross-Browser-Implementation
        
    }
}
