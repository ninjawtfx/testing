using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBotForTwitch
{
	public static class Settings
	{
		public static string StreamerUrl = "https://www.twitch.tv/cn_lion";

		public static List<string> Proxies = Files.GetProxyies();
	}
}
