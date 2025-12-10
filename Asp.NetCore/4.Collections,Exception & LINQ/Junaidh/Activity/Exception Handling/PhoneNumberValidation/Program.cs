using PhoneNumberValidation;
using PhoneNumberValidation.Exception;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter Phone Number:");
            string PhoneNumber = Console.ReadLine();

            ValidatePhoneNumber(PhoneNumber);
            Console.WriteLine("PhoneNumber is valid .");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
    }
    public static void ValidatePhoneNumber(string phoneNumber)
    {
        
        string pattern = @"^\+?[1-9]\d{9,14}$";
        if (!Regex.IsMatch(phoneNumber, pattern))
        {
            throw new InvalidPhoneNumberException("Invalid phone number format.");
        }
    }
}