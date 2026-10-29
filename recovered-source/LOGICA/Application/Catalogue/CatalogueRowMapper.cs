using System.Data;
using Microsoft.VisualBasic;

namespace LOGICA.ApplicationLayer.Catalogue
{
    internal static class CatalogueRowMapper
    {
        public static void PopulateNew(DataRow row, int id, string articleId, ICatalogueRowInput input)
        {
            row["ID"] = id;
            row["ID_ARTICLE"] = articleId;
            PopulateFields(row, input, true);
        }

        public static void PopulateEdited(DataRow row, ICatalogueRowInput input)
        {
            row["ID"] = input.Id;
            row["ID_ARTICLE"] = input.ArticleId;
            PopulateFields(row, input, false);
        }

        private static void PopulateFields(DataRow row, ICatalogueRowInput input, bool creating)
        {
            // Read each value at its original assignment, preserving partial writes on failure.
            row["Code"] = Strings.Trim(input.Code);
            row["Article"] = Strings.Trim(input.Article);
            row["Famille"] = input.Family;
            row["Sous_Famille"] = input.Subfamily;
            row["GROUPE"] = input.Group;
            row["Description"] = input.Description;
            row["Prix_A"] = Strings.FormatNumber(input.PurchasePrice);
            row["PRIX_MP"] = Strings.FormatNumber(creating ? input.PurchasePrice : input.AveragePrice);
            row["PRIX_V_1"] = Strings.FormatNumber(input.SalePrice);
            row["PRIX_V_2"] = Strings.FormatNumber(input.SecondSalePrice);
            row["PRIX_QTE"] = Strings.FormatNumber(input.QuantityPrice);
            row["PRIX_QTE_MIN"] = Conversion.Val(input.MinimumQuantity);
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
            row["Taille"] = input.Size;
            row["Couleur"] = input.Color;
            row["Emplacement"] = input.Location;
            row["PROMOTION"] = Strings.FormatNumber(input.Promotion);
            row["FENETRE_PESAGE"] = input.WeighingWindow;
            row["BALANCE"] = input.Balance;
        }
    }
}
