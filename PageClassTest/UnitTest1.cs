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
      IWebDriver driver;

        

        [TestInitialize]
    

        public void start_Browser()

        {
            driver = new ChromeDriver(@"C:\Root Folder\WebDriver");
          driver.Navigate().GoToUrl("http://www.webdriveruniversity.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
         
            PageClassLib.DCRPage dcrpage =new PageClassLib.DCRPage(driver);
        }
        [TestMethod]
        [Ignore]
        public void TestMethod1()
        {
           PageClassLib.HomePage  homepage =new PageClassLib.HomePage(driver);
           homepage.DCRbtns();
           
        }
        [TestMethod]

        public void TestMethod2()
        {
          PageClassLib.HomePage  homepage =new PageClassLib.HomePage(driver);
          PageClassLib.DCRPage dcrpage =new PageClassLib.DCRPage(driver);
          homepage.DCRbtns();
          Thread.Sleep(4000);
          var newWindowHandle = driver.WindowHandles[1];
          Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
          string expectedNewWindowTitle = "WebDriver | Dropdown Menu(s) | Checkboxe(s) | Radio Button(s)" ;
          Assert.AreEqual(driver.SwitchTo().Window(newWindowHandle).Title, expectedNewWindowTitle);
           Thread.Sleep(4000);
          dcrpage.yellowbtn();
          Thread.Sleep(4000);
          dcrpage.LanguageDD();
          Thread.Sleep(4000);
          dcrpage.IDEDD();       
          Thread.Sleep(4000);

    
        }
        

        [TestCleanup]

        public void close_Browser()

        {

            driver.Quit();

        }


    }
}
