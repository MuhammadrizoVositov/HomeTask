


using N45_HT_1;
using System.Threading.Tasks.Dataflow;

var users=new List<User>();
{
    new User(1, "Mirzohid");
    new User(1, "Bobirjon");
    new User(1, "Abdurahmon");
    new User(1, "Bunyod");
}
var ordering=new List<Order>();
{
    new Order(1, 2000, 5);
    new Order(2, 2045, 6);
    new Order(5, 2322, 3);
    new Order(7, 2555, 2);
}
var orderproducts = new List<OrderProduct>()
{
    new OrderProduct { Count=1,Id=2,OrderId=2,ProductId=9},
    new OrderProduct { Count=4,Id=3,OrderId=5,ProductId=88},
    new OrderProduct { Count=6,Id=4,OrderId=3,ProductId=56},
    new OrderProduct { Count=2,Id=4,OrderId=1,ProductId=44},
};
var products = new List<Product>()
{
    new Product(1,"nimagap",122),
    new Product(1,"kompyuter",125),
    new Product(1,"Ipad",127),
    new Product(1,"Phone",124),
};

var query =
    from user in users
    join order in ordering on user.Id equals order.UserId
    join orderProduct in orderproducts on order.Id equals orderProduct.OrderId
    join product in products on orderProduct.ProductId equals product.Id
    select new
    {
        UserId = user.Id,
        ProductId = product.Id,
        OrderId = order.Id,
        OrderProductId = orderProduct.Id

    };
