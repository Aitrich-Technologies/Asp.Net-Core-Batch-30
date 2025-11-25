using Exercise._2.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise._2.managers;

namespace Exercise._2.Interfaces
{
     public interface IJob
    {
        public void AddJob(Job job);
        public Job[] GetJobs();
    }
}
