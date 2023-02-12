using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HeroKuAppAutomation.PageFragment
{
    public class DeleteElementFragment : AbstractFragment
    {
        private string locator = "div[id='elements']";
        private string locatorButton = "div[id='elements'] > button";
        public DeleteElementFragment(IWebDriver driver) : base(driver) { }

        public ReadOnlyCollection<IWebElement> DeleteElements()
        {
            return _driver.FindElements(By.CssSelector(locatorButton));
        }
        public override bool isDisplayed()
        {
            IWebElement element = new WebDriverWait(_driver, TimeSpan.FromSeconds(3))
            .Until(driver => driver.FindElement(By.CssSelector(locator)));
            return element.Displayed;
        }
    }
}
