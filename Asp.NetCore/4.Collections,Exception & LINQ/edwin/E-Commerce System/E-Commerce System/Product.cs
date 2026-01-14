using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System
{
    abstract class Product
    {
        public int ProductId {  get; set; }

        public string ProductName {  get; set; }

        public double Price {  get; set; }
        

        public Product(int productId, string productName,double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
           

            
        }
        public abstract  double CalculateDiscount(double price);
    }
}
