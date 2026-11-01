using System.Security.Cryptography;

namespace Hanouty.Licensing.Core;

public enum LicenseStatus { Valid, Warning, Grace, Expired, Invalid }

public sealed record LicenseDecision(LicenseStatus Status, string Reason)
{
    public bool MaySell => Status is LicenseStatus.Valid or LicenseStatus.Warning or LicenseStatus.Grace;
}

public static class LicenseValidator
{
    // lastInvoiceUtc is observational only: it never becomes a blocking clock authority.
    public static LicenseDecision Validate(SignedLicense license, ECDsa trustedPublicKey,
        DateTimeOffset nowUtc, string? deviceFingerprint, DateTimeOffset? lastInvoiceUtc = null,
        TimeSpan? gracePeriod = null)
    {
        if (!LicenseCryptography.Verify(license, trustedPublicKey))
            return new(LicenseStatus.Invalid, "Invalid digital signature.");
        var p = license.Payload;
        if (p.Product != "Hanouty.POS" || string.IsNullOrWhiteSpace(p.LicenseId) ||
            string.IsNullOrWhiteSpace(p.CustomerName) || p.Features is null ||
            p.Features.MaxRegisters < 1 || p.Features.InvoicePrefix is null)
            return new(LicenseStatus.Invalid, "Invalid license fields.");
        if (!string.IsNullOrEmpty(p.DeviceFingerprint) &&
            !string.Equals(p.DeviceFingerprint, deviceFingerprint, StringComparison.Ordinal))
            return new(LicenseStatus.Invalid, "License belongs to another device.");
        if (p.LicenseType == "Lifetime")
        {
            if (p.ExpiresAt is not null)
                return new(LicenseStatus.Invalid, "Lifetime license must not expire.");
            // Never stop checkout because of CMOS resets, time drift or invoice dates.
            return lastInvoiceUtc.HasValue && nowUtc < lastInvoiceUtc.Value
                ? new(LicenseStatus.Warning, "Computer clock predates the last invoice; sales remain enabled.")
                : new(LicenseStatus.Valid, "Lifetime license valid.");
        }
        if (p.LicenseType is not ("Annual" or "Trial") || p.ExpiresAt is null ||
            p.ExpiresAt <= p.IssuedAt)
            return new(LicenseStatus.Invalid, "Invalid time-limited license.");
        var grace = gracePeriod ?? TimeSpan.FromHours(72);
        if (grace < TimeSpan.Zero || grace > TimeSpan.FromDays(7))
            throw new ArgumentOutOfRangeException(nameof(gracePeriod));
        if (nowUtc < p.IssuedAt)
            return new(LicenseStatus.Warning, "Computer clock is earlier than issuance; sales remain enabled.");
        if (nowUtc <= p.ExpiresAt.Value)
            return lastInvoiceUtc.HasValue && nowUtc < lastInvoiceUtc.Value
                ? new(LicenseStatus.Warning, "Computer clock predates the last invoice; sales remain enabled.")
                : new(LicenseStatus.Valid, "License valid.");
        if (nowUtc <= p.ExpiresAt.Value.Add(grace))
            return new(LicenseStatus.Grace, "License expired; grace period active.");
        return new(LicenseStatus.Expired, "License expired after grace period.");
    }
}
