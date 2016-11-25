using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyhealth.co.nz.Models
{
    internal class OrderPage
    {
        internal By AddressSelector
        {
            get { return By.Id("billing-address-select"); }
        }

        internal By AddressOptions
        {
            get { return By.XPath("//select[@id='billing-address-select']/option"); }
        }
    }
}
