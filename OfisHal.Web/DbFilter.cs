using OfisHal.Core;
using OfisHal.Services;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OfisHal.Web
{
    public class DbFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // login sayfasında kuralı uygulama
            if (!CheckRouteData("Login", "Account", filterContext.RouteData))
            {
                var redir = false;

                var currentWorkSpace = DependencyResolver.Current.GetService<ITenantService>()?.GetCurrentWorkSpace();

                if (currentWorkSpace == null)
                {
                    filterContext.HttpContext.Response.RemoveCookie(Constants.WorkSpaceCookieName);
                    redir = true;
                }

                // eğer panel girişte ise işlem olmamalı
                if (redir && CheckRouteData("Index", "Dashboard", filterContext.RouteData))
                    redir = false;

                // eğer yönlendirmeye düşmüşse panel girişe gitmeli
                if (redir)
                    filterContext.Result = new RedirectToRouteResult("Default", new RouteValueDictionary(new { controller = "Dashboard", action = "Index" }));
            }

            base.OnActionExecuting(filterContext);
        }

        private bool CheckRouteData(string action, string controller, RouteData routes) =>
            routes.GetRequiredString("controller").Equals(controller, StringComparison.InvariantCultureIgnoreCase) && routes.GetRequiredString("action").Equals(action, StringComparison.InvariantCultureIgnoreCase);
    }
}
