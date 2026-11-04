using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Hanouty.ArchitectureBridge;

namespace Hanouty.Inventory.MariaDb;

// Production read-only adapter. Supply a SELECT-only disposable/local MariaDB account.
// Never expose a writable connection or silently substitute an empty catalogue.
public sealed class MariaDbCatalogueReader : ICatalogueReader
{
    private readonly string _connectionString;
    private readonly string _imagesDirectory;

    public MariaDbCatalogueReader(string connectionString, string legacyDataDirectory)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentException("A local MariaDB connection is required.", nameof(connectionString));
        if (string.IsNullOrWhiteSpace(legacyDataDirectory))
            throw new ArgumentException("Legacy data directory is required.", nameof(legacyDataDirectory));
        _connectionString = connectionString;
        _imagesDirectory = Path.GetFullPath(Path.Combine(legacyDataDirectory, "bd", "images"));
    }

    public IReadOnlyList<ProductSummary> ListAll() => Read(null, null);
    public IReadOnlyList<ProductSummary> FindBarcode(string barcode) => Read("barcode", barcode ?? throw new ArgumentNullException(nameof(barcode)));
    public IReadOnlyList<ProductSummary> RefreshBarcode(string barcode) => FindBarcode(barcode);
    public IReadOnlyList<ProductSummary> RefreshArticle(string articleId)
    {
        if (string.IsNullOrWhiteSpace(articleId)) throw new ArgumentException("Stable article ID is required.", nameof(articleId));
        return Read("article", articleId);
    }

    private IReadOnlyList<ProductSummary> Read(string? filter, string? value)
    {
        const string columns = "SELECT ID_ARTICLE, Code, Article, Images FROM TABLE_ARTICLES";
        string sql = filter switch
        {
            "barcode" => columns + " WHERE BINARY Code = BINARY @value",
            "article" => columns + " WHERE BINARY ID_ARTICLE = BINARY @value",
            _ => columns
        };
        var result = new List<ProductSummary>();
        var identities = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        using var connection = new MySqlConnection(_connectionString);
        connection.Open();
        using var command = new MySqlCommand(sql, connection);
        command.CommandType = CommandType.Text;
        if (filter != null) command.Parameters.AddWithValue("@value", value);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            string id = reader.IsDBNull(0) ? "" : Convert.ToString(reader.GetValue(0)) ?? "";
            if (string.IsNullOrWhiteSpace(id) || !identities.Add(id))
                throw new InvalidOperationException("Catalogue contains missing or duplicate stable article identity.");
            string barcode = reader.IsDBNull(1) ? "" : Convert.ToString(reader.GetValue(1)) ?? "";
            string name = reader.IsDBNull(2) ? "" : Convert.ToString(reader.GetValue(2)) ?? "";
            string? photo = reader.IsDBNull(3) ? null : AvailableImage(Convert.ToString(reader.GetValue(3)));
            result.Add(new ProductSummary(id, barcode, name, photo));
        }
        return result;
    }

    private string? AvailableImage(string? legacyName)
    {
        if (string.IsNullOrWhiteSpace(legacyName) || legacyName == "0") return null;
        // Legacy Images stores a file name relative to <data>/bd/images.
        // Do not allow DB-supplied paths to escape the image directory.
        if (Path.IsPathRooted(legacyName) || legacyName != Path.GetFileName(legacyName))
            return null;
        string candidate = Path.GetFullPath(Path.Combine(_imagesDirectory, legacyName));
        return File.Exists(candidate) ? candidate : null;
    }
}
