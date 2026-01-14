using Exercise.Exceptions;
using Exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Services
{
    public class UserService
    {

        private Dictionary<string, User> users = new Dictionary<string, User>();

        public bool Register(string username, string password)
        {
            if (users.ContainsKey(username))
                return false;

            users.Add(username, new User(username, password));
            return true;
        }

        public bool Login(string username, string password)
        {
            return users.ContainsKey(username) && users[username].Password == password;
        }
    }
}
