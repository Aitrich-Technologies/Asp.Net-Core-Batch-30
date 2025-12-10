using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Admin
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Admin()
        {
            Email = "admin@gmail.com";
            Password = "123";
        }
    }
}