using System.Globalization;
using System.IO;
using ClosedXML.Excel;

namespace Hanouty.Desktop.Bootstrap;

internal static class CatalogueWorkbook
{
    private static readonly string[] RequiredHeaders = ["Code", "Article", "Famille", "PRIX_A", "PRIX_V", "STOCK"];

    internal static IReadOnlyList<CataloguePriceEditor.ImportLine> Read(string file)
    {
        using var workbook = new XLWorkbook(file);
        var sheet = workbook.Worksheets.SingleOrDefault(item =>
            string.Equals(item.Name, "Feuil1", StringComparison.OrdinalIgnoreCase))
            ?? throw new InvalidDataException("La feuille Feuil1 est requise.");
        var columns = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        foreach (var cell in sheet.Row(1).CellsUsed())
        {
            var label = cell.GetString().Trim();
            if (RequiredHeaders.Contains(label, StringComparer.OrdinalIgnoreCase) &&
                !columns.TryAdd(label, cell.Address.ColumnNumber))
                throw new InvalidDataException($"Colonne en double : {label}.");
        }
        if (RequiredHeaders.Any(header => !columns.ContainsKey(header)))
            throw new InvalidDataException("Colonnes requises : Code, Article, Famille, PRIX_A, PRIX_V et STOCK.");

        var lines = new List<CataloguePriceEditor.ImportLine>();
        foreach (var row in sheet.RowsUsed().Skip(1))
        {
            IXLCell Cell(string header)
            {
                var cell = row.Cell(columns[header]);
                if (cell.HasFormula || cell.DataType == XLDataType.Error)
                    throw new InvalidDataException($"Ligne {row.RowNumber()}, {header} : utilisez une valeur simple.");
                return cell;
            }

            string Text(string header)
            {
                var value = Cell(header).GetFormattedString(CultureInfo.InvariantCulture).Trim();
                if (value.Length is 0 or > 128)
                    throw new InvalidDataException($"Ligne {row.RowNumber()}, {header} : texte requis, 128 caractères au maximum.");
                return value;
            }

            decimal Number(string header, int scale)
            {
                var cell = Cell(header);
                decimal value;
                var valid = cell.DataType == XLDataType.Number
                    ? cell.TryGetValue(out value)
                    : decimal.TryParse(cell.GetString().Trim().Replace(',', '.'),
                        NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out value);
                if (!valid || value < 0 || decimal.Round(value, scale) != value)
                    throw new InvalidDataException($"Ligne {row.RowNumber()}, {header} : valeur positive ou nulle attendue.");
                return value;
            }

            lines.Add(new CataloguePriceEditor.ImportLine(Text("Article"), Text("Code"), Text("Famille"),
                Number("PRIX_A", 2), Number("PRIX_V", 2), Number("STOCK", 3)));
        }
        if (lines.Count == 0) throw new InvalidDataException("Le fichier ne contient aucun article.");
        return lines.AsReadOnly();
    }
}
