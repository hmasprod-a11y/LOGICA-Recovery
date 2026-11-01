namespace TODO.Licensing;

// Pure migration decision: legacy activation is never overwritten or silently disabled.
// The host must supply the existing legacy result; this component never reads shop data.
public enum ActivationChannel { Legacy, TodoOffline }
public sealed record ActivationDecision(bool CanStart, ActivationChannel Channel, string Code,
    bool ShouldShowWarning);

public static class ActivationMigration
{
    public static ActivationDecision Evaluate(
        bool legacyActivationAccepted,
        bool explicitTodoOptIn,
        string? todoLicenseJson,
        System.Security.Cryptography.ECDsa trustedPublicKey,
        DateTimeOffset nowUtc,
        string? deviceHash = null,
        DateTimeOffset? lastInvoiceUtc = null)
    {
        // An opted-out shop retains the existing activation flow, including its failures.
        if (!explicitTodoOptIn)
            return new(legacyActivationAccepted, ActivationChannel.Legacy,
                legacyActivationAccepted ? "legacy-valid" : "legacy-rejected", false);

        // A legacy-activated shop must never lose access during optional migration.
        if (string.IsNullOrWhiteSpace(todoLicenseJson))
            return new(legacyActivationAccepted, ActivationChannel.Legacy,
                "todo-license-missing", true);

        var result = OfflineLicensing.Verify(todoLicenseJson, trustedPublicKey, nowUtc,
            deviceHash, lastInvoiceUtc);
        if (result.IsValid)
            return new(true, ActivationChannel.TodoOffline, result.Code,
                result.Code is "clock-warning" or "grace-period");

        return new(legacyActivationAccepted, ActivationChannel.Legacy,
            "todo-" + result.Code + (legacyActivationAccepted ? "-legacy-fallback" : ""),
            true);
    }
}
