using BankAccount.Exception;
using BankAccount.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        BankAccounts account = new BankAccounts()
        {
            Id = 1,
            Name = "Edwin",
            Balance = 5000
        };

        Console.WriteLine("Welcome " + account.Name);
        Console.WriteLine("Current Balance: " + account.Balance);

        try
        {
            Console.WriteLine("Enter amount to withdraw:");
            int amount = Convert.ToInt32(Console.ReadLine());

            if(amount < 0)
            {
                throw new NegativeValueException("Negative amount not allowed!");

            }
            if(amount > account.Balance)
            {
                throw new InsufficientFundsException("Not enough balance to withdraw");
            }
            account.Balance -= amount;

            Console.WriteLine("Withdrawal Success!");
            Console.WriteLine("New Balance: " + account.Balance);

        }
        catch(NegativeValueException ex)
        {
            Console.WriteLine(ex.Message);   
        }
        catch(InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unknown Error: " + ex.Message);
        }
        Console.WriteLine("\nThank you!");

    }
}