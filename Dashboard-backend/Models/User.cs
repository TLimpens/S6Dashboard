using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }

         public User()
        {

        }

        public User(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
