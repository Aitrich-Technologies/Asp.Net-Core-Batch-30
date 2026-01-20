using HiringManagementSystem.Interface;
using HiringManagementSystem.Models;
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagementSystem.Managers
{
    public class JobManager:IJob
    {
        private Job[] _jobs = new Job[100];
        private int _count = 0;

        public void AddJob(Job job)
        {
            if (_count < _jobs.Length)
            {
                job.Id = _count + 1;
                _jobs[_count] = job;
                _count++;
            }
            else
            {
                
                    Console.WriteLine("job list is full.cannot add more jobs");
                }
            }

            public Job[]   GetJobs()
        {
            Job[] result = new Job[_count];
            for(int i=0; i<_count;i++)
            {
                result[i] = _jobs[i];

            }
            return result;
        }
        }
    }

