using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepCollecExercise4.html.Model
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; } = string.Empty;
        //public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        //public string JobType { get; set; } = string.Empty;
        public int ExperienceLevel {  get; set; }
        public decimal SalaryRange {  get; set; }
        public string Company { get; set; } = string.Empty;
    }
}
