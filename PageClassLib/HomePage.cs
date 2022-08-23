using System;
using System.Linq;
using OpenQA.Selenium;
using System.Threading;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace PageClassLib
{
    public class HomePage
    {
        private IWebDriver _driver;
        
         [FindsBy(How= How.PartialLinkText, Using="DROPDOWN, CHECKBOXE(S) & RADIO BUTTON(S)")]
         private IWebElement _HyperLink;


        public HomePage (IWebDriver driver)
        {
          
          _driver =driver; 
        PageFactory.InitElements(_driver,this);
        }
        public void DCRbtns()
        {
          _HyperLink.Click();

        }
       

    
}
}