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
	public class FacebookPage
	{
		protected IWebDriver _driver;
        private string _url;

		public FacebookPage(IWebDriver driver)
        {
            _driver = driver;
            _url = "https://www.facebook.com/";

            PageFactory.InitElements(_driver, this);

        }

		public void GetPage()
		{
			_driver.Navigate().GoToUrl(_url);

			_driver.Manage().Window.Maximize();
		}

		public void FirstNameSetText(string text)
		{
			Extens.SetText(FirstName, text);
		}

		public void LastNameSetText(string text)
		{
			Extens.SetText(LastName, text);
		}

		public void MailSetText(string text)
		{
			Extens.SetText(Mail, text);
		}

		public void MailConfirmationSetText(string text)
		{
			Extens.SetText(MailConfirmation, text);
		}

		public void PasswordSetText(string text)
		{
			Extens.SetText(Password, text);
		}
		public void ChooseBirthdayDay()
		{
			SelectElement selec = new SelectElement(BirthdayDay);

			string rnd = new Random().Next(1, 25).ToString();

			selec.SelectByValue(rnd);
		}
		public void ChooseBirthdayMonth()
		{
			SelectElement selec = new SelectElement(BirthdayMonth);

			string rnd = new Random().Next(1, 12).ToString();

			selec.SelectByValue(rnd);
		}

		public void ChooseBirthdayYear()
		{
			SelectElement selec = new SelectElement(BirthdayYear);

			string rnd = new Random().Next(1955, 1995).ToString();

			selec.SelectByValue(rnd);
		}

		public void SexClick()
		{
			Sex.Click();
		}

		public void SubmitClick()
		{
			Submit.Click();
		}

		[FindsBy(How = How.Name, Using = "firstname")]
		protected IWebElement FirstName { get; set; }

		[FindsBy(How = How.Name, Using = "lastname")]
		protected IWebElement LastName { get; set; }

		[FindsBy(How = How.Name, Using = "reg_email__")]
		protected IWebElement Mail { get; set; }

		[FindsBy(How = How.Name, Using = "reg_email_confirmation__")]
		protected IWebElement MailConfirmation { get; set; }

		[FindsBy(How = How.Name, Using = "reg_passwd__")]
		protected IWebElement Password { get; set; }

		[FindsBy(How = How.Name, Using = "birthday_day")]
		protected IWebElement BirthdayDay { get; set; }

		[FindsBy(How = How.Name, Using = "birthday_month")]
		protected IWebElement BirthdayMonth { get; set; }

		[FindsBy(How = How.Name, Using = "birthday_year")]
		protected IWebElement BirthdayYear { get; set; }

		[FindsBy(How = How.Name, Using = "sex")]
		protected IWebElement Sex { get; set; }

		[FindsBy(How = How.Name, Using = "websubmit")]
		protected IWebElement Submit { get; set; }
	}
}
