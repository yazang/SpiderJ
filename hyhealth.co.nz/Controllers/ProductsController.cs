using hyhealth.co.nz.Models.Product;
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
    public class ProductsController
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private Actions _action;
        private ProductsGrid _grid;
        private ProductThumb _thumb;
        private ProductPage _page;

        public ProductsController(
            IWebDriver driver,
            TimeSpan timeSpan)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, timeSpan);
            _action = new Actions(_driver);
            _grid = new ProductsGrid();
            _thumb = new ProductThumb();
            _page = new ProductPage();
        }

        public void AddProductToCart(string productName)
        {
            List<IWebElement> products = _wait.Until(d => d.FindElements(_grid.Products)).ToList();
            foreach (var product in products)
            {
                if (product.FindElement(_thumb.ProductLink).Text == productName)
                {
                    product.FindElement(_thumb.ProductLink).Click();
                    _wait.Until(d => d.FindElement(_page.AddToCart)).Click();
                    //_action.MoveToElement(product.FindElement(_thumb.AddToCart)).Click().Build().Perform();
                }
            }
        }
    }
}
