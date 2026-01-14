using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    internal class PartTime : Employee
    {
        public double HourlyRate {  get; set; }
        public int HourWorked { get; set; }

        public PartTime(double hourlyRate, int hourWorked,string name, int empId):base(empId,name)
        {
            HourlyRate = hourlyRate;
            HourWorked = hourWorked;
        }
        public override double CalculateSalary()
        {
            return HourlyRate * HourWorked;
        }
    }
}
