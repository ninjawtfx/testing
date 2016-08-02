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

namespace TestBotForTwitch.Pages
{
    public class SignUpMailPage : MailPage
    {
        public SignUpMailPage(IWebDriver driver):base(driver)
        {

        }

        public void UserNameInputSetText(string text)
        {
            Extens.SetText(UserNameInput, text);
        }

        public void LastNameInputSetText(string text)
        {
            Extens.SetText(LastNameInput, text);
        }

        public void SexInputClick()
        {
            SexInput.Click();
        }

        public string ChooseMailLogin()
        {
            MailLoginInput.Click();
            Thread.Sleep(500);

			var ss = ChooseMail.Text;

            ChooseMail.Click();



			return ss;
        }

        public void ChooseDay()
        {
            SelectElement select = new SelectElement(DaySelect);

            string rnd = new Random().Next(1, 25).ToString();

            select.SelectByValue(rnd);
        }

        public void ChooseMonth()
        {
            SelectElement select = new SelectElement(MonthSelect);

            string rnd = new Random().Next(1, 12).ToString();

            select.SelectByValue(rnd);
        }

        public void ChooseYear()
        {
            SelectElement select = new SelectElement(YearSelect);

            string rnd = new Random().Next(1950, 1995).ToString();

            select.SelectByValue(rnd);
        }

        public void PasswordSetText(string text)
        {
            Extens.SetText(PassInput, text);
        }

        public void DoublePasswordSetText(string text)
        {
            Extens.SetText(DoublePassInput, text);
        }

        public void RegisterClick()
        {
            RegisterButton.Click();
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'qc-firstname-row')]//input")]
        private IWebElement UserNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'qc-lastname-row')]//input")]
        private IWebElement LastNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'qc-sex-row')]//input)[1]")]
        private IWebElement SexInput { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'qc-birthday-row')]//select)[1]")]
        private IWebElement DaySelect { get; set; }
        
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'qc-birthday-row')]//select)[2]")]
        private IWebElement MonthSelect { get; set; }
       
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'qc-birthday-row')]//select)[3]")]
        private IWebElement YearSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'qc-login-row')]//input")]
        private IWebElement MailLoginInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'qc-pass-row')]//input")]
        private IWebElement PassInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'qc-passverify-row')]//input")]
        private IWebElement DoublePassInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@value='Зарегистрироваться']")]
        private IWebElement RegisterButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "((//div[@class='geo_popup ac-layer'])[2]//a)[1]")]
        private IWebElement ChooseMail { get; set; }

    }
}
