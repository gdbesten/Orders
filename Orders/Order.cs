using System.Collections.Generic;
using System.Globalization;

namespace Orders
{
    public class Order
    {
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();    
        }

        public double TotalPrice()
        {
            var total = 0.0;
            foreach (var item in OrderItems)
            {
                if (item.Number == 0)
                    continue;
                total += item.Number*item.Price;
            }
            return total;
        }
    }
}