using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
    internal class Shopingcart
    {
       
        public class ShoppingCart
        {
            private List<Items> items = new List<Items>();

            public void AddItem(Items item)
            {
                items.Add(item);
                Console.WriteLine("Item added successfully!");
            }

            public void RemoveItem(string itemName)
            {
                Items item = items.Find(i => i.Name.ToLower() == itemName.ToLower());

                if (item == null)
                    throw new ApplicationException("Item not found in the cart!");

                items.Remove(item);
                Console.WriteLine("Item removed successfully!");
            }

            public double CalculateTotal()
            {
                double total = 0;
                foreach (var item in items)
                    total += item.Price * item.Quantity;

                return total;
            }

            public double ApplyDiscount(double percentage)
            {
                if (percentage < 0 || percentage > 100)
                    throw new ArgumentException("Discount must be 0–100");

                double total = CalculateTotal();
                double discountAmount = total * (percentage / 100);
                double finalAmount = total - discountAmount;

                if (finalAmount < 0)
                    finalAmount = 0;

                return finalAmount;
            }
        }
    }

}

