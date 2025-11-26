using BankAccount;

internal class Program
{
    private static void Main(string[] args)
    {
        BankAcount account = new BankAcount(1000);
        account.Deposit(500);
        account.Withdraw(300);
        account.Withdraw(1500);

        Console.WriteLine($"Current Balance: {account.GetBalance()}");

    }
}