using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestBotForTwitch.Class
{
	public class Dialogs
	{
		private Dictionary<Bot, Bot> _relations = new Dictionary<Bot, Bot>();

		public Dialogs()
		{

		}

		public void StartSmallTalk(Thems them)
		{
			var talk = new Talk(them);

			var rnd1 = new Random().Next(0, Settings.ListBots.Count);
			var rnd2 = new Random().Next(0, Settings.ListBots.Count);

			while (rnd1 == rnd2)
			{
				rnd2 = new Random().Next(0, Settings.ListBots.Count);
			}

			
			for(int i = 0; i <= talk.FirstReplics.Count; i++)
			{
				Settings.ListBots[rnd1].Say(talk.FirstReplics[i]);
				
				Thread.Sleep(new Random().Next(900, 2000));
				
				if(talk.SecondsReplics.Count < i)
					Settings.ListBots[rnd2].Say(talk.SecondsReplics[i]);

				Thread.Sleep(new Random().Next(900, 2000));
			}
		}
	}
}
