using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
    abstract class LibraryMember
    {
        public int MemberId {  get; set; }
        public string Name { get; set; }

        public LibraryMember(int MemberId, string Name)
        {
            this.MemberId = MemberId;
            this.Name = Name;
        }
        public abstract double CalculateFine(int overdueDays);
    }
}
