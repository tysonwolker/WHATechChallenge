using System.Web.Configuration;
using RiskAnalysis.Infrastructure.Interfaces;

namespace RiskAnalysis.Api.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public string DataFilePath
        {
            get { return @WebConfigurationManager.AppSettings["DataFilePath"]; }
        }
    }
}