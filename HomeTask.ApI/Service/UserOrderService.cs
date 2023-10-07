namespace HomeTask.ApI.Service
{
    public class UserOrderService
    {
        private readonly UserService _userService;
        private readonly OrderService _orderService;
        public UserOrderService(UserService userService, OrderService orderService)
        {
            this._userService= userService;
            this._orderService = orderService;
        }
        //public List<Order> GetUserOrdersByUserId(int userId)
        //{
        //    var user= _userService
        //}
    }
}
