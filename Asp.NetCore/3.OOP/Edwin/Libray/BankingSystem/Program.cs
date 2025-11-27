using BankingSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount acc1 = new SavingsAccount(101, "Alice", 5000);
        BankAccount ac2 = new CurrentAccount(102, "Bob", 2000);
        LoanAccount loan = new HomeLoan(103, "Vishnu", 100000);

        acc1.Withdraw(6000);
        ac2.Withdraw(6000);

        Console.WriteLine($"Alice Balance: {acc1.GetBalance()}");
        Console.WriteLine($"Bob Balance: {ac2.GetBalance()}");
        Console.WriteLine($"Vishnu Loan Interest: {loan.CalculateInterest()}");
    }
}