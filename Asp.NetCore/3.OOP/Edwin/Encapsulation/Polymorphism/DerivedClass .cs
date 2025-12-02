using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class DerivedClass:BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("Display method in DerivedClass");
        }

    }
}
