using System.Windows.Forms;
using MongoDB.Driver;

namespace TestBotForTwitch.Forms
{
	public partial class ProxyDialog : Form
	{
		public ProxyDialog()
		{
			InitializeComponent();


			refreshListFromFile();

		}

		private void refreshListFromFile()
		{
			foreach (var prox in Settings.Proxies)
			{
				listBox1.Items.Add(prox);
			}
		}

		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Extens.CheckProxy(listBox1.SelectedItem.ToString());
		}

		
	}
}
