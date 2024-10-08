using OfisHal.Core;

namespace System.Web
{
    public static class CookieExtensions
    {
        public static bool ExistsCookie(this HttpRequestBase request, string name)
        {
            name = name.FormatCookieName();
            return request.Cookies.Get(name) != null;
        }

        public static T GetCookie<T>(this HttpRequestBase request, string name)
        {
            name = name.FormatCookieName();

            var value = request.Cookies.Get(name)?.Value;

            if (string.IsNullOrWhiteSpace(value))
                return default;

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public static void AddCookie(this HttpResponseBase response, string name, string value, DateTime? expiry = null)
        {
            name = name.FormatCookieName();

            var cookie = new HttpCookie(name, value);

            if (expiry.HasValue)
                cookie.Expires = expiry.Value;

            response.Cookies.Add(cookie);
        }

        public static void RemoveCookie(this HttpResponseBase response, string name) => response.AddCookie(name, string.Empty, DateTime.Now.AddYears(-1));

        private static string FormatCookieName(this string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            return name.StartsWith(Constants.CookiePrefix, StringComparison.OrdinalIgnoreCase) ? name : string.Concat(Constants.CookiePrefix, name);
        }
    }
}
