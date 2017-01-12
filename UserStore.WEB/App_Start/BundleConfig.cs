﻿using System.Web;
using System.Web.Optimization;

namespace UserStore
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/css/master.css"));

            bundles.Add(new StyleBundle("~/Content/index").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/css/master.css",
                      "~/Content/css/index-page.css"));

            bundles.Add(new StyleBundle("~/Content/contact").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/css/master.css",
                      "~/Content/css/index-page.css",
                      "~/Content/css/contact-page.css"));

            bundles.Add(new StyleBundle("~/Content/article").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/css/master.css",
                      "~/Content/css/articles-page.css"));
        }
    }
}
