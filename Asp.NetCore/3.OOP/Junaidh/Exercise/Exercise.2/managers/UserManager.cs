using Exercise._2.Interfaces;
using Exercise._2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._2.managers
{
    public class UserManager : IMenu
    {
        private readonly JobManager jobManager;  

        public UserManager(JobManager jobManager)
        {
            jobManager = jobManager;
        }

        public void DisplayMenu(object? publicManager = null)
        {
            var printer = new Printer();
            while (true)
            {
                Console.WriteLine("\n=== JobSeeker Menu ===");
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

