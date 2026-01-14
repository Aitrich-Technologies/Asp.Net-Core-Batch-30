using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool Login(string username, string password)
        {
            Console.WriteLine("Login Success!");
            return true;
        }
        abstract public void Welcome();
    }
}
