using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    abstract class Order
    {
        public int orderId;
        public string customerName;
        public DateOnly orderDate;

        public Order(int OrderId,string CustomerName, DateOnly OrderDate)
        {
            orderId=OrderId;
            customerName=CustomerName;
            orderDate=OrderDate;
        }
        public abstract decimal CalculateTotal();
    }
    
}
