using BankAccount.Exception;
using BankAccount;

internal class Program
{
    public static void Main(string[] args)
    {
        bankAccount account = new bankAccount(1000); 

        
        Console.WriteLine($"Current Balance: {account.Balance}");

        Console.Write("\nEnter amount to withdraw: ");
        string input = Console.ReadLine();

        try
        {
            double amount = double.Parse(input);
            account.Withdraw(amount);

            Console.WriteLine($"\nWithdrawal successful!");
            Console.WriteLine($"Updated Balance: {account.Balance}");
        }
        catch (NegativeValueException ex)
        {
            Console.WriteLine("\nError: " + ex.Message);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("\nError: " + ex.Message);
        }
       
        catch (Exception ex)
        {
            Console.WriteLine("\nUnexpected Error: " + ex.Message);
        }

    }
}
