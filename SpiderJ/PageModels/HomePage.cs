﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpiderJ.Utils;
using System;
using System.Threading;

namespace SpiderJ.PageModels
{
    public class HomePage
    {
        private IWebDriver _driver;
        private IElementLocator _locator;

        public HomePage(
            IWebDriver driver,
            IElementLocator locator)
        {
            _driver = driver;
            _locator = locator;
        }

        public IWebElement NavMenuItem
        {
            get
            {
                return _locator.Find(_driver, By.ClassName("nav-1"));
            }
        }
    }
}
