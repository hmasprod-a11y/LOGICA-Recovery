using System;
using System.Drawing;
using System.IO;
using LOGICA.ApplicationLayer.Checkout;

namespace LOGICA.Infrastructure.Checkout
{
    // Windows-only adapter. Missing, locked and invalid image files never become fake tiles.
    internal static class CheckoutArticleImageLoader
    {
        internal static Bitmap Load(string imageDirectory, string fileName)
        {
            if (!CheckoutArticleImageSelectionService.IsEligible(
                fileName, delegate(string name) { return File.Exists(Path.Combine(imageDirectory, name)); }))
                return null;

            try
            {
                using (var stream = new FileStream(Path.Combine(imageDirectory, fileName),
                    FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    Image source;
                    try { source = Image.FromStream(stream); }
                    // GDI+ reports some invalid image formats as OutOfMemoryException.
                    // Only treat that exception as a bad file at the decoder boundary.
                    catch (OutOfMemoryException) { return null; }
                    using (source)
                        return new Bitmap(source); // Own pixels after closing the file.
                }
            }
            catch (IOException) { return null; }
            catch (UnauthorizedAccessException) { return null; }
            catch (ArgumentException) { return null; }
            catch (System.Runtime.InteropServices.ExternalException) { return null; }
        }
    }
}
