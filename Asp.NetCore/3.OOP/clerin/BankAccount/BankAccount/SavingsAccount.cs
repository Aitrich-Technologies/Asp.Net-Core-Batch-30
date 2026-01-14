using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public  class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accnumber,string holdername): base(accnumber,holdername)
        { }

        public override double CalculateInterest(double balance)
        {
            return balance * 0.05;
        }
    }
}
