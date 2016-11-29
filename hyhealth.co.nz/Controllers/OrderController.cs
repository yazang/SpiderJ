using hyhealth.co.nz.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void NewAddress()
        {
            var js = _driver as IJavaScriptExecutor;
            _addressSelector.Click();
            js.ExecuteScript("arguments[0].scrollIntoView(true);", new object[] { _newAddress });
            _newAddress.Click();
            _addressSelector.Click();
        }

        public void EnterAddress()
        {
            var lastName = _wait.Until(d => d.FindElement(_page.LastName));
            lastName.Clear();
            lastName.SendKeys("LIU");

            var firstName = _wait.Until(d => d.FindElement(_page.FirstName));
            firstName.Clear();
            firstName.SendKeys("YUAN");

            var phone = _wait.Until(d => d.FindElement(_page.Phone));
            phone.Clear();
            phone.SendKeys("18612345678");

            var address = _wait.Until(d => d.FindElement(_page.Address));
            address.Clear();
            address.SendKeys("龙湖江与城");

            _wait.Until(d => d.FindElement(_page.CountrySelector)).Click();
            var countries = _driver.FindElements(_page.CountryOptions);
            foreach (var country in countries)
            {
                if (country.GetAttribute("value") == "CN")
                {
                    country.Click();
                }
            }

            var city = _wait.Until(d => d.FindElement(_page.City));
            city.Clear();
            city.SendKeys("CHONGQING");

            var postCode = _wait.Until(d => d.FindElement(_page.PostCode));
            postCode.Clear();
            postCode.SendKeys("400000");

            var region = _wait.Until(d => d.FindElement(_page.Region));
            region.Clear();
            region.SendKeys("CHONGQING");

            var senderName = _wait.Until(d => d.FindElement(_page.SenderName));
            senderName.Clear();
            senderName.SendKeys("ZHENG TAN");

            var saveAddress = _wait.Until(d => d.FindElement(_page.SaveAddress));
            if (saveAddress.Selected)
            {
                saveAddress.Click();
            }

            var termAndConditions = _wait.Until(d => d.FindElement(_page.TermsAndConditions));
            if (!termAndConditions.Selected)
            {
                //Thread.Sleep(10000);
                termAndConditions.Click();
            }
        }

        private IWebElement _addressSelector
        {
            get { return _wait.Until(d => d.FindElement(_page.AddressSelector)); }
        }

        private IWebElement _newAddress
        {
            get
            {
                //var options = _wait.Until(d => d.FindElements(_page.AddressOptions));
                var options = _driver.FindElements(_page.AddressOptions);
                return options.Last();
            }
        }

        private IWebElement _selectedAddress
        {
            get
            {
                var options = _wait.Until(d => d.FindElements(_page.AddressOptions));
                foreach (var option in options)
                {
                    if (option.GetAttribute("selected") != null)
                    {
                        return option;
                    }
                }
                return null;
            }
        }
    }
}
