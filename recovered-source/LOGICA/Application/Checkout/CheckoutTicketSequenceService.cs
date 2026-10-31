using System;
using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Checkout
{
    // The first scalar read is deliberately NOT reused. The original Form executes
    // the SELECT twice unless the first result is DBNull.Value.
    internal interface ICheckoutTicketSequenceSource
    {
        void Prepare();
        object ExecuteScalar();
    }

    internal static class CheckoutTicketSequenceService
    {
        internal static string ReadCurrent(ICheckoutTicketSequenceSource source,
            ILegacyCheckoutTicketSequenceSemantics semantics)
        {
            source.Prepare();
            if (source.ExecuteScalar() == DBNull.Value)
                return semantics.ZeroText();
            return semantics.FormatSequence(semantics.ToDouble(source.ExecuteScalar()));
        }
    }
}
