using BankAccount.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class bankAccount
    {
        public double Balance { get; private set; }

        public bankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new NegativeValueException("Withdrawal amount cannot be negative!");
            }

            if (amount > Balance)
            {
                throw new InsufficientFundsException("Insufficient funds to complete withdrawal!");
            }

            Balance -= amount;
        }
    }
}
