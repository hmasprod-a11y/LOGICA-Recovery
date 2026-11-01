using System;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Pure, portable eligibility rule: image-mode tiles must represent a real product photo.
    // The caller supplies the filesystem probe; list-mode search remains unfiltered.
    internal static class CheckoutArticleImageSelectionService
    {
        internal static bool IsEligible(string fileName, Func<string, bool> fileExists)
        {
            if (String.IsNullOrWhiteSpace(fileName) ||
                fileName == "." || fileName == ".." ||
                fileName.IndexOfAny(new[] { '/', '\\', ':' }) >= 0 ||
                String.Equals(fileName, "0.png", StringComparison.OrdinalIgnoreCase) ||
                String.Equals(fileName, "0X.png", StringComparison.OrdinalIgnoreCase))
                return false;
            return fileExists(fileName);
        }
    }
}
