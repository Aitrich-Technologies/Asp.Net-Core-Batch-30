// See https://aka.ms/new-console-template for more information
using System;

namespace ExpectionHandling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //IndexOutOfRangeException
            try
            {
                string[] pets = { "Dog", "Cat", "Parrot" };
                Console.WriteLine(pets[10]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Exception occured");
            }
            finally
            {
                Console.WriteLine("Final block executed");
            }
=======
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
            
>>>>>>> c65346a8715ef5f84b526c46ede8030b3555f835
        }
    }
}
