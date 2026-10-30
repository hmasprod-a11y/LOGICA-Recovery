using Microsoft.VisualBasic.CompilerServices;
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
        internal static string FirstWarning(IClientSettlementValidationContext context)
        {
            if (Operators.CompareString(context.ClientId, "", false) == 0)
                return "Veuillez remplir le champ -ID_CLIENT- ";
            if (Operators.CompareString(context.ClientName, "", false) == 0)
                return "Veuillez remplir le champ -CLIENT- ";
            if (Operators.CompareString(context.Amount, "", false) == 0)
                return "Veuillez remplir le champ -MONTANT- ";
            if (ClientSettlementAmountRule.IsRejected(context.Amount))
                return "Veuillez remplir le champ -MONTANT- ";
            if (Operators.CompareString(context.PaymentMode, "", false) == 0)
                return "Veuillez remplir le champ -MODE_P- ";
            return null;
        }
    }
}
