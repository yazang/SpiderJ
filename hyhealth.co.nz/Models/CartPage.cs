using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyhealth.co.nz.Models
{
    internal class CartPage
    {
        internal By CheckOut
        {
            get { return By.XPath("//button[@title='结算']"); }
        }
    }
}
