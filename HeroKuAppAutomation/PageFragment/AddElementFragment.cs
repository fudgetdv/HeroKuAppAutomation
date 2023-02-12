using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroKuAppAutomation.PageFragment
{
    public class AddElementFragment : AbstractFragment
    {
        private string locator = "div[class='example'] > button";
        public AddElementFragment(IWebDriver driver) : base(driver) { }

        public void ClickeAddElement()
        {
            _driver.FindElement(By.CssSelector(locator)).Click();
        }
        public override bool isDisplayed()
        {
            IWebElement element = new WebDriverWait(_driver, TimeSpan.FromSeconds(3))
            .Until(driver => driver.FindElement(By.CssSelector(locator)));
            return element.Displayed;
        }
    }
}
