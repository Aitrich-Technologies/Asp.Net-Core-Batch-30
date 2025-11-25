using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Doctor:Staff
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double ConsultationFee { get; set; }
        public Doctor(string name, int id, double consultationFee) : base(name, id)
        {
            this.Name = name;
            this.ID = id;
            this.ConsultationFee = consultationFee;
        }

        public override double CalculateSalary()
        {
            return ConsultationFee * 30;
        }

        
        
    }
}
