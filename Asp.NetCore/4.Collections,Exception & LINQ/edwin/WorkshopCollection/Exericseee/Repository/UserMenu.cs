using Exericseee.Model;
using Exericseee.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericseee.Repository
{
    internal class UserMenu
    {
        JobService jobService = new();
        ApplicationService appService = new();
        Userservice userService = new();

        public void ShowMenu(User user)
        {
            while (true)
            {
                Console.WriteLine("\n1. List all jobs\n2. Saved Jobs\n3. Applied Jobs\n4. My Profile\n5. Logout");
                Console.Write("Choose: ");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1: ListJobs(user); break;
                    case 2: ShowSaved(user.Email); break;
                    case 3: ShowApplications(); break;
                    case 4: ShowProfile(user); break;
                    case 5: return;
                    default: Console.WriteLine("Invalid choice."); break;
                }
            }
        }

        void ListJobs(User user)
        {
            var jobs = jobService.ListJobs();

            Console.WriteLine("\nJobId | Title | Company | Location");
            foreach (var j in jobs)
                Console.WriteLine($"{j.JobId} | {j.Title} | {j.Company} | {j.Location}");

            Console.WriteLine("\n1. Apply\n2. Save\n3. Back");
            int c = int.Parse(Console.ReadLine());

            if (c == 3) return;

            Console.Write("Enter JobId: ");
            int id = int.Parse(Console.ReadLine());
            var job = jobService.GetJobById(id);

            if (c == 1)
            {
                appService.ApplyForJob(job);
                Console.WriteLine("Applied successfully!");
            }
            else if (c == 2)
            {
                userService.SaveJob(user.Email, job);
                Console.WriteLine("Saved!");
            }
        }

        void ShowApplications()
        {
            var apps = appService.GetApplications();

            Console.WriteLine("\nId | Name | Location");
            foreach (var a in apps)
                Console.WriteLine($"{a.Id} | {a.Name} | {a.Location}");
        }

        void ShowSaved(string email)
        {
            var saved = userService.GetSavedJobs(email);

            Console.WriteLine("\nSaved Jobs:");
            foreach (var j in saved)
                Console.WriteLine($"{j.JobId} | {j.Title} | {j.Company}");
        }

        void ShowProfile(User u)
        {
            Console.WriteLine($"\nName: {u.FirstName} {u.LastName}");
            Console.WriteLine("Email: " + u.Email);
            Console.WriteLine("Phone: " + u.Phone);
        }
    }
}
