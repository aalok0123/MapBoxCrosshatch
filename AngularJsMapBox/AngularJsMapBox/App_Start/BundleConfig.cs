using System.Web;
using System.Web.Optimization;

namespace AngularJsMapBox
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                "~/Scripts/spa/app.js",
"~/Scripts/spa/mapBox/mapBoxCtrl.js"
                          ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                       "~/Scripts/angular.js",
                       "~/Scripts/angular-ui-router.js",
                        "~/Scripts/angular-animate.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css"
                      ));

        }
    }
}
