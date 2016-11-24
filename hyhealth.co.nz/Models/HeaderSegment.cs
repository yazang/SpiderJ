using OpenQA.Selenium;

namespace hyhealth.co.nz.Models
{
    internal class HeaderSegment
    {
        internal By Login
        {
            get { return By.LinkText("登录"); }
        }

        internal By SearchBox
        {
            get { return By.Id("search"); }
        }

        internal By SearchButton
        {
            get { return By.XPath("//form[@id='search_mini_form']//button"); }
        }

        internal By Cart
        {
            get { return By.Id("minicart-link"); }
        }

        internal By CheckOut
        {
            get { return By.XPath("//button[@title='结账']"); }
        }
    }
}
