using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class BankAccount
    {
        private decimal balance;  

        public int AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }

        public BankAccount(int accountNumber, string accountHolder, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            balance = initialBalance;
        }

 
        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public virtual void Withdraw(decimal amount)  
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }
    }

}
