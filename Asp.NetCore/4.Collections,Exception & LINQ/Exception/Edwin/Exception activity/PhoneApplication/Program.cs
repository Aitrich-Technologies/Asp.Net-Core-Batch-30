using PhoneApplication.Exception;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            ValidatePhoneNumber(phoneNumber);
            Console.WriteLine("phone number is valid.");
        }
        catch(Exception ex) 
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    public static void ValidatePhoneNumber(string phoneNumber)
    {
        string pattern= @"^\+?[1-9]\d{9,14}$";

        if(!Regex.IsMatch(pattern, phoneNumber))
        {
            throw new InvalidPhoneNumberException("Invalid phone number format.");
        }
    }
}