using AdminJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminJob.Interface
{
    public interface IJobProvider
    {
        void PostJob(Job job);
        List<Job> GetJobs();
    }
}
