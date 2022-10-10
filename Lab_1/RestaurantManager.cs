using System.Collections.Concurrent;

namespace Lab_1
{
    public class RestaurantManager
    {
        private static readonly BlockingCollection<Customer> _customersQueue = new();
        private static readonly BlockingCollection<Order> _ordersToCook = new();
        private static readonly BlockingCollection<Order> _cookedOrders = new();
        private static readonly ConcurrentDictionary<int, Customer> _customersWatingForOrders = new();
        public static IPresentationEditor? PresentationEditor { get; set; }

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
                    PresentationEditor?.SetOrdersAmount(_ordersToCook.Count);
                    _customersWatingForOrders.TryAdd(customer.OrderNumber, customer);
                    PresentationEditor?.SetNumberOfCustomersWaitingInTheServiceLine(_customersWatingForOrders.Count);
                    PresentationEditor?.SetCurrentlyTakingOrderNumber(order.Number);
                    PresentationEditor?.UpdateOrderNumberDataGrid(_ordersToCook);
                }
            });

            Task cookTask = new(() =>
            {
                var cook = new Cook(orderFulfilmentTimeInterval);
                while (!cancellationToken.IsCancellationRequested)
                {
                    Order preparedOrder = _ordersToCook.Take();
                    PresentationEditor?.SetPreparingOrderNumber(preparedOrder.Number);
                    cook.ProcessOrder(preparedOrder);
                    _cookedOrders.Add(preparedOrder);
                    PresentationEditor?.SetOrderNumberAvailableToPickup(preparedOrder.Number);
                    PresentationEditor?.UpdateOrderNumberDataGrid(_ordersToCook);
                }
            });

            Task serverTask = new(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    var cookedOrder = _cookedOrders.Take();
                    _customersWatingForOrders.TryRemove(cookedOrder.Number, out var customer);
                    PresentationEditor?.SetNumberOfCustomersWaitingInTheServiceLine(_customersWatingForOrders.Count);
                }
            });

            Task custommerArrival = new(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(customerArrivalTimeInterval));
                    Customer newCustomer = new();
                    _customersQueue.Add(newCustomer);
                    PresentationEditor?.SetNumberOfCusomersWaitingToPlaceOrder(_customersQueue.Count);
                }
            });

            custommerArrival.Start();
            orderTakerTask.Start();
            cookTask.Start();
            serverTask.Start();
        }
    }
}
