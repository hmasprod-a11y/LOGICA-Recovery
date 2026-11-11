using System;
using LOGICA.ApplicationLayer.Checkout;
using MySql.Data.MySqlClient;
using Hanouty.ArchitectureBridge;

namespace LOGICA.Infrastructure.Checkout
{
    // Checkout owns financial authorization and trusted pricing. The caller must
    // supply a production implementation backed by authenticated cashier state
    // and authoritative product/pricing records, NEVER UI-supplied totals.
    internal interface ITrustedCheckoutPostingPreparation
    {
        CheckoutPostingInput Prepare(AuthorizedCheckoutRequest request, MySqlConnection connection, MySqlTransaction transaction);
    }

    // This is the production transaction adapter, not a replacement for the
    // Architecture AuthorizedCheckoutCommitGate. The prepared input uses the
    // existing production stock/ticket/payment writers through one boundary.
    internal sealed class AuthorizedCheckoutMariaDbPort : IAuthorizedCheckoutPort
    {
        private readonly Func<MySqlConnection> createConnection;
        private readonly ITrustedCheckoutPostingPreparation trustedPreparation;

        internal AuthorizedCheckoutMariaDbPort(
            Func<MySqlConnection> createConnection,
            ITrustedCheckoutPostingPreparation trustedPreparation)
        {
            this.createConnection = createConnection ?? throw new ArgumentNullException(nameof(createConnection));
            this.trustedPreparation = trustedPreparation ?? throw new ArgumentNullException(nameof(trustedPreparation));
        }

        public void Commit(AuthorizedCheckoutRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            request.Validate();
            // Do not pretend to support return, credit or non-cash tenders
            // before their financial policy and trusted preparation are wired.
            if (request.Payments.Count != 1 ||
                request.Payments[0].Kind != CheckoutPaymentKind.Cash)
                throw new NotSupportedException("Only authorized single-cash sale or verified full-ticket cash return is enabled.");

            using (MySqlConnection connection = createConnection())
            {
                // Authentication, price read and posting MUST share the same
                // InnoDB snapshot. Preparing before Begin was a TOCTOU risk.
                var boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                bool begun = false;
                bool commitAttempted = false;
                try
                {
                    boundary.Open();
                    boundary.BeginAndBind();
                    begun = true;
                    if (!boundary.TryClaimOperation(request.OperationId))
                    {
                        boundary.Rollback();
                        begun = false;
                        boundary.Close();
                        return; // Gate independently verifies persisted journal.
                    }
                    // Production preparation must use this exact transaction for
                    // authenticated permission + price reads. Never trust the UI.
                    CheckoutPostingInput input = trustedPreparation.Prepare(
                        request, connection, boundary.ActiveTransaction);
                    if (input == null)
                        throw new InvalidOperationException("Trusted preparation returned no posting records.");
                    CheckoutPostingService.Post(boundary, input);
                    commitAttempted = true;
                    boundary.Commit();
                    begun = false;
                    boundary.Close();
                }
                catch
                {
                    // Once Commit was attempted, its outcome is UNKNOWN; never
                    // claim rollback or silently retry. Gate reconciles journal.
                    if (begun && !commitAttempted)
                    {
                        try { boundary.Rollback(); }
                        finally { boundary.Close(); }
                    }
                    throw;
                }
            }
        }
    }
}
