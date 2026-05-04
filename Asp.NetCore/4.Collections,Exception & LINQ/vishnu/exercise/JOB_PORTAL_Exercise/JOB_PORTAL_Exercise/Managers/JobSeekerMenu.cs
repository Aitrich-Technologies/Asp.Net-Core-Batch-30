using JOB_PORTAL_Exercise.Models;
using JOB_PORTAL_Exercise.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_PORTAL_Exercise.Managers
{
    internal class JobSeekerMenu
    {

        private  JobService _jobService;
        private  User _user;

        public JobSeekerMenu(JobService jobService, User user)
        {
            _jobService = jobService;
            _user = user;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine($"\nWelcome {_user.FirstName}");
                Console.WriteLine("1. List Jobs\n2. Saved Jobs\n3. Applied Jobs\n4. Profile\n5. Logout\n");

                var opt = Console.ReadLine();

                if (opt == "1") ListJobsMenu();
                else if (opt == "2") PrintSaved();
                else if (opt == "3") PrintApplied();
                else if (opt == "4") PrintProfile();
                else if (opt == "5") break;
                else Console.WriteLine("Invalid option\n");
            }
        }

        private void ListJobsMenu()
        {
            foreach (var j in _jobService.GetAll())
                Console.WriteLine(j);

            Console.WriteLine("\n1. Apply\n2. Save\n3. Back");

            var opt = Console.ReadLine();

            if (opt == "1")
            {
                Console.Write("Enter Job ID: ");
                int id = int.Parse(Console.ReadLine());
                if (!_user.AppliedJobs.Contains(id))
                    _user.AppliedJobs.Add(id);

                Console.WriteLine("Applied!");
            }
            else if (opt == "2")
            {
                Console.Write("Enter Job ID: ");
                int id = int.Parse(Console.ReadLine());
                if (!_user.SavedJobs.Contains(id))
                    _user.SavedJobs.Add(id);

                Console.WriteLine("Saved!");
            }
        }

        private void PrintSaved()
        {
            Console.WriteLine("Saved Jobs:");
            foreach (var id in _user.SavedJobs)
            {
                var j = _jobService.GetById(id);
                if (j != null) Console.WriteLine(j);
            }
        }

        private void PrintApplied()
        {
            Console.WriteLine("Applied Jobs:");
            foreach (var id in _user.AppliedJobs)
            {
                var j = _jobService.GetById(id);
                if (j != null) Console.WriteLine(j);
            }
        }

        private void PrintProfile()
        {
            Console.WriteLine("\n--- Profile ---");
            Console.WriteLine($"Name: {_user.FullName}");
            Console.WriteLine($"Email: {_user.Email}");
            Console.WriteLine($"Phone: {_user.Phone}");
            Console.WriteLine($"Role: {_user.Role}");
        }


    }
}
