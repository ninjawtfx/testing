using OpenQA.Selenium;

using System.Threading;
using TestBotForTwitch.Pages;
using TestBotForTwitch.Class;

namespace TestBotForTwitch
{
    public class RegisterAccount
    {
        public RegistrationModel Account { get; set; }
        private IWebDriver _driver { get; set; }

        public RegisterAccount(IWebDriver driver, RegistrationModel account)
        {
            _driver = driver;
            Account = account;
        }

        public void RegisterOnMail()
        {
            MailPage page = new MailPage(_driver);

            page.GetPage();

            page.ClickSignUpButton();

            SignUpMailPage _page = new SignUpMailPage(_driver);

            Thread.Sleep(5000);

            _page.UserNameInputSetText(Account.Name);
			Thread.Sleep(500);
            _page.LastNameInputSetText(Account.LastName);
            _page.ChooseDay();
            _page.ChooseMonth();
            _page.ChooseYear();
            _page.SexInputClick();
			Thread.Sleep(300);
            _page.PasswordSetText(Account.Password);
            _page.DoublePasswordSetText(Account.Password);
            Account.Email = _page.ChooseMailLogin();
            _page.RegisterClick();

            
        }

		public void RegisterOnFacebook()
		{
			FacebookPage page = new FacebookPage(_driver);

			page.GetPage();

			page.FirstNameSetText(Account.Name);
			page.LastNameSetText(Account.LastName);
			Thread.Sleep(300);
			page.MailSetText(Account.Email);
			Thread.Sleep(400);
			page.MailConfirmationSetText(Account.Email);
			page.PasswordSetText(Account.Password);
			page.ChooseBirthdayDay();
			Thread.Sleep(500);
			page.ChooseBirthdayMonth();
			page.ChooseBirthdayYear();
			page.SexClick();
			page.SubmitClick();
		}

        public void RegisterOnTwitch()
        {
            MainPage page = new MainPage(_driver);

            page.GetPage();

            page.ClickSugnUpButton();

            Thread.Sleep(5000);

            SignUpPage signupPage = new SignUpPage(_driver);

            signupPage.UserNameInputSetText(Account.NickName);
            signupPage.PasswordInputSetText(Account.Password);
            signupPage.ChooseMonthBirthday();
            signupPage.ChooseDayBirthday();
            signupPage.ChooseYearBirthday();
            signupPage.EmailInputSetText(Account.Email);
            signupPage.ClickCaptchaButton();

        }

		public void RegisterUserInTwitch()
		{

			var ss = Files.GetLastName();
			var aqw = Files.GetName();

			RegistrationModel model = new RegistrationModel();
			model.Name = aqw;
			model.LastName = ss;


			AccountsFabric fabric = new AccountsFabric(_driver, model);

			fabric.RegisterAccount();
		}
    }
}
