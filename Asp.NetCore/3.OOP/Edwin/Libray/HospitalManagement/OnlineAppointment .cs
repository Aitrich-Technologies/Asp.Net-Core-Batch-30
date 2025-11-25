using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class OnlineAppointment : Appointment
    {
        public OnlineAppointment(string name, int id) : base(name) { }

        public override void ScheduleAppointment()
        {
            Console.WriteLine($"Online appointment scheduled for {PatientName}");
        }
    }

}

