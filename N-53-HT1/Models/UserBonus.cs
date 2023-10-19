namespace N_53_HT1.Models
{
    public class UserBonus
    {
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public Guid BonusId { get; set; }
    }
}
