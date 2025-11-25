using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop2.Enums;

namespace Workshop2.Modals
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Company { get; set; } = string.Empty;
        public string location { get; set; } = string.Empty;
        public string SalaryRange { get; set; } = string.Empty;
        public string JobType { get; set; } = string.Empty;
    }
}
