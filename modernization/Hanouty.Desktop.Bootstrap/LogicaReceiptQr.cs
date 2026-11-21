using System.Drawing;
using System.IO;
using QRCoder;

namespace Hanouty.Desktop.Bootstrap;
internal static class LogicaReceiptQr
{
    // LOGICA encodes Text_ID_TICKET, not a URL or the displayed ticket number.
    internal static Bitmap Create(string originalId)
    {
        if (string.IsNullOrWhiteSpace(originalId) || originalId.Length > 64 || originalId.Any(char.IsControl))
            throw new InvalidOperationException("Identité du ticket invalide pour le QR.");
        using var data = QRCodeGenerator.GenerateQrCode(originalId, QRCodeGenerator.ECCLevel.L);
        using var renderer = new PngByteQRCode(data);
        using var stream = new MemoryStream(renderer.GetGraphic(2));
        using var image = Image.FromStream(stream);
        return new Bitmap(image);
    }
}
