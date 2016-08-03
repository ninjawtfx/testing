using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestBotForTwitch
{
	public static class Files
	{

		private static string _names = "Files/Names.txt";
		private static string _lastNames = "Files/LastNames.txt";
		private static string _accounts = "Files/Accounts.txt";
		private static string _proxies = "Files/Proxyies.txt";
		private static string _helloReplic = "Files/Replics/{0}Hello.txt";

		static public void SettingsNames()
		{
			List<string> linesForCopy = new List<string>();
			using (StreamReader sr = new StreamReader(_names, System.Text.Encoding.Default))
			{
				List<string> lines = new List<string>();
				
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					lines.Add(line);
				}

				foreach(var item in lines)
				{
					linesForCopy.Add(item + ";");					
				}
			}

			using (StreamWriter sw = new StreamWriter(_lastNames, true, System.Text.Encoding.Default))
			{
				foreach(var item in linesForCopy)
				sw.Write(item);
			}

		}

		static public string GetName()
		{
			string result;
			using (StreamReader sr = new StreamReader(_names, System.Text.Encoding.Default))
			{
				List<string> lines = new List<string>();

				lines = sr.ReadToEnd().Split(';').ToList();

				int rnd = new Random().Next(0, lines.Count);

				result = lines[rnd];
			}

			return result;
		}

		static public string GetHelloReplic(Roles role)
		{
			string result;
			using (var sr = new StreamReader(string.Format(_helloReplic, role.Description()), System.Text.Encoding.Default))
			{
				List<string> lines = new List<string>();

				lines = sr.ReadToEnd().Split(';').ToList();

				int rnd = new Random().Next(0, lines.Count);

				result = lines[rnd];
			}

			return result;
		}

		static public string GetLastName()
		{
			string result;
			using (StreamReader sr = new StreamReader(_lastNames, System.Text.Encoding.Default))
			{
				List<string> lines = new List<string>();

				lines = sr.ReadToEnd().Split(';').ToList();

				int rnd = new Random().Next(0, lines.Count);

				result = lines[rnd+1];
			}

			return result;
		}

		static public List<string> GetAccountNamesFromFile()
		{
			using (StreamReader sr = new StreamReader(_accounts, System.Text.Encoding.Default))
			{
				return sr.ReadToEnd().Split(';').ToList();
			}
		}

		static public List<string> GetProxyies()
		{
			using (StreamReader sr = new StreamReader(_proxies, System.Text.Encoding.Default))
			{
				var list = new List<string>();

				string line;

				while ((line = sr.ReadLine()) != null)
				{
					list.Add(line);
				}

				return list;
			}
		}
	}
}
