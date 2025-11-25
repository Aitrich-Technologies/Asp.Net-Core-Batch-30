using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    public abstract class Product
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price,int id)
        {
            Name = name;
            Price = price;
            Id=id;

        }

        public abstract void DisplayInfo();
    }
}
