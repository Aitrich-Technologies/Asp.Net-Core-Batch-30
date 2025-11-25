using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class OfflineAppointment : Appointment
    {
        public OfflineAppointment(string name, int id) : base(name) { }

        public override void ScheduleAppointment()
        {
            Console.WriteLine($"Offline appointment scheduled for {PatientName} at Hospital");
        }
    }
}

