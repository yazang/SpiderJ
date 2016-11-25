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
    public class CartController
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private Actions _action;
        private CartPage _page;

        public CartController(
            IWebDriver driver,
            TimeSpan timeSpan)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, timeSpan);
            _action = new Actions(_driver);
            _page = new CartPage();
        }

        // Does not work.
        //public void CheckOut()
        //{
        //    _action.MoveToElement(_checkOutButton).Click().Build().Perform();
        //}

        //private IWebElement _checkOutButton
        //{
        //    get { return _wait.Until(d => d.FindElement(_page.CheckOut)); }
        //}
    }
}
