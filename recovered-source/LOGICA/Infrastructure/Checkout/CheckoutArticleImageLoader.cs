using System;
using System.Drawing;
using System.IO;
using LOGICA.ApplicationLayer.Checkout;

namespace LOGICA.Infrastructure.Checkout
{
    // Windows-only adapter. Missing, locked and invalid image files never become fake tiles.
    internal static class CheckoutArticleImageLoader
    {
        // Resolve images from an existing shop installation as well as portable ZIP layouts.
        // Never fabricate a tile: Load checks eligibility and reads the actual file.
        internal static Bitmap LoadWithFallback(string shopRoot, string startupPath, string fileName)
        {
            if (String.IsNullOrWhiteSpace(fileName) || fileName == "0")
                return null;

            string[] roots = {
                shopRoot,
                startupPath,
                Path.GetDirectoryName(startupPath ?? ""),
                Path.GetDirectoryName(shopRoot ?? "")
            };
            foreach (string root in roots)
            {
                if (String.IsNullOrWhiteSpace(root))
                    continue;
                foreach (string candidate in new[] {
                    Path.Combine(root, "bd", "images"),
                    Path.Combine(root, "images")
                })
                {
                    Bitmap image = Load(candidate, fileName);
                    if (image != null)
                        return image;
                }
            }
            return null;
        }

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
