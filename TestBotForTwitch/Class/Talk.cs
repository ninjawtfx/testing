using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBotForTwitch.Class
{
	public class Talk
	{
		public List<string> FirstReplics = new List<string>();
		public List<string> SecondsReplics = new List<string>();


		public Talk(Thems them)
		{
			if (them == Thems.AboutDauns)
				GetTalkAboutDauns();
		}

		public void GetTalkAboutDauns()
		{
			FirstReplics.Add("Прикинь, иду сейчас в метро и какой-то даун мне ноги отдавил мразь");
			SecondsReplics.Add("да я рот шатал этих даунов в метро");
			FirstReplics.Add("А если еще потные ублюдки рядом с тобой трутся это вообще жесть");
			SecondsReplics.Add("да алн в жаре тоже плюс есть телочки в юбках :DD");
			FirstReplics.Add("Жи есть брат");
		}
	}
}
