﻿
using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestBotForTwitch.Class
{
	public class Driver : IWebDriver
	{
		public static readonly TimeSpan ImplicitWait = new TimeSpan(0, 0, 0, 3);
		public static readonly TimeSpan NoWait = new TimeSpan(0, 0, 0, 0);

		private IWebDriver _driver;
		public Driver(string proxy)
		{
			var options = new ChromeOptions();

			options.AddArguments(string.Format("--proxy-server={0}", proxy));

			_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMinutes(2));

			_driver = new ChromeDriver(options);
		}

		public Driver()
		{
			_driver = new ChromeDriver();
		}

		public IWebDriver GetDriver()
		{
			return _driver;
		}

		public bool WaitUntilElementIsEnabled(By by, int timeout = 10)
		{
			var wait = new WebDriverWait(this, TimeSpan.FromMinutes(timeout));

			try
			{
				return wait.Until(d => ((Driver)d).FindElement(by).Enabled);
			}
			catch (WebDriverTimeoutException)
			{
				return false;
			}
		}
		
		#region Реализация интерфейса IWebDriver

		public string CurrentWindowHandle
		{
			get { return _driver.CurrentWindowHandle; }
		}

		public string PageSource
		{
			get { return _driver.PageSource; }
		}

		public string Title
		{
			get { return _driver.Title; }
		}

		public string Url
		{
			get { return _driver.Url; }
			set { _driver.Url = value; }
		}

		public ReadOnlyCollection<string> WindowHandles
		{
			get { return _driver.WindowHandles; }
		}

		public IWebElement FindElement(By by)
		{
			return _driver.FindElement(by);
		}

		public ReadOnlyCollection<IWebElement> FindElements(By by)
		{
			return _driver.FindElements(by);
		}

		public void Close()
		{
			_driver.Close();
		}

		public IOptions Manage()
		{
			return _driver.Manage();
		}

		public INavigation SimpleNavigate()
		{
			return _driver.Navigate();
		}

		public INavigation Navigate()
		{
			return _driver.Navigate();
		}

		public void Quit()
		{
			_driver.Quit();
		}

		public ITargetLocator SwitchTo()
		{
			return _driver.SwitchTo();
		}

		#endregion

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Ждем, когда элемент станет кликабельным
		/// </summary>
		/// <param name="by">локатор</param>
		/// <param name="timeout">время ожидания</param>
		public IWebElement WaitUntilElementIsClickable(By by, int timeout = 10)
		{
			var wait = new WebDriverWait(this, TimeSpan.FromSeconds(timeout));

			try
			{
				return wait.Until(ExpectedConditions.ElementToBeClickable(by));
			}
			catch (WebDriverTimeoutException)
			{
				return null;
			}
		}

		/// <summary>
		/// Ждем, пропадет ли элемент
		/// </summary>
		/// <param name="by">локатор</param>
		/// <param name="timeout">время ожидания</param>
		public bool WaitUntilElementIsDisappeared(By by, int timeout = 10)
		{
			_driver.Manage().Timeouts().ImplicitlyWait(NoWait);
			var wait = new WebDriverWait(this, TimeSpan.FromSeconds(timeout));

			try
			{
				var result = wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
				_driver.Manage().Timeouts().ImplicitlyWait(ImplicitWait);
				return result;
			}
			catch (WebDriverTimeoutException)
			{
				_driver.Manage().Timeouts().ImplicitlyWait(ImplicitWait);
				return false;
			}
		}

		/// <summary>
		/// Ждем, отобразится ли элемент
		/// </summary>
		/// <param name="by">локатор</param>
		/// <param name="timeout">время ожидания</param>
		public bool WaitUntilElementIsDisplay(By by, int timeout = 10)
		{
			var wait = new WebDriverWait(this, TimeSpan.FromMinutes(timeout));

			try
			{
				return wait.Until(d => ((Driver)d).FindElement(by).Displayed);
			}
			catch (NotFoundException)
			{
				return false;
			}
		}
	}
}
