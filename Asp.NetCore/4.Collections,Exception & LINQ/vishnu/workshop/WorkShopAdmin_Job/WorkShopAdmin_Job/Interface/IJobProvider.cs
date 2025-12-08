using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopAdmin_Job.Models;

namespace WorkShopAdmin_Job.Interface
{
    public interface IJobProvider
    {
        void PostJob(Job job);

        List<Job> GetJobs();
    }
}
