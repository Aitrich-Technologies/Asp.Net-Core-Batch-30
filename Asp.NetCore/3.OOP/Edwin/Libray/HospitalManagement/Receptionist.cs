using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    internal class Receptionist:Staff
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public double FixedSalary { get; set; }
        public Receptionist(string name, int id,double fixedSalary) : base(name, id)
        {
            this.Name = name;
            this.ID = id;
            this.FixedSalary = fixedSalary;
        }

        public override double CalculateSalary()
        {
            return FixedSalary;
        }
    }
}
