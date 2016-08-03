using System;
using System.IO;
using System.Xml;
using OpenQA.Selenium;

using System.Threading;
using TestBotForTwitch.Class;
using TestBotForTwitch.Pages;

namespace TestBotForTwitch
{
	public class Bot
	{
		private Driver _driver;

		public FakeAccount Account;
		private MainPage _mainPage;

		public Bot(Driver driver, string login, string password, Roles role)
		{
			_driver = driver;

			Account = new FakeAccount(login, password, role);

			_mainPage = new MainPage(_driver);

			_mainPage.GetPage();
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

		public void GetStart(string url)
		{
			Thread.Sleep(5000);

			_mainPage.ClickSignUpButton();

			Thread.Sleep(4000);

			SignIn(Account.Name, Account.Password);

			_mainPage.SendMessageInChat(GetHelloReplic());
		}

		public string GetHelloReplic()
		{
			return Files.GetHelloReplic(Account.Role);
		}

		public void Say(string text)
		{
			_mainPage.SendMessageInChat(text);
		}

		public void Bunt()
		{
			_mainPage.SendMessageInChat("БУНТ!!!!!!!!!!!");
		}

		public void Laught()
		{
			var rnd = new Random().Next(20);

			string result = string.Empty;

			for (int i = 0; i < rnd; i++)
			{
				result += "ах";
			}

			_mainPage.SendMessageInChat(result);
		}
	}
}
