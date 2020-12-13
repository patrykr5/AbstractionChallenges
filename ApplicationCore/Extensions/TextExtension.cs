using System;
using System.Text;

namespace ApplicationCore.Extensions
{
    internal static class TextExtension
    {
        internal static StringBuilder AppendLine(this StringBuilder stringBuilder, object targetObject)
        {
            return stringBuilder.Append(Environment.NewLine + targetObject);
        }
    }
}
