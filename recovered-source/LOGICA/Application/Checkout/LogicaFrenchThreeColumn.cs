namespace LOGICA.ApplicationLayer.Checkout;

internal static class LogicaFrenchThreeColumn
{
    // The original CL_FR_3C renderer truncates each field before padding it.
    internal static string Line(string quantity, string article, string amount) =>
        Left(quantity, 7) + Left(article, 27) + " " + Right(amount, 8);

    private static string Left(string text, int width) =>
        text.Length > width ? text.Substring(0, width) : text.PadRight(width);

    private static string Right(string text, int width) =>
        text.Length > width ? text.Substring(0, width) : text.PadLeft(width);
}
