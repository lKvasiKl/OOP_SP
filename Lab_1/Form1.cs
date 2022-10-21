using System.Collections.Concurrent;

namespace Lab_1
{
    public partial class Lab_1 : Form
    {
        private int _customerArrivalTimeInterval;
        private int _orderFulfilmentTimeInterval;
        private CancellationTokenSource source = new CancellationTokenSource();

        public Lab_1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (source.IsCancellationRequested)
            {
                source.Dispose();
                source = new CancellationTokenSource();
            }

            _customerArrivalTimeInterval = (int)arrivalTimeUpDown.Value;
            _orderFulfilmentTimeInterval = (int)fulfilmentTimeUpDown.Value;
            var cancelationToken = source.Token;
            RestaurantManager.PresentationEditor ??= new PresentationEditor(this);
            RestaurantManager.Start(cancelationToken, _orderFulfilmentTimeInterval, _customerArrivalTimeInterval);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            source.Cancel();
        }

        public void SetCurrentOrderNumberTextBoxText(string orderNumber)
        {
            Action action = new(() => currentOrderNumberTextBox.Text = orderNumber);
            currentOrderNumberTextBox.Invoke(action);
        }

        public void SetOrderLineTextBoxText(string count)
        {
            Action action = new(() => orderLineTextBox.Text = count);
            orderLineTextBox.Invoke(action);
        }

        public void SetWaitingCustomersNumberTextBoxText(string count)
        {
            Action action = new(() => waitingCustomersNumberTextBox.Text = count);
            waitingCustomersNumberTextBox.Invoke(action);
        }

        public void SetOrderAvailableForPickupTextBoxText(string orderNumber)
        {
            Action action = new(() => orderAvailableForPickupTextBox.Text = orderNumber);
            orderAvailableForPickupTextBox.Invoke(action);
        }

        public void SetOredersAmountTextBoxText(string amount)
        {
            Action action = new(() => oredersAmountTextBox.Text = amount);
            oredersAmountTextBox.Invoke(action);
        }

        public void SetPreparingOrderTextBoxText(string orderNumber)
        {
            Action action = new(() => preparingOrderTextBox.Text = orderNumber);
            preparingOrderTextBox.Invoke(action);
        }

        public void SetOrderNumberGridView(BlockingCollection<Order> ordersToCook)
        {
            Action action = new(() =>
            {
                orderNumberGridView.Rows.Clear();
                foreach (var order in ordersToCook)
                {
                    orderNumberGridView.Rows.Add(order.Number.ToString());
                }
            });

            orderNumberGridView.Invoke(action);
        }
    }
}