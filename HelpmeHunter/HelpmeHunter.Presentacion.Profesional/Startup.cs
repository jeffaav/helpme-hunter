using Microsoft.Owin;
using Owin;
using System.Web.Routing;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(HelpmeHunter.Presentacion.Profesional.Startup))]

namespace HelpmeHunter.Presentacion.Profesional
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
