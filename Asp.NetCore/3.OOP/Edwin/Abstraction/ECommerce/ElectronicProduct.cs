using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    internal class ElectronicProduct:Product
    {
        public int WarrantyPeriod {  get; set; }

        public ElectronicProduct(int id,int warrantyPeriod, string name, decimal price):base(name,price, id)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("---- Electronic Product ----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"Warranty: {WarrantyPeriod} months");
            Console.WriteLine();
        }
    }
}
