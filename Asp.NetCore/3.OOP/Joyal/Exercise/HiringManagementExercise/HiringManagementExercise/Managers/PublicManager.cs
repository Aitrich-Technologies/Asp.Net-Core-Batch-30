using HiringManagementExercise.Enums;
using HiringManagementExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagementExercise.Managers
{
    public class PublicManager
    {
        private User[] Users = new User[10];
        private int UserCount = 0;
        private readonly JobManager JobManager;

        public PublicManager(JobManager jobManager)
        {
            JobManager = jobManager;
        }

        public bool Login(string email, string password)
        {
            for (int i = 0; i < UserCount; i++)
            {
                if (Users[i] != null &&
                    Users[i].Email == email &&
                    Users[i].Password == password)
                {
                    return true;
                }
            }
            return false;

        }

        public void Register(User user)
        {
            if (UserCount >= Users.Length)
            {
                Console.WriteLine("Registration limit reached");
                return;
            }

            user.Id = UserCount + 1;
            Users[UserCount] = user;
            UserCount++;

            Console.WriteLine("Registration successful!");
        }

        public void DisplayMenu(object? pm = null)
        {
            while (true)
            {
                Console.WriteLine("\n===== PUBLIC MENU =====");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine() ?? "";
                        Console.Write("Enter Password: ");
                        string password = Console.ReadLine() ?? "";

                        if (Login(email, password))
                        {
                            var user = Array.Find(Users, u => u != null && u.Email == email)!;

                            if (user.Role == Roles.Admin)
                            {
                                new AdminManager(Users, UserCount, JobManager).DisplayMenu(this);
                            }
                            else
                            {
                                new UserManager(JobManager).DisplayMenu(this);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid credentials!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n=== Register User ===");

                        Console.Write("First Name: ");
                        string first = Console.ReadLine() ?? "";
                        Console.Write("Last Name: ");
                        string last = Console.ReadLine() ?? "";
                        Console.Write("Email: ");
                        string mail = Console.ReadLine() ?? "";
                        Console.Write("Phone: ");
                        string phone = Console.ReadLine() ?? "";
                        Console.Write("Password: ");
                        string pass = Console.ReadLine() ?? "";

                        Console.WriteLine("Select Role: 1.Admin 2.JobSeeker");
                        Roles role = Console.ReadLine() == "1" ? Roles.Admin : Roles.JobSeeker;

                        Register(new User
                        {
                            FirstName = first,
                            LastName = last,
                            Email = mail,
                            Password = pass,
                            Phone = phone,
                            Role = role
                        });

                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
