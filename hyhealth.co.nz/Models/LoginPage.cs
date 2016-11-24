using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyhealth.co.nz.Models
{
    internal class LoginPage
    {
        internal By Email
        {
            get { return By.Id("email"); }
        }

        internal By Password
        {
            get { return By.Id("pass"); }
        }

        internal By Login
        {
            get { return By.Id("send2"); }
        }
    }
}
