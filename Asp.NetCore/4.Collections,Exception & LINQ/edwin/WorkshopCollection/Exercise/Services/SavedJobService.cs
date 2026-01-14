using Exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Services
{
    public class SavedJobService
    {
      
        private Dictionary<string, List<Job>> savedJobs = new Dictionary<string, List<Job>>();

        public void SaveJob(string username, Job job)
        {
            if (!savedJobs.ContainsKey(username))
                savedJobs[username] = new List<Job>();

            savedJobs[username].Add(job);
            Console.WriteLine("Job saved successfully!");
        }

        public void ShowSavedJobs(string username)
        {
            Console.WriteLine("\n--- Saved Jobs ---");

            if (!savedJobs.ContainsKey(username) || savedJobs[username].Count == 0)
            {
                Console.WriteLine("You have no saved jobs.");
                return;
            }

            foreach (var job in savedJobs[username])
                Console.WriteLine(job);
        }
    }
}   

