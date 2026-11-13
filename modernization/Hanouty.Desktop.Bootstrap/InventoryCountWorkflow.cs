using Hanouty.Desktop.Wpf.Presentation;
using MySql.Data.MySqlClient;

namespace Hanouty.Desktop.Bootstrap;

internal sealed class InventoryCountWorkflow(string connectionString, string actor, Func<string> readPin)
    : IInventoryCountWorkflow
{
    private InventoryCountDocument? source;
    private readonly Dictionary<string, decimal> counts = new(StringComparer.Ordinal);

    public InventoryCountDocument Open(string documentId)
    {
        source = null;
        counts.Clear();
        var endpoint = new MySqlConnectionStringBuilder(connectionString);
        if (endpoint.Server is not ("localhost" or "127.0.0.1" or "::1"))
            throw new InvalidOperationException("Local inventory database required.");
        using var connection = new MySqlConnection(connectionString);
        connection.Open();
        using var command = new MySqlCommand(
            "SELECT ID_ARTICLE, Article, STOCK_LOGIQUE, STOCK_PHYSIQUE FROM TABLE_INVENTAIRES_DETAILS " +
            "WHERE BINARY ID_INV=BINARY @id AND ETAT='ENREGISTRER' AND EXISTS " +
            "(SELECT 1 FROM TABLE_INVENTAIRES_ENTETE WHERE BINARY ID_INV=BINARY @id AND ETAT='ENREGISTRER') " +
            "ORDER BY BINARY ID_ARTICLE", connection);
        command.Parameters.AddWithValue("@id", documentId);
        using var reader = command.ExecuteReader();
        var lines = new List<InventoryCountLine>();
        while (reader.Read())
            lines.Add(new InventoryCountLine(reader.GetString(0), reader.IsDBNull(1) ? "" : reader.GetString(1),
                reader.GetDecimal(2), reader.IsDBNull(3) ? null : reader.GetDecimal(3)));
        if (lines.Count == 0 || lines.Select(line => line.ArticleId).Distinct(StringComparer.Ordinal).Count() != lines.Count)
            throw new InvalidOperationException("Open inventory document not found or contains duplicate articles.");
        source = new InventoryCountDocument(documentId, lines.AsReadOnly());
        return Snapshot(source);
    }

    public InventoryCountDocument RecordPhysicalQuantity(string documentId, string articleId, decimal physicalQuantity)
    {
        var document = RequireDocument(documentId);
        if (physicalQuantity < 0 || !document.Lines.Any(line => line.ArticleId == articleId))
            throw new InvalidOperationException("Invalid inventory count.");
        counts[articleId] = physicalQuantity;
        return Snapshot(document);
    }

    public bool Confirm(string documentId)
    {
        var document = RequireDocument(documentId);
        if (counts.Count != document.Lines.Count) return false;
        var pin = readPin();
        if (string.IsNullOrWhiteSpace(pin)) return false;
        var reviewed = document.Lines.ToDictionary(line => line.ArticleId,
            line => (line.ExpectedQuantity, line.PhysicalQuantity, counts[line.ArticleId]), StringComparer.Ordinal);
        new InventoryDocumentValidation(connectionString).Validate(documentId, actor, pin, reviewed);
        source = null;
        counts.Clear();
        return true;
    }

    private InventoryCountDocument RequireDocument(string id) =>
        source is { } document && document.DocumentId == id
            ? document : throw new InvalidOperationException("Open the inventory document first.");

    private InventoryCountDocument Snapshot(InventoryCountDocument document) =>
        new(document.DocumentId, document.Lines.Select(line => line with
        {
            PhysicalQuantity = counts.TryGetValue(line.ArticleId, out var quantity) ? quantity : null
        }).ToArray());
}
