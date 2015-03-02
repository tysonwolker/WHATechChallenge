using CsvHelper.Configuration;
using RiskAnalysis.Domain.Entities.Bets;

namespace RiskAnalysis.Infrastructure.Data.Repository
{
    public sealed class BetMapper : CsvClassMap<Bet>
    {
        public BetMapper()
        {
            References<CustomerMapper>(map => map.Customer);
            References<EventMapper>(map => map.Event);
            References<ParticipantMapper>(map => map.Participant);
            Map(map => map.Stake).Index(3);
            Map(map => map.Win).Index(4);
        }
    }
}