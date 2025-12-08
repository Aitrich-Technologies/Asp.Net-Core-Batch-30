using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopAdmin_Job.Enums;

namespace WorkShopAdmin_Job.Models
{
    public class User
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long  Phone { get; set; }
      
        public Roles Role { get; set; }

        public string Password {  get; set; }
        public User () { }

        public User(int id,string firstname,string  lastname,string email,long  phone,Roles roles,string password)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            Role = roles;
            Password = password;

        }

        public User(int v1, string v2, string v3, string v4, int v5, string v6, Roles admin)
        {
        }
    }
}
