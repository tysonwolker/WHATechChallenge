using Autofac;
using RiskAnalysis.CompositionRoot;

namespace RiskAnalysis.Api.Bootstrapper
{
    public static class Dependencies
    {
        public static void RegisterDependencies(this ContainerBuilder builder)
        {
            builder.RegisterModule(new BetAnalysisModule());
        }
    }
}