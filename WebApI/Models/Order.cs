namespace WebApI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public Order(int id, decimal amount, int userId)
        {
            Id = id;
            Amount = amount;
            UserId = userId;
        }
    }
}
