using System.Web.Mvc;

namespace OfisHal.Core.Framework.Engines
{
    public class AppRazorViewEngine : RazorViewEngine
    {
        private readonly string _defaultExtensions = "cshtml";

        public AppRazorViewEngine()
        {
            AreaViewLocationFormats = new string[2] { "~/Areas/{2}/Views/{1}/{0}." + _defaultExtensions, "~/Areas/{2}/Views/Shared/{0}." + _defaultExtensions };
            AreaMasterLocationFormats = new string[2] { "~/Areas/{2}/Views/{1}/{0}." + _defaultExtensions, "~/Areas/{2}/Views/Shared/{0}." + _defaultExtensions };
            AreaPartialViewLocationFormats = new string[2] { "~/Areas/{2}/Views/{1}/{0}." + _defaultExtensions, "~/Areas/{2}/Views/Shared/{0}." + _defaultExtensions };

            ViewLocationFormats = new string[2] { "~/Views/{1}/{0}." + _defaultExtensions, "~/Views/Shared/{0}." + _defaultExtensions };
            MasterLocationFormats = new string[2] { "~/Views/{1}/{0}." + _defaultExtensions, "~/Views/Shared/{0}." + _defaultExtensions };
            PartialViewLocationFormats = new string[2] { "~/Views/{1}/{0}." + _defaultExtensions, "~/Views/Shared/{0}." + _defaultExtensions };

            FileExtensions = new string[1] { _defaultExtensions };
        }
    }
}
