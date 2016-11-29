using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using hyhealth.co.nz.Controllers;
using System.Threading;

namespace UnitTesting
{
    [TestClass]
    public class HYhealthTests
    {
        private string _url = @"http://www.hyhealth.co.nz/";
        private string _email = @"vivianzheng525@outlook.com";
        private string _password = @"1010629Vivian330";

        private IWebDriver _driver;
        private TimeSpan _timespan;

        public HYhealthTests()
        {
            _driver = new ChromeDriver();
            _timespan = TimeSpan.FromSeconds(TestParameters.WAITTIME);
        }

        [TestMethod]
        public void Demo()
        {
            _driver.Navigate().GoToUrl(_url);
            _driver.Manage().Window.Maximize();
            var headerController = new HeaderController(_driver, _timespan);
            headerController.OpenLoginPage();
            var loginController = new LoginController(_driver, _timespan);
            loginController.Login(_email, _password);
            headerController.CheckOut();
            //headerController.Search("蜂蜜");
            //var productsController = new ProductsController(_driver, _timespan);
            //productsController.AddProductToCart("红印 蜂胶蜂蜜香皂 100克");
            //headerController.OpenCart();
            //var cartController = new CartController(_driver, _timespan);
            //cartController.CheckOut();
            var orderController = new OrderController(_driver, _timespan);
            orderController.NewAddress();
            orderController.EnterAddress();
        }
    }
}
