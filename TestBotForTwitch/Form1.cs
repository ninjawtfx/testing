using System;
using System.Collections.Generic;
using System.Windows.Forms;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

using TestBotForTwitch.Forms;

namespace TestBotForTwitch
{
	public partial class Form1 : Form
	{
		public IWebDriver Driver;
	
		public List<string> Logins = Files.GetAccountNamesFromFile();

		public List<StartBoting> listBots = new List<StartBoting>();

		private string password = "q123456789q";

		private Int32 _countViewers;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int i = 0;

			foreach (var item in Logins)
			{
				ChromeOptions options = new ChromeOptions();

				options.AddArguments(string.Format("--proxy-server={0}", Settings.Proxies[i]));

				Driver = new ChromeDriver(options);

				var start = new StartBoting(Driver);

				start.GetStart(Driver, Settings.StreamerUrl, item, password);

				listBots.Add(start);

				i++;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Int32.TryParse(textBox1.Text, out _countViewers);
		}

		private void proxyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var proxyDialog = new ProxyDialog();

			proxyDialog.ShowDialog();
		}
	}
}
