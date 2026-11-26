using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

public sealed record LowStockAlertRow(string ArticleId, string Code, string Article, decimal Stock, string ModeStock);

public sealed record ExpiryAlertRow(string ReceptionId, string ArticleId, string Code, string Article, DateTime ExpiryDate, decimal Quantity, string LotNumber);

internal sealed class StockAlertsReader(string connectionString)
{
    public IReadOnlyList<LowStockAlertRow> ReadNegativeOrLowStock(decimal threshold = 0m)
    {
        var list = new List<LowStockAlertRow>();
        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        using var cmd = new MySqlCommand(
            "SELECT COALESCE(ID_ARTICLE,''), COALESCE(Code,''), COALESCE(Article,''), COALESCE(STOCK,0), COALESCE(MODE_STOCK,'') " +
            "FROM TABLE_ARTICLES WHERE COALESCE(STOCK,0) <= @threshold AND MODE_STOCK IN ('FINI','MATIERE PREMIERE') " +
            "ORDER BY STOCK ASC, Article ASC LIMIT 250", conn);
        cmd.Parameters.AddWithValue("@threshold", threshold);
        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            list.Add(new LowStockAlertRow(r.GetString(0), r.GetString(1), r.GetString(2), Convert.ToDecimal(r.GetValue(3)), r.GetString(4)));
        }
        return list;
    }

    public IReadOnlyList<ExpiryAlertRow> ReadExpiringLots(DateTime from, DateTime to)
    {
        var list = new List<ExpiryAlertRow>();
        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        using var cmd = new MySqlCommand(
            "SELECT COALESCE(ID_BR,''), COALESCE(ID_ARTICLE,''), COALESCE(CODE,''), COALESCE(ARTICLE,''), DATE_PEREMPTION, COALESCE(`Qté`,0), COALESCE(N_LOT,'') " +
            "FROM TABLE_RECEPTIONS_DETAILS WHERE DATE_PEREMPTION BETWEEN @from AND @to ORDER BY DATE_PEREMPTION ASC LIMIT 250", conn);
        cmd.Parameters.AddWithValue("@from", from.Date);
        cmd.Parameters.AddWithValue("@to", to.Date);
        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            list.Add(new ExpiryAlertRow(
                r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3),
                r.GetDateTime(4), Convert.ToDecimal(r.GetValue(5)), r.GetString(6)));
        }
        return list;
    }
}
