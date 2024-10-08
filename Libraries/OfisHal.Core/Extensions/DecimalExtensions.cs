using System.Globalization;

namespace System
{
    public static class DecimalExtensions
    {
        public static decimal ToDecimal(this double value) => Convert.ToDecimal(value.ToString("0.00"));

        public static decimal ToDecimal(this decimal value) => Convert.ToDecimal(value.ToString("0.00"));
        public static decimal ToDecimal(this double? value) => Convert.ToDecimal((value ?? 0).ToString("0.00"));

        public static decimal ToDecimal(this int value) => Convert.ToDecimal(value.ToString("0.00"));

        public static string WriteCurrency(this decimal value) => value.WriteCurrency(2);

        public static string WriteCurrency(this decimal? value) => value.HasValue ? value.Value.WriteCurrency() : string.Empty;

        public static string WriteCurrency(this double value) => ((decimal)value).WriteCurrency(2);

        public static string WriteCurrency(this double? value) => value.HasValue ? value.Value.WriteCurrency() : string.Empty;

        private static string WriteCurrency(this decimal value, int place = 2)
        {
            var currencyCulture = new CultureInfo(Threading.Thread.CurrentThread.CurrentUICulture.Name);
            currencyCulture.NumberFormat.CurrencyPositivePattern = 3;
            return value.ToString($"C{place}", currencyCulture);
        }
    }
}
