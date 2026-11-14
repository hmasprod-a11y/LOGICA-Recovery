using System.IO;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed record LogicaReceiptSettings(string Printer, string Connection, string Template)
{
    // LOGICA loads the workstation printer from PRINTER_CL.sni and the two
    // shared settings from TABLE_PARAMETRES (Form_0_TEMPLATE / Form_3_VENTE).
    internal static LogicaReceiptSettings? Read(MySqlConnection connection, string workstationDirectory)
    {
        var path = Path.Combine(workstationDirectory, "PRINTER_CL.sni");
        if (!File.Exists(path)) return null;

        var printer = File.ReadAllText(path);
        if (printer == "0") return new LogicaReceiptSettings(printer, "", "");

        using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT OBJET, VALEUR FROM TABLE_PARAMETRES
            WHERE BINARY OBJET IN ('BRANCHEMENT', 'MODELE_TICKET')
            """;
        using var rows = command.ExecuteReader();
        string? connectionType = null;
        string? template = null;
        while (rows.Read())
        {
            if (rows.IsDBNull(1)) return null;
            switch (rows.GetString(0))
            {
                case "BRANCHEMENT":
                    if (connectionType is not null) return null;
                    connectionType = rows.GetString(1);
                    break;
                case "MODELE_TICKET":
                    if (template is not null) return null;
                    template = rows.GetString(1);
                    break;
            }
        }

        return connectionType is not null && template is not null
            ? new LogicaReceiptSettings(printer, connectionType, template)
            : null;
    }
}
