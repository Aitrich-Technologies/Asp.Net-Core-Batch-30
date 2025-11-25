using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementAssesment
{
    public class OutPatient:Patient
    {
        public OutPatient(int pid, string name) : base(pid, name) { }

        public int PerVisit(int visit)
        {
            return visit* 250;
        }

        public int CalculateVisit(int visits)
        {
            return PerVisit(visits);
        }
    }
}
