using System.Web.Optimization;

namespace HelpmeHunter.Presentacion.Landing
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css").Include(
                "~/Content/animate.css",
                "~/Content/bootstrap.css",
                "~/Content/flexslider.css",
                "~/Content/icomoon.css",
                "~/Content/magnific-popup.css",
                "~/Content/style.css"
                ));

            bundles.Add(new ScriptBundle("~/js").Include(
                "~/Scripts/jquery.min.js",
                "~/Scripts/jquery.easing.1.3.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jquery.waypoints.min.js",
                "~/Scripts/jquery.countTo.js",
                "~/Scripts/jquery.magnific-popup.min.js",
                "~/Scripts/magnific-popup-options.js",
                "~/Scripts/main.js"
                ));
        }
    }
}