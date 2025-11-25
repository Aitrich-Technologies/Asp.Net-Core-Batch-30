using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiringManagementExercise.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public string SalaryRange { get; set; } = string.Empty;
        public string JobType { get; set; } = string.Empty;
        public Enums.ExperinceLevels ExperienceLevel { get; set; }
    }
}
