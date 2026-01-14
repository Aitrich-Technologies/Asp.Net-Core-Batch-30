using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
internal class FacultyMember:LibraryMember
    {
        public FacultyMember(int memberId,string name):base(memberId,name) { }

        private double FineLogic(int overdueDays)
        {
            return overdueDays * 0.5;
        }
        public override double CalculateFine(int overdueDays)
        {
            return FineLogic(overdueDays);
        }
    }
}
