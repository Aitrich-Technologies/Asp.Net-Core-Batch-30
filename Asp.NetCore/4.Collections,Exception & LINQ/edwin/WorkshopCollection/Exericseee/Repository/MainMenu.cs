using Exericseee.Exception;
using Exericseee.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericseee.Repository
{
    internal class MainMenu
    {
        Userservice userService = new();
        JobService jobService = new();
        ApplicationService appService = new();

        public void Show()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\n1. Login\n2. Register\n3. Exit");
                    Console.Write("Enter choice: ");
                    int ch = int.Parse(Console.ReadLine());

                    switch (ch)
                    {
                        case 1: LoginScreen(); break;
                        case 2: RegisterScreen(); break;
                        case 3: return;
                        default: throw new InvalidChoiceException("Invalid option!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[ERROR] " + ex.Message);
                }
            }
        }

        void LoginScreen()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string pass = Console.ReadLine();

            var user = userService.Login(email, pass);

            new UserMenu().ShowMenu(user);
        }

        void RegisterScreen()
        {
            Console.Write("First name: ");
            string fn = Console.ReadLine();

            Console.Write("Last name: ");
            string ln = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Phone: ");
            string ph = Console.ReadLine();

            Console.Write("Password: ");
            string pw = Console.ReadLine();

            userService.Register(fn, ln, email, ph, pw);

            Console.WriteLine("Registration successful!");
        }
    }
}
