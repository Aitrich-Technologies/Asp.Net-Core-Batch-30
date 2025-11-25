using Workshop2.Modals;
using Workshop2.Utils;
using Workshop2.Enums;
using Workshop2.Interface;

namespace Workshop2.Managers
{
    public class JobManager:IJob
    {
        private Job[] jobs = new Job[100];
        private int count = 0;

        public void AddJob(Job  job)
        {
            if(count <  jobs.Length)
            {
                job.Id = count + 1;
                jobs[count] = job;
                count++;
            }
            else
            {
                Console.WriteLine("Job list is full.Cannot add more jobs.");
            }
        }
        public Job[] GetJobs()
        {
            Job[] result = new Job[count];
            for(int i = 0; i < count; i++)
            {
                result[i] = jobs[i];
            }
            return result;
        }
    }
}
