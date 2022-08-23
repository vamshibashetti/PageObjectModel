using System;
using System.Linq;
using OpenQA.Selenium;
using System.Threading;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

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


        [FindsBy(How= How.XPath, Using="//select[@id='dropdowm-menu-1']")]
        private IWebElement LangDropDown;
        [FindsBy(How= How.XPath, Using="//select[@id='dropdowm-menu-2']")]
        private IWebElement IdeDropDown;
        [FindsBy(How= How.XPath, Using="//select[@id='dropdowm-menu-3']")]
        private IWebElement ScriptDropDown;
       


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
          
          public void  LanguageDD(){
            SelectElement  dropDown = new SelectElement(LangDropDown);
            //dropDown.SelectByText("c#");
            dropDown.SelectByIndex(1);


          }
           public void  IDEDD(){
            SelectElement  dropDown = new SelectElement(IdeDropDown);
            dropDown.SelectByText("TestNG");
          }

         

    }
}