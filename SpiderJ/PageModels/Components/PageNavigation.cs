using OpenQA.Selenium;
using SpiderJ.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderJ.PageModels.Components
{
    public class PageNavigation
    {
        private IWebDriver _driver;
        private IElementLocator _locator;

        public PageNavigation(
            IWebDriver driver,
            IElementLocator locator)
        {
            _driver = driver;
            _locator = locator;
        }

        public IWebElement NextPage
        {
            get
            {
                return _locator.Find(_driver, By.ClassName("next"));
            }
        }
    }
}
