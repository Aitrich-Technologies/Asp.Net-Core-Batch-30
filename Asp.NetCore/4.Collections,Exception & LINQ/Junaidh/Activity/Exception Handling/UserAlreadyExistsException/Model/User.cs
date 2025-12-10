using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAlreadyExistsException.Model
{
     public class User
    {
        public string name {  get; set; }
        public  string email { get; set; }
        public int age { get; set; }
        public string Password { get; set; }
    }
}
