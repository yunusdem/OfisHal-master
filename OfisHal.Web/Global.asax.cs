using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Security;

namespace OfisHal.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
        }

        protected void Application_AuthenticateRequest()
        {
            if (Context.User != null)
            {
                if (Context.User.Identity.IsAuthenticated)
                {
                    if (Context.User.Identity is FormsIdentity fi)
                    {
                        var claimsIdentity = new ClaimsIdentity(new FormsIdentity(fi.Ticket));
                        var data = fi.Ticket.UserData.Split('|');

                        if (data.Length > 1)
                        {
                            var id = data.FirstOrDefault();
                            var roleName = data.LastOrDefault();

                            if (!string.IsNullOrWhiteSpace(id))
                                claimsIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, id));

                            if (!string.IsNullOrWhiteSpace(roleName))
                                claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, roleName));
                        }

                        Context.User = new ClaimsPrincipal(claimsIdentity);
                    }
                }
            }
        }
    }
}
