using JobPortal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Manager
{
    public class JobManager
    {
        public List<Job> Jobs = new List<Job>();

        public JobManager()
        {
            Jobs.Add(new Job(1, "Software Engineer", ExperienceLevel.Senior, "Aimploy",
                "India,Bngalore", "$50,000 - $75,000", JobType.FullTime));

            Jobs.Add(new Job(2, "Product Manager", ExperienceLevel.MidLevel, "FreshToHome.",
                "India,Hyderabad ", "$20,000 - $30,000", JobType.PartTime));

            Jobs.Add(new Job(3, "Marketing Specialist", ExperienceLevel.Fresher, "KR Enterprises",
                "India,Kerala", "$10,000 - $15,000", JobType.Intern));
        }

        public void ListJobs()
        {
            Console.WriteLine("Jobs available:\n");

            Console.WriteLine("JobId | Title | ExperienceLevel | Company | Location | SalaryRange | JobType");
            Console.WriteLine("------------------------------------------------------------------------------------");

            foreach (var job in Jobs)
            {
                Console.WriteLine($"{job.JobId} | {job.Title} | {job.ExperienceLevel} | {job.Company} | {job.Location} | {job.SalaryRange} | {job.JobType}");
                Console.WriteLine("------------------------------------------------------------------------------------");
            }
        }
    }
}
