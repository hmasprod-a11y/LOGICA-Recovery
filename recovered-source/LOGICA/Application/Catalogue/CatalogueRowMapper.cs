using System.Data;
using LOGICA.Domain;

namespace LOGICA.ApplicationLayer.Catalogue
{
    internal static class CatalogueRowMapper
    {
        public static void PopulateNew(DataRow row, int id, string articleId, ICatalogueRowInput input, ILegacyCatalogueSemantics semantics)
        {
            row["ID"] = id;
            row["ID_ARTICLE"] = articleId;
            PopulateFields(row, input, true, semantics);
        }

        public static void PopulateEdited(DataRow row, ICatalogueRowInput input, ILegacyCatalogueSemantics semantics)
        {
            row["ID"] = input.Id;
            row["ID_ARTICLE"] = input.ArticleId;
            PopulateFields(row, input, false, semantics);
        }

        // The article identifier is editable in LOGICA. On Save, the immutable
        // database row ID selects the original record; ID_ARTICLE is validated
        // separately by the existing duplicate lookup before it is changed.
        internal static DataRow ResolveUniqueByDatabaseId(DataTable table, string id)
        {
            if (table == null || string.IsNullOrWhiteSpace(id) ||
                !table.Columns.Contains("ID") || !table.Columns.Contains("ID_ARTICLE"))
                return null;
            DataRow match = null;

            foreach (DataRow row in table.Rows)
            {
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached)
                    continue;
                if (!string.Equals(System.Convert.ToString(row["ID"]), id, System.StringComparison.Ordinal))
                    continue;
                if (match != null)
                    return null;
                match = row;
            }
            return match;
        }

        // The WinForms grid can be sorted or filtered independently of DataTable.Rows.
        // Never identify an edited/deleted product by a displayed row index.
        internal static DataRow ResolveUniqueExistingRow(DataTable table, string id, string articleId)
        {
            if (table == null || string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(articleId) ||
                !table.Columns.Contains("ID") || !table.Columns.Contains("ID_ARTICLE"))
                return null;

            DataRow match = null;

            foreach (DataRow row in table.Rows)
            {
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached)
                    continue;
                bool sameId = string.Equals(System.Convert.ToString(row["ID"]), id, System.StringComparison.Ordinal);
                bool sameArticleId = string.Equals(System.Convert.ToString(row["ID_ARTICLE"]), articleId, System.StringComparison.Ordinal);
                if (!sameId && !sameArticleId)
                    continue;
                // A duplicate or partially mismatched identity is unsafe, even if
                // the grid hides the conflicting row with a filter.
                if (!sameId || !sameArticleId || match != null)
                    return null;
                match = row;
            }
            return match;
        }

        private static void PopulateFields(DataRow row, ICatalogueRowInput input, bool creating, ILegacyCatalogueSemantics semantics)
        {
            // Read each value at its original assignment, preserving partial writes on failure.
            row["Code"] = semantics.Trim(input.Code);
            row["Article"] = semantics.Trim(input.Article);
            row["Famille"] = input.Family;
            row["Sous_Famille"] = input.Subfamily;
            if (row.Table.Columns.Contains("GROUPE")) row["GROUPE"] = input.Group;
            row["Description"] = input.Description;
            row["Prix_A"] = semantics.FormatNumber(input.PurchasePrice);
            row["PRIX_MP"] = semantics.FormatNumber(creating ? input.PurchasePrice : input.AveragePrice);
            row["PRIX_V_1"] = semantics.FormatNumber(input.SalePrice);
            row["PRIX_V_2"] = semantics.FormatNumber(input.SecondSalePrice);
            if (row.Table.Columns.Contains("PRIX_QTE")) row["PRIX_QTE"] = semantics.FormatNumber(input.QuantityPrice);
            if (row.Table.Columns.Contains("PRIX_QTE_MIN")) row["PRIX_QTE_MIN"] = semantics.ToMinimumQuantity(input.MinimumQuantity);
            row["STOCK"] = input.Stock;
            row["Alert"] = input.Alert;
            row["DATES"] = input.CreationDate;
            row["DATE_INVENTAIRE"] = creating ? input.CreationDate : input.InventoryDate;
            row["STOCK_INITIAL"] = creating ? input.Stock : input.OpeningStock;
            row["TAUX_TVA"] = input.VatRate;
            row["UNITE"] = input.Unit;
            row["REFERENCE"] = input.Reference;
            row["FOURNISSEUR"] = input.Supplier;
            row["MODE_STOCK"] = input.StockMode;
            row["PRINTER"] = input.Printer;
            row["PRINTER_DUPLICATA"] = input.DuplicatePrinter;
            row["Images"] = input.ImageName;
            if (row.Table.Columns.Contains("Taille")) row["Taille"] = input.Size;
            if (row.Table.Columns.Contains("Couleur")) row["Couleur"] = input.Color;
            if (row.Table.Columns.Contains("Emplacement")) row["Emplacement"] = input.Location;
            row["PROMOTION"] = semantics.FormatNumber(input.Promotion);
            row["FENETRE_PESAGE"] = input.WeighingWindow;
            row["BALANCE"] = input.Balance;
        }
    }
}
