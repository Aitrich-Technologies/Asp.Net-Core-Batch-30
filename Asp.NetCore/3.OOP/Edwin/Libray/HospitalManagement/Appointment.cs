using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public abstract class Appointment
    {
        public string PatientName { get; set; }
  

        public Appointment(string name)
        {
            PatientName = name;
          
        }

        public abstract void ScheduleAppointment();
    }

}
