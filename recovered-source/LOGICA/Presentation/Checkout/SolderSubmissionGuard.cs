using System;

namespace LOGICA.Presentation.Checkout
{
    // Desktop-only attempt latch; database idempotency remains Checkout/QA-owned.
    internal sealed class SolderSubmissionGuard
    {
        public bool IsInProgress { get; private set; }
        public bool RequiresReconciliation { get; private set; }

        public bool TryBegin()
        {
            if (IsInProgress || RequiresReconciliation) return false;
            IsInProgress = true;
            return true;
        }

        public void MarkPostingAttempt()
        {
            if (!IsInProgress) throw new InvalidOperationException("No active SOLDER attempt.");
            // Old finalizer cannot distinguish precommit from postcommit exceptions.
            RequiresReconciliation = true;
        }

        public void MarkCompleted()
        {
            if (!IsInProgress || !RequiresReconciliation)
                throw new InvalidOperationException("No posted SOLDER attempt.");
            RequiresReconciliation = false;
        }

        public void EndAttempt()
        {
            IsInProgress = false;
        }
    }
}
