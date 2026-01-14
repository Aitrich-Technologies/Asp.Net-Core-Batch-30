using Exericseee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericseee.Services
{
    static class AuthService
    {

        public static List<User> Users = new List<User>();

        public static User Login()
        {
            Console.Write("\nEmail: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string pass = Console.ReadLine();

            return Users.Find(u => u.Email == email && u.Password == pass);
        }

        public static void Register()
        {
            Console.Write("\nFirst Name: ");
            string fname = Console.ReadLine();

            Console.Write("Last Name: ");
            string lname = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Password: ");
            string pass = Console.ReadLine();

            Console.WriteLine("1. Job Seeker\n2. Job Provider");
            string type = Console.ReadLine();

            Users.Add(new User
            {
                FirstName = fname,
                LastName = lname,
                Email = email,
                Phone = phone,
                Password = pass,
                UserType = type == "2" ? "provider" : "seeker"
            });

            Console.WriteLine("\nRegistration Successful!\n");
        }
    }
}
