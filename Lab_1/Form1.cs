using System.Collections.Concurrent;

namespace Lab_1
{
    public partial class Lab_1 : Form
    {
        private int customerArrivalTimeInterval = 2;
        private int orderFulfilmentTimeInterval = 2;

        public Lab_1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var cancelationToken = new CancellationToken();
            RestaurantMenager.Start(cancelationToken, orderFulfilmentTimeInterval, customerArrivalTimeInterval);
        }
    }
}