using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.Domain
{
    internal static class CatalogueRequiredFields
    {
        public static bool IsMissingIdentifier(string value)
        {
            // Code and article use VB Trim; later catalogue fields use different checks.
            return Operators.CompareString(Strings.Trim(value), "", false) == 0;
        }
    }
}
