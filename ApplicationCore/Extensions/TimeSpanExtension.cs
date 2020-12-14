using System;

namespace ApplicationCore.Extensions
{
    public static class TimeSpanExtension
    {
        internal static string ToStringExecutionTime(this TimeSpan executionTime)
        {
            return string.Concat("Execution time in ms: ", executionTime.TotalMilliseconds);
        }
    }
}
