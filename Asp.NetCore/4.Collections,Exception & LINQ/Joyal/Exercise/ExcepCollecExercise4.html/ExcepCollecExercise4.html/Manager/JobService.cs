using ExcepCollecExercise4.html.Exceptions;
using ExcepCollecExercise4.html.Interface;
using ExcepCollecExercise4.html.Model;
using ExcepCollecExercise4.html.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepCollecExercise4.html.Manager
{
    public class JobService : IJobService
    {
        private readonly JobRepository repo;
        private readonly Dictionary<string, List<int>> savedJobs = new Dictionary<string, List<int>>();
        private readonly Dictionary<string, List<int>> appliedJobs = new Dictionary<string, List<int>>();

        public JobService(JobRepository repo)
        {
            this.repo = repo;
        }

        public void ListJobs()
        {
            Console.WriteLine("\nJobs:\n");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-25} | {3,-20} | {4,-15} | {5,-15} ",
                              "JobId", "Title", "ExperienceLevel", "Company", "Location", "Salary");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------");

            if (repo.Jobs != null && repo.Jobs.Count > 0)
            {
                foreach (Job job in repo.Jobs)
                {
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-25} | {3,-20} | {4,-15} | {5,-15}",
                                       job.JobId,
                                       job.Title,
                                       job.ExperienceLevel,
                                       job.Company,
                                       job.Location,
                                       job.SalaryRange);
                                       
                }
            }
            else
            {
                Console.WriteLine("No jobs found.");
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------\n");
        }


        public void PostJob(User user)
        {
            if (user.Role != "jobprovider")
            {
                Console.WriteLine("Only job providers can post jobs.");
                return;
            }

            Console.Write("Job Title: ");
            string title = Console.ReadLine();

            Console.Write("Experience Level (in years): ");
            int exp = int.Parse(Console.ReadLine());

            Console.Write("Company: ");
            string company = Console.ReadLine();

            Console.Write("Location: ");
            string loc = Console.ReadLine();

            Console.Write("Salary Range: ");
            decimal sal = decimal.Parse(Console.ReadLine());

            Job j = new Job()
            {
                Title = title,
                ExperienceLevel = exp,
                Company = company,
                Location = loc,
                SalaryRange = sal
            };

            repo.AddJob(j);

            Console.WriteLine("Job posted successfully!\n");
        }

        public void ApplyJob(User user)
        {
            try
            {
                Console.Write("Enter JobId: ");
                int id = Convert.ToInt32(Console.ReadLine());

                var job = repo.GetJobById(id);

                if (job == null)
                    throw new JobNotFoundException("Job not found.");

                if (!appliedJobs.ContainsKey(user.Email))
                    appliedJobs[user.Email] = new List<int>();

                if (appliedJobs[user.Email].Contains(id))
                    throw new AlreadyAppliedException("You already applied for this job.");

                appliedJobs[user.Email].Add(id);

                Console.WriteLine("Job applied successfully!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SaveJob(User user)
        {
            try
            {
                Console.Write("Enter JobId: ");
                int id = Convert.ToInt32(Console.ReadLine());

                if (!savedJobs.ContainsKey(user.Email))
                    savedJobs[user.Email] = new List<int>();

                savedJobs[user.Email].Add(id);

                Console.WriteLine("Job saved successfully!");
            }
            catch (Exception)
            {
                Console.WriteLine("Saving job failed.");
            }
        }

        public void ShowSavedJobs(User user)
        {
            Console.WriteLine("\nSaved Jobs:");

            if (!savedJobs.ContainsKey(user.Email))
            {
                Console.WriteLine("No saved jobs.");
                return;
            }

            foreach (var id in savedJobs[user.Email])
            {
                var job = repo.GetJobById(id);
                if (job != null)
                    Console.WriteLine($"{job.JobId} - {job.Title}");
            }
        }

        public void ShowAppliedJobs(User user)
        {
            Console.WriteLine("\nApplied Jobs:");

            if (!appliedJobs.ContainsKey(user.Email))
            {
                Console.WriteLine("No applied jobs.");
                return;
            }

            foreach (var id in appliedJobs[user.Email])
            {
                var job = repo.GetJobById(id);
                if (job != null)
                    Console.WriteLine($"{job.JobId} - {job.Title}");
            }
        }
    }
}
