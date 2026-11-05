using System;

namespace LOGICA.Application.Inventory
{
    // Portable authorization boundary; no provider dependency in Application.
    // Infrastructure must validate connection/transaction types and ownership.
    // Authorization remains disabled until an approved persistent grant mapping exists.
    // The session identity and permission must be verified against a trusted,
    // persisted source; neither a UI user label nor a role name is a grant.
    internal interface IManualStockAuthorization
    {
        // Must fail closed on missing/expired sessions, missing/ambiguous grants,
        // connectivity failures and any identity mismatch. Implementations must
        // verify permission in the SAME database transaction as the stock write.
        VerifiedManualStockActor VerifyForWrite(object connection,
            object transaction, string authenticatedSessionId,
            string requestedUserId);
    }

    // Safe default: a missing persisted grant provider must never authorize a write.
    // This is deliberately NOT a fake or hard-coded permission implementation.
    internal sealed class DenyAllManualStockAuthorization : IManualStockAuthorization
    {
        public VerifiedManualStockActor VerifyForWrite(object connection,
            object transaction, string authenticatedSessionId,
            string requestedUserId)
        {
            throw new UnauthorizedAccessException(
                "No verified actor-scoped manual stock permission provider is configured.");
        }
    }

    // Immutable result from a trusted authorization adapter, never from WPF.
    // This type does not itself confer permission; writer integration remains
    // disabled until Architecture approves the real session/grant mapping.
    internal sealed class VerifiedManualStockActor
    {
        internal string UserId { get; private set; }

        internal VerifiedManualStockActor(string userId)
        {
            if (String.IsNullOrWhiteSpace(userId) || userId != userId.Trim())
                throw new UnauthorizedAccessException("Verified manual stock actor identity is missing.");
            foreach (char character in userId)
                if (Char.IsControl(character))
                    throw new UnauthorizedAccessException("Invalid verified manual stock actor identity.");
            UserId = userId;
        }
    }
}
