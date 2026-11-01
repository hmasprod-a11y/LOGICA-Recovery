using System.Security.Cryptography;
using System.Text.Json;
using TODO.Licensing;

internal static class Program
{
    private static int assertions;
    private static void Check(bool ok, string name)
    {
        assertions++;
        if (!ok) throw new Exception("Licensing regression: " + name);
    }
    private static void Expect(string expected, string document, ECDsa key,
        DateTimeOffset now, string? device = null)
    {
        var result = OfflineLicensing.Verify(document, key, now, device);
        Check(result.Code == expected, expected + " got " + result.Code);
        Check(result.IsValid == (expected == "valid"), "validity flag " + expected);
    }
    private static int Main()
    {
        using var issuer = ECDsa.Create(ECCurve.NamedCurves.nistP256);
        using var wrongIssuer = ECDsa.Create(ECCurve.NamedCurves.nistP256);
        using var publicOnly = ECDsa.Create();
        publicOnly.ImportSubjectPublicKeyInfo(issuer.ExportSubjectPublicKeyInfo(), out _);
        DateTimeOffset now = new(2026, 11, 1, 0, 0, 0, TimeSpan.Zero);
        string device = OfflineLicensing.HashDeviceIdentifier("isolated-device-1");
        var claims = new LicenseClaims(Guid.NewGuid().ToString(), OfflineLicensing.Product,
            "Standard", 1, now.AddDays(-1), now.AddDays(30), device);
        string signed = OfflineLicensing.Issue(claims, issuer);
        Expect("valid", signed, publicOnly, now, device);
        Expect("device-mismatch", signed, publicOnly, now);
        Expect("device-mismatch", signed, publicOnly, now, OfflineLicensing.HashDeviceIdentifier("other"));
        Expect("not-yet-valid", signed, publicOnly, now.AddDays(-2), device);
        Expect("expired", signed, publicOnly, now.AddDays(31), device);
        Expect("untrusted-key", signed, wrongIssuer, now, device);
        Expect("invalid-document", "not json", publicOnly, now);
        Expect("invalid-document", "", publicOnly, now);
        var envelope = JsonSerializer.Deserialize<SignedLicense>(signed)!;
        var altered = envelope with { Payload = Convert.ToBase64String(
            System.Text.Encoding.UTF8.GetBytes("{\"Product\":\"TODO POS 2.0\"}")) };
        Expect("invalid-signature", JsonSerializer.Serialize(altered), publicOnly, now, device);
        Expect("invalid-document", JsonSerializer.Serialize(envelope with { Signature = "!" }),
            publicOnly, now, device);
        Expect("invalid-document", JsonSerializer.Serialize(envelope with { Signature = "" }),
            publicOnly, now, device);
        Expect("untrusted-key", JsonSerializer.Serialize(envelope with { KeyId = "WRONG" }),
            publicOnly, now, device);
        var perpetual = claims with { DeviceHash = null, ExpiresUtc = null };
        Expect("valid", OfflineLicensing.Issue(perpetual, issuer), publicOnly,
            now.AddYears(25));
        foreach (var invalid in new[]
        {
            claims with { Product = "LOGICA" },
            claims with { Seats = 0 },
            claims with { Seats = 1001 },
            claims with { LicenseId = "not-guid" },
            claims with { DeviceHash = "bad" },
            claims with { ExpiresUtc = now.AddDays(-2) },
            claims with { Edition = "" }
        })
        {
            bool rejected = false;
            try { OfflineLicensing.Issue(invalid, issuer); }
            catch (ArgumentException) { rejected = true; }
            Check(rejected, "issuer rejected invalid claims");
        }
        Check(OfflineLicensing.KeyId(issuer) == OfflineLicensing.KeyId(publicOnly),
            "public key identity");
        Check(device == OfflineLicensing.HashDeviceIdentifier("isolated-device-1"),
            "stable fingerprint");
        Console.WriteLine("PASS: " + assertions + " TODO POS offline licensing assertions (no network or shop data)");
        return 0;
    }
}
