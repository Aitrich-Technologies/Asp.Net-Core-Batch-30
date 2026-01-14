using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public int EmpId;
        public string Name;
        public double BasicSalary;
        public Employee(int empId, string name, double basicSalary)
        {
           EmpId = empId;
            Name = name;
            BasicSalary = basicSalary;
        }

        public double CalculateNetSalary()
        {
            double hra = BasicSalary * 0.20;
            double tax = BasicSalary * 0.10;
            double Totalsalary = BasicSalary + (hra - tax);
            return Totalsalary;
        }
    }
}
