using ExcepCollecExercise4.html.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepCollecExercise4.html.Repository
{
    public class UserRepository
    {
        public List<User> Users = new List<User>();

        public void AddUser(User u)
        {
            Users.Add(u);
        }

        public User Login(string email, string pass)
        {
            return Users.Find(u => u.Email == email && u.Password == pass);
        }
        public bool DoesEmailExist(string email)
        {
            return Users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

    }
}
