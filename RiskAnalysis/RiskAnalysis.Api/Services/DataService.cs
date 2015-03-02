using System.Web.Configuration;
using RiskAnalysis.Infrastructure.Interfaces;

namespace RiskAnalysis.Api.Services
{
    public class DataService : IDataService
    {
        public string SettledCsv
        {
            get { return @Properties.Settings.Default.SettledCsv; }
        }

        public string UnsettledCsv
        {
            get { return @Properties.Settings.Default.UnsettledCsv; }
        }
    }
}