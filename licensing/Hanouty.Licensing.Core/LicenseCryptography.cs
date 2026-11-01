using System.Security.Cryptography;
using System.Text.Json;

namespace Hanouty.Licensing.Core;

public static class LicenseCryptography
{
    // Fixed JSON property order is part of the v1 wire format. Never sign arbitrary input JSON.
    // Any future schema or canonicalization change requires a new protocol version.
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = false,
        PropertyNamingPolicy = null
    };

    public static byte[] CanonicalPayload(LicensePayload payload) =>
        JsonSerializer.SerializeToUtf8Bytes(payload, JsonOptions);

    public static string Serialize(SignedLicense license) =>
        JsonSerializer.Serialize(license, JsonOptions);

    public static SignedLicense Parse(string json) =>
        JsonSerializer.Deserialize<SignedLicense>(json, JsonOptions)
        ?? throw new FormatException("Empty license document.");

    public static SignedLicense Generate(LicensePayload payload, ECDsa privateKey)
    {
        ArgumentNullException.ThrowIfNull(payload);
        ArgumentNullException.ThrowIfNull(privateKey);
        if (privateKey.KeySize != 256) throw new ArgumentException("ECDSA P-256 key required.", nameof(privateKey));
        var signature = privateKey.SignData(CanonicalPayload(payload), HashAlgorithmName.SHA256,
            DSASignatureFormat.Rfc3279DerSequence);
        return new SignedLicense(payload, Convert.ToBase64String(signature));
    }

    public static bool Verify(SignedLicense license, ECDsa publicKey)
    {
        ArgumentNullException.ThrowIfNull(publicKey);
        if (license?.Payload is null || string.IsNullOrWhiteSpace(license.Signature) || publicKey.KeySize != 256)
            return false;
        try
        {
            return publicKey.VerifyData(CanonicalPayload(license.Payload),
                Convert.FromBase64String(license.Signature), HashAlgorithmName.SHA256,
                DSASignatureFormat.Rfc3279DerSequence);
        }
        catch (FormatException) { return false; }
        catch (CryptographicException) { return false; }
    }
}
