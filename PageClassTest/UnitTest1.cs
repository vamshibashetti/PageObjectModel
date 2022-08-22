using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;


namespace PageClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver (@"C:\Root Folder\WebDriver");
            driver.Navigate().GoToUrl("http://www.webdriveruniversity.com/");
            driver.Manage().Window.Maximize(); 
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10); 

          PageClassLib.HomePage page =new PageClassLib.HomePage(driver);
           page.DCRbtns();
    
        }
        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver (@"C:\Root Folder\WebDriver");
            driver.Navigate().GoToUrl("http://www.webdriveruniversity.com/");
            driver.Manage().Window.Maximize(); 
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10); 
          PageClassLib.HomePage  homepage =new PageClassLib.HomePage(driver);
           homepage.DCRbtns();
          PageClassLib.DCRPage dcrpage =new PageClassLib.DCRPage(driver);

          dcrpage.bluebtn();
    
        }


    }
}
