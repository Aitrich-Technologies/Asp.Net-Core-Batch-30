using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    public class ShoppingCart
    {
        private Product[] Products;
        private int count;

        public ShoppingCart(int capacity)
        {
            Products = new Product[capacity];
            count = 0;
        }
        public void AddProudct(Product product)
        {
            if (count < Products.Length)
            {
                Products[count] = product;
                count++;
                Console.WriteLine($"Product '{product.Name}' added to cart.");

            }
            else
            {
                Console.WriteLine("Cart is full! Cannot add more products.");
            }

        }
        public void RemoveProduct(int productId)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                {
                    if (Products[i].Id == productId)

                    {
                        Console.WriteLine($"Product '{Products[i].Name}' removed from cart.");



                        for (int j = i; j < count - 1; j++)
                        {
                            Products[j] = Products[j + 1];
                        }

                        Products[count - 1] = null;
                        count--;
                        found = true;
                        break;

                    }

                }
            }
                    if (!found)
                    {
                        Console.WriteLine("Product not found in cart.");
                    }

                
            

        }
        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            for (int i = 0; i < count; i++)
            {
                total += Products[i].Price;
            }
            return total;
        }
        public void DisplayCartContents()
        {
            Console.WriteLine("\n--- Shopping Cart Contents ---");
            for (int i = 0; i < count; i++)
            {
                Products[i].DisplayInfo();
            }
            Console.WriteLine($"Total Price: {CalculateTotalPrice():C}");
            Console.WriteLine("-------------------------------\n");

        }
    }
}
