using collectionException.Model;
using collectionException.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionException.Repository
{
    public class UserMenu
    {
        JobService jobService = new();
        Userservice userService = new();
        ApplicationService appService = new();
        InterviewService interviewService = new();

        public void ShowMenu(User user)
        {
            while (true)
            {
                Console.WriteLine("\n===== SEEKER MENU =====");
                Console.WriteLine("1. View Jobs");
                Console.WriteLine("2. Save Job");
                Console.WriteLine("3. View Saved Jobs");
                Console.WriteLine("4. Apply for Job");
                Console.WriteLine("5. View Applications");
                Console.WriteLine("6. View Interviews");
                Console.WriteLine("7. Logout");
                Console.Write("Choice: ");

                try
                {
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1: ViewJobs();
                                break;
                        case 2: SaveJob(user);
                                break;
                        case 3: ViewSaved(user); 
                                break;
                        case 4: ApplyForJob();
                                break;
                        case 5: ViewApplications();
                                break;
                        case 6: ViewInterviews();
                                break;
                        case 7: 
                                return;
                        default: Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[ERROR] " + ex.Message);
                }
            }
        }

        void ViewJobs()
        {
            Console.WriteLine("\n--- JOBS ---");
            foreach (var j in JobService.Jobs) Console.WriteLine(j);
        }

        void SaveJob(User user)
        {
            Console.Write("Enter Job ID to save: ");
            int id = int.Parse(Console.ReadLine());
            var job = jobService.GetJobById(id);
            userService.SaveJob(user.Email, job);
            Console.WriteLine("Saved.");
        }

        void ViewSaved(User user)
        {
            Console.WriteLine("\n--- SAVED JOBS ---");
            var list = userService.GetSavedJobs(user.Email);
            if (list.Count == 0) Console.WriteLine("None.");
            else list.ForEach(j => Console.WriteLine(j));
        }

        void ApplyForJob()
        {
            Console.Write("Enter Job ID to apply: ");
            int id = int.Parse(Console.ReadLine());
            var job = jobService.GetJobById(id);
            appService.ApplyForJob(job);
            Console.WriteLine("Applied.");
        }

        void ViewApplications()
        {
            Console.WriteLine("\n--- APPLICATIONS ---");
            var apps = appService.GetApplications();
            if (apps.Count == 0) Console.WriteLine("None.");
            else apps.ForEach(a => Console.WriteLine(a));
        }

        void ViewInterviews()
        {
            Console.WriteLine("\n--- INTERVIEWS ---");
            var list = interviewService.GetAll();
            if (list.Count == 0) Console.WriteLine("None.");
            else list.ForEach(i => Console.WriteLine(i));
        }
    }
}
