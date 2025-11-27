using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    internal class FullTime: Employee
    {
        public double BaseSalary {  get; set; }
        public double Allowance { get; set; }

        public FullTime(double  baseSalary, double allowance,string name,int empId):base(empId,name)
        {
            BaseSalary = baseSalary;
            Allowance = allowance;
        }
        public override double CalculateSalary()
        {
            return BaseSalary + Allowance;
        }
    }
}
