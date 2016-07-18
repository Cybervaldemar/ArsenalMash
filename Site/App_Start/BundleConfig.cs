using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Site.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
              "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
              "~/Scripts/jquery-ui-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
              "~/Scripts/jquery.unobtrusive*",
              "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
              "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Themes/Progressus/assets/js").Include(
              "~/Themes/Progressus/assets/js/headroom.min.js",
              "~/Themes/Progressus/assets/js/jQuery.headroom.min.js",
              "~/Themes/Progressus/assets/js/template.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Themes/Progressus/assets/css").Include(
                "~/Themes/Progressus/assets/css/bootstrap-theme.css",
                "~/Themes/Progressus/assets/css/main.css"));
        }
    }
}