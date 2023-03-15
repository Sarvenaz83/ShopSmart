using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSmart
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }
        public static List<User> users =  new List<User>();
        public User(string firstName, string lastName, string userName, string password, string email, string city, int postCode)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Email = email;
            City = city;
            PostCode = postCode;
        }
    }
}
