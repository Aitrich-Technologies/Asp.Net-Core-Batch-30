using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class CompileTimePolymorphism
    {
        public void Display()
        {
            Console.WriteLine("Display method with no parameters.");
        }
        public void Display(string message)
        {
            Console.WriteLine("Display Method with a message:" + message);
        }
        public void Display(string message,int number)
        {
            Console.WriteLine($"Display metod with a message:{message} and a number:{number}");
        }
    }
}
