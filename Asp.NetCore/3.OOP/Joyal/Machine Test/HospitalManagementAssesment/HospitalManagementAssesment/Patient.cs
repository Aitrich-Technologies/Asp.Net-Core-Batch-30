using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementAssesment
{
    public abstract class Patient
    {
        private int patientId;
        public string PatientName;

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public Patient(int pid,string name)
        {
            PatientId = pid;
            PatientName = name;
        }

        public int Calculate(int days)
        {
            return days;
        }

        public int CalculateBillPatient(int daysAdmitted)
        {
            return Calculate(daysAdmitted);
        }
    }
}
