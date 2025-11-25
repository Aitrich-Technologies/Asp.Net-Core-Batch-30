using Exercise._2.Enums;
using Exercise._2.Modals;
using Exercise._2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise._2.Interfaces;
using Exercise._2.managers;

namespace Exercise._2.managers
{
    public class AdminManager : IMenu
    {
        private readonly User[] users;
        private readonly int userCount;
        private readonly JobManager jobManager;   

        public AdminManager(User[] users,int userCount,JobManager _jobManager)
        {
            this.users = users;
            this.userCount = userCount;
            jobManager = _jobManager;
        }

        public void DisplayMenu(object? publicManager = null)
        {
            var printer = new Printer();

            while (true)
            {
                Console.WriteLine("\n=== Admin Menu ===");
                Console.WriteLine("1. View Registrations");
                Console.WriteLine("2. Add Job");
                Console.WriteLine("3. List Jobs");
                Console.WriteLine("4. Logout");

                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        printer.Print(users);
                        break;

                    case "2":
                        AddJob();
                        break;

                    case "3":
                        var jobs = jobManager.GetJobs();
                        printer.Print(jobs);  
                        break;

                    case "4":
                        return;
                }
            }
        }

        private void AddJob()
        {
            Console.WriteLine("\n=== Add Job ===");
            Console.Write("Title: ");
            string title = Console.ReadLine() ?? "";
            Console.Write("Company: ");
            string company = Console.ReadLine() ?? "";
            Console.Write("Location: ");
            string location = Console.ReadLine() ?? "";
            Console.Write("Salary Range: ");
            string salary = Console.ReadLine() ?? "";
            Console.Write("Job Type: ");
            string jobType = Console.ReadLine() ?? "";

            Console.WriteLine("Select Experience Level: 1. Fresher  2. MidLevel  3. Senior");
            string choice = Console.ReadLine();
            ExperienceLevels exp;

            switch (choice)
            {
                case "2":
                    exp = ExperienceLevels.MidLevel;
                    break;
                case "3":
                    exp = ExperienceLevels.Senior;
                    break;
                default:
                    exp = ExperienceLevels.Fresher;
                    break;
            }

            Job job = new()
            {
                Title = title,
                Company = company,
                Location = location,
                SalaryRange = salary,
                JobType = jobType,
                ExperienceLevel = exp
            };

            jobManager.AddJob(job);  
            Console.WriteLine("Job added successfully!");
        }
    }
}