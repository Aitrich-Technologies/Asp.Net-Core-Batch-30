using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementAssesment
{
    public class InPatient:Patient
    {
        public InPatient(int pid,string name):base(pid,name) { }
        
        public int Bill(int days)
        {
            return days * 1000;
        }

        public int CalculateBillInPatient(int daysAdmitted)
        {
            return Bill(daysAdmitted);
        }
    }
}
