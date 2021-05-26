using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Kpi.MetaUa.ClientTests.Platform.Driver
{
    internal static class WebDriverExtensions
    {
        public static bool Alive(this IWebDriver driver)
        {
            try
            {
                // Poke web driver.
                // ReSharper disable once UnusedVariable
                var handle = driver.CurrentWindowHandle;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }

            return driver.FindElement(by);
        }
    }
}
