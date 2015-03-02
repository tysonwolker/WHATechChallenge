using CsvHelper.Configuration;
using RiskAnalysis.Domain.Entities.Bets;

namespace RiskAnalysis.Infrastructure.Data.Repository
{
    public sealed class ResultedBetMapper : CsvClassMap<SettledBet>
    {
        public ResultedBetMapper()
        {
            References<BetMapper>(map => map.Bet);
        }
    }
}