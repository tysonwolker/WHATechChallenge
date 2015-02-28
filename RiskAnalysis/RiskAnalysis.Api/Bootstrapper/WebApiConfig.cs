using System.Collections;
using System.Web.Http;

namespace RiskAnalysis.Api.Bootstrapper
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            Routes.Register(config);
            CompositionRoot.Register(config);
        }
    }
}
