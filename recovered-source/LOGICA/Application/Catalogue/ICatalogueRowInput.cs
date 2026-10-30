namespace LOGICA.ApplicationLayer.Catalogue
{
    internal interface ICatalogueRowInput
    {
        string Id { get; }
        string ArticleId { get; }
        string Code { get; }
        string Article { get; }
        string Family { get; }
        string Subfamily { get; }
        string Group { get; }
        string Description { get; }
        string PurchasePrice { get; }
        string AveragePrice { get; }
        string SalePrice { get; }
        string SecondSalePrice { get; }
        string QuantityPrice { get; }
        string MinimumQuantity { get; }
        string Stock { get; }
        string Alert { get; }
        string CreationDate { get; }
        string InventoryDate { get; }
        string OpeningStock { get; }
        string VatRate { get; }
        string Unit { get; }
        string Reference { get; }
        string Supplier { get; }
        string StockMode { get; }
        string Printer { get; }
        string DuplicatePrinter { get; }
        string ImageName { get; }
        string Size { get; }
        string Color { get; }
        string Location { get; }
        string Promotion { get; }
        string WeighingWindow { get; }
        string Balance { get; }
    }
}
