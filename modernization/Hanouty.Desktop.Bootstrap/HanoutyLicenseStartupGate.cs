using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;
using Hanouty.Licensing.Core;

namespace Hanouty.Desktop.Bootstrap;

internal static class HanoutyLicenseStartupGate
{
    public static LicenseDecision EvaluateLocalLicense(string dataDirectory, string? deviceFingerprint = null)
    {
        var licensePath = Path.Combine(dataDirectory, "hanouty.license.json");
        var keyPath = Path.Combine(dataDirectory, "hanouty.public.pem");

        if (!File.Exists(licensePath) || !File.Exists(keyPath))
            return new LicenseDecision(LicenseStatus.Grace, "Aucune licence locale installée; mode grâce actif.");

        try
        {
            var json = File.ReadAllText(licensePath);
            var signed = JsonSerializer.Deserialize<SignedLicense>(json);
            if (signed is null)
                return new LicenseDecision(LicenseStatus.Invalid, "Fichier de licence illisible.");

            using var ecdsa = ECDsa.Create();
            ecdsa.ImportFromPem(File.ReadAllText(keyPath));
            return LicenseValidator.Validate(signed, ecdsa, DateTimeOffset.UtcNow, deviceFingerprint);
        }
        catch (Exception ex) when (ex is IOException or JsonException or CryptographicException)
        {
            return new LicenseDecision(LicenseStatus.Invalid, "Erreur de lecture de la licence : " + ex.Message);
        }
    }
}
