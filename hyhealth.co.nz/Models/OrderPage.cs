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

        internal By LastName
        {
            get { return By.Id("billing:lastname"); }
        }

        internal By FirstName
        {
            get { return By.Id("billing:firstname"); }
        }

        internal By Phone
        {
            get { return By.Id("billing:telephone"); }
        }

        internal By Address
        {
            get { return By.Id("billing:street1"); }
        }

        internal By CountrySelector
        {
            get { return By.Id("billing:country_id"); }
        }

        internal By CountryOptions
        {
            get { return By.XPath("//select[@id='billing:country_id']/option"); }
        }

        internal By City
        {
            get { return By.Id("billing:city"); }
        }

        internal By PostCode
        {
            get { return By.Id("billing:postcode"); }
        }

        internal By Region
        {
            get { return By.Id("billing:region"); }
        }

        internal By SenderName
        {
            get { return By.Id("billing:fax"); }
        }

        internal By SaveAddress
        {
            get { return By.Id("billing:save_in_address_book"); }
        }

        internal By TermsAndConditions
        {
            get { return By.Id("terms_conditions_checkbox_id"); }
        }

        internal By SubmitOrder
        {
            get { return By.Id("onestepcheckout-button-place-order"); }
        }
    }
}
