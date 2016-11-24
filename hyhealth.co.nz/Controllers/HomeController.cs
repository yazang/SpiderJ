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
    public class HomeController
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private HomePage _page;

        public HomeController(
            IWebDriver driver,
            TimeSpan timespan)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, timespan);
            _page = new HomePage();
        }
    }
}
