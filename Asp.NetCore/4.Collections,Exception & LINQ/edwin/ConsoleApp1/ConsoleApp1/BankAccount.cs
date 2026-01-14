using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        public BankAccount(int accountNumber, string holderName, double Balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = Balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ₹{amount}. New Balance: ₹{Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew ₹{amount}. Remaining Balance: ₹{Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
    }
}
