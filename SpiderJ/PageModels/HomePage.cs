using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SpiderJ.PageModels
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement NavMenuItem
        {
            get
            {
                var by = By.ClassName("nav-1");

                for (int sec = 0; sec < 15; sec++)
                {
                    try
                    {
                        return _driver.FindElement(by);
                    }
                    catch (NoSuchElementException)
                    {
                        Thread.Sleep(1000);
                        continue;
                    }
                }

                return null;
            }
        }
    }
}
