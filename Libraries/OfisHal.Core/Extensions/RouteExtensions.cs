namespace System.Web.Routing
{
    public static class RouteExtensions
    {
        public static T GetValue<T>(this RouteData routeData, string key)
        {
            if (routeData != null && !string.IsNullOrWhiteSpace(key))
            {
                var value = Convert.ToString(routeData.Values[key]);

                if (!string.IsNullOrEmpty(value))
                {
                    if (typeof(T).IsEnum)
                        return (T)Enum.Parse(typeof(T), value, true);

                    if (typeof(T) == typeof(bool) && (object)value is int)
                        return (T)Convert.ChangeType(Convert.ToInt32(value), typeof(T));

                    return (T)Convert.ChangeType(value, typeof(T));
                }
            }

            return default;
        }
    }
}
