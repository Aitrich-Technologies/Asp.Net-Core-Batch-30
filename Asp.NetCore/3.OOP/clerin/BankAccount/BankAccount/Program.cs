using Bank;

public class Program
{
    private static void Main(string[] args)
    {
        BankAccount[] accounts =new BankAccount[]
        {
            new SavingsAccount("1000","Clerin"),
            new CurrentAccount("1001","Peter"),
            new SavingsAccount("1003","Anu")
        };

        double balance1 = 1000,2000,3000;
       

        foreach (BankAccount acc in accounts)
        {
            double interest1 = acc.CalculateInterest(balance1);
            double interest2 = acc.CalculateInterest(balance1);
            double interest3 = acc.CalculateInterest(balance1);



            Console.WriteLine($"Account Number : {acc.AccountNumber}");
            Console.WriteLine($"Holder Name    : {acc.HolderName}");
            Console.WriteLine($"Balance        : {balance1}");
            Console.WriteLine($"Interest       : {interest1}");


           


         
        }
    }
}

