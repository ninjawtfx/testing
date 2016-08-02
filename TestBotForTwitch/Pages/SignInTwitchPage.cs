using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.Extensions;

namespace TestBotForTwitch.Pages
{
	public class SignInTwitchPage : MainPage
	{

		public SignInTwitchPage(IWebDriver driver)
			: base(driver)
        {

        }

		public void UserNameInputSetText(string text)
		{
			_driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//div[@id='passport_iframe_container']//iframe")));

			Extens.SetText(UserNameInput, text);

			_driver.SwitchTo().DefaultContent();
		}

		public void PasswordInputSetText(string text)
		{
			_driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//div[@id='passport_iframe_container']//iframe")));

			Extens.SetText(PasswordInput, text);

			_driver.SwitchTo().DefaultContent();
		}

		public void SubmitInputClick()
		{
			_driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//div[@id='passport_iframe_container']//iframe")));

			SignInButton.Click();

			_driver.SwitchTo().DefaultContent();
		}


		[FindsBy(How = How.Id, Using = "username")]
		private IWebElement UserNameInput { get; set; }

		[FindsBy(How = How.Name, Using = "password")]
		private IWebElement PasswordInput { get; set; }

		[FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
		private IWebElement SignInButton { get; set; }
	}
}
