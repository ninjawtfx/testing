using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

using TestBotForTwitch.Class;


namespace TestBotForTwitch.Pages
{
    public class MainPage
    {
        protected Driver _driver;

        public MainPage(Driver driver)
        {
            _driver = driver;

			_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
			_driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));

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
            _driver.Navigate().GoToUrl(Settings.StreamerUrl);

            _driver.Manage().Window.Maximize();
        }

	    public void MessageSetText(string text)
	    {
		    if(_driver.WaitUntilElementIsEnabled(By.XPath("//div[@class='textarea-contain']//textarea")))
				Extens.SetText(MessageArea, text);
	    }

	    public void MessageSendClick()
	    {
		    var button =
			    _driver.WaitUntilElementIsClickable(By.XPath("//div[@class='chat-buttons-container clearfix']//button"));
			button.Click();
	    }

	    public void SendMessageInChat(string text)
	    {
		    if (LoadPage())
		    {
			    MessageSetText(text);
			    MessageSendClick();
		    }
	    }

	    public bool LoadPage()
	    {
			return(_driver.WaitUntilElementIsDisappeared(By.XPath("//div[@class='twitch_subwindow_container']"))
			&& _driver.WaitUntilElementIsDisplay(By.XPath("//div[@class='chat-interface']")));
	    }

	    [FindsBy(How = How.XPath, Using = "//*[@id='right_col']/div/div[2]/div/div[2]/a[2]")]
		private IWebElement SugnUpButton { get; set; }

		[FindsBy(How = How.XPath, Using = "(//a[@class='button' and @href='/login'])[1]")]
		private IWebElement SignUpButton { get; set; }

		[FindsBy(How = How.XPath, Using = "//div[@class='textarea-contain']//textarea")]
		private IWebElement MessageArea { get; set; }

		[FindsBy(How = How.XPath, Using = "//div[@class='chat-buttons-container clearfix']//button")]
		private IWebElement MessageSendButton { get; set; }
        
        
    }
}
