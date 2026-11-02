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
