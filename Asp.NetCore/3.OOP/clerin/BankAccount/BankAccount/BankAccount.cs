using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; set; }

        public string HolderName { get; set; }

        public BankAccount(string accnumber,string holdername)
        {
            AccountNumber = accnumber;
            HolderName = holdername;
        }
        public abstract double CalculateInterest(double balance);
    }
}
