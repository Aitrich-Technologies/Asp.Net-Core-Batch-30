using Adminjob.Model;
using Adminjob.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Adminjob.Manager
{
    internal class JobManager : IJob
    {


        private int numJobs = 0;
        private Job[] jobs = new Job[100];


        public void addJob()
        {
            if (numJobs == jobs.Length)
            {
                Console.WriteLine("Maximum number of jobs reached. Please try again later.");
                return;
            }
            Console.Write("Enter job id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter job title: ");
            string title = Console.ReadLine();

            Console.Write("Enter job description: ");
            string description = Console.ReadLine();
            Console.Write("Enter job salary: ");
            string salary = Console.ReadLine();
            Console.Write("Enter job location: ");
            string location = Console.ReadLine();

            Job newjob = new Job(id, title, description, salary, location);
            jobs[numJobs] = newjob;
            numJobs++;

            Console.WriteLine("Job added successfully.");

        }
    
        public void ListJob()
        {
            Console.WriteLine("Jobs:");
            for (int i = 0; i < numJobs; i++)
            {
                Console.WriteLine($"Title: {jobs[i].title}");
                Console.WriteLine($"Description: {jobs[i].Description}");
                Console.WriteLine($"Salary: {jobs[i].salary}");
                Console.WriteLine($"Location: {jobs[i].Location}");
            }
        }
          
    }
}
