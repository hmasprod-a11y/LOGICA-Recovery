using System.Drawing;
namespace Hanouty.Desktop.Bootstrap;
internal static class LogicaReceiptRenderer
{
    private const string Separator = "-------------------------------------------";
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
        using var total = new Font("Inconsolata ExtraBold", 16, FontStyle.Bold);
        using var format = new StringFormat(StringFormatFlags.NoClip);
        graphics.DrawImage(logo, logoBounds);
        graphics.DrawString(Separator, regular, Brushes.Black, 0, headerHeight, format);
        var y = headerHeight + 10;
        foreach (var line in lines)
        {
            graphics.DrawString(line, bold, Brushes.Black, 0, y, format);
            y += 16;
        }
        graphics.DrawString(Separator, regular, Brushes.Black, 0, y, format);
        graphics.DrawString("TOTAL NET: " + (totalAmount + " DH").PadLeft(12), total, Brushes.Black, 0, y + 10, format);
        graphics.DrawString(Separator, regular, Brushes.Black, 0, y + 30, format);
        graphics.DrawString(tail, bold, Brushes.Black, 0, y + 40, format);

    }
}
