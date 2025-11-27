using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray
{
    public abstract class Transaction
    {
        public string TransactionID {  get; set; }
        public string MemberName { get; set; }
        public DateTime TransactionDate {  get; set; }

        public abstract decimal CalculateFine(int daysLate);

    }
}
