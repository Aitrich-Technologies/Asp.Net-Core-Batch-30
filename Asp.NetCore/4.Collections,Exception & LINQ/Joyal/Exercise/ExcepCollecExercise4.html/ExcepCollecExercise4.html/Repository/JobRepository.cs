using ExcepCollecExercise4.html.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepCollecExercise4.html.Repository
{
    public class JobRepository
    {
        public List<Job> Jobs = new List<Job>();
        private int idCounter = 1;

        public void AddJob(Job job)
        {
            job.JobId = idCounter++;
            Jobs.Add(job);
        }

        public Job GetJobById(int id)
        {
            return Jobs.Find(j => j.JobId == id);
        }
    }
}
