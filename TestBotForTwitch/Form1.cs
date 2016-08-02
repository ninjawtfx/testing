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
		public string StreamerUrl = "https://2ip.ru";

		public List<Proxy> proxies = new List<Proxy>();


        public Form1()
        {
            InitializeComponent();


			//proxies.Add(new Proxy { HttpProxy = "198.2.202.43:8090" });
			//proxies.Add(new Proxy { HttpProxy = "104.220.35.53:14843" });
			proxies.Add(new Proxy { HttpProxy = "socks5://103.208.78.21:48111" });
			proxies.Add(new Proxy { HttpProxy = "socks4://1.175.139.171:3129" });
			
			proxies.Add(new Proxy { HttpProxy = "1.175.139.171:3129" });

			proxies.Add(new Proxy { HttpProxy = "212.158.161.241:80" });
			


        }

        private void GO()
        {
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
			List<string> logins = Files.GetAccountNamesFromFile();
			List<StartBoting> listBots = new List<StartBoting>();

			string password = "q123456789q";

			int i = 0;

			foreach(var item in logins)
			{

				//var proxy = proxies[i];
				//var profileManager = new FirefoxProfileManager();
				//FirefoxProfile ffProfile = new FirefoxProfile();
				//ffProfile.SetProxyPreferences(proxy);

				ChromeOptions options = new ChromeOptions();

				options.AddArguments(string.Format("--proxy-server={0}",proxies[i].HttpProxy));

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
