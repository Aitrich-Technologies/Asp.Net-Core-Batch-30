using HiringManagementExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagementExercise.Interfaces
{
    public interface IJob
    {
        public void AddJob(Job job);
        public Job[] GetJobs();
    }
}
