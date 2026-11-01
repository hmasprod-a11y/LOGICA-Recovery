using System.Security.Cryptography;
using System.Text.Json;

namespace TODO.Licensing;

// Isolated proof-of-concept: no dependency on WinForms, database, licensing of the legacy EXE,
// internet access, or a secret embedded in the client. Not yet wired to the working POS.
public sealed record LicenseClaims(
    string LicenseId, string Product, string Edition, int Seats,
    DateTimeOffset NotBeforeUtc, DateTimeOffset? ExpiresUtc, string? DeviceHash);

public sealed record SignedLicense(string KeyId, string Payload, string Signature);
public sealed record LicenseValidationResult(bool IsValid, string Code, LicenseClaims? Claims = null);

public static class OfflineLicensing
{
    public const string Product = "TODO POS 2.0";
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = false,
        MaxDepth = 8
    };

    public static string KeyId(ECDsa key)
    {
        byte[] digest = SHA256.HashData(key.ExportSubjectPublicKeyInfo());
        return Convert.ToHexString(digest.AsSpan(0, 16));
    }

    public static string Issue(LicenseClaims claims, ECDsa privateKey)
    {
        if (privateKey.KeySize != 256) throw new ArgumentException("P-256 key required", nameof(privateKey));
        if (!ValidShape(claims)) throw new ArgumentException("Invalid TODO license claims", nameof(claims));
        byte[] payload = JsonSerializer.SerializeToUtf8Bytes(claims, JsonOptions);
        byte[] signature = privateKey.SignData(payload, HashAlgorithmName.SHA256,
            DSASignatureFormat.IeeeP1363FixedFieldConcatenation);
        return JsonSerializer.Serialize(new SignedLicense(KeyId(privateKey),
            Convert.ToBase64String(payload), Convert.ToBase64String(signature)), JsonOptions);
    }

    public static LicenseValidationResult Verify(
        string licenseJson, ECDsa publicKey, DateTimeOffset nowUtc, string? deviceHash = null,
        DateTimeOffset? lastInvoiceUtc = null)
    {
        if (publicKey.KeySize != 256) return new(false, "invalid-public-key");
        if (string.IsNullOrEmpty(licenseJson) || licenseJson.Length > 32768)
            return new(false, "invalid-document");
        try
        {
            SignedLicense? envelope = JsonSerializer.Deserialize<SignedLicense>(licenseJson, JsonOptions);
            if (envelope is null || envelope.KeyId != KeyId(publicKey) ||
                envelope.Payload is null || envelope.Signature is null)
                return new(false, "untrusted-key");
            byte[] payload = Convert.FromBase64String(envelope.Payload);
            byte[] signature = Convert.FromBase64String(envelope.Signature);
            if (payload.Length == 0 || payload.Length > 8192 || signature.Length != 64)
                return new(false, "invalid-document");
            if (!publicKey.VerifyData(payload, signature, HashAlgorithmName.SHA256,
                DSASignatureFormat.IeeeP1363FixedFieldConcatenation))
                return new(false, "invalid-signature");
            LicenseClaims? claims = JsonSerializer.Deserialize<LicenseClaims>(payload, JsonOptions);
            if (!ValidShape(claims)) return new(false, "invalid-claims");
            
            if (claims.DeviceHash is not null &&
                !string.Equals(claims.DeviceHash, deviceHash, StringComparison.OrdinalIgnoreCase))
                return new(false, "device-mismatch");
            // Clock resets must not disable checkout on a perpetual license.
            // Invoice timestamps are advisory, never a trusted clock or blocking condition.
            if (claims!.ExpiresUtc is null)
                return new(true, nowUtc < claims.NotBeforeUtc ||
                    (lastInvoiceUtc.HasValue && nowUtc < lastInvoiceUtc.Value)
                    ? "clock-warning" : "valid", claims);
            if (nowUtc < claims.NotBeforeUtc ||
                (lastInvoiceUtc.HasValue && nowUtc < lastInvoiceUtc.Value))
                return new(true, "clock-warning", claims);
            if (nowUtc > claims.ExpiresUtc.Value)
            {
                // Fixed offline grace avoids an abrupt checkout stop after an expiry.
                if (nowUtc <= claims.ExpiresUtc.Value.AddHours(72))
                    return new(true, "grace-period", claims);
                return new(false, "expired", claims);
            }
            return new(true, "valid", claims);
        }
        catch (Exception e) when (e is JsonException or FormatException or CryptographicException or ArgumentException or OverflowException)
        {
            return new(false, "invalid-document");
        }
    }

    private static bool ValidShape(LicenseClaims? claims)
    {
        if (claims is null || claims.Product != Product ||
            !Guid.TryParse(claims.LicenseId, out _) ||
            string.IsNullOrWhiteSpace(claims.Edition) || claims.Edition.Length > 64 ||
            claims.Seats < 1 || claims.Seats > 1000 ||
            claims.NotBeforeUtc.Offset != TimeSpan.Zero ||
            (claims.ExpiresUtc.HasValue && (claims.ExpiresUtc.Value.Offset != TimeSpan.Zero ||
                claims.ExpiresUtc.Value < claims.NotBeforeUtc)))
            return false;
        return claims.DeviceHash is null ||
            (claims.DeviceHash.Length == 64 && claims.DeviceHash.All(Uri.IsHexDigit));
    }

    // Callers may hash a user-approved stable machine identifier; never store raw hardware IDs.
    public static string HashDeviceIdentifier(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentException("A nonempty identifier is required", nameof(identifier));
        return Convert.ToHexString(SHA256.HashData(
            System.Text.Encoding.UTF8.GetBytes("TODO-POS-DEVICE-V1:" + identifier)));
    }
}
