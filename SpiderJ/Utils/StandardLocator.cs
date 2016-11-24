using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SpiderJ.Utils
{
    public class StandardLocator : IElementLocator
    {
        private TimeSpan _waitTime = TimeSpan.FromSeconds(10);

        public IWebElement Find(IWebDriver driver, By by)
        {
            for (int sec = 0; sec < _waitTime.Seconds; sec++)
            {
                try
                {
                    return driver.FindElement(by);
                }
                catch (NoSuchElementException)
                {
                    Thread.Sleep(1000);
                    continue;
                }
            }

            return null;
        }

        public ICollection<IWebElement> FindAll(IWebDriver driver, By by)
        {
            for (int sec = 0; sec < _waitTime.Seconds; sec++)
            {
                try
                {
                    return driver.FindElements(by);
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
