using hyhealth.co.nz.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyhealth.co.nz.Controllers
{
    public class OrderController
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private Actions _action;
        private OrderPage _page;

        public OrderController(
            IWebDriver driver,
            TimeSpan timeSpan)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, timeSpan);
            _action = new Actions(_driver);
            _page = new OrderPage();
        }

        public void EnterAddress()
        {
            //_addressSelector.Click();
            var js = _driver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].click();", _addressSelector);


            //_action.MoveToElement(_newAddress).Click().Build().Perform();
            
            //js.ExecuteScript("arguments[0].scrollIntoView(true);", _newAddress);
        }

        private IWebElement _addressSelector
        {
            get { return _wait.Until(d => d.FindElement(_page.AddressSelector)); }
        }

        private IWebElement _newAddress
        {
            get
            {
                var options = _wait.Until(d => d.FindElements(_page.AddressOptions));
                return options.Last();
            }
        }
    }
}
