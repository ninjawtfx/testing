using System.IO;
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

		public Bot(Driver driver, string login, string password, Roles role)
		{
			_driver = driver;

			Account = new FakeAccount(login, password, role);
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
			var mainPage = new MainPage(_driver);

			mainPage.GetPage();

			Thread.Sleep(5000);

			mainPage.ClickSignUpButton();

			Thread.Sleep(4000);

			SignIn(Account.Name, Account.Password);

			mainPage.SendMessageInChat(GetHelloReplic());
		}

		public string GetHelloReplic()
		{
			return Files.GetHelloReplic(Account.Role);
		}
	}
}
