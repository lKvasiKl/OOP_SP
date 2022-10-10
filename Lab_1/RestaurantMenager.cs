using System.Collections.Concurrent;

namespace Lab_1
{
    public class RestaurantMenager
    {
        private static BlockingCollection<Customer> _customersQueue = new();
        private static BlockingCollection<Order> _ordersToCook = new();
        private static BlockingCollection<Order> _cookedOrders = new();
        private static ConcurrentDictionary<int, Customer> _customersWatingForOrders = new();

        public static void Start(CancellationToken cancellationToken, int orderFulfilmentTimeInterval, int customerArrivalTimeInterval)
        {
            Task orderTakerTask = new(() =>
            {
                var orderTaker = new OrderTaker();
                while (!cancellationToken.IsCancellationRequested)
                {
                    var customer = _customersQueue.Take();
                    Order order = orderTaker.TakeOrder(customer);
                    _ordersToCook.Add(order);
                    _customersWatingForOrders.TryAdd(customer.OrderNumber, customer);
                }
            });

            Task cookTask = new(() =>
            {
                var cook = new Cook(orderFulfilmentTimeInterval);
                while (!cancellationToken.IsCancellationRequested)
                {
                    Order preparedOrder = cook.ProcessOrder(_ordersToCook.Take());
                    _cookedOrders.Add(preparedOrder);
                }
            });

            Task serverTask = new(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    var cookedOrder = _cookedOrders.Take();
                    Customer customer;
                    _customersWatingForOrders.TryGetValue(cookedOrder.Number, out customer);
                    _customersWatingForOrders.TryRemove(cookedOrder.Number, out customer);
                }
            });

            Task custommerArrival = new(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(customerArrivalTimeInterval));
                    Customer newCustomer = new();
                    _customersQueue.Add(newCustomer);
                }
            });

            custommerArrival.Start();
            orderTakerTask.Start();
            cookTask.Start();
            serverTask.Start();
        }
    }
}
