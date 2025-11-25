using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_sample
{
    abstract class Animal
    {
        public abstract void AnimalSound();
 
    public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
}
