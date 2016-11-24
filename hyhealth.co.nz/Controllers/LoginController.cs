using hyhealth.co.nz.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyhealth.co.nz.Controllers
{
    public class LoginController
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private LoginPage _page;

        public LoginController(
            IWebDriver driver,
            TimeSpan timeSpan)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, timeSpan);
            _page = new LoginPage();
        }

        public void Login(string email, string password)
        {
            _email.SendKeys(email);
            _password.SendKeys(password);
            _loginButton.Click();
        }

        private IWebElement _email
        {
            get { return _wait.Until(d => d.FindElement(_page.Email)); }
        }

        private IWebElement _password
        {
            get { return _wait.Until(d => d.FindElement(_page.Password)); }
        }

        private IWebElement _loginButton
        {
            get { return _wait.Until(d => d.FindElement(_page.Login)); }
        }
    }
}
