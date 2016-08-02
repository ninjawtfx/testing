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
    public class MainPage
    {
        protected IWebDriver _driver;
        private string _url;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            _url = "https://www.twitch.tv/directory";

            PageFactory.InitElements(_driver, this);

        }

        public void ClickSugnUpButton()
        {
            SugnUpButton.Click();
        }

		public void ClickSignUpButton()
		{
			SignUpButton.Click();
		}

        public void GetPage()
        {
            _driver.Navigate().GoToUrl(_url);

            _driver.Manage().Window.Maximize();
        }




        [FindsBy(How = How.XPath, Using = "//*[@id='right_col']/div/div[2]/div/div[2]/a[2]")]

        private IWebElement SugnUpButton { get; set; }

		[FindsBy(How = How.XPath, Using = "(//span[@class='ember-view']//button)[1]")]

		private IWebElement SignUpButton { get; set; }


        
        
    }
}
