using JOB_PORTAL_Exercise.Exceptions;
using JOB_PORTAL_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_PORTAL_Exercise.Services
{
    internal class JobService
    {

        private  List<Job> _jobs = new List<Job>();
        private int _nextId = 1;

        public JobService()
        {
            AddJob(new Job
            {
                Title = "Developer",
                Description = ".NET Developer",
                Company = "Aitrich",
                Location = "Thrissur",
                JobType = "Online",
                SalaryRange = "23000"
            });
        }

        public IEnumerable<Job> GetAll() => _jobs.ToList();

        public Job GetById(int id) => _jobs.FirstOrDefault(j => j.Id == id);

        public Job AddJob(Job job)
        {
            if (string.IsNullOrWhiteSpace(job.Title))
                throw new InvalidJobException("Job Title is required.");

            if (string.IsNullOrWhiteSpace(job.Company))
                throw new InvalidJobException("Company name is required.");

            if (string.IsNullOrWhiteSpace(job.Location))
                throw new InvalidJobException("Location is required.");

            job.Id = _nextId++;
            _jobs.Add(job);

            return job;
        }
    
}
}
