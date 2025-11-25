using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System
{
    internal class Electronics:Product
    {
        public Electronics(int productId, string productName,double price):base(productId, productName,price) { }

        public override double CalculateDiscount(double price)
        {
            return price * 0.10;
        }
    }

}
