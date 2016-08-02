using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace TestBotForTwitch.Pages
{
    public class MailPage
    {
        protected IWebDriver _driver;
        protected string _url = "https://mail.ru/";

        public MailPage(IWebDriver driver)
        {
            _driver = driver;

            PageFactory.InitElements(_driver, this);
        }

        public void GetPage()
        {
            _driver.Navigate().GoToUrl(_url);

            _driver.Manage().Window.Maximize();
        }

        public void ClickSignUpButton()
        {
            SignUpButton.Click();
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='mailbox__register__link']")]

        private IWebElement SignUpButton { get; set; }

        
    }
}
