using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUnitTestProject
{
    [TestClass]
    public class SeleniumTest
    {
        String test_url = "http://www.practiceselenium.com/";

        //String itemName = "Add it to list";

        [TestMethod]
        public void NavigateToDoApp()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl(test_url);
            //driver.Manage().Window.Maximize();


            IWebElement img = driver.FindElement(By.ClassName("img"));
            Boolean getImg = img.Displayed;
            Assert.IsTrue(condition: getImg);
            Console.WriteLine(getImg);
            IWebElement welcomText = driver.FindElement(By.ClassName("active"));
            String getText = welcomText.Text;
            Assert.IsTrue(getText.Contains(getText));
            Console.WriteLine(getText);
            IWebElement menuText = driver.FindElement(By.LinkText("Menu"));
            Console.WriteLine(menuText);
            IWebElement TeaTxt = driver.FindElement(By.ClassName("txt"));
            IWebElement checkOut = driver.FindElement(By.LinkText("Check Out"));
            /*IWebElement checkOut = driver.FindElement(By.CssSelector(cssSelectorToFind: ".nav-vertical>ul>li.active"));*/
            string getColorTxt = checkOut.Text;
            Assert.IsTrue(getColorTxt.Contains(getColorTxt));
            checkOut.Click();
            Console.WriteLine(getColorTxt);


            driver.Quit();

        }

    }
}
