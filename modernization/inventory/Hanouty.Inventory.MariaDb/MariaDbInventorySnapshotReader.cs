using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hanouty.Inventory.MariaDb;

/// <summary>Read-only, WPF-facing inventory snapshot. Financial stock changes belong to Checkout.</summary>
public sealed record InventorySnapshot(string ArticleId, string Barcode, decimal Stock,
    decimal SalePrice, decimal PurchasePrice);

/// <summary>Read-only stocktake totals; not a financial posting or accounting balance.</summary>
public sealed record InventoryStocktakeTotals(int ArticleCount, decimal SignedUnits, decimal PurchaseCostValue, decimal SalePriceValue,
    int PositiveStockArticles, int ZeroStockArticles, int NegativeStockArticles);

/// <summary>Preview-only discrepancy: signed counted-minus-book units and purchase-cost impact. Never posts stock.</summary>
public sealed record InventoryCountDiscrepancy(string ArticleId, decimal BookUnits, decimal CountedUnits,
    decimal DeltaUnits, decimal PurchaseCostDelta);

/// <summary>Read-only aggregate of a physical-count preview; never a posted stock adjustment.</summary>
public sealed record InventoryCountPreviewTotals(int ArticleCount, int ShortageArticles, int SurplusArticles,
    int MatchingArticles, decimal SignedUnitDifference, decimal PurchaseCostDifference);

/// <summary>Read-only supplier replenishment suggestion; not a purchase order or stock mutation.</summary>
public sealed record InventoryReorderSuggestion(string ArticleId, decimal BookUnits, decimal TargetUnits,
    decimal SuggestedUnits, decimal EstimatedPurchaseCost);

public interface IInventorySnapshotReader
{
    InventorySnapshot ReadArticle(string articleId);
    IReadOnlyList<InventorySnapshot> ReadArticlesByIds(IReadOnlyList<string> articleIds);
    IReadOnlyList<InventorySnapshot> ListAll();
    InventoryStocktakeTotals ReadStocktakeTotals();
    InventoryStocktakeTotals ReadStocktakeTotalsForArticles(IReadOnlyList<string> articleIds);
    IReadOnlyList<InventoryCountDiscrepancy> PreviewCountDiscrepancies(IReadOnlyDictionary<string, decimal> countedUnits);
    InventoryCountPreviewTotals PreviewCountTotals(IReadOnlyDictionary<string, decimal> countedUnits);
    IReadOnlyList<InventorySnapshot> FindBarcode(string barcode);
    InventorySnapshot ReadUniqueBarcode(string barcode);
    IReadOnlyList<InventorySnapshot> FindStockBelow(decimal threshold);
    IReadOnlyList<InventorySnapshot> FindStockInRange(decimal minimumInclusive, decimal maximumInclusive);
    IReadOnlyList<InventorySnapshot> FindOutOfStock();
    IReadOnlyList<InventoryReorderSuggestion> PreviewReplenishment(decimal reorderPoint, decimal targetStock);
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

    /// <summary>Full read-only inventory for stocktake and WPF reporting; no sales or adjustment side effects.</summary>
    public IReadOnlyList<InventorySnapshot> ListAll()
        => Read("1 = @all", "@all", 1);

    /// <summary>Compute stocktake totals from one read-only query snapshot, retaining negative stock.</summary>
    public InventoryStocktakeTotals ReadStocktakeTotals()
    {
        return CalculateStocktakeTotals(ListAll());
    }

    /// <summary>Stocktake valuation for an explicitly selected stable-ID batch, never inferred from barcode or grid order.</summary>
    public InventoryStocktakeTotals ReadStocktakeTotalsForArticles(IReadOnlyList<string> articleIds)
        => CalculateStocktakeTotals(ReadArticlesByIds(articleIds));

    /// <summary>Read book quantities by stable ID, reject missing IDs, and calculate a non-posting physical count preview.</summary>
    public IReadOnlyList<InventoryCountDiscrepancy> PreviewCountDiscrepancies(IReadOnlyDictionary<string, decimal> countedUnits)
    {
        if (countedUnits == null) throw new ArgumentNullException(nameof(countedUnits));
        if (countedUnits.Count == 0) return Array.Empty<InventoryCountDiscrepancy>();
        if (countedUnits.Count > 500)
            throw new ArgumentOutOfRangeException(nameof(countedUnits), "Count preview is limited to 500 articles.");
        foreach (var entry in countedUnits)
            if (string.IsNullOrWhiteSpace(entry.Key) || entry.Value < 0)
                throw new ArgumentException("Physical counts require stable IDs and nonnegative quantities.", nameof(countedUnits));
        var ids = new List<string>(countedUnits.Keys);
        var rows = ReadArticlesByIds(ids);
        var discrepancies = new List<InventoryCountDiscrepancy>(rows.Count);
        for (int i = 0; i < rows.Count; i++)
        {
            var row = rows[i];
            // Never let a caller's case-insensitive dictionary alias a distinct durable SQL identity.
            if (!string.Equals(row.ArticleId, ids[i], StringComparison.Ordinal))
                throw new InvalidOperationException("Physical count article identity differs from the requested stable ID.");
            decimal counted = countedUnits[ids[i]];
            decimal delta, impact;
            checked
            {
                delta = counted - row.Stock;
                impact = delta * row.PurchasePrice;
            }
            discrepancies.Add(new InventoryCountDiscrepancy(row.ArticleId, row.Stock, counted, delta, impact));
        }
        return discrepancies;
    }

    /// <summary>Aggregate one physical-count preview without performing a stock mutation or a second SQL read.</summary>
    public InventoryCountPreviewTotals PreviewCountTotals(IReadOnlyDictionary<string, decimal> countedUnits)
    {
        var rows = PreviewCountDiscrepancies(countedUnits);
        int shortages = 0, surpluses = 0, matching = 0;
        decimal units = 0m, cost = 0m;
        foreach (var row in rows)
        {
            if (row.DeltaUnits < 0m) shortages++;
            else if (row.DeltaUnits > 0m) surpluses++;
            else matching++;
            checked
            {
                units += row.DeltaUnits;
                cost += row.PurchaseCostDelta;
            }
        }
        return new InventoryCountPreviewTotals(rows.Count, shortages, surpluses, matching, units, cost);
    }

    private static InventoryStocktakeTotals CalculateStocktakeTotals(IReadOnlyList<InventorySnapshot> rows)
    {
        decimal units = 0m, cost = 0m, sale = 0m;
        int positive = 0, zero = 0, negative = 0;
        foreach (var row in rows)
        {
            if (row.Stock > 0) positive++;
            else if (row.Stock < 0) negative++;
            else zero++;
            checked
            {
                units += row.Stock;
                cost += row.Stock * row.PurchasePrice;
                sale += row.Stock * row.SalePrice;
            }
        }
        return new InventoryStocktakeTotals(rows.Count, units, cost, sale, positive, zero, negative);
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

    /// <summary>Resolve an explicit set of stable article IDs for inventory review; never substitute a barcode or grid index.</summary>
    public IReadOnlyList<InventorySnapshot> ReadArticlesByIds(IReadOnlyList<string> articleIds)
    {
        if (articleIds == null) throw new ArgumentNullException(nameof(articleIds));
        if (articleIds.Count == 0) return Array.Empty<InventorySnapshot>();
        if (articleIds.Count > 500) throw new ArgumentOutOfRangeException(nameof(articleIds), "Batch is limited to 500 article IDs.");
        var unique = new HashSet<string>(StringComparer.Ordinal);
        for (int i = 0; i < articleIds.Count; i++)
            if (string.IsNullOrWhiteSpace(articleIds[i]) || !unique.Add(articleIds[i]))
                throw new ArgumentException("Article IDs must be nonempty and unique.", nameof(articleIds));

        using var connection = new MySqlConnection(_connectionString);
        connection.Open();
        using var command = new MySqlCommand { Connection = connection, CommandType = CommandType.Text };
        var parameters = new List<string>(articleIds.Count);
        for (int i = 0; i < articleIds.Count; i++)
        {
            string name = "@id" + i.ToString(System.Globalization.CultureInfo.InvariantCulture);
            parameters.Add("BINARY " + name);
            command.Parameters.AddWithValue(name, articleIds[i]);
        }
        command.CommandText = "SELECT ID_ARTICLE, Code, STOCK, PRIX_V_1, Prix_A FROM TABLE_ARTICLES WHERE BINARY ID_ARTICLE IN (" + string.Join(",", parameters) + ")";
        var found = new Dictionary<string, InventorySnapshot>(StringComparer.Ordinal);
        var identities = new HashSet<string>(StringComparer.Ordinal);
        using (var reader = command.ExecuteReader())
            while (reader.Read())
            {
                var row = MapSnapshot(reader, identities);
                found.Add(row.ArticleId, row);
            }
        if (found.Count != articleIds.Count)
            throw new InvalidOperationException("Requested article identity is missing or ambiguous.");
        var ordered = new List<InventorySnapshot>(articleIds.Count);
        foreach (var id in articleIds) ordered.Add(found[id]);
        return ordered;
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

    /// <summary>Read all zero or negative stock articles, preserving stable article identities.</summary>
    public IReadOnlyList<InventorySnapshot> FindOutOfStock()
        => Read("STOCK <= @threshold", "@threshold", 0m);

    /// <summary>Calculate read-only purchase quantities for items strictly below a reorder point.</summary>
    public IReadOnlyList<InventoryReorderSuggestion> PreviewReplenishment(decimal reorderPoint, decimal targetStock)
    {
        if (reorderPoint < 0m || targetStock < reorderPoint)
            throw new ArgumentOutOfRangeException(nameof(targetStock), "Reorder target must be at least a nonnegative reorder point.");
        var rows = FindStockBelow(reorderPoint);
        var suggestions = new List<InventoryReorderSuggestion>(rows.Count);
        foreach (var row in rows)
        {
            decimal quantity, cost;
            checked
            {
                quantity = targetStock - row.Stock;
                cost = quantity * row.PurchasePrice;
            }
            if (quantity <= 0m) throw new InvalidOperationException("Invalid replenishment quantity.");
            suggestions.Add(new InventoryReorderSuggestion(row.ArticleId, row.Stock, targetStock, quantity, cost));
        }
        // Supplier review and QA manifests must not depend on MariaDB row enumeration order.
        suggestions.Sort((left, right) => StringComparer.Ordinal.Compare(left.ArticleId, right.ArticleId));
        return suggestions;
    }

    /// <summary>Read a bounded stock interval, including signed historical stock; no mutation or financial writer.</summary>
    public IReadOnlyList<InventorySnapshot> FindStockInRange(decimal minimumInclusive, decimal maximumInclusive)
    {
        if (minimumInclusive > maximumInclusive)
            throw new ArgumentException("Minimum stock must not exceed maximum stock.", nameof(minimumInclusive));
        return ReadStockRange(minimumInclusive, maximumInclusive);
    }

    private List<InventorySnapshot> ReadStockRange(decimal minimum, decimal maximum)
    {
        var rows = new List<InventorySnapshot>();
        var identities = new HashSet<string>(StringComparer.Ordinal);
        using var connection = new MySqlConnection(_connectionString);
        connection.Open();
        using var command = new MySqlCommand("SELECT ID_ARTICLE, Code, STOCK, PRIX_V_1, Prix_A FROM TABLE_ARTICLES WHERE STOCK >= @minimum AND STOCK <= @maximum", connection);
        command.Parameters.AddWithValue("@minimum", minimum);
        command.Parameters.AddWithValue("@maximum", maximum);
        using var reader = command.ExecuteReader();
        while (reader.Read()) rows.Add(MapSnapshot(reader, identities));
        return rows;
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
            rows.Add(MapSnapshot(reader, identities));
        }
        return rows;
    }

    private static InventorySnapshot MapSnapshot(MySqlDataReader reader, HashSet<string> identities)
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
            return new InventorySnapshot(id, barcode, stock, sale, purchase);
    }

}
