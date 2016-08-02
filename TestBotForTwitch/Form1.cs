using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TestBotForTwitch.Class;

using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

using TestBotForTwitch.Pages;

namespace TestBotForTwitch
{
    public partial class Form1 : Form
    {
        public IWebDriver Driver;
		public string StreamerUrl = "https://www.twitch.tv/cn_lion";

		public List<string> proxies = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void GO()
        {
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
			List<string> logins = Files.GetAccountNamesFromFile();
			List<StartBoting> listBots = new List<StartBoting>();

			proxies = Files.GetProxyies();

			string password = "q123456789q";

			int i = 0;

			foreach(var item in logins)
			{

				//var proxy = proxies[i];
				//var profileManager = new FirefoxProfileManager();
				//FirefoxProfile ffProfile = new FirefoxProfile();
				//ffProfile.SetProxyPreferences(proxy);

				ChromeOptions options = new ChromeOptions();

				options.AddArguments(string.Format("--proxy-server={0}",proxies[i]));

				Driver = new ChromeDriver(options);

				//Driver = new FirefoxDriver(ffProfile);

			

			var start = new StartBoting(Driver);

			start.GetStart(Driver, StreamerUrl, item, password);

			listBots.Add(start);

			i++;
			}

			
			

        }

        public void RegisterUserInTwitch()
        {

			var ss = Files.GetLastName();
			var aqw = Files.GetName();

			RegistrationModel model = new RegistrationModel();
			model.Name = aqw;
			model.LastName = ss;


			AccountsFabric fabric = new AccountsFabric(Driver, model);

			fabric.RegisterAccount();
        }
    }
}
