using Microsoft.Owin;
using Owin;
using System.Web.Routing;
using System.Web.Mvc;
using System.Web.Optimization;

[assembly: OwinStartup(typeof(HelpmeHunter.Presentacion.Landing.Startup))]

namespace HelpmeHunter.Presentacion.Landing
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
