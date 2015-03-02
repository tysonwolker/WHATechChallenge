using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskAnalysis.Domain.Entities.Bets;

namespace RiskAnalysis.Domain.Interfaces
{
    public interface IBetRepository
    {
        IEnumerable<SettledBet> GetSettledBets();
        IEnumerable<Bet> GetUnsettledBets();
    }
}
