﻿using System.Web;
using System.Web.Optimization;

namespace FBA
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bg/TweenLite.min.js",
                        "~/Scripts/bg/EasyPack.js",
                        "~/Scripts/bg/background.js",
                        "~/Scripts/custom.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"
                      ));
            bundles.Add(new ScriptBundle("~/bundles/reactions").Include(
                      "~/Scripts/reactScript/reactions.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/background/background.css",
                      "~/Content/fontawesome-all.min.css"));
            bundles.Add(new StyleBundle("~/Content/icon").Include(
                      "~/Content/fb-icon.css"
                ));
        }
    }
}
