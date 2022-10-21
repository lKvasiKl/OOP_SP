using System.Collections.Concurrent;

namespace Lab_1
{
    public class PresentationEditor : IPresentationEditor
    {
        private readonly Lab_1 _form;

        public PresentationEditor(Lab_1 form)
        {
            _form = form;
        }

        public void SetCurrentlyTakingOrderNumber(int orderNumber)
        {
            _form.SetCurrentOrderNumberTextBoxText(orderNumber.ToString());
        }

        public void SetNumberOfCusomersWaitingToPlaceOrder(int count)
        {
            _form.SetOrderLineTextBoxText(count.ToString());
        }

        public void SetNumberOfCustomersWaitingInTheServiceLine(int count)
        {
            _form.SetWaitingCustomersNumberTextBoxText(count.ToString());
        }

        public void SetOrderNumberAvailableToPickup(int orderNumber)
        {
            _form.SetOrderAvailableForPickupTextBoxText(orderNumber.ToString());
        }

        public void SetOrdersAmount(int amount)
        {
            _form.SetOredersAmountTextBoxText(amount.ToString());
        }

        public void SetPreparingOrderNumber(int orderNumber)
        {
            _form.SetPreparingOrderTextBoxText(orderNumber.ToString());
        }

        public void UpdateOrderNumberDataGrid(BlockingCollection<Order> ordersToCook)
        {
            _form.SetOrderNumberGridView(ordersToCook);
        }
    }
}
