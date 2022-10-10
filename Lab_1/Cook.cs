using System.Collections.Concurrent;

namespace Lab_1
{
    public class Cook
    {
        public int OrderFulfilmentTimeInterval { get; init; }

        public Cook(int orderFulfilmentTimeInterval)
        {
            OrderFulfilmentTimeInterval = orderFulfilmentTimeInterval;
        }

        public Order ProcessOrder(Order order)
        {
            Thread.Sleep(TimeSpan.FromSeconds(OrderFulfilmentTimeInterval));
            return order;
        }
    }
}
