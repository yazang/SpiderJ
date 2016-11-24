using OpenQA.Selenium;
using System.Collections.Generic;

namespace SpiderJ.Utils
{
    public interface IElementLocator
    {
        IWebElement Find(IWebDriver driver, By by);
        ICollection<IWebElement> FindAll(IWebDriver driver, By by);
    }
}
