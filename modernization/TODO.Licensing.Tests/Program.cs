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
        Check(result.IsValid == (expected == "valid" || expected == "clock-warning" || expected == "grace-period"), "validity flag " + expected);
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
        Expect("clock-warning", signed, publicOnly, now.AddDays(-2), device);
        Expect("grace-period", signed, publicOnly, now.AddDays(31), device);
        Expect("expired", signed, publicOnly, now.AddDays(34), device);
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
        Expect("clock-warning", OfflineLicensing.Issue(perpetual, issuer), publicOnly,
            now.AddYears(-10));
        var invoiceWarning = OfflineLicensing.Verify(OfflineLicensing.Issue(perpetual, issuer),
            publicOnly, now, lastInvoiceUtc: now.AddDays(5));
        Check(invoiceWarning.IsValid && invoiceWarning.Code == "clock-warning",
            "perpetual clock rollback after invoice is advisory");
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
        var migrationLicense = OfflineLicensing.Issue(perpetual, issuer);
        var legacyOk = ActivationMigration.Evaluate(true, false, null, publicOnly, now);
        Check(legacyOk.CanStart && legacyOk.Channel == ActivationChannel.Legacy,
            "legacy valid preserved without opt-in");
        var legacyDenied = ActivationMigration.Evaluate(false, false, migrationLicense, publicOnly, now);
        Check(!legacyDenied.CanStart && legacyDenied.Channel == ActivationChannel.Legacy,
            "no silent license migration");
        var migrated = ActivationMigration.Evaluate(false, true, migrationLicense, publicOnly, now);
        Check(migrated.CanStart && migrated.Channel == ActivationChannel.TodoOffline,
            "opt-in signed license accepted");
        var rollback = ActivationMigration.Evaluate(true, true, "tampered", publicOnly, now);
        Check(rollback.CanStart && rollback.Channel == ActivationChannel.Legacy,
            "existing valid legacy activation survives invalid TODO license");
        var rejected = ActivationMigration.Evaluate(false, true, "tampered", publicOnly, now);
        Check(!rejected.CanStart, "no license bypass on invalid TODO and invalid legacy");
        var missing = ActivationMigration.Evaluate(true, true, null, publicOnly, now);
        Check(missing.CanStart && missing.Channel == ActivationChannel.Legacy,
            "missing optional TODO license preserves legacy");
        var clock = ActivationMigration.Evaluate(false, true, migrationLicense, publicOnly,
            now.AddYears(-10));
        Check(clock.CanStart && clock.ShouldShowWarning, "perpetual CMOS reset is nonblocking");
        Console.WriteLine("PASS: " + assertions + " TODO POS offline licensing assertions (no network or shop data)");
        return 0;
    }
}
