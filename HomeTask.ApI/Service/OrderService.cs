namespace HomeTask.ApI.Service
{
    public class OrderService
    {
        private List<Order> _order = new List<Order>();
        public OrderService() 
        {
            _order.Add(new Order { Id = 1, UserId = 123, ProductName = "Kitob" });
            _order.Add(new Order { Id = 2, UserId = 122, ProductName = "Daftar" });
            _order.Add(new Order { Id = 3, UserId = 121, ProductName = "Ruchka" });
            _order.Add(new Order { Id = 4, UserId = 120, ProductName = "Qalam" });
        }
        public void AddOrder(Order order)
        {
            _order.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return _order;
        }

    }
}
