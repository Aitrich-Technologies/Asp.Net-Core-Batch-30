using Exercise.Exceptions;
using Exercise.Model;
using Exercise.Services;
using System.Diagnostics.Metrics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        UserService userService = new UserService();
        JobService jobService = new JobService();
        SavedJobService savedService = new SavedJobService();

        string loggedUser = null;

        while (true)
        {
            Console.WriteLine("\n===== MAIN MENU =====");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter username: ");
                string u = Console.ReadLine();

                Console.Write("Enter password: ");
                string p = Console.ReadLine();

                if (userService.Register(u, p))
                    Console.WriteLine("Registration successful!");
                else
                    Console.WriteLine("User already exists!");
            }
            else if (choice == "2")
            {
                Console.Write("Enter username: ");
                string u = Console.ReadLine();

                Console.Write("Enter password: ");
                string p = Console.ReadLine();

                if (userService.Login(u, p))
                {
                    loggedUser = u;
                    Console.WriteLine("Login successful!");
                    JobMenu(loggedUser, jobService, savedService);
                }
                else
                    Console.WriteLine("Invalid login!");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Exiting...");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }

    static void JobMenu(string username, JobService jobService, SavedJobService savedService)
    {
        while (true)
        {
            Console.WriteLine("\n===== JOB MENU =====");
            Console.WriteLine("1. View Jobs");
            Console.WriteLine("2. Save Job");
            Console.WriteLine("3. View Saved Jobs");
            Console.WriteLine("4. Logout");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                jobService.ShowJobs();
            }
            else if (choice == "2")
            {
                Console.Write("Enter Job ID: ");
                int id = int.Parse(Console.ReadLine());

                try
                {
                    Job job = jobService.FindJob(id);
                    savedService.SaveJob(username, job);
                }
                catch (JobNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (choice == "3")
            {
                savedService.ShowSavedJobs(username);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Logged out.");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }

}
