using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Clients
{
    internal interface IClientSettlementValidationContext
    {
        string ClientId { get; }
        string ClientName { get; }
        string Amount { get; }
        string PaymentMode { get; }
    }

    // Exact original Button12_Click guard sequence; returns the original popup text.
    // Re-read Amount for the numeric guard just as the original form does.
    internal static class ClientSettlementValidationService
    {
        internal static string FirstWarning(IClientSettlementValidationContext context, ILegacySettlementSemantics legacy)
        {
            if (legacy.IsEmpty(context.ClientId))
                return "Veuillez remplir le champ -ID_CLIENT- ";
            if (legacy.IsEmpty(context.ClientName))
                return "Veuillez remplir le champ -CLIENT- ";
            if (legacy.IsEmpty(context.Amount))
                return "Veuillez remplir le champ -MONTANT- ";
            if (ClientSettlementAmountRule.IsRejected(context.Amount, legacy))
                return "Veuillez remplir le champ -MONTANT- ";
            if (legacy.IsEmpty(context.PaymentMode))
                return "Veuillez remplir le champ -MODE_P- ";
            return null;
        }
    }
}
