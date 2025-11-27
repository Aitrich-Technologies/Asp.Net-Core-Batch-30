    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    internal class Orders:Order
    {
        
            public product[] p = new product[3];
             public int orderid;
             public string customername;
             public DateOnly orderdate;
            public Orders(int OrderId, string CustomerName, DateOnly OrderDate): base(OrderId, CustomerName, OrderDate)
            {
             orderId= OrderId;
            customername= CustomerName;
            orderdate= OrderDate;
            }


            public override decimal CalculateTotal()
            {
                decimal total = 0;
                for (int i = 0; i < p.Length; i++)
                {

                    if (p[i] != null)
                    {
                    total += p[i].Price;
                    }
                }
                return total;
            }


            public void DisplayDetails()
            {
                Console.WriteLine("Products in the order\n");

                for (int i = 0; i < p.Length; i++)
                {


                    if (p[i] is ElectronicProduct ep)
                    {
                        Console.WriteLine($"{ep.Name}: ${ep.Price} (Brand: {ep.brand}, Warranty: {ep.warrentyperiod} years)");
                    }

                    if (p[i] is ClothingProduct cp)
                    {
                        Console.WriteLine($"{cp.Name}: ${cp.Price} (Size: {cp.size}, Material: {cp.material})");
                    }

                }

                Console.WriteLine($"\nOrder Total: ${CalculateTotal()}");
            }
        }   
}
