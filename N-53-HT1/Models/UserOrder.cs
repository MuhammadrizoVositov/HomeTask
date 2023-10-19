namespace N_53_HT1.Models
{
    public class UserOrder
    {
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public Guid OrderId { get; set; }
    }
}
