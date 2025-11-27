using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement;

    public class Nurse:Staff
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public double HourlyRate {  get; set; }
        public Nurse(string name, int id,double hourlyRate) : base(name, id) 
    {
        this.Name = name;
        this.ID = id;
        this.HourlyRate = hourlyRate;
    }

        public override  double CalculateSalary()
        {
            return HourlyRate*160;
        }
    }

