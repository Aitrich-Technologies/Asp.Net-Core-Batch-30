using Exercise._2.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._2.Utils
{
    public class Printer
    {
        public void Print(Job[] jobs)
        {
            Console.WriteLine("\n ===Available Jobs ===");
            foreach(var job  in jobs)
            {
                if (job == null) break;
                Console.WriteLine($"Id :{job.Id} | Title: {job.Title} | Company: {job.Company}");
                Console.WriteLine($"Location: {job.Location}| Salary: {job.SalaryRange} | Type:{job.JobType}");
                Console.WriteLine($"Experience : {job.ExperienceLevel}\n");
            }
        }
        public void Print(User[] users)
        {
            Console.WriteLine("\n === Registered Users ===");

            foreach (var user in users)
            {
                if (user == null) break;
                Console.WriteLine($"Id :{user.Id} | Name:{user.FirstName} {user.LastName} | Roles: {user.Role}");
                Console.WriteLine($"Email: {user.Email} | Phone:{user.Phone}\n");

            }
                

            
        }

        
    }
}
