using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using RiskAnalysis.Domain.Entities.Bets;
using RiskAnalysis.Domain.Interfaces;
using RiskAnalysis.Infrastructure.Interfaces;

namespace RiskAnalysis.Infrastructure.Data.Repository
{
    public class BetRepository : IBetRepository
    {
        private readonly IConfigurationService _configurationService;
        private readonly IDataService _dataService;

        public BetRepository(IConfigurationService configurationService, IDataService dataService)
        {
            _configurationService = configurationService;
            _dataService = dataService;
        }

        public IEnumerable<SettledBet> GetSettledBets()
        {
            using (TextReader reader = File.OpenText(_configurationService.DataFilePath + _dataService.SettledCsv))
            {
                var csv = new CsvReader(reader);
                csv.Configuration.RegisterClassMap<ResultedBetMapper>();
                return csv.GetRecords<SettledBet>().ToList();
            }
        }

        public IEnumerable<Bet> GetUnsettledBets()
        {
            using (TextReader reader = File.OpenText(_configurationService.DataFilePath + _dataService.UnsettledCsv))
            {
                var csv = new CsvReader(reader);
                csv.Configuration.RegisterClassMap<BetMapper>();
                return csv.GetRecords<Bet>().ToList();
            }
        }
    }
}
