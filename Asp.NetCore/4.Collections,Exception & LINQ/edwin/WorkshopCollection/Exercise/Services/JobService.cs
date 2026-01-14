using Exercise.Exceptions;
using Exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Services
{
    public class JobService
    {
        public List<Job> Jobs { get; set; } = new List<Job>();

        public JobService()
        {
            SeedJobs();
        }

        private void SeedJobs()
        {
            Jobs.Add(new Job(1, "Software Engineer", "Google"));
            Jobs.Add(new Job(2, "Web Developer", "Microsoft"));
            Jobs.Add(new Job(3, "Cloud Architect", "Amazon"));
            Jobs.Add(new Job(4, "Full Stack Developer", "Infosys"));
        }

        public Job FindJob(int id)
        {
            var job = Jobs.Find(j => j.Id == id);
            if (job == null)
                throw new JobNotFoundException("Job not found!");
            return job;
        }

        public void ShowJobs()
        {
            foreach (var job in Jobs)
                Console.WriteLine(job);
        }
    }
}

