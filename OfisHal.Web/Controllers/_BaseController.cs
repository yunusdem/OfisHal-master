using System.Net;
using System.Web.Mvc;

namespace OfisHal.Web.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected HttpStatusCodeResult Problem(string message) => new HttpStatusCodeResult(HttpStatusCode.BadRequest, message);

        protected ActionResult RedirectToLocal(string path)
        {
            if (!string.IsNullOrWhiteSpace(path) && Url.IsLocalUrl(path))
                return Redirect(path);
            return RedirectToRoute("Default");
        }
    }
}
