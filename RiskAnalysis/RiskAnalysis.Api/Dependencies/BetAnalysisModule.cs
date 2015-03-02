using Autofac;
using RiskAnalysis.Api.Services;
using RiskAnalysis.Domain.Interfaces;
using RiskAnalysis.Infrastructure.Interfaces;

namespace RiskAnalysis.Api.Dependencies
{
    public class InfrastructureServices : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataService>().As<IDataService>();
            builder.RegisterType<ConfigurationService>().As<IConfigurationService>();
        }
    }
}
