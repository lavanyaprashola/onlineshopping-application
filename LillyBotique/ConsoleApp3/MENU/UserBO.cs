using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class UserBO
    {
        private string Username, Password, Email;


        public UserBO()
        {
        }
        public UserBO(string userName, string userMail, string password)
        {
            Username1 = userName;
            Email1 = userMail;
            Password1 = password;

        }

        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Email1 { get => Email; set => Email = value; }


        public override string ToString()
        {
            return string.Format(this.Username1 + " " + this.Email1 + " " + this.Password1);
        }
    }

}
