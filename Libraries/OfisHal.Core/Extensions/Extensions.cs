using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web.Configuration;
using System.Web.Security;

namespace System
{
    public static class Extensions
    {
#pragma warning disable CS0618
        public static string HashPassword(this string password, FormsAuthPasswordFormat format = FormsAuthPasswordFormat.SHA512) =>
            string.IsNullOrEmpty(password) ? string.Empty : FormsAuthentication.HashPasswordForStoringInConfigFile(password, format.ToString().ToLowerInvariant());
#pragma warning restore CS0618

        public static int GetUserId(this IPrincipal principal)
        {
            if (int.TryParse(new ClaimsPrincipal(principal)?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value, out var id))
                return id;
            return -1;
        }

        public static string GetRole(this IPrincipal principal) => 
            new ClaimsPrincipal(principal)?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;

        public static int? GetValueOrNull(this int? value)
        {
            if (value.HasValue)
                return value.Value;
            return null;
        }
    }
}
