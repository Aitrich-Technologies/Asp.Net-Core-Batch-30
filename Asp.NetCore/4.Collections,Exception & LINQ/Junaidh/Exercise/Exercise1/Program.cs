using Exercise1;
using Exercise1.Manager;
using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            UserManager userManager = new UserManager();
            JobManager jobManager = new JobManager();

            bool running = true;

            while (running)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");

                Console.Write(" ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Please enter your email address: ");
                        string email = Console.ReadLine();

                        Console.Write("Please enter your password: ");
                        string password = Console.ReadLine();

                        if (email == admin.Email && password == admin.Password)
                        {
                            Console.WriteLine("Login successful!");
                            Console.WriteLine("Welcome admin\n");

                            bool adminMenu = true;
                            while (adminMenu)
                            {
                                Console.WriteLine("1. New Registrations");
                                Console.WriteLine("2. List all Jobs");
                                Console.WriteLine("3. Logout");

                                string adminChoice = Console.ReadLine();

                                if (adminChoice == "1")
                                {
                                    foreach (var u in userManager.Users)
                                    {
                                        Console.WriteLine($"{u.FirstName} {u.LastName} - {u.Email}");
                                    }
                                }
                                else if (adminChoice == "2")
                                    jobManager.ListJobs();
                                else if (adminChoice == "3")
                                {
                                    Console.WriteLine("Logged out successfully!");
                                    adminMenu = false;
                                }
                            }
                        }
                        else
                        {
                            try
                            {
                                User loggedUser = userManager.Login(email, password);
                                Console.WriteLine("Login successful!");

                                bool userMenu = true;
                                while (userMenu)
                                {
                                    Console.WriteLine("1. List all jobs");
                                    Console.WriteLine("2. My Profile");
                                    Console.WriteLine("3. Logout");

                                    string userChoice = Console.ReadLine();

                                    if (userChoice == "1")
                                        jobManager.ListJobs();
                                    else if (userChoice == "2")
                                    {
                                        Console.WriteLine("\n-------------------MY PROFILE---------------------");
                                        Console.WriteLine($"First Name: {loggedUser.FirstName}");
                                        Console.WriteLine($"Last Name: {loggedUser.LastName}");
                                        Console.WriteLine($"Email: {loggedUser.Email}");
                                        Console.WriteLine($"Phone: {loggedUser.Phone}\n");
                                    }
                                    else if (userChoice == "3")
                                    {
                                        Console.WriteLine("Logged out successfully!");
                                        userMenu = false;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;

                    case "2":
                        userManager.Register();
                        break;

                    case "3":
                        running = false;
                        break;

                    default:
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}