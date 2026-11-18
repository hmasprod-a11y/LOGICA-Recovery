using Hanouty.Desktop.Wpf;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class CustomerCreditStatementReader(string connectionString)
{
    // Keep the same inclusive date bounds as the LOGICA credit statement.
    private const string StatementSql = """
        SELECT c.ID_CLIENT, c.CLIENT, c.CREDIT_INITIAL,
               v.TOTAL_CREDIT, v.TOTAL_RETOUR, r.TOTAL_REGLE
        FROM TABLE_CLIENTS c
        LEFT JOIN (
        SELECT ID_CLIENT,
               SUM(CASE WHEN OPERATION = 'CREDIT' THEN TOTAL_NET END) AS TOTAL_CREDIT,
               SUM(CASE WHEN OPERATION = 'RETOUR CREDIT' THEN TOTAL_NET END) AS TOTAL_RETOUR
        FROM TABLE_VENTES_JOURNAL
        WHERE DATES BETWEEN @fromDate AND @toDate AND OPERATION IN ('CREDIT', 'RETOUR CREDIT')
        GROUP BY ID_CLIENT
        ) v ON v.ID_CLIENT = c.ID_CLIENT
        LEFT JOIN (
        SELECT ID_CLIENT, SUM(MONTANT) AS TOTAL_REGLE
        FROM TABLE_CLIENTS_REGLE
        WHERE DATES BETWEEN @fromDate AND @toDate
        GROUP BY ID_CLIENT
        ) r ON r.ID_CLIENT = c.ID_CLIENT
        ORDER BY c.CLIENT ASC
        """;

    public IReadOnlyList<CustomerCreditStatementRow> Read(DateTime from, DateTime to)
    {
        if (from.Date > to.Date)
            throw new ArgumentException("La date de début doit précéder la date de fin.", nameof(from));

        var settings = new MySqlConnectionStringBuilder(connectionString);
        if (settings.Server is not ("127.0.0.1" or "localhost" or "::1"))
            throw new InvalidOperationException("Base MariaDB locale requise.");

        using var connection = new MySqlConnection(connectionString);
        using var command = new MySqlCommand(StatementSql, connection);
        command.Parameters.AddWithValue("@fromDate", from.Date);
        command.Parameters.AddWithValue("@toDate", to.Date);
        connection.Open();
        using var reader = command.ExecuteReader();
        var rows = new List<CustomerCreditStatementRow>();
        while (reader.Read())
        {
            var opening = reader.IsDBNull(2) ? 0m : Conversions.ToDecimal(reader.GetValue(2));
            var credit = ReadRoundedComponent(reader, 3);
            var returns = ReadRoundedComponent(reader, 4);
            var payments = ReadRoundedComponent(reader, 5);
            rows.Add(new CustomerCreditStatementRow(
                Convert.ToString(reader.GetValue(0)) ?? "",
                Convert.ToString(reader.GetValue(1)) ?? "",
                opening, credit, returns, payments,
                credit + returns + opening - payments));
        }
        return rows;
    }

    private static decimal ReadRoundedComponent(MySqlDataReader reader, int index) =>
        Conversions.ToDecimal(Strings.FormatNumber(reader.IsDBNull(index) ? 0 : reader.GetValue(index)));
}
