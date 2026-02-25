using BankAccounts.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Model
{
    internal class BankAccount
    {
        public string Name { get; set; }

        public int AccountNumber { get; set; }

        public double Balance { get; set; }

        public BankAccount(string name, int accountnumber, double balance)
        {
            Name = name;
            AccountNumber = accountnumber;
            Balance = balance;
            


        }
        public void WithDraw( double amount)
        {
            if(amount<0)
            {
                throw new ArgumentException("withdrawal amount cannot be negative");
            }
            if (amount > Balance)
            {
                throw new InSufficientFundException($"insufficient  funds! your balance is {Balance}");
            }
            Balance -= amount;

        }

    }
}
