using System.Globalization;
using System.Security.Cryptography;
using TODO.Licensing;

internal static class Program
{
    private static int Main(string[] args)
    {
        try
        {
            if (args.Length == 2 && args[0] == "keygen")
            {
                string privatePath = args[1];
                string publicPath = privatePath + ".pub.pem";
                if (File.Exists(privatePath) || File.Exists(publicPath))
                    throw new InvalidOperationException("Refusing to overwrite an existing key");
                using var key = ECDsa.Create(ECCurve.NamedCurves.nistP256);
                // Never print or commit the private key. Protect it at rest and back it up offline.
                File.WriteAllText(privatePath, key.ExportECPrivateKeyPem());
                if (!OperatingSystem.IsWindows())
                    File.SetUnixFileMode(privatePath, UnixFileMode.UserRead | UnixFileMode.UserWrite);
                File.WriteAllText(publicPath, key.ExportSubjectPublicKeyInfoPem());
                Console.WriteLine("Public key ID: " + OfflineLicensing.KeyId(key));
                Console.WriteLine("Private key stored locally: " + privatePath);
                return 0;
            }
            if ((args.Length == 7 || args.Length == 8) && args[0] == "issue")
            {
                if (File.Exists(args[6]))
                    throw new InvalidOperationException("Refusing to overwrite an existing license");
                using var key = ECDsa.Create();
                key.ImportFromPem(File.ReadAllText(args[1]));
                DateTimeOffset? expiry = null;
                if (args[5] != "never")
                {
                    var date = DateTime.ParseExact(args[5], "yyyy-MM-dd",
                        CultureInfo.InvariantCulture, DateTimeStyles.None);
                    expiry = new DateTimeOffset(DateTime.SpecifyKind(date, DateTimeKind.Utc))
                        .AddDays(1).AddTicks(-1);
                }
                var claims = new LicenseClaims(args[2], OfflineLicensing.Product, args[3],
                    int.Parse(args[4], CultureInfo.InvariantCulture),
                    DateTimeOffset.UtcNow.AddMinutes(-5), expiry,
                    args.Length == 8 ? args[7] : null);
                string license = OfflineLicensing.Issue(claims, key);
                File.WriteAllText(args[6], license);
                Console.WriteLine("Issued license: " + claims.LicenseId);
                return 0;
            }
            if ((args.Length == 3 || args.Length == 4) && args[0] == "verify")
            {
                using var key = ECDsa.Create();
                key.ImportFromPem(File.ReadAllText(args[1]));
                var result = OfflineLicensing.Verify(File.ReadAllText(args[2]), key,
                    DateTimeOffset.UtcNow, args.Length == 4 ? args[3] : null);
                Console.WriteLine(result.Code);
                return result.IsValid ? 0 : 2;
            }
            Console.Error.WriteLine("Usage:");
            Console.Error.WriteLine("  keygen <private-key.pem>");
            Console.Error.WriteLine("  issue <private-key.pem> <license-guid> <edition> <seats> <yyyy-MM-dd|never> <output.license.json> [device-sha256]");
            Console.Error.WriteLine("  verify <public-key.pem> <license.json> [device-sha256]");
            return 1;
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException or
            ArgumentException or FormatException or OverflowException or CryptographicException or
            InvalidOperationException)
        {
            Console.Error.WriteLine("License operation failed: " + e.GetType().Name);
            return 1;
        }
    }
}
