using collectionException.Model;
using collectionException.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionException.Repository
{
    public class ProviderMenu
    {
        JobService jobService = new();
        InterviewService interviewService = new();

        public void ShowMenu(User user)
        {
            while (true)
            {
                Console.WriteLine("\n===== PROVIDER MENU =====");
                Console.WriteLine("1. Add Job");
                Console.WriteLine("2. List Jobs");
                Console.WriteLine("3. Schedule Interview");
                Console.WriteLine("4. View Interviews");
                Console.WriteLine("5. Reschedule Interview");
                Console.WriteLine("6. Cancel Interview");
                Console.WriteLine("7. Logout");
                Console.Write("Choice: ");

                try
                {
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1: AddJob();
                                break;
                        case 2: ListJobs();
                                break;
                        case 3: ScheduleInterview(); 
                                break;
                        case 4: ViewInterviews();
                                break;
                        case 5: Reschedule(); 
                                break;
                        case 6: Cancel();
                                break;
                        case 7: 
                                return;
                        default:
                                Console.WriteLine("Invalid choice"); 
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[ERROR] " + ex.Message);
                }
            }
        }

        void AddJob()
        {
            Console.Write("Title: "); string t = Console.ReadLine();
            Console.Write("Desc: "); string d = Console.ReadLine();
            Console.Write("Company: "); string c = Console.ReadLine();
            Console.Write("Location: "); string l = Console.ReadLine();
            Console.Write("Salary: "); string s = Console.ReadLine();
            Console.Write("Type: "); string ty = Console.ReadLine();
            jobService.AddJob(t, d, c, l, s, ty);
            Console.WriteLine("Added.");
        }

        void ListJobs()
        {
            Console.WriteLine("\n--- JOBS ---");
            foreach (var j in JobService.Jobs) 
                Console.WriteLine(j);
        }

        void ScheduleInterview()
        {
            Console.Write("Job ID: "); int jobId = int.Parse(Console.ReadLine());
            var job = jobService.GetJobById(jobId);
            Console.Write("Seeker name: "); string seeker = Console.ReadLine();
            Console.Write("Date (yyyy-MM-dd HH:mm): "); DateTime dt = DateTime.Parse(Console.ReadLine());
            var iv = interviewService.ScheduleInterview(jobId, seeker, job.Company, dt);
            Console.WriteLine("Scheduled: " + iv);
        }

        void ViewInterviews()
        {
            Console.WriteLine("\n--- INTERVIEWS ---");
            var list = interviewService.GetAll();
            if (list.Count == 0) Console.WriteLine("None.");
            else list.ForEach(i => Console.WriteLine(i));
        }

        void Reschedule()
        {
            Console.Write("Interview ID: "); int id = int.Parse(Console.ReadLine());
            Console.Write("New Date (yyyy-MM-dd HH:mm): "); DateTime nd = DateTime.Parse(Console.ReadLine());
            interviewService.Reschedule(id, nd);
            Console.WriteLine("Rescheduled.");
        }

        void Cancel()
        {
            Console.Write("Interview ID: "); int id = int.Parse(Console.ReadLine());
            interviewService.CancelInterview(id);
            Console.WriteLine("Cancelled.");
        }
    }
}