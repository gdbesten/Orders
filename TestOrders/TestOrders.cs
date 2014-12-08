using NUnit.Framework;
using Orders;

namespace TestOrders
{
    [TestFixture]
    public class TestOrders
    {
        [Test]
        public void TestTotalPriceOrders()
        {
            var order = new Order();
            order.OrderItems.Add(new OrderItem{Number = 1, Name = "Item 1", Price = 10.0});

            Assert.AreEqual(10.0, order.TotalPrice());
        }

        [Test]
        public void TestTotalPriceOrdersWithTwoOrderItems()
        {
            var order = new Order();
            order.OrderItems.Add(new OrderItem { Number = 1, Name = "Item 1", Price = 10.0 });
            order.OrderItems.Add(new OrderItem { Number = 5, Name = "Item 2", Price = 5.0 });

            Assert.AreEqual(35.0, order.TotalPrice());
        }
    }
}