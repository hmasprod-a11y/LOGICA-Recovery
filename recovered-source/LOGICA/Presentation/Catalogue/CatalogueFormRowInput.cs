using LOGICA.ApplicationLayer.Catalogue;

namespace LOGICA.Presentation.Catalogue
{
    internal sealed class CatalogueFormRowInput : ICatalogueRowInput
    {
        private readonly Form_2_ARTICLES form;
        public CatalogueFormRowInput(Form_2_ARTICLES form) { this.form = form; }
        public string Id { get { return form.Text_ID.Text; } }
        public string ArticleId { get { return form.Text_ID_ARTICLE.Text; } }
        public string Code { get { return form.Text_CODE.Text; } }
        public string Article { get { return form.Text_ARTICLE.Text; } }
        public string Family { get { return form.Combo_FAMILLE.Text; } }
        public string Subfamily { get { return form.Text_SOUS_FAMILLE.Text; } }
        public string Group { get { return form.Combo_GROUPES.Text; } }
        public string Description { get { return form.Text_DESCRIPTION.Text; } }
        public string PurchasePrice { get { return form.Text_PRIX_A.Text; } }
        public string AveragePrice { get { return form.Text_PRIX_MP.Text; } }
        public string SalePrice { get { return form.Text_PRIX_V.Text; } }
        public string SecondSalePrice { get { return form.Text_PRIX_V_2.Text; } }
        public string QuantityPrice { get { return form.Text_PRIX_QTE.Text; } }
        public string MinimumQuantity { get { return form.Text_PRIX_QTE_MIN.Text; } }
        public string Stock { get { return form.Text_STOCK.Text; } }
        public string Alert { get { return form.Text_ALERT.Text; } }
        public string CreationDate { get { return form.Text_DATE_CREATION.Text; } }
        public string InventoryDate { get { return form.Text_DATE_INVENTAIRE.Text; } }
        public string OpeningStock { get { return form.Text_STOCK_INITIAL.Text; } }
        public string VatRate { get { return form.Combo_TAUX_TVA.Text; } }
        public string Unit { get { return form.Combo_UNITE.Text; } }
        public string Reference { get { return form.Text_REFERENCE.Text; } }
        public string Supplier { get { return form.Combo_FOURNISSEUR.Text; } }
        public string StockMode { get { return form.Combo_MODE_STOCK.Text; } }
        public string Printer { get { return form.Combo_PRINTER.Text; } }
        public string DuplicatePrinter { get { return form.Combo_PRINTER_DUPLICATA.Text; } }
        public string ImageName { get { return form.Text_LIEN_PICTURE.Text; } }
        public string Size { get { return form.Combo_TAILLES.Text; } }
        public string Color { get { return form.Combo_COULEURS.Text; } }
        public string Location { get { return form.Text_EMPLACEMENT.Text; } }
        public string Promotion { get { return form.Text_PROMOTION.Text; } }
        public string WeighingWindow { get { return form.Combo_FENETRE_PESEE.Text; } }
        public string Balance { get { return form.Combo_BALANCE.Text; } }
    }
}
