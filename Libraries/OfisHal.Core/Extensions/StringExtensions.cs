using System.Text;
using System.Text.RegularExpressions;

namespace System
{
    public static class StringExtensions
    {
        public static string ToSlug(this string phrase)
        {
            var str = phrase.RemoveAccent().ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 250 ? str.Length : 250).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }

        public static bool IsLike(this string text, string pattern, bool caseSensitive = false)
        {
            pattern = pattern.Replace(".", @"\.");
            pattern = pattern.Replace("?", ".");
            pattern = pattern.Replace("*", ".*?");
            pattern = pattern.Replace(@"\", @"\\");
            pattern = pattern.Replace(" ", @"\s");
            return new Regex(pattern, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase).IsMatch(text);
        }

        private static string RemoveAccent(this string txt) => Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(txt));

        public static string Truncate(this string value, int maxLength) => Truncate(value, maxLength, string.Empty);

		public static string Truncate(this string value, int maxLength, string suffix = "…") =>
            value?.Length > maxLength ? value.Substring(0, maxLength) + suffix : value;

        public static string ReplaceFirst(this string value, char replacedChar)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            value = value.Remove(0, 1);

            return string.Concat(replacedChar, value);
        }
    }
}
