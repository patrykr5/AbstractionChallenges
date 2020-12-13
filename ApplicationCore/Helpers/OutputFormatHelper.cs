using System.Text;

namespace ApplicationCore.Helpers
{
    internal class OutputFormatHelper
    {
        //TODO Added elapsed time
        public static string FormatOutput(StringBuilder builder)
        {
            return " |" + builder.ToString();
        }
    }
}
