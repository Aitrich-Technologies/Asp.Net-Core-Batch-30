using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class School
    {
        public int RollNo {  get; set; }
        public string Name {  get; set; }
        public int Marks {  get; set; }

        public School(int  rollNo, string name, int marks)
        {
            RollNo = rollNo;
            Name = name;
            Marks = marks;
        }
        public void CheckResult()
        {
            if (Marks >= 40)
                Console.WriteLine($"{Name} - Pass");
            else
                Console.WriteLine($"{Name} - Fail");
        }
    }
}
