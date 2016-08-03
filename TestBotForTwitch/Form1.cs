using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TestBotForTwitch.Forms;
using TestBotForTwitch.Class;

namespace TestBotForTwitch
{
	public partial class Form1 : Form
	{
		public List<string> Logins = Files.GetAccountNamesFromFile();
		
		private Int32 _countViewers;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < _countViewers; i++)
			{
				var driver = new Driver();

				var start = new Bot(driver, Logins[i], Settings.Password, Roles.Agressive);

				start.GetStart(Settings.StreamerUrl);

				Settings.ListBots.Add(start);
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

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			Settings.StreamerUrl = textBox2.Text;
		}
	}
}
