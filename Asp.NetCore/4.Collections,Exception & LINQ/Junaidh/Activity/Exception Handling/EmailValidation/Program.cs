using EmailValidation;
using EmailValidation.Exception;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter Email :");
            string Email = Console.ReadLine();
            EmailValidator.ValidateEmail(Email);
            Console.WriteLine("Valid Email.");
        }
        catch(InvalidEmailException ex)
        {
            Console.WriteLine($"Error : {ex.Message}");
        }
    }
}