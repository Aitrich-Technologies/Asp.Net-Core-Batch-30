using BankAccounts.Exception;
using BankAccounts.Model;

class Program
{
    static void Main(string[] args)
    {
        BankAccount acc = new BankAccount("clerin", 12345678, 10000);

        Console.WriteLine($"Welcome:{acc.Name}");
        Console.WriteLine($"your current balance: {acc.Balance}");

        Console.Write("Enter amount to withdraw");

        try
        {
            double amount = Convert.ToDouble(Console.ReadLine());
            acc.WithDraw(amount);
            Console.WriteLine($"Withdrawal successful! new balance: {acc.Balance}");

        }
        catch(InSufficientFundException ex)
        {
            Console.WriteLine("error: "+ ex.Message);
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine("error:" + ex.Message);

        }
        catch(FormatException ex)
        {
            Console.WriteLine("Error: Please enter a valid numeric amount.");
            
        }
    }
}
