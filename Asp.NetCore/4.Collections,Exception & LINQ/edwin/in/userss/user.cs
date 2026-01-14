using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userss
{
    public  class user
    {
        public int X;

        public user(int x)
        {
                this.X = x;
        }

        public  void Display()
        {
            Console.WriteLine(X);
        }
    }
}
