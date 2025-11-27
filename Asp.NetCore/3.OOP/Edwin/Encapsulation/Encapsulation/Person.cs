using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    Console.WriteLine("Name Cannot be empty.");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age cannot be negative.");
            }
         
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name:{Name},Age:{Age}");
        }
    }

}
