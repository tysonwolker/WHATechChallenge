using System.Web.Configuration;
using RiskAnalysis.Infrastructure.Interfaces;

namespace RiskAnalysis.Api.Services
{
    public class DataService : IDataService
    {
        public string SettledCsv
        {
            get { return @WebConfigurationManager.AppSettings["SettledCsv"]; }
        }

        public string UnsettledCsv
        {
            get { return @WebConfigurationManager.AppSettings["UnsettledCsv"]; }
        }
    }
}