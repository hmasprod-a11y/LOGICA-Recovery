using System.Security.Cryptography;
using Hanouty.Licensing.Core;

static void Assert(bool condition, string message)
{
    if (!condition) throw new Exception(message);
}
using var key = ECDsa.Create(ECCurve.NamedCurves.nistP256);
using var publicKey = ECDsa.Create();
publicKey.ImportSubjectPublicKeyInfo(key.ExportSubjectPublicKeyInfo(), out _);
var issued = new DateTimeOffset(2026, 11, 1, 10, 0, 0, TimeSpan.Zero);
var payload = new LicensePayload("HNT-2026-000142", "Hanouty.POS", "Al Baraka", "Lifetime",
    issued, null, issued.AddYears(1), "device-A", new LicenseFeatures(1, "ALB-", false));
var signed = LicenseCryptography.Generate(payload, key);
var roundTrip = LicenseCryptography.Parse(LicenseCryptography.Serialize(signed));
Assert(LicenseCryptography.Verify(roundTrip, publicKey), "Roundtrip signature failed");
Assert(LicenseValidator.Validate(roundTrip, publicKey, issued.AddDays(-300), "device-A", issued.AddDays(10)).MaySell,
    "Lifetime checkout blocked by CMOS rollback");
Assert(LicenseValidator.Validate(roundTrip, publicKey, issued.AddDays(-300), "device-A", issued.AddDays(10)).Status == LicenseStatus.Warning,
    "Expected nonblocking clock warning");
Assert(!LicenseValidator.Validate(roundTrip, publicKey, issued, "wrong-device").MaySell, "Device mismatch accepted");
Assert(!LicenseValidator.Validate(roundTrip with { Payload = payload with { CustomerName = "Tampered" } },
    publicKey, issued, "device-A").MaySell, "Tampered payload accepted");
Assert(!LicenseValidator.Validate(roundTrip with { Signature = "not base64" }, publicKey, issued, "device-A").MaySell,
    "Malformed signature accepted");
var annual = LicenseCryptography.Generate(payload with
{
    LicenseType = "Annual", ExpiresAt = issued.AddDays(365)
}, key);
Assert(LicenseValidator.Validate(annual, publicKey, issued.AddDays(366), "device-A").Status == LicenseStatus.Grace,
    "Grace period missing");
Assert(!LicenseValidator.Validate(annual, publicKey, issued.AddDays(370), "device-A").MaySell,
    "Expired license accepted");
Assert(LicenseValidator.Validate(annual, publicKey, issued.AddDays(-10), "device-A").MaySell,
    "CMOS rollback blocked checkout");
var farFuture = LicenseCryptography.Generate(payload with { LicenseType = "Annual", ExpiresAt = DateTimeOffset.MaxValue }, key);
Assert(LicenseValidator.Validate(farFuture, publicKey, issued, "device-A").Status == LicenseStatus.Valid,
    "Maximum expiry date must not overflow");
Assert(LicenseValidator.Validate(annual, publicKey, issued.AddDays(365).AddHours(72), "device-A").Status == LicenseStatus.Grace,
    "Grace boundary should be inclusive");
Assert(LicenseValidator.Validate(annual, publicKey, issued.AddDays(365).AddHours(72).AddTicks(1), "device-A").Status == LicenseStatus.Expired,
    "Grace must end after its boundary");
using var otherKey = ECDsa.Create(ECCurve.NamedCurves.nistP256);
Assert(!LicenseCryptography.Verify(roundTrip, otherKey), "Wrong public key accepted");
Console.WriteLine("PASS: Hanouty offline license signing, tamper, device, lifetime clock drift and annual grace.");
