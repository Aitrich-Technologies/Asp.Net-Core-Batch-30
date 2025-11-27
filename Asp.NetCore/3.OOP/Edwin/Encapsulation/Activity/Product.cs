using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    internal class product
    {
        private int id;
        private string name;
        private decimal price;
        private int stockquantity;

        public product(int ID, string Name, decimal Price, int StockQuantity)
        {
           id=ID;
            name=Name;
            price=Price;
            stockquantity=StockQuantity;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be Empty");
            }   }
        }
        public decimal Price
        {
            get{ return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Price cannot be negative");
                }
            }
        }
        public int Stock
        {
            get { return stockquantity;}
            set
            {
                if (value > 0)
                {
                    stockquantity= value;
                }
                else
                {
                    Console.WriteLine("Stock cannot be negative");  
                }
            }
        }
            
        
    }

   
}
