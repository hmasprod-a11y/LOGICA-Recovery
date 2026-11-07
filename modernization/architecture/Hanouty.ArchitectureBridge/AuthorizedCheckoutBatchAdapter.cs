using System;
using System.Collections.Generic;
using System.Linq;

namespace Hanouty.ArchitectureBridge;

// Explicit financial submission seam for an existing CheckoutSession.
// Host must supply authenticated cashier and tender context at payment time;
// selection/staging alone never invokes this adapter.
public sealed record AuthorizedCheckoutPaymentContext(
    string CashierId, string Currency, bool IsReturn,
    IReadOnlyList<CheckoutPayment> Payments, decimal ExpectedTotal);

public sealed class AuthorizedCheckoutBatchAdapter : IAtomicCheckoutBatchPort
{
    private readonly AuthorizedCheckoutCommitGate _gate;
    private readonly Func<AuthorizedCheckoutPaymentContext> _context;

    public AuthorizedCheckoutBatchAdapter(AuthorizedCheckoutCommitGate gate,
        Func<AuthorizedCheckoutPaymentContext> context)
    {
        _gate = gate ?? throw new ArgumentNullException(nameof(gate));
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void AddBatch(IReadOnlyList<CheckoutBatchLine> lines, string operationId)
    {
        ArgumentNullException.ThrowIfNull(lines);
        var payment = _context() ?? throw new InvalidOperationException("Authenticated payment context is required.");
        var request = new AuthorizedCheckoutRequest(operationId, payment.CashierId,
            payment.Currency, payment.IsReturn,
            Array.AsReadOnly(lines.ToArray()),
            Array.AsReadOnly(payment.Payments?.ToArray() ?? Array.Empty<CheckoutPayment>()),
            payment.ExpectedTotal);
        request.Validate();
        var result = _gate.Commit(request);
        if (result == FinancialCommitOutcome.Unknown)
            throw new InvalidOperationException("Financial outcome unknown; reconcile the durable operation ID.");
        // Committed and AlreadyCommitted both require durable journal confirmation.
    }
}
