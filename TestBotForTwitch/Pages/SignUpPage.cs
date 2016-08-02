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
    class SignUpPage : MainPage
    {

        
        public SignUpPage(IWebDriver driver) : base(driver)
        {

        }
        
        public void ClickCaptchaButton()
        {
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//div[@id='passport_iframe_container']//iframe")));
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//div[@class='g-recaptcha']//iframe")));
            _driver.FindElement(By.XPath("//div[@class='recaptcha-checkbox-checkmark']")).Click();

            _driver.SwitchTo().DefaultContent();
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

        public void EmailInputSetText(string text)
        {
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//div[@id='passport_iframe_container']//iframe")));

            Extens.SetText(EmailInput, text);

            _driver.SwitchTo().DefaultContent();
        }

        public void ChooseMonthBirthday()
        {
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//div[@id='passport_iframe_container']//iframe")));

            SelectElement select = new SelectElement(MonthSelect);

            int rnd = new Random().Next(1, 12);

            select.SelectByValue(rnd.ToString());

            _driver.SwitchTo().DefaultContent();
        }

        public void ChooseDayBirthday()
        {
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//div[@id='passport_iframe_container']//iframe")));

            SelectElement select = new SelectElement(DaySelect);

            int rnd = new Random().Next(1, 25);

            select.SelectByValue(rnd.ToString());

            _driver.SwitchTo().DefaultContent();
        }

        public void ChooseYearBirthday()
        {
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("//div[@id='passport_iframe_container']//iframe")));

            SelectElement select = new SelectElement(YearSelect);

            int rnd = new Random().Next(1950, 1995);

            select.SelectByValue(rnd.ToString());

            _driver.SwitchTo().DefaultContent();
        }



        [FindsBy(How = How.XPath, Using = "//div[@class='recaptcha-checkbox-checkmark']")]

        private IWebElement CaptchaButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='passport_iframe_container']//iframe")]

        private IWebElement box { get; set; }

        [FindsBy(How = How.Id, Using = "username")]

        private IWebElement UserNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
		private IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement EmailInput { get; set; }

        [FindsBy(How = How.Name, Using = "birthday.month")]
        private IWebElement MonthSelect { get; set; }

        [FindsBy(How = How.Name, Using = "birthday.day")]
        private IWebElement DaySelect { get; set; }

        [FindsBy(How = How.Name, Using = "birthday.year")]
        private IWebElement YearSelect { get; set; }
    }
}
