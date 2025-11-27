using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    internal class Class
    {
        public string Name;
        public static int Count = 0; 

        public Class(string name)
        {
            Name = name;
            Count++;  
        }

    }
}
