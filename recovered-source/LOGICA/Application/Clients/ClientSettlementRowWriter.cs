namespace LOGICA.ApplicationLayer.Clients
{
    // Preserves the original Form_5_CLIENTS_REGLE.Button12_Click assignment order.
    // Reads stay lazy: UI getters execute only when their original row assignment is reached.
    internal interface IClientSettlementRowContext
    {
        object ReadId();
        object ReadDate();
        object ReadUser();
        object ReadDocumentId();
        object ReadClientId();
        object ReadClientCode();
        object ReadClientName();
        object ReadAmount();
        object ReadPaymentMode();
        object ReadNotes();
        void Set(string column, object value);
    }

    internal static class ClientSettlementRowWriter
    {
        internal static void Populate(IClientSettlementRowContext context)
        {
            context.Set("ID", context.ReadId());
            context.Set("DATES", context.ReadDate());
            context.Set("UTILISATEUR", context.ReadUser());
            context.Set("ID_REGLE", context.ReadDocumentId());
            context.Set("ID_CLIENT", context.ReadClientId());
            context.Set("CODE_CLIENT", context.ReadClientCode());
            context.Set("CLIENT", context.ReadClientName());
            context.Set("MONTANT", context.ReadAmount());
            context.Set("MODE_P", context.ReadPaymentMode());
            context.Set("NOTES", context.ReadNotes());
            context.Set("ETAT", "VALIDER");
        }
    }
}
