using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
   


        public class Items
        {
            private string name;
            private double price;
            private int quatity;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Price
            {
                get { return price; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Price cannot be negative");
                    price = value;
                }
            }
            public int Quantity
            {
                get { return quatity; }
                set
                {
                    if (value < 1)
                        throw new ArgumentException("Quantity must be at least 1");
                    quatity = value;
                }
            }

            public Items(string name, double price, int quatity)
            {
                Name = name;
                Price = price;
                Quantity = quatity;
            }
        }
    }



