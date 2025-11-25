using HiringManagementExercise.Interfaces;
using HiringManagementExercise.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagementExercise.Managers
{
    public class UserManager : IMenu
    {
        private readonly JobManager jobManager;

        public UserManager(JobManager jobManager)
        {
            this.jobManager = jobManager;
        }

        public void DisplayMenu(object? pm = null)
        {
            var printer = new Printer();

            while (true)
            {
                Console.WriteLine("\n=== JOBSEEKER MENU ===");
                Console.WriteLine("1. View Jobs");
                Console.WriteLine("2. Logout");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var jobs = jobManager.GetJobs();
                        printer.Print(jobs);
                        break;

                    case "2":
                        return;
                }
            }
        }
    }
}
