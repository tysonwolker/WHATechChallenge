namespace RiskAnalysis.Domain.Entities.Bets
{
    public class Bet
    {
        public Customer Customer { get; set; }
        public Event Event { get; set; }
        public Participant Participant { get; set; }
        public decimal Stake { get; set; }
        public decimal Win { get; set; }
    }
}