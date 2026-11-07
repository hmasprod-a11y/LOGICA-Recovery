using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Inventory.MariaDb;

/// <summary>Read-only, WPF-facing inventory snapshot. Financial stock changes belong to Checkout.</summary>
public sealed record InventorySnapshot(string ArticleId, string Barcode, decimal Stock,
    decimal SalePrice, decimal PurchasePrice);

public interface IInventorySnapshotReader
{
    InventorySnapshot ReadArticle(string articleId);
    IReadOnlyList<InventorySnapshot> FindBarcode(string barcode);
    InventorySnapshot ReadUniqueBarcode(string barcode);
    IReadOnlyList<InventorySnapshot> FindStockBelow(decimal threshold);
}

/// <summary>
/// Reads authoritative V1 article values from local MariaDB without inferring a variant
/// from grid order. No write access or permission grant is exposed to the UI.
/// </summary>
public sealed class MariaDbInventorySnapshotReader : IInventorySnapshotReader
{
    private readonly string _connectionString;

    public MariaDbInventorySnapshotReader(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentException("Local MariaDB connection is required.", nameof(connectionString));
        var endpoint = new MySqlConnectionStringBuilder(connectionString);
        if (!string.Equals(endpoint.Server, "localhost", StringComparison.OrdinalIgnoreCase) &&
            !string.Equals(endpoint.Server, "127.0.0.1", StringComparison.OrdinalIgnoreCase) &&
            !string.Equals(endpoint.Server, "::1", StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Inventory snapshots require local MariaDB.");
        _connectionString = connectionString;
    }

    public InventorySnapshot ReadArticle(string articleId)
    {
        if (string.IsNullOrWhiteSpace(articleId))
            throw new ArgumentException("Stable article identity is required.", nameof(articleId));
        var rows = Read("BINARY ID_ARTICLE = BINARY @value", articleId);
        if (rows.Count != 1)
            throw new InvalidOperationException("Article identity is missing or ambiguous.");
        return rows[0];
    }

    public IReadOnlyList<InventorySnapshot> FindBarcode(string barcode)
    {
        if (string.IsNullOrWhiteSpace(barcode))
            throw new ArgumentException("Nonempty barcode required; blank codes are not identities.", nameof(barcode));
        return Read("BINARY Code = BINARY @value", barcode);
    }

    /// <summary>Resolve a scan only when exactly one durable article matches; never pick the first variant.</summary>
    public InventorySnapshot ReadUniqueBarcode(string barcode)
    {
        var matches = FindBarcode(barcode);
        if (matches.Count != 1)
            throw new InvalidOperationException("Barcode is missing or ambiguous; select an explicit article.");
        return matches[0];
    }

    /// <summary>Live, read-only low-stock query for WPF inventory review; never modifies stock.</summary>
    public IReadOnlyList<InventorySnapshot> FindStockBelow(decimal threshold)
    {
        if (threshold < 0)
            throw new ArgumentOutOfRangeException(nameof(threshold), "Stock threshold cannot be negative.");
        return Read("STOCK < @threshold", "@threshold", threshold);
    }

    private List<InventorySnapshot> Read(string predicate, string value)
        => Read(predicate, "@value", value);

    private List<InventorySnapshot> Read(string predicate, string parameterName, object value)
    {
        var rows = new List<InventorySnapshot>();
        var identities = new HashSet<string>(StringComparer.Ordinal);
        using var connection = new MySqlConnection(_connectionString);
        connection.Open();
        using var command = new MySqlCommand(
            "SELECT ID_ARTICLE, Code, STOCK, PRIX_V_1, Prix_A FROM TABLE_ARTICLES WHERE " + predicate,
            connection);
        command.CommandType = CommandType.Text;
        command.Parameters.AddWithValue(parameterName, value);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            string id = reader.IsDBNull(0) ? "" : Convert.ToString(reader.GetValue(0)) ?? "";
            if (string.IsNullOrWhiteSpace(id) || !identities.Add(id))
                throw new InvalidOperationException("Missing or duplicate stable article identity.");
            string barcode = reader.IsDBNull(1) ? "" : Convert.ToString(reader.GetValue(1)) ?? "";
            if (reader.IsDBNull(2) || reader.IsDBNull(3) || reader.IsDBNull(4))
                throw new InvalidOperationException("Inventory stock or prices are missing.");
            decimal stock = Convert.ToDecimal(reader.GetValue(2), System.Globalization.CultureInfo.InvariantCulture);
            decimal sale = Convert.ToDecimal(reader.GetValue(3), System.Globalization.CultureInfo.InvariantCulture);
            decimal purchase = Convert.ToDecimal(reader.GetValue(4), System.Globalization.CultureInfo.InvariantCulture);
            if (sale < 0 || purchase < 0)
                throw new InvalidOperationException("Negative article prices are invalid.");
            rows.Add(new InventorySnapshot(id, barcode, stock, sale, purchase));
        }
        return rows;
    }
}
