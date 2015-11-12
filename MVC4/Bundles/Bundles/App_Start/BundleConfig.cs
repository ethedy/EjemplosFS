using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Optimization;

namespace Bundles
{
  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/scripts")
        .Include(
          "~/Scripts/jquery-{version}.js", 
          "~/Scripts/jquery.validate.js", 
          "~/Scripts/jquery.validate.unobtrusive.js"));
    }
  }
}
