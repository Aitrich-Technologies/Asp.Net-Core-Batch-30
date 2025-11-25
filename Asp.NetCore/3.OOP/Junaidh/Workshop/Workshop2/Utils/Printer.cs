using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop2.Modals;

namespace Workshop2.Utils
{
    public class Printer
    {
        public void Print(Job[] jobs)
        {
            Console.WriteLine("===== Available Jobs =====");
            foreach (var job in jobs)
            {
                if (job == null) break;
                Console.WriteLine($" ID: {job.Id} | Title: {job.Title} | Company: {job.Company}");
                Console.WriteLine($"Location: {job.location} |Salary:{job.SalaryRange} | Type : {job.JobType}");
                Console.WriteLine($"Experience: {job.ExperienceLevel}\n");
            }
        }
        public void Print(User[] users)
        {
            Console.WriteLine("\n=== Registered Users ===");
            foreach(var user in users)
            {
                if(user == null) break;
                Console.WriteLine($"ID: {user.Id} | Name: {user.FirstName} {user.LastName} | Role:{user.Role}");
                Console.WriteLine($"Email : {user.Email} | Phone : {user.Phone}\n");
            }
        }

    }
}
