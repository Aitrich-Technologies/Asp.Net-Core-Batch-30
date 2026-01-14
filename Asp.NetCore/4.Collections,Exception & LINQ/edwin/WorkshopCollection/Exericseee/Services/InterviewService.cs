using Exericseee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericseee.Services
{
    public class InterviewService
    {
        public static List<Interview> Interviews = new();
        private static int counter = 1;

        public void Schedule(string desig, string comp, string loc, string date, string time)
        {
            Interviews.Add(new Interview
            {
                Id = counter++,
                Designation = desig,
                Company = comp,
                Location = loc,
                Date = date,
                Time = time
            });
        }
        public List<Interview> List()
        {
            return Interviews;
        }
    }
}
