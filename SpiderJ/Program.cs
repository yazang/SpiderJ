using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using SpiderJ.Data;
using SpiderJ.Model;
using SpiderJ.PageModels;

namespace SpiderJ
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Repository();

            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("http://www.hyhealth.co.nz/");

                var homePage = new HomePage(driver);
                var menuItem = homePage.NavMenuItem;
                menuItem.Click();

                //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                
                //IWebElement sales1 = wait.Until<IWebElement>(d => d.FindElement(By.ClassName("homepage_products_3")));

                //if (sales1 != null)
                //{
                //    IEnumerable<IWebElement> items = sales1.FindElements(By.ClassName("homepage_item"));

                //    foreach (IWebElement item in items)
                //    {
                //        var name = item.FindElement(By.ClassName("homepage_product_name"));
                //        var url = name.FindElement(By.TagName("a"));
                //        var price = item.FindElement(By.ClassName("special-price")).FindElement(By.ClassName("price"));
                //        var image = item.FindElement(By.TagName("img"));

                //        context.Add(new Product
                //        {
                //            Name = name.Text,
                //            Url = url.GetAttribute("href"),
                //            Price = price.Text,
                //            Image = image.GetAttribute("src")
                //        });
                //    }
                //}
            }
        }
    }
}
