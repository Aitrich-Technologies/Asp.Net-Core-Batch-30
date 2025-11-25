using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }

        public Employee(int empId, string name)
        {
            EmpId = empId;
            Name = name;

        }
        public virtual double CalculateSalary()
        {
            return 0;

        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"EmployeeId{EmpId}");
            Console.WriteLine($"Employee Name{Name}");
        }
    }
}
