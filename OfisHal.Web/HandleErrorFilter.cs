using Elmah;
using System;
using System.Web;
using System.Web.Mvc;

namespace OfisHal.Web
{
    internal sealed class HandleErrorAttribute : System.Web.Mvc.HandleErrorAttribute
    {
        private static ErrorFilterConfiguration config;

        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);

            if (!context.ExceptionHandled)
                return;

            var e = context.Exception;
            var httpContext = context.HttpContext.ApplicationInstance.Context;

            if (httpContext != null && (RaiseErrorSignal(e, httpContext) || IsFiltered(e, httpContext)))
                return;

            LogException(e, httpContext);
        }

        private static bool RaiseErrorSignal(Exception e, HttpContext context)
        {
            var signal = ErrorSignal.FromContext(context);

            if (signal == null)
                return false;

            signal.Raise(e, context);
            return true;
        }

        private static bool IsFiltered(Exception e, HttpContext context)
        {
            if (config == null)
                config = context.GetSection("elmah/errorFilter") as ErrorFilterConfiguration ?? new ErrorFilterConfiguration();

            var testContext = new ErrorFilterModule.AssertionHelperContext(e, context);
            return config.Assertion.Test(testContext);
        }

        private static void LogException(Exception e, HttpContext context) => ErrorLog.GetDefault(context).Log(new Error(e, context));
    }
}
