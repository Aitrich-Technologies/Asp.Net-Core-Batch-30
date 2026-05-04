using JOB_PORTAL_Exercise.Exceptions;
using JOB_PORTAL_Exercise.Models;
using JOB_PORTAL_Exercise.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_PORTAL_Exercise.Managers
{
    internal class JobProviderMenu
    {
        private  JobService _jobService;
        private  User _user;

        public JobProviderMenu(JobService jobService, User user)
        {
            _jobService = jobService;
            _user = user;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Choose an option:\n1. Jobs\n2. Logout\n");
                var opt = Console.ReadLine();

                if (opt == "1") JobsMenu();
                else if (opt == "2") break;
                else Console.WriteLine("Invalid option\n");
            }
        }

        private void JobsMenu()
        {
            while (true)
            {
                Console.WriteLine("1. List Jobs\n2. Post Job\n3. Back\n");
                var opt = Console.ReadLine();

                if (opt == "1") PrintJobs();
                else if (opt == "2") PostJob();
                else if (opt == "3") break;
                else Console.WriteLine("Invalid option\n");
            }
        }

        private void PrintJobs()
        {
            Console.WriteLine("\n--- Jobs ---");
            foreach (var j in _jobService.GetAll())
                Console.WriteLine(j);
        }

        private void PostJob()
        {
            try
            {
                Console.Write("Title: ");
                var title = Console.ReadLine();
                Console.Write("Description: ");
                var desc = Console.ReadLine();
                Console.Write("Company: ");
                var company = Console.ReadLine();
                Console.Write("Location: ");
                var loc = Console.ReadLine();
                Console.Write("Job Type: ");
                var type = Console.ReadLine();
                Console.Write("Salary: ");
                var sal = Console.ReadLine();

                var job = new Job
                {
                    Title = title,
                    Description = desc,
                    Company = company,
                    Location = loc,
                    JobType = type,
                    SalaryRange = sal
                };

                _jobService.AddJob(job);
                Console.WriteLine("Job posted successfully.\n");
            }
            catch (InvalidJobException ex)
            {
                Console.WriteLine("Custom Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("System Error: " + ex);
            }
        }
    }
}
