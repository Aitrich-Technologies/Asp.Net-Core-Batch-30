
using System;
using HireMeNow.models;

namespace HireMeNow.enums;

    public class JobManager
    {
        public Job[] Jobs = new Job[100];
        private int jobCount = 0;

        public JobManager()
        {

        Jobs[jobCount++] = new Job(1, "Software Developer", Experiencelevel.Fresher, "TechCorp", "Bangalore", "3-5 LPA", "Full Time");
        Jobs[jobCount++] = new Job(2, "Senior Analyst", Experiencelevel.Senior, "Infosys", "Chennai", "10-15 LPA", "Full Time");
        Jobs[jobCount++] = new Job(3, "UI/UX Designer", Experiencelevel.Midlevel, "Google", "Hyderabad", "8-12 LPA", "Contract");
        }

        public void ListJobs()
        {
            Console.WriteLine("\n-------- AVAILABLE JOBS --------");
            PrintJobs(Jobs);
        }

        public void PrintJobs(Job[] jobs)
        {
            for (int i = 0; i < jobCount; i++)
            {
                var job = jobs[i];
                if (job == null) continue;

                Console.WriteLine($"\nJob ID: {job.Id}");
                Console.WriteLine($"Title: {job.Title}");
                Console.WriteLine($"Experience: {job.ExperienceLevel}");
                Console.WriteLine($"Company: {job.Company}");
                Console.WriteLine($"Location: {job.Location}");
                Console.WriteLine($"Salary: {job.SalaryRange}");
                Console.WriteLine($"Job Type: {job.JobType}");
                Console.WriteLine("-----------------------------------");
            }
        }

        public Job GetJobById(int jobId)
        {
            for (int i = 0; i < jobCount; i++)
            {
                if (Jobs[i] != null && Jobs[i].Id == jobId)
                    return Jobs[i];
            }
            return null;
        }
    }

