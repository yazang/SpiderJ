using System;
using OpenQA.Selenium;
using SpiderJ.Data;
using SpiderJ.PageModels;
using SpiderJ.Utils;
using Ninject;
using System.Reflection;
using SpiderJ.PageModels.Components;
using System.Threading;
using System.Data.Entity;

namespace SpiderJ
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var driver = kernel.Get<IWebDriver>();
            var locator = kernel.Get<IElementLocator>();
            //var repository = kernel.Get<IRepository>();
            var dbContext = new SpiderJDB();
            
            driver.Navigate().GoToUrl("http://www.hyhealth.co.nz/");

            var homePage = new HomePage(driver, locator);
            var menuItem = homePage.NavMenuItem;
            menuItem.Click();

            var productsPage = new ProductGridPage(driver, locator);
            for (int i = 0; !productsPage.IsLoaded(); i++)
            {
                if (i >= 2)
                {
                    Console.WriteLine("Cannot load ProductGridPage.");
                    break;
                }
                menuItem.Click();
            }

            foreach (var product in productsPage.Products)
            {
                //repository.Add(product);
                dbContext.Products.Add(product);
            }

            var pageNavigation = new PageNavigation(driver, locator);
            
            while (pageNavigation.NextPage != null)
            {
                pageNavigation.NextPage.Click();
                Thread.Sleep(3000);

                if (productsPage.IsLoaded())
                {
                    foreach (var product in productsPage.Products)
                    {
                        //repository.Add(product);
                        dbContext.Products.Add(product);
                    }
                }
            }

            dbContext.SaveChanges();
        }
    }
}
