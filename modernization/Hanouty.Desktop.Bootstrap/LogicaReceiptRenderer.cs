using System.Drawing;
namespace Hanouty.Desktop.Bootstrap;
internal static class LogicaReceiptRenderer
{
    private const string Separator = "-------------------------------------------";
    internal static Font FitTotalFont(Graphics graphics, string text)
    {
        using var original = new Font("Inconsolata ExtraBold", 16, FontStyle.Bold);
        var available = graphics.VisibleClipBounds.Width - 2f;
        if (available <= 0f) throw new InvalidOperationException("Largeur d’impression du ticket indisponible.");
        var measured = graphics.MeasureString(text, original).Width;
        var scale = Math.Min(1f, available / Math.Max(measured, 1f));
        return new Font(original.Name, original.Size * scale, original.Style, original.Unit);
    }
    internal static void Draw(Graphics graphics, string[] lines, string totalAmount, string tail)
    {
        using var logoStream = typeof(LogicaReceiptRenderer).Assembly.GetManifestResourceStream("LogicaReceiptLogo.jpg")
            ?? throw new InvalidOperationException("Logo LOGICA introuvable.");
        using var logo = Image.FromStream(logoStream);
        // Picture_LOGO.Location/Size and Panel_LOGO.Size in LOGICA.Form_3_VENTE.resx.
        var logoBounds = new Rectangle(3, 2, 258, 52);
        const int headerHeight = 58;

        using var regular = new Font("Inconsolata Condensed", 11);
        using var bold = new Font("Inconsolata Condensed", 11, FontStyle.Bold);
        var totalText = "TOTAL NET: " + (totalAmount + " DH").PadLeft(12);
        using var total = FitTotalFont(graphics, totalText);
        using var format = new StringFormat(StringFormatFlags.NoClip);
        graphics.DrawImage(logo, logoBounds);
        graphics.DrawString(Separator, regular, Brushes.Black, 0, headerHeight, format);
        var separatorHeight = Math.Max(10f, regular.GetHeight(graphics) + 1f);
        var articleHeight = Math.Max(16f, bold.GetHeight(graphics) + 1f);
        var y = headerHeight + separatorHeight;
        foreach (var line in lines)
        {
            graphics.DrawString(line, bold, Brushes.Black, 0, y, format);
            y += articleHeight;
        }
        graphics.DrawString(Separator, regular, Brushes.Black, 0, y, format);
        var totalY = y + separatorHeight;
        graphics.DrawString(totalText, total, Brushes.Black, 0, totalY, format);
        // Preserve the original order/spacing when its font is available. A
        // Windows fallback font must not clip DH or strike through the total.
        var separatorY = Math.Max(y + 30f, totalY + total.GetHeight(graphics) + 2f);
        graphics.DrawString(Separator, regular, Brushes.Black, 0, separatorY, format);
        graphics.DrawString(tail, bold, Brushes.Black, 0, separatorY + separatorHeight, format);

    }
}
