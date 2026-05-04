using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsm
{
    internal class CompileTimePolymorphism
    {

        public void display()
            {

                    Console.WriteLine("Display method with no parameters.");
            }

        public void display(string message)
        {
            Console.WriteLine("Display method with a message: " + message);
        }


        public void display(string message,int number)
        {
            Console.WriteLine($"Display method with a message: {message} and a number: {number}");
        }
        }
}
