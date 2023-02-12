using HeroKuAppAutomation.PageFragment;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroKuAppAutomation.Page
{
    public class AppPage
    {
        private IWebDriver _driver;
        private AddElementFragment addElement;
        private DeleteElementFragment deleteElement;
        public AppPage(IWebDriver driver) {
            _driver = driver;
            addElement = new AddElementFragment(driver);
            deleteElement = new DeleteElementFragment(driver);
        }

        public void AddNElements(int count)
        {
            addElement.isDisplayed();
            for(int i = 0; i < count; i++)
            {
                addElement.ClickeAddElement();
            }
        }

        public int CountElements()
        {
            deleteElement.isDisplayed();
            return deleteElement.DeleteElements().Count();
        }
    }
}
