using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
    internal class StudentMember:LibraryMember
    {
        public StudentMember(int memberId,string name):base( memberId,name)
        {

        }
        private double FineLogic(int overdueDays)
        {
            return overdueDays * 1.0;
        }
        public override double CalculateFine(int overdueDays)
        {
            return FineLogic(overdueDays);
        }
    }
}
