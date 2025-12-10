using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int i,j,k = 0;

        //DivideByZeroException
        try
        {
            Console.WriteLine("Enter first number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            j = Convert.ToInt32(Console.ReadLine());
            k = i / j;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Result is {0} :", k);
        }
    }
}