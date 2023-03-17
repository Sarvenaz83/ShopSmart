using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSmart
{
    internal class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public static List<Login> userinfo = new List<Login>();
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
