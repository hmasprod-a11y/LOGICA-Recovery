using System;

namespace LOGICA.ApplicationLayer.Checkout
{
    // Preserves Text_FIND_TextChanged's original length gate and *two* tab reads.
    // The caller owns UI/database work and the original exception handler.
    internal static class CheckoutArticleSearchService
    {
        internal static void Search(
            Func<int> readSearchLength,
            Func<int> readSelectedTab,
            Action searchList,
            Action searchImages)
        {
            checked
            {
                if (readSearchLength() <= 2)
                    return;
                if (readSelectedTab() == 0)
                    searchList();
                else if (readSelectedTab() != 1)
                    return;
                else
                    searchImages();
            }
        }
    }
}
