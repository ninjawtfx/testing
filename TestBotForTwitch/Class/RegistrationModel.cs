using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBotForTwitch.Class
{
    public class RegistrationModel
    {
        public string NickName
        {
            get
            {
                var rnd = new Random().Next(1, 1000000);
                return string.Format("{0}{1}{2}", Name, LastName, rnd);
            }
        }

        public string Name { get; set; }

        public string LastName { get; set; }

		public string Password { get { return "q123456789q"; } }

        public string Email { get; set; }

        public Roles Role { get; set; }

    }
}
