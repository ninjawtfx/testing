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
			Password = pass;
			Role = role;
		}
	}
}
