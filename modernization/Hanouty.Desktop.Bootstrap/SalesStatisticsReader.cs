using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

public sealed record SalesStatisticsSummary(decimal TotalSalesNet, decimal TotalCost, decimal GrossMargin, int TicketCount);

public sealed record TopSellingArticleRow(string Code, string Article, decimal Quantity, decimal NetTotal);

internal sealed class SalesStatisticsReader(string connectionString)
{
    public SalesStatisticsSummary ReadSummary(DateTime from, DateTime to)
    {
        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        using var cmd = new MySqlCommand(
            "SELECT COALESCE(SUM(TOTAL_NET),0), COALESCE(SUM(COALESCE(PRIX_MP, PRIX_A, 0) * COALESCE(`QTé`,0)),0), COUNT(DISTINCT TICKET) " +
            "FROM TABLE_VENTES_JOURNAL WHERE Dates >= @from AND Dates < @to", conn);
        cmd.Parameters.AddWithValue("@from", from.Date);
        cmd.Parameters.AddWithValue("@to", to.Date.AddDays(1));
        using var r = cmd.ExecuteReader();
        if (!r.Read()) return new(0m, 0m, 0m, 0);
        var net = Convert.ToDecimal(r.GetValue(0));
        var cost = Convert.ToDecimal(r.GetValue(1));
        var count = Convert.ToInt32(r.GetValue(2));
        return new(net, cost, net - cost, count);
    }

    public IReadOnlyList<TopSellingArticleRow> ReadTopArticles(DateTime from, DateTime to, int limit = 50)
    {
        var list = new List<TopSellingArticleRow>();
        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        using var cmd = new MySqlCommand(
            "SELECT COALESCE(Code,''), COALESCE(Article,''), COALESCE(SUM(`QTé`),0), COALESCE(SUM(TOTAL_NET),0) " +
            "FROM TABLE_VENTES_JOURNAL WHERE Dates >= @from AND Dates < @to " +
            "GROUP BY Code, Article ORDER BY SUM(TOTAL_NET) DESC LIMIT @lim", conn);
        cmd.Parameters.AddWithValue("@from", from.Date);
        cmd.Parameters.AddWithValue("@to", to.Date.AddDays(1));
        cmd.Parameters.AddWithValue("@lim", limit);
        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            list.Add(new TopSellingArticleRow(
                r.GetString(0),
                r.GetString(1),
                Convert.ToDecimal(r.GetValue(2)),
                Convert.ToDecimal(r.GetValue(3))));
        }
        return list;
    }
}
