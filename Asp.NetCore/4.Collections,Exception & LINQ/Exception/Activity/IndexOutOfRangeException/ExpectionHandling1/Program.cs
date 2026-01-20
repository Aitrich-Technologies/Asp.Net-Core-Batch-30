// See https://aka.ms/new-console-template for more information
using System;

namespace ExpectionHandling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //indexoutof range exception
            try
            {
                string[] pets = { "Dog,cat,parrot" };
                Console.WriteLine(pets[10]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("exception occured");
            }
            finally
            {
                Console.WriteLine("final block executed");
            }
            
        }
    }
}
