using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using RiskAnalysis.Domain.Entities.Bets;
using RiskAnalysis.Domain.Interfaces;

namespace RiskAnalysis.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
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
