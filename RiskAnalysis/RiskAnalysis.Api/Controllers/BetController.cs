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
    public class BetController : ApiController
    {
        private readonly IBetRepository _betRepository;
        public BetController(IBetRepository betRepository)
        {
            _betRepository = betRepository;
        }
        public IEnumerable<Bet> Get()
        {
            return _betRepository.GetUnsettledBets();
        }
    }
}
