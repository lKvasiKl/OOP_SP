namespace Lab_1
{
    public class Customer
    {
        public int OrderNumber { get; set; } = -1;

        public Order MakeOrder()
        {
            return new Order();
        }
    }
}
