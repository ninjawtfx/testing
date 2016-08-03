using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBotForTwitch
{
    public enum Roles
    {
		[Description("Agr")]
        Agressive = 0,
		[Description("Peace")]
        Peacefull = 1
    }

	public enum Thems
	{
		[Description("О долбаебах")]
		AboutDauns = 0
	}
}
