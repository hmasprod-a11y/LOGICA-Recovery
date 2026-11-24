using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

public sealed record PurchaseOrderLineInput(string ArticleId, string Code, string ArticleName, decimal Quantity, decimal UnitPrice);

public sealed record PurchaseOrderSummaryRow(string OrderNumber, string Supplier, DateTime OrderDate, decimal Total, string Status);

internal sealed class PurchaseOrderStore(string connectionString)
{
    public IReadOnlyList<PurchaseOrderSummaryRow> ListOrders(int limit = 100)
    {
        var list = new List<PurchaseOrderSummaryRow>();
        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        using var cmd = new MySqlCommand(
            "SELECT COALESCE(ID_BC,''), COALESCE(FOURNISSEUR,''), DATES, COALESCE(TOTAL_TTC,0), COALESCE(ETAT,'EN COURS') " +
            "FROM TABLE_COMMANDES_ENTETE ORDER BY DATES DESC, ID_BC DESC LIMIT @lim", conn);
        cmd.Parameters.AddWithValue("@lim", limit);
        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            list.Add(new PurchaseOrderSummaryRow(
                r.GetString(0), r.GetString(1), r.GetDateTime(2), Convert.ToDecimal(r.GetValue(3)), r.GetString(4)));
        }
        return list;
    }

    public string CreateOrder(string supplierId, string supplierName, IReadOnlyList<PurchaseOrderLineInput> lines)
    {
        if (string.IsNullOrWhiteSpace(supplierName))
            throw new ArgumentException("Fournisseur obligatoire.", nameof(supplierName));
        if (lines is null || lines.Count == 0)
            throw new ArgumentException("Ajoutez au moins une ligne à la commande.", nameof(lines));

        using var conn = new MySqlConnection(connectionString);
        conn.Open();
        using var tx = conn.BeginTransaction(IsolationLevel.Serializable);

        int nextBc;
        using (var seq = new MySqlCommand("SELECT COALESCE(BC,0) FROM TABLE_NUM WHERE ID = 0 FOR UPDATE", conn, tx))
        {
            nextBc = Convert.ToInt32(seq.ExecuteScalar()) + 1;
        }
        using (var upd = new MySqlCommand("UPDATE TABLE_NUM SET BC = @next WHERE ID = 0", conn, tx))
        {
            upd.Parameters.AddWithValue("@next", nextBc);
            upd.ExecuteNonQuery();
        }

        var orderId = $"BC{nextBc:000000}";
        decimal total = 0m;
        foreach (var l in lines)
        {
            if (l.Quantity <= 0m || l.UnitPrice < 0m)
                throw new ArgumentException("Quantité ou prix invalide sur une ligne de commande.");
            total += l.Quantity * l.UnitPrice;
        }

        using (var insH = new MySqlCommand(
            "INSERT INTO TABLE_COMMANDES_ENTETE (ID_BC, ID_FOURNISSEUR, FOURNISSEUR, DATES, TOTAL_TTC, ETAT) " +
            "VALUES (@id, @supId, @supName, @dt, @tot, 'EN COURS')", conn, tx))
        {
            insH.Parameters.AddWithValue("@id", orderId);
            insH.Parameters.AddWithValue("@supId", supplierId ?? "");
            insH.Parameters.AddWithValue("@supName", supplierName.Trim());
            insH.Parameters.AddWithValue("@dt", DateTime.Now);
            insH.Parameters.AddWithValue("@tot", total);
            insH.ExecuteNonQuery();
        }

        foreach (var l in lines)
        {
            using var insD = new MySqlCommand(
                "INSERT INTO TABLE_COMMANDES_DETAILS (ID_BC, ID_ARTICLE, CODE, ARTICLE, `QTÉ`, PRIX_U, TOTAL) " +
                "VALUES (@id, @artId, @code, @art, @qty, @price, @lineTot)", conn, tx);
            insD.Parameters.AddWithValue("@id", orderId);
            insD.Parameters.AddWithValue("@artId", l.ArticleId);
            insD.Parameters.AddWithValue("@code", l.Code);
            insD.Parameters.AddWithValue("@art", l.ArticleName);
            insD.Parameters.AddWithValue("@qty", l.Quantity);
            insD.Parameters.AddWithValue("@price", l.UnitPrice);
            insD.Parameters.AddWithValue("@lineTot", l.Quantity * l.UnitPrice);
            insD.ExecuteNonQuery();
        }

        tx.Commit();
        return orderId;
    }
}
