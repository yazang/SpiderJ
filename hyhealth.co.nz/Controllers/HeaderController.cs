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
    public class HeaderController
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private Actions _action;
        private HeaderSegment _page;

        public HeaderController(
            IWebDriver driver,
            TimeSpan timeSpan)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, timeSpan);
            _action = new Actions(_driver);
            _page = new HeaderSegment();
        }

        public void OpenLoginPage()
        {
            _login.Click();
        }

        public void Search(string searchText)
        {
            _searchBox.SendKeys(searchText);
            _searchButton.Click();
        }

        public void OpenCart()
        {
            _cart.Click();
        }

        public void CheckOut()
        {
            _action.MoveToElement(_cart).MoveToElement(_checkOut).Click().Build().Perform();
        }

        private IWebElement _login
        {
            get { return _wait.Until(d => d.FindElement(_page.Login)); }
        }

        private IWebElement _searchBox
        {
            get { return _wait.Until(d => d.FindElement(_page.SearchBox)); }
        }

        private IWebElement _searchButton
        {
            get { return _wait.Until(d => d.FindElement(_page.SearchButton)); }
        }

        private IWebElement _cart
        {
            get { return _wait.Until(d => d.FindElement(_page.Cart)); }
        }

        private IWebElement _checkOut
        {
            get { return _wait.Until(d => d.FindElement(_page.CheckOut)); }
        }
    }
}
