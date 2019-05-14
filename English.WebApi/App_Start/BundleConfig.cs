using System.Web;
using System.Web.Optimization;

namespace English.WebApi
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css",
            //          "~/Content/index .css"));
            bundles.Add(new ScriptBundle("~/bundles/scripts_system")
                         .IncludeDirectory("~/Scripts/System", "*.js", true));
            bundles.Add(new ScriptBundle("~/bundles/scripts_client")
                         .IncludeDirectory("~/Scripts/Client", "*.js", true));
            bundles.Add(new ScriptBundle("~/bundles/scripts_admin")
                         .IncludeDirectory("~/Scripts/System", "*.js", true));
            bundles.Add(new StyleBundle("~/bundles/css_system")
                    .IncludeDirectory("~/Content/system", "*.css", true));
            bundles.Add(new StyleBundle("~/bundles/css")
                         .IncludeDirectory("~/Content/css", "*.css", true));
            //bundles.Add(new ScriptBundle("~/bundles/css_client")
            //             .IncludeDirectory("~/Content/System", "*.css", true));
        }
    }
}
