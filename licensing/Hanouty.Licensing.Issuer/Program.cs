using System.Security.Cryptography;
using System.Text.Json;
using Hanouty.Licensing.Core;

// Local, offline issuer. Private key is never bundled with the POS or printed to stdout.
if (args.Length < 1)
{
    Console.Error.WriteLine("Usage: issuer init <private-key.pem> <public-key.pem> | issue <private-key.pem> <payload.json> <hanouty.license>");
    return 2;
}
try
{
    switch (args[0])
    {
        case "init" when args.Length == 3:
            foreach (var path in args[1..])
                if (File.Exists(path)) throw new IOException("Refusing to overwrite an existing key file.");
            using (var key = ECDsa.Create(ECCurve.NamedCurves.nistP256))
            {
                // Keep the private key on the issuer's trusted, encrypted device.
                using (var privateStream = new FileStream(args[1], FileMode.CreateNew, FileAccess.Write, FileShare.None))
                using (var writer = new StreamWriter(privateStream))
                    writer.Write(key.ExportECPrivateKeyPem());
                File.WriteAllText(args[2], key.ExportSubjectPublicKeyInfoPem());
            }
            Console.WriteLine("Created local signing key pair. Back up private key securely; distribute only public key.");
            return 0;
        case "issue" when args.Length == 4:
            using (var key = ECDsa.Create())
            {
                key.ImportFromPem(File.ReadAllText(args[1]));
                var payload = JsonSerializer.Deserialize<LicensePayload>(File.ReadAllText(args[2]))
                    ?? throw new FormatException("Missing payload.");
                if (payload.Product != "Hanouty.POS" || payload.Features is null ||
                    payload.Features.MaxRegisters < 1 || string.IsNullOrWhiteSpace(payload.LicenseId) ||
                    string.IsNullOrWhiteSpace(payload.CustomerName) ||
                    payload.LicenseType is not ("Lifetime" or "Annual" or "Trial") ||
                    (payload.LicenseType == "Lifetime" && payload.ExpiresAt is not null) ||
                    (payload.LicenseType != "Lifetime" && (payload.ExpiresAt is null || payload.ExpiresAt <= payload.IssuedAt)))
                    throw new FormatException("Invalid license payload.");
                var signed = LicenseCryptography.Generate(payload, key);
                using var output = new FileStream(args[3], FileMode.CreateNew, FileAccess.Write, FileShare.None);
                using var writer = new StreamWriter(output);
                writer.Write(LicenseCryptography.Serialize(signed));
            }
            Console.WriteLine("Signed offline license created.");
            return 0;
        default:
            Console.Error.WriteLine("Invalid command or argument count.");
            return 2;
    }
}
catch (Exception ex)
{
    Console.Error.WriteLine("License issuance failed: " + ex.GetType().Name + ": " + ex.Message);
    return 1;
}
