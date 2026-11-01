using System.Text.Json.Serialization;

namespace Hanouty.Licensing.Core;

public sealed record LicenseFeatures(
    [property: JsonPropertyName("maxRegisters")] int MaxRegisters,
    [property: JsonPropertyName("invoicePrefix")] string InvoicePrefix,
    [property: JsonPropertyName("allowMobileSync")] bool AllowMobileSync);

public sealed record LicensePayload(
    [property: JsonPropertyName("licenseId")] string LicenseId,
    [property: JsonPropertyName("product")] string Product,
    [property: JsonPropertyName("customerName")] string CustomerName,
    [property: JsonPropertyName("licenseType")] string LicenseType,
    [property: JsonPropertyName("issuedAt")] DateTimeOffset IssuedAt,
    [property: JsonPropertyName("expiresAt")] DateTimeOffset? ExpiresAt,
    [property: JsonPropertyName("updatesUntil")] DateTimeOffset? UpdatesUntil,
    [property: JsonPropertyName("deviceFingerprint")] string? DeviceFingerprint,
    [property: JsonPropertyName("features")] LicenseFeatures Features);

public sealed record SignedLicense(
    [property: JsonPropertyName("payload")] LicensePayload Payload,
    [property: JsonPropertyName("signature")] string Signature);
