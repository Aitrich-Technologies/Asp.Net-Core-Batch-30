using JobPortalApplication.Interfaces;
using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalApplication.Manager
{
    internal  class JobPortalManager : IUser, IJobProvider, IInterviewProvider
    {
        private User[] users = new User[100];
        private Job[] jobs = new Job[100];
        private Interview[] interviews = new Interview[100];


        private int userCount = 0;
        private int jobCount = 0;
        private int interviewCount = 0;



        public void Register(User user)
        {

            if (userCount < users.Length)
            {
                user.Id = userCount + 1;
                users[userCount] = user;
                userCount++;
                Console.WriteLine("User Registered Successfully!");
            }
        }

        public User Login(string email, string password)
        {

            for (int i = 0; i < userCount; i++)
            {
                if (users[i].Email == email && users[i].Password == password)
                {
                    return users[i];
                }
            }

            return null;


            //return users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

   

        public void PostJob(Job job)
        {
            if (jobCount < jobs.Length)
            {
                job.Id = jobCount + 1;
                jobs[jobCount] = job;
                jobCount++;
            }
                Console.WriteLine("Job Posted Successfully!");
        }


        public Job[] GetJobs()
        {
            return jobs.ToArray();
        }

        public void ScheduleInterview(Interview interview)
        {
            if (interviewCount < interviews.Length)
            {
                interview.Id = jobCount + 1;
                interviews[interviewCount] = interview;
                interviewCount++;
            }
                Console.WriteLine("Interview Scheduled Successfully!");
        }


        public Interview[] GetInterviews()
        {
            return interviews.ToArray();
        }

    



    }
}
