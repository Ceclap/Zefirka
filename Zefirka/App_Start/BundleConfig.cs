using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Zefirka.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles").Include(
                                       "~/Content/js/login.js",
                                       "~/Content/js/main.js"));
            bundles.Add(new StyleBundle("~/bundles/css/login").Include(
                                       "~/Content/css/login.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles").Include(
                                       "~/Content/css/style.css", new CssRewriteUrlTransform()));
            
        }
    }
}