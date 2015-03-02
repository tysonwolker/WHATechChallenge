using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RiskAnalysis.Domain.Entities.Bets;
using RiskAnalysis.Domain.Interfaces;

namespace RiskAnalysis.Api.Controllers
{
    public class ResultedBetController : ApiController
    {
        private readonly IBetRepository _betRepository;
        public ResultedBetController(IBetRepository betRepository)
        {
            _betRepository = betRepository;
        }
        public IEnumerable<SettledBet> Get()
        {
            return _betRepository.GetSettledBets();
        }
    }
}
