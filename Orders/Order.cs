using System.Collections.Generic;

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
                total += item.Number*item.Price;
            }
            return total;
        }
    }
}