using System.Web.Http;
using RiskAnalysis.Api.Bootstrapper;

namespace RiskAnalysis.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
