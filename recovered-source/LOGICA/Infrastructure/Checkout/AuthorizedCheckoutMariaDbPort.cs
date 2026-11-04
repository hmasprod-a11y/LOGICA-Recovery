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
        CheckoutPostingInput Prepare(AuthorizedCheckoutRequest request, MySqlConnection connection);
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
            if (request.IsReturn || request.Payments.Count != 1 ||
                request.Payments[0].Kind != CheckoutPaymentKind.Cash)
                throw new NotSupportedException("Only authorized cash sales are enabled.");

            using (MySqlConnection connection = createConnection())
            {
                // Prepare is required to verify cashier authority, recalculate
                // totals and produce real posting records. No fallback exists.
                CheckoutPostingInput input = trustedPreparation.Prepare(request, connection);
                if (input == null)
                    throw new InvalidOperationException("Trusted checkout preparation returned no posting records.");
                var boundary = new MySqlCheckoutAtomicPostingBoundary(connection);
                var progress = new CheckoutCommitProgress();
                // Claim, stock, ticket, payment and completion share one InnoDB
                // transaction. Commit exceptions remain UNKNOWN to the caller;
                // Architecture's gate reconciles through the durable journal.
                CheckoutAtomicPostingResult result =
                    CheckoutAtomicPostingService.Execute(boundary, input, request.OperationId, progress);
                if (result == CheckoutAtomicPostingResult.AlreadyCommitted)
                    return; // The gate verifies the durable journal before reporting success.
            }
        }
    }
}
