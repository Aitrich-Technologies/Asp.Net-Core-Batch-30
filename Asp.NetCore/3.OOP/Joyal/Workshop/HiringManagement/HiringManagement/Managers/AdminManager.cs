using HiringManagement.Enums;
using HiringManagement.Interface;
using HiringManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagement.Managers
{
    public class AdminManager:IMenu
    {
        private readonly User[] Users;
        private readonly int UserCount;
        private readonly JobManager JobManager;

        public AdminManager(User[] users, int userCount,JobManager jobManager)
        {
            Users = users;
            UserCount = userCount;
            JobManager = jobManager;
        }

        public void DisplayMenu(object? publicManager = null)
        {
            var printer = new Utils.Printer();
            while (true)
            {
                Console.WriteLine("### Admin Menu ###");
                Console.WriteLine("1. View Registerations");
                Console.WriteLine("2. Add Job");
                Console.WriteLine("3. List Jobs");
                Console.WriteLine("4. Logout");

                string? choice=Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        printer.Print(Users);
                        break;
                    case "2":
                        AddJob();
                        break;
                    case "3":
                        printer.Print(JobManager.GetJobs());
                        break;
                    case "4":
                        return;
                }
            }
        }

        public void AddJob()
        {
            Console.WriteLine("@@@ Add job @@@");
            Console.Write("Title: ");
            string title=Console.ReadLine()??"";
            Console.Write("Campany: ");
            string company = Console.ReadLine() ?? "";
            Console.Write("Location: ");
            string location = Console.ReadLine() ?? "";
            Console.Write("Salary Range: ");
            string salary = Console.ReadLine() ?? "";
            Console.Write("Job Type: ");
            string jobtype = Console.ReadLine() ?? "";

            Console.WriteLine("Select Experince Level: 1.Fresher 2.MidLevel 3.Senoir");
            string choice = Console.ReadLine();
            ExperinceLevels exp;

            switch(choice)
            {
                case "2":
                    exp = ExperinceLevels.MidLevel;
                    break;
                case "3":
                    exp= ExperinceLevels.Senior;
                    break;
                default:
                    exp=ExperinceLevels.Fresher;
                    break;
            }

            Job job = new()
            {
                Title = title,
                Company = company,
                Location = location,
                SalaryRange= salary,
                JobType = jobtype,
                ExperinceLevel = exp
            };

            JobManager.AddJob(job);
            Console.WriteLine("Job added successfully!");
        }
    }
}
