using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Staff
    {
        public string StaffName {  get; set; }
        public int StaffId {  get; set; }

        public Staff(string staffName, int staffId)
        {
            StaffName = staffName;
            StaffId = staffId;
        }

        public virtual double CalculateSalary()
        {
            return 1;
        }
    }
}
