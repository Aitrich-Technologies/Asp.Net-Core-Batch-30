using Exercisee.Exception;
using Exercisee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisee.Manager
{
    public class JobPortalManager
    {
        private List<Job> jobs = new List<Job>();
        private Dictionary<string, List<Job>> savedJobs = new Dictionary<string, List<Job>>(StringComparer.OrdinalIgnoreCase);

 
        private Dictionary<string, User> users = new Dictionary<string, User>(StringComparer.OrdinalIgnoreCase);

        public JobPortalManager()
        {
            jobs.Add(new Job { Id = 101, Title = "Software Developer", Company = "TechSoft", Salary = 60000 });
            jobs.Add(new Job { Id = 102, Title = "Front-End Developer", Company = "WebNova", Salary = 50000 });
            jobs.Add(new Job { Id = 103, Title = "QA Engineer", Company = "AssureQ", Salary = 45000 });
            jobs.Add(new Job { Id = 104, Title = "Data Analyst", Company = "DataSight", Salary = 55000 });
        }

    
        public void RegisterUser(string username, string password)
        {
            if (users.ContainsKey(username))
                throw new UserAlreadyExistsException("Username already exists.");

            users[username] = new User(username, password);
            savedJobs[username] = new List<Job>();
        }

        
        public bool Login(string username, string password)
        {
            if (!users.ContainsKey(username))
                throw new ApplicationException("User not found.");

            if (users[username].Password != password)
                throw new ApplicationException("Incorrect password.");

            return true;
        }

        public IEnumerable<Job> GetAllJobs() => jobs;

        public Job GetJobById(int id) => jobs.FirstOrDefault(j => j.Id == id);

        public void SaveJob(string username, int jobId)
        {
            if (!users.ContainsKey(username))
                throw new ApplicationException("Login first.");

            Job job = GetJobById(jobId);
            if (job == null)
                throw new KeyNotFoundException("Job not found.");

            if (savedJobs[username].Any(j => j.Id == jobId))
                throw new ApplicationException("Job already saved.");

            savedJobs[username].Add(job);
        }

        public IEnumerable<Job> GetSavedJobs(string username)
        {
            return savedJobs[username];
        }

        public void RemoveSavedJob(string username, int jobId)
        {
            var job = savedJobs[username].FirstOrDefault(j => j.Id == jobId);

            if (job == null)
                throw new ApplicationException("Job not found in saved list.");

            savedJobs[username].Remove(job);
        }

        public IEnumerable<string> GetAllUsers()
        {
            return users.Keys;
        }
    }
}

