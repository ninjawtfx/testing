using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.Extensions;

using TestBotForTwitch.Pages;
using TestBotForTwitch.Class;

namespace TestBotForTwitch
{
	public class AccountsFabric
	{
		private Driver _driver;
		private RegistrationModel _modelForRegistration;
		public FakeAccount FakeAccount;

		public AccountsFabric(Driver driver, RegistrationModel model)
		{
			_driver = driver;
			_modelForRegistration = model;
		}

		public AccountsFabric(Driver driver)
		{
			_driver = driver;
		}

		public void RegisterAccount()
		{
			var regAcc = new RegisterAccount(_driver, _modelForRegistration);

			regAcc.RegisterOnMail();

			regAcc.RegisterOnFacebook();

			regAcc.RegisterOnTwitch();
			
			
		}

		public void GetAccountsFromFile()
		{

		}
	}
}
