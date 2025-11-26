using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class BankAtm:Atm
    {
        private decimal balance;


        public BankAtm(decimal intialBalance)
        {
            balance = intialBalance;
        }
        public override void WithdrawMoney(decimal amount)
        {
            if(amount>0&& amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"You have withdrawn {amount:C}. Remaining balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficent balance or invalid Amount");
            }
        }
        public override void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: {balance:C}");

        }
        public override void DepositMoney(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"You have deposited {amount:C}. New balance: {balance:C}");
            }
            else
            {


                Console.WriteLine("Invalid deposit amount.");
            }
        }
    }
}
