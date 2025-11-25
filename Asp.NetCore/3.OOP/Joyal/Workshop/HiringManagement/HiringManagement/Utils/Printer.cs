using HiringManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagement.Utils
{
    public class Printer
    {
        public void Print(Job[] jobs)
        {
            Console.WriteLine("---Available Jobs---");
            foreach (Job job in jobs)
            {
                if (job == null) break;
                
                    Console.WriteLine($"ID: {job.Id} | Title: {job.Title} | Company: {job.Company} | Location: {job.Location} | Salary: {job.SalaryRange} | Type:{job.JobType} | Experience: {job.ExperinceLevel} \n");
                
            }
        }

        public void Print(User[] users) 
        {
            Console.WriteLine("!!!!REgistered Users!!!!");
            foreach (User user in users)
            {
                if(user == null) break;
                Console.WriteLine($"ID: {user.Id} | Name: {user.FirstName} {user.LastName} | Role: {user.Role} | Email: {user.Email} | Phone: {user.Phone}");
            }
        }
    }
}
