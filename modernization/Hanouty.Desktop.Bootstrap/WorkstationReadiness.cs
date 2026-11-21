using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;
internal static class WorkstationReadiness
{
    internal static bool IsReady(CatalogueSettings settings)
    {
        using var db = new MySqlConnection(settings.ConnectionString); db.Open();
        var required = new[] { "TABLE_PASS", "TABLE_ARTICLES", "TABLE_NUM", "TABLE_VENTES_ENTETE", "TABLE_VENTES_JOURNAL", "TABLE_VENTES_REGLEMENTS",
            "hanouty_checkout_operations", "hanouty_cash_return_consumption", "hanouty_purchase_receipt_order", "hanouty_catalogue_price_audit",
            "hanouty_stock_issue_history", "hanouty_client_settlement_operations", "hanouty_supplier_settlement_operations", "hanouty_customer_file_operations",
            "hanouty_return_line_consumption", "hanouty_stock_issue_create_operations" };
        foreach (var table in required)
        {
            using var command = new MySqlCommand("SELECT ENGINE FROM information_schema.TABLES WHERE TABLE_SCHEMA=DATABASE() AND TABLE_NAME=@name", db);
            command.Parameters.AddWithValue("@name", table);
            if (Convert.ToString(command.ExecuteScalar()) != "InnoDB") return false;
        }
        var keys = new[] { "MODELE_TICKET", "BRANCHEMENT", "AFFICHER_MODE_P", "AFFICHER_N_TICKET", "AFFICHER_CODE_BARRE", "PIED_TICKET", "FENETRE_MODE_P" };
        var values = new Dictionary<string, string>(StringComparer.Ordinal);
        using (var command = new MySqlCommand("SELECT OBJET,VALEUR FROM TABLE_PARAMETRES WHERE UPPER(OBJET) IN ('MODELE_TICKET','BRANCHEMENT','AFFICHER_MODE_P','AFFICHER_N_TICKET','AFFICHER_CODE_BARRE','PIED_TICKET','FENETRE_MODE_P')", db))
        using (var rows = command.ExecuteReader())
            while (rows.Read())
                if (rows.IsDBNull(0) || rows.IsDBNull(1) || !keys.Contains(rows.GetString(0), StringComparer.Ordinal) || !values.TryAdd(rows.GetString(0), rows.GetString(1))) return false;
        if (values.Count != keys.Length || string.IsNullOrWhiteSpace(values["MODELE_TICKET"]) || string.IsNullOrWhiteSpace(values["BRANCHEMENT"])) return false;
        try
        {
            foreach (var key in new[] { "AFFICHER_MODE_P", "AFFICHER_N_TICKET", "AFFICHER_CODE_BARRE", "FENETRE_MODE_P" })
                _ = Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(values[key]);
        }
        catch (Exception ex) when (ex is InvalidCastException or FormatException or OverflowException) { return false; }
        return true;
    }
}
