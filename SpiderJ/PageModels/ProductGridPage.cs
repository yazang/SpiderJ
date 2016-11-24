using OpenQA.Selenium;
using SpiderJ.Model;
using SpiderJ.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderJ.PageModels
{
    public class ProductGridPage
    {
        private IWebDriver _driver;
        private IElementLocator _locator;

        public ProductGridPage(
            IWebDriver driver,
            IElementLocator locator)
        {
            _driver = driver;
            _locator = locator;
        }

        public IWebElement CategoryProducts
        {
            get
            {
                return _locator.Find(_driver, By.ClassName("category-products"));
            }
        }

        public IEnumerable<Product> Products
        {
            get
            {
                var items = _locator.FindAll(_driver, By.ClassName("item"));
                var products = new List<Product>();

                foreach (var item in items)
                {
                    var product = new Product
                    {
                        Name = item.FindElement(By.ClassName("product-name")).FindElement(By.TagName("a")).Text,
                        Url = item.FindElement(By.TagName("a")).GetAttribute("href"),
                        ImageUri = item.FindElement(By.TagName("img")).GetAttribute("src"),
                        Price = item.FindElement(By.ClassName("price")).Text
                    };

                    products.Add(product);
                }

                return products;
            }
        }

        public bool IsLoaded()
        {
            if (CategoryProducts != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
