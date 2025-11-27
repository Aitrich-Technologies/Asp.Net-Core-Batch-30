using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    internal class GroceryProduct:Product
    {
        public DateTime ExpirationDate {  get; set; }


       public GroceryProduct(int id,DateTime expirationDate,string name, decimal price ):base(name,price,id)
        {
            ExpirationDate = expirationDate;
            
        }
        

        public override void DisplayInfo()
        {
            Console.WriteLine("---- Grocery Product ----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Expiration Date: {ExpirationDate.ToShortDateString()}");
            Console.WriteLine();
        }
    }
}
