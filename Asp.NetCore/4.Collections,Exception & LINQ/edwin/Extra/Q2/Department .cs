using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class Department:Stuent
    {
        public string DeptName {  get; set; }

        public Department(string deptName)
        {
           DeptName = deptName;
        }
    }
}
