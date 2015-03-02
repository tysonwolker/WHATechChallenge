using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using RiskAnalysis.Domain.Interfaces;
using RiskAnalysis.Infrastructure.Data.Repository;

namespace RiskAnalysis.CompositionRoot
{
    public class BetAnalysisModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BetRepository>().As<IBetRepository>();
        }
    }
}
