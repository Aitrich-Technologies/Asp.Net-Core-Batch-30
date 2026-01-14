using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public  class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accnumber,string holdername): base(accnumber,holdername)
        { }
        public override double CalculateInterest(double balance)
        {
            return balance * 0.03;
        }
    }
}
