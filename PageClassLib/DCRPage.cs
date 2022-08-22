using System;
using System.Linq;
using OpenQA.Selenium;
using System.Threading;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace PageClassLib
{
    public class DCRPage
    {
        private IWebDriver _driver;
        
        [FindsBy(How= How.XPath, Using="//input[@value='green']")]
        private IWebElement _greenbtn;
        [FindsBy(How= How.XPath, Using="//input[@value='blue']")]
        private IWebElement _bluebtn;
        [FindsBy(How= How.XPath, Using="//input[@value='yellow']")]
        private IWebElement _yellowbtn;
        [FindsBy(How= How.XPath, Using="//input[@value='orange']")]
        private IWebElement _orangebtn;
        [FindsBy(How= How.XPath, Using="//input[@value='purple']")]
        private IWebElement _purplebtn;

      public DCRPage (IWebDriver driver)
        {
          
          _driver =driver; 
        PageFactory.InitElements(_driver,this);
        }

        public void greenbtn(){

            _greenbtn.Click();
        }

        public void bluebtn(){

            _bluebtn.Click();
        }

        public void yellowbtn(){

             _yellowbtn.Click();
        }

        public void orangebtn(){

           _orangebtn.Click();
        }
        public void purplebtn(){

            _purplebtn.Click();
        }
         

         

    }
}