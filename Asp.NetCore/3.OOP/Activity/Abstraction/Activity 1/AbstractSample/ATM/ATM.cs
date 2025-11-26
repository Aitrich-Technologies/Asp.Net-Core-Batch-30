using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public abstract class Atm
    {
        public abstract void WithdrawMoney(decimal amount);
        public abstract void CheckBalance();

        public abstract void DepositMoney(decimal amount);

    }
}
