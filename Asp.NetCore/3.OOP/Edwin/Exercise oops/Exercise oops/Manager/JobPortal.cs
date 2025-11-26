using Exercise_oops.Interface;
using Exercise_oops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_oops.Manager
{
    public class JobPortal:IJobProvider,IApplicationProvider,IInterview
    {
        Job[] jobs = new Job[10];
        Application[]applications = new Application[10];
        Interview[]interviews = new Interview[10];

        int jobIndex = 0, appIndex = 0, intIndex = 0;

        public void PostJob(Job job)
        {
            jobs[jobIndex++] = job;

        }

        public Job[] GetJobs()
        {
            return jobs;
        }
        public void AddApplication(Application application)
        {
            applications[appIndex++] = application;
        }

        public Application[] GetApplications()
        {
            return applications;
        }

        public void ScheduleInterview(Interview interview)
        {
            interviews[intIndex++] = interview;
        }
        public Interview[] GetInterviews()
        {
            return interviews;
        }

    }

    
}
