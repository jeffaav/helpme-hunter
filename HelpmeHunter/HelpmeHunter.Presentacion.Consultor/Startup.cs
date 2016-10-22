using Microsoft.Owin;
using Owin;
using System.Web.Routing;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(HelpmeHunter.Presentacion.Consultor.Startup))]

namespace HelpmeHunter.Presentacion.Consultor
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
