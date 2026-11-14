using System;

namespace Hanouty.Inventory.Validation;

// A narrow, non-production write entry gate. No connection may be opened before
// the approved session/actor/capability adapter supplies a verified grant.
// This does not grant permission, open MariaDB or implement a stock writer.
internal static class InventoryValidationWriteGate
{
    internal static T ExecuteAfterAuthorization<T>(
        InventoryValidationRequest request,
        VerifiedInventoryValidationGrant? grant,
        DateTimeOffset now,
        Func<T> openConnectionAndExecute)
    {
        // Check the capability before invoking the delegate, including when
        // the caller supplied a null delegate. This is intentional fail-closed order.
        InventoryValidationBoundary.DemandVerifiedGrant(request, grant, now);
        if (openConnectionAndExecute is null)
            throw new ArgumentNullException(nameof(openConnectionAndExecute));
        return openConnectionAndExecute();
    }
}
