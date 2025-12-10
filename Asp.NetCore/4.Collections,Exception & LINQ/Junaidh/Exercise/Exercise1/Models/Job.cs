using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public JobType JobType { get; set; }

        public Job(int jobId, string title, ExperienceLevel exp, string company,
                   string location, string salary, JobType jobType)
        {
            JobId = jobId;
            Title = title;
            ExperienceLevel = exp;
            Company = company;
            Location = location;
            SalaryRange = salary;
            JobType = jobType;
        }
    }
}