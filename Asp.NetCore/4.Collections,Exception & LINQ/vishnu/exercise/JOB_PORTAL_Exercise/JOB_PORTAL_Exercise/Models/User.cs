using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB_PORTAL_Exercise.Models
{
    public enum Role { JobProvider, JobSeeker }

    internal class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public List<int> SavedJobs { get; } = new List<int>();
        public List<int> AppliedJobs { get; } = new List<int>();

        public string FullName => string.IsNullOrWhiteSpace(FirstName) ? Email : FirstName + " " + LastName;

    }


}

