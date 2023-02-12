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
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new ArgumentNullException("chromedriver location not known");

            using (var driver = new ChromeDriver(path,chromeOptions))
            {
                int count = 9;
                driver.Url = "https://the-internet.herokuapp.com/add_remove_elements/";
                AppPage page = new AppPage(driver);
                page.AddNElements(count);
                Assert.IsTrue(page.CountElements() == count, "The count of elments is off");
            }
        }
    }
}