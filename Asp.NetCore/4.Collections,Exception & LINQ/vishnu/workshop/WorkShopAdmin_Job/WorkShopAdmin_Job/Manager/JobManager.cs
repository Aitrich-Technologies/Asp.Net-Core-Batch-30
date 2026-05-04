using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopAdmin_Job.Interface;
using WorkShopAdmin_Job.Models;

namespace WorkShopAdmin_Job.Manager
{
    public  class JobManager:IJobProvider 
    {

        List<Job> jobs=new List<Job>();


        public void PostJob(Job job)
        {
            job.Id = jobs .Count ;
            jobs.Add(job);
        }

        public List<Job> GetJobs()
        {
            return jobs;
        }



    }
}
