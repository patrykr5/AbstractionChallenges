namespace ApplicationCore.Extensions
{
    internal static class TextExtension
    {
        internal static string ToJoinString(this int[] targetObject)
        {
            return "[" + string.Join(", ", targetObject) + "]";
        }
    }
}
