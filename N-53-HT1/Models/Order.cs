using Microsoft.AspNetCore.SignalR;

namespace N_53_HT1.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
    }
}
