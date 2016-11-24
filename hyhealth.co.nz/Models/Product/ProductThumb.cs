using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyhealth.co.nz.Models.Product
{
    internal class ProductThumb
    {
        internal By ProductLink
        {
            get { return By.XPath("//h2[@class='product-name']/a"); }
        }

        internal By AddToCart
        {
            //get { return By.XPath("//button[@title='加入购物车']"); }
            get { return By.ClassName("btn-cart"); }
        }
    }
}
