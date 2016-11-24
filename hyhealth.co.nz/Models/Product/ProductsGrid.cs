using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyhealth.co.nz.Models.Product
{
    internal class ProductsGrid
    {
        internal By Products
        {
            get { return By.XPath("//div[@class='category-products']//li[@class='item']"); }
        }
    }
}
