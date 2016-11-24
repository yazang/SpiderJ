using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SpiderJ.Utils;
using SpiderJ.Data;
using System.Data.Entity;

namespace SpiderJ
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IWebDriver>().To<FirefoxDriver>();
            Bind<IElementLocator>().To<StandardLocator>();
            Bind<IRepository>().To<MemoryRepository>();
        }
    }
}
