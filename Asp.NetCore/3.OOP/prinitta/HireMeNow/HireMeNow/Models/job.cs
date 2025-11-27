
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow.models
{
    public class Job
    {
        public int Id;
        public string Title;
        public Experiencelevel ExperienceLevel;
        public string Company;
        public string Location;
        public string SalaryRange;
        public string JobType;

        public Job(int id, string title, Experiencelevel expLevel, string company, string location, string salaryRange, string jobType)
        {
            Id = id;
            Title = title;
            ExperienceLevel = expLevel;
            Company = company;
            Location = location;
            SalaryRange = salaryRange;
            JobType = jobType;
        }
    }
}
