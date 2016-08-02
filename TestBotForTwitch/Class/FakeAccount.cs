using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBotForTwitch.Class
{
	public class FakeAccount
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public Roles Role { get; set; }

		public FakeAccount(string name, string pass, Roles role)
		{
			Name = name;
			pass = Password;
			Role = role;
		}
	}
}
