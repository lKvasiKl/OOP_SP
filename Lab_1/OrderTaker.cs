using System.Collections.Concurrent;

namespace Lab_1
{
    public class OrderTaker
    {
        private int orderCounter = 0;

        public Order TakeOrder(Customer customer)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            orderCounter++;
            var order = customer.MakeOrder();
            order.Number = orderCounter;
            customer.OrderNumber = orderCounter;

            return order;
        }
    }
}
