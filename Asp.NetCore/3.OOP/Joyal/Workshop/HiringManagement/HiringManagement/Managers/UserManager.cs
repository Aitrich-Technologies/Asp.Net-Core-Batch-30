using HiringManagement.Interface;
using HiringManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagement.Managers
{
    public class UserManager : IMenu
    {
        private readonly JobManager _jobManager;

        public UserManager(JobManager jobManager)
        {
            _jobManager = jobManager;
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
                        var jobs = _jobManager.GetJobs();
                        printer.Print(jobs);
                        break;

                    case "2":
                        return;
                }
            }
        }
    }
}