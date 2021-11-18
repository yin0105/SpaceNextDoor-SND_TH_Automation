using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;

namespace SND_TH.Helpers
{
    public class Methods
    {
        public static void GoToUrl(IWebDriver driver, string url) => driver.Navigate().GoToUrl(url);
        public static void SwitchToTab(IWebDriver driver, int to = 1) => driver.SwitchTo().Window(driver.WindowHandles[to]);

        public static void CloseTab(IWebDriver driver, int tabNumber = 0)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript(string.Format("window.close();"));
            SwitchToTab(driver, tabNumber);
        }

        public static void OpenNewTab(IWebDriver driver, string url)
        {
            _ = ((IJavaScriptExecutor)driver).ExecuteScript(string.Format($"window.open('{url}','_blank');"));
            SwitchToTab(driver, 1); //needs to be tested multiple open is working or not. because driverhandle [1] is second tab
        }
        public static void SwitchiFrame(IWebDriver driver, IWebElement iframe) => driver.SwitchTo().Frame(iframe);

        public static void PreviousTab(IWebDriver driver) => driver.Navigate().Back();

        public static void CheckUrl(IWebDriver driver, string url) => driver.Url.Contains(url);//equals is a better solution? needs to be tested

        public static string RandomDigits(int lenght)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < lenght; i++)
            {
                s = string.Concat(s, random.Next(10).ToString());
            }
            return s;
        }


        public ReadOnlyCollection<IWebElement> getAlliFrames(IWebDriver driverCurrent)
        {
            //List<IWebElement> iframes = driverCurrent.FindElements(By.TagName("iframe"));
            ReadOnlyCollection<IWebElement> list = driverCurrent.FindElements(By.TagName("iframe"));
            return list;
        }

        public static void Sleep(int wait = 1500) => Thread.Sleep(wait);

        public static void Refresh(IWebDriver driver) => driver.Navigate().Refresh();

        public static int TabCount(IWebDriver driver) => driver.WindowHandles.Count;
    }
}
