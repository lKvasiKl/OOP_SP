using System.Collections.Concurrent;

namespace Lab_1
{
    public interface IPresentationEditor
    {
        public void SetNumberOfCusomersWaitingToPlaceOrder(int count);

        public void SetCurrentlyTakingOrderNumber(int orderNumber);

        public void SetOrderNumberAvailableToPickup(int orderNumber);

        public void SetNumberOfCustomersWaitingInTheServiceLine(int count);

        public void SetPreparingOrderNumber(int orderNumber);

        public void SetOrdersAmount(int amount);

        public void UpdateOrderNumberDataGrid(BlockingCollection<Order> ordersToCook);

    }
}
