using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

using TestBotForTwitch.Pages;

namespace TestBotForTwitch
{
	public class StartBoting
	{
		private IWebDriver _driver;

		public StartBoting(IWebDriver driver)
		{
			_driver = driver;
		}

		public void SignIn(string login, string password)
		{
			var page = new SignInTwitchPage(_driver);

			page.UserNameInputSetText(login);
			page.PasswordInputSetText(password);

			page.SubmitInputClick();
		}

		public void GoToStreamerPage(string url)
		{
			_driver.Navigate().GoToUrl(url);
		}

		public void GetStart(IWebDriver driver, string url, string login, string password)
		{
			var mainPage = new MainPage(_driver);

			mainPage.GetPage();

			Thread.Sleep(5000);

			mainPage.ClickSignUpButton();

			Thread.Sleep(4000);

			SignIn(login, password);

		}
	}
}
