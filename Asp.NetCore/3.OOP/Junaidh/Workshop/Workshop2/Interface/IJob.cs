using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop2.Modals;

namespace Workshop2.Interface
{
    public interface IJob
    {
        public void AddJob(Job job);
        public Job[] GetJobs(); 
    }
}
