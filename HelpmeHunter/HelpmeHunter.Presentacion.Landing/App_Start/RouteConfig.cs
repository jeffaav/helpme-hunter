using System.Web.Mvc;
using System.Web.Routing;

namespace HelpmeHunter.Presentacion.Landing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //   name: "Index",
            //   url: "",
            //   defaults: new { controller = "Home", action = "Index" }
            //);

            //routes.MapRoute(
            //    name: "Home",
            //    url: "{action}",
            //    defaults: new { controller = "Home" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.LowercaseUrls = true;
        }
    }
}
