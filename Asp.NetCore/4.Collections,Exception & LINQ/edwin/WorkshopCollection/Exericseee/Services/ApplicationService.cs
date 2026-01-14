using Exericseee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericseee.Services
{
    public class ApplicationService
    {
        public static List<Application> Applications = new();
        private static int counter = 1;

        public void ApplyForJob(Job job)
        {
            Applications.Add(new Application
            {
                Id = counter++,
                Name = $"{job.Title} Applicant",
                Location = job.Location,
                Qualification = "N/A",
                Experience = "N/A"
            });
        }

        public List<Application> GetApplications()
        {
            return Applications;
        }
    }
}
