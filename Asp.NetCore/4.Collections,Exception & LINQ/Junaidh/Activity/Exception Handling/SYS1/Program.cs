using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //indexoutRangeException
        //try
        //{
        //    string[] pets = { "Dog", "cat", "goat" };
        //    Console.WriteLine(pets[10]);
        //}
        //catch(IndexOutOfRangeException) 
        //{
        //    Console.WriteLine("Exception is occured");
        //}
        //finally
        //{
        //    Console.WriteLine( "Final block executed");
        //}


        //overflowException
        try
        {
            int i = int.MaxValue;
            int j = checked(i + 1);
            Console.WriteLine(j);
        }
        catch ( OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}