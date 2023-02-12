using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroKuAppAutomation.PageFragment
{
    public abstract class AbstractFragment
    {
        protected IWebDriver _driver;

        public AbstractFragment(IWebDriver driver)
        {
            _driver = driver;
        }
        public abstract bool isDisplayed();
    }
}
