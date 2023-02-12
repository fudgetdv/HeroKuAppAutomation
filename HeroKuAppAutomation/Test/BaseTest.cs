using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Reflection;
using HeroKuAppAutomation.Page;


namespace HeroKuAppAutomation.Test
{
    [TestClass]
    public class BaseTest
    {

        [TestMethod]
        public void AddElementTest()
        {
            int count = 9;
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new ArgumentNullException("chromedriver location not known");
            IWebDriver _driver = new ChromeDriver(path)
            {
                Url = "https://the-internet.herokuapp.com/add_remove_elements/"
            };
            AppPage page = new AppPage(_driver);
            page.AddNElements(count);
            Assert.IsTrue(page.CountElements() == count, "The count of elments is off");

            _driver.Dispose();
        }

    }
}