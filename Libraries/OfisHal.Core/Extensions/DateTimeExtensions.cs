using System;

namespace OfisHal.Core.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTimeOffset ToDatetimeOffsetFromUtc(this DateTime date) => new DateTimeOffset(DateTime.SpecifyKind(date, DateTimeKind.Utc));
    }
}
