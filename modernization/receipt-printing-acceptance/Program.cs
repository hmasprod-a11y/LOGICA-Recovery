using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using Hanouty.Desktop.Bootstrap;

internal static class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        int assertions = 0;
        void Check(bool ok, string name) { if (!ok) throw new Exception(name); assertions++; }
        LogicaPostedTicket Ticket(params LogicaTicketLine[] lines) => new("000042", "2026-11-18", "TEST", "01", "VENTE", "", lines.Sum(x => x.Net), lines, [new("ESPECES", lines.Sum(x => x.Net))]);
        var discounted = Ticket(new LogicaTicketLine("Cafe", 2m, 10m, 99m, 18m), new("Sucre", .5m, 20m, 0m, 9m));
        foreach (var culture in new[] { "fr-FR", "en-US" })
        {
            var configured = (CultureInfo)CultureInfo.GetCultureInfo(culture).Clone(); configured.NumberFormat.NumberDecimalDigits = 2; CultureInfo.CurrentCulture = configured;
            string decimalMark = culture == "fr-FR" ? "," : ".";
            var summary = LogicaReceiptSummary.Format(discounted);
            Check(summary.StartsWith("* Nbr Articles: 2"+decimalMark+"5\r\n\r\n"), "fractional quantity sum, not row count");
            Check(summary.Contains("    3"+decimalMark+"00 DH / 10"+decimalMark+"00 %"), "gross/net savings, independent of discount percentage column");
            Check(!LogicaReceiptSummary.Format(Ticket(new LogicaTicketLine("Zero", 0, 0, 0, 0))).Contains("REMISE"), "zero gross without division");
            Check(!LogicaReceiptSummary.Format(Ticket(new LogicaTicketLine("Normal", 3, 10, 20, 30))).Contains("REMISE"), "no savings despite nonzero percentage field");
            Check(!LogicaReceiptSummary.Format(Ticket(new LogicaTicketLine("Higher net", 1, 10, 0, 11))).Contains("REMISE"), "negative savings omitted as in LOGICA");
            Check(LogicaReceiptSummary.Format(Ticket(new LogicaTicketLine("One", 1, 3, 0, 2))).Contains("33"+decimalMark+"33 %"), "percentage rounding");
            Check(!discounted.FormatFrenchThreeColumnIdentity(false).Any(x => x.Contains("TICKET")), "hidden ticket identity preserved");
            Check(discounted.FormatFrenchThreeColumnCashPayment(x => x.ToString("0.00"))[1].Contains("0"+decimalMark+"00 DH"), "cash change preserved");
        }
        try { LogicaReceiptSummary.Format(Ticket(new LogicaTicketLine("Invalid", 1, 0, 0, -1))); throw new Exception("Expected invalid gross rejection"); }
        catch (InvalidOperationException) { assertions++; }
        var previewCulture = (CultureInfo)CultureInfo.GetCultureInfo("fr-FR").Clone(); previewCulture.NumberFormat.NumberDecimalDigits = 2; CultureInfo.CurrentCulture = previewCulture;
        var output = Path.GetFullPath(args.Length > 0 ? args[0] : "evidence");
        Directory.CreateDirectory(output);
        string Amount(decimal n) => n.ToString("0.00");
        var tail = LogicaReceiptSummary.Format(discounted) + string.Join("\r\n", discounted.FormatFrenchThreeColumnCashPayment(Amount).Concat(discounted.FormatFrenchThreeColumnIdentity(true))) + "\r\nMerci de votre visite\r\n18/11/2026 08:00:00(1)";
        var png = Path.Combine(output, "receipt-summary.png");
        foreach (var width in new[] { 304, 420 })
        using (var surface = new Bitmap(width, 300))
        using (var graphics = Graphics.FromImage(surface))
        foreach (var amount in new[] { "21.60", "9999999999999.99" })
        {
            var text = "TOTAL NET: " + (amount + " DH").PadLeft(12);
            using var fitted = LogicaReceiptRenderer.FitTotalFont(graphics, text);
            Check(graphics.MeasureString(text, fitted).Width <= width && fitted.Size <= 16f,
                "whole total and currency fit narrow receipt with Windows font fallback");
        }
        using (var bitmap = new Bitmap(420, 650))
        using (var graphics = Graphics.FromImage(bitmap))
        {
            graphics.Clear(Color.White);
            LogicaReceiptRenderer.Draw(graphics, discounted.FormatFrenchThreeColumnLines(n => n.ToString("0.###"), Amount).ToArray(), Amount(discounted.Total), tail);
            bitmap.Save(png, ImageFormat.Png);
        }
        var returned = new LogicaPostedTicket("000043", "2026-11-18", "TEST", "01", "RETOUR REMBOURSEMENT", "", -18m,
            [new("Cafe", -2m, 10m, 10m, -18m)], [new("ESPECES", -18m)]);
        Check(returned.FormatFrenchThreeColumnPayment(Amount).Count == 0, "return receipt omits sale tender and change");
        using (var qr = LogicaReceiptQr.Create("d30b8f0644a34849a138e8ab37bf8c68"))
        using (var bitmap = new Bitmap(304, 750))
        using (var graphics = Graphics.FromImage(bitmap))
        {
            Check(qr.Width > 0 && qr.Width < 260 && qr.Width == qr.Height, "canonical operation QR fits original receipt width");
            graphics.Clear(Color.White);
            LogicaReceiptRenderer.Draw(graphics, returned.FormatFrenchThreeColumnLines(n => n.ToString("0.###"), Amount).ToArray(),
                Amount(returned.Total), LogicaReceiptSummary.Format(returned) + string.Join("\r\n", returned.FormatFrenchThreeColumnIdentity(true)), qr, returned.Operation);
            bitmap.Save(Path.Combine(output, "receipt-return-qr.png"), ImageFormat.Png);
            Check(bitmap.GetPixel(1, 1).ToArgb() == Color.Black.ToArgb(), "return operation uses original black header");
        }
        foreach (var invalid in new[] { "", "\nforged", new string('x', 65) })
        {
            try { using var unexpected = LogicaReceiptQr.Create(invalid); throw new Exception("Expected invalid QR identity rejection"); }
            catch (InvalidOperationException) { assertions++; }
        }
        File.WriteAllText(Path.Combine(output,"result.txt"), $"PASS {assertions} assertions. Production sale and return renderer PNGs generated. Synthetic persisted-ticket-shaped data; no database write, spooler or physical printer tested.\n");
        Console.WriteLine($"PASS {assertions} assertions; {png}");
        if (args.Contains("--show"))
        {
            var image = new System.Windows.Controls.Image { Source = new BitmapImage(new Uri(png)), Stretch = System.Windows.Media.Stretch.None };
            new Application().Run(new Window { Title = "LOGICA FR_3C — synthetic rendering acceptance", Width = 470, Height = 730, Content = image });
        }
    }
}



