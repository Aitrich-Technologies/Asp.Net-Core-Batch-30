using collectionException.Exceptions;
using collectionException.Model;
using collectionException.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace collectionException.Repository
{
    internal class MainMenu
    {
        Userservice userService = new();
        JobService jobService = new();

        public void Show()
        {
           
            if (JobService.Jobs.Count == 0)
            {
                jobService.AddJob("Developer", ".NET Developer", "TCS", "Chennai", "5 LPA", "Full-time");
                jobService.AddJob("Tester", "Automation Tester", "Infosys", "Bengaluru", "4 LPA", "Full-time");
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("\n--- MAIN MENU ---");
                    Console.WriteLine("1. Login");
                    Console.WriteLine("2. Register");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter choice: ");
                    int ch = int.Parse(Console.ReadLine());

                    switch (ch)
                    {
                        case 1: LoginScreen(); 
                                break;
                        case 2: RegisterScreen();
                                break;
                        case 3: Console.WriteLine("Exiting...");
                                return;
                        default: 
                            throw new InvalidChoiceException("Choose 1-3.");
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
            Console.Write("\nEmail: ");
            string email = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email cannot be empty!");


            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new Exception("Invalid email format!");
            Console.Write("Password: ");
            string pw = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(pw))
                throw new Exception("Password cannot be empty!");



            var user = userService.Login(email, pw);
            Console.WriteLine($"\nWelcome {user.FirstName} ({user.UserType})");

            if (user.UserType == "provider")
                new ProviderMenu().ShowMenu(user);
            else
                new UserMenu().ShowMenu(user);
        }

        void RegisterScreen()
        {
            Console.Write("\nFirst name: ");
            string fn = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(fn))
                throw new Exception("First name cannot be empty!");

            Console.Write("Last name: ");
            string ln = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(ln))
                throw new Exception("Last name cannot be empty!");

            Console.Write("Email: ");
            string email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email cannot be empty!");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new Exception("Invalid email format!");

            Console.Write("Phone: ");
            string ph = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(ph))
                throw new Exception("Phone number cannot be empty!");

            if (!Regex.IsMatch(ph, @"^[0-9]{10}$"))
                throw new Exception("Phone number must be 10 digits!");

            Console.Write("Password: ");
            string pw = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(pw))
                throw new Exception("Password cannot be empty!");

            if (pw.Length < 8)
                throw new Exception("Password must be at least 8 characters!");
            Console.WriteLine("Choose: 1. Seeker  2. Provider");
            Console.Write("Enter 1 or 2: ");
            string t = Console.ReadLine();
            //string userType = t == "2" ? "provider" : "seeker";
            string userType;

            if (t == "2")
            {
                userType = "provider";
            }
            else
            {
                userType = "seeker";
            }

            userService.Register(fn, ln, email, ph, pw, userType);
            Console.WriteLine("Registration successful!");
        }
    }
}
