using System;
using Hanouty.ArchitectureBridge;

namespace Hanouty.Desktop.Wpf.Presentation;

// The existing production host calls this only after it has constructed the
// approved Checkout transaction preparation, posting gate and durable journal.
// No default credentials, database, demo submission or second host is created.
public static class AuthorizedWpfServiceRegistration
{
    public static (ICatalogueReader Catalogue, IProductSelection Checkout, ICheckoutSubmission Submission)
        Create(ICatalogueReader catalogue, IProductSelection selection,
            ITrustedWpfCheckoutPreparation trustedPreparation,
            AuthorizedCheckoutCommitGate gate, ICheckoutOperationJournal journal)
    {
        ArgumentNullException.ThrowIfNull(catalogue);
        ArgumentNullException.ThrowIfNull(selection);
        ArgumentNullException.ThrowIfNull(trustedPreparation);
        ArgumentNullException.ThrowIfNull(gate);
        ArgumentNullException.ThrowIfNull(journal);
        var submission = new AuthorizedWpfCheckoutAdapter(trustedPreparation, gate, journal);
        return (catalogue, selection, submission);
    }
}
