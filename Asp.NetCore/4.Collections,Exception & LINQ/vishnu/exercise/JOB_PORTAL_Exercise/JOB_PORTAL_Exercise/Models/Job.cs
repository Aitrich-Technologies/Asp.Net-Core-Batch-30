using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_PORTAL_Exercise.Models
{
    internal class Job
    {


        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public string SalaryRange { get; set; }

        public override string ToString()
        {
            return $"{Id,-3} | {Title,-15} | {Description,-15} | {Company,-10} | {Location,-10} | {SalaryRange,-8}\n       | {JobType}";
        }



    }
}
