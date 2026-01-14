using collectionException.Exceptions;
using collectionException.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionException.Services
{
    public class JobService
    {
        public static List<Job> Jobs = new();
        private static int jobCounter = 1;

        public void AddJob(string title, string desc, string comp, string loc, string sal, string type)
        {
            if (string.IsNullOrWhiteSpace(title)) 
                throw new PortalException("Title required.");
            Jobs.Add(new Job
            {
                JobId = jobCounter++,
                Title = title,
                Description = desc,
                Company = comp,
                Location = loc,
                SalaryRange = sal,
                JobType = type
            });
        }

        public List<Job> ListJobs() => Jobs;

        public Job GetJobById(int id)
        {
            var j = Jobs.Find(x => x.JobId == id);
            if (j == null) throw new JobNotFoundException("Job not found!");
            return j;
        }
    }
}
