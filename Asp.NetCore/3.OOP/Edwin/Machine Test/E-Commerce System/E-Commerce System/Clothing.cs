using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System
{
    internal class Clothing:Product
    {
        public Clothing(int productId, string prodctName,double price):base(productId, prodctName,price) { }


        public override double CalculateDiscount(double price)
        {
            return price * 0.20;
        }
    }
}
