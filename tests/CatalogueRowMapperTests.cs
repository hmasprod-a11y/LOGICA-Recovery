using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using LOGICA.ApplicationLayer.Catalogue;

internal static class CatalogueRowMapperTests
{
    private sealed class Input : ICatalogueRowInput
    {
        public readonly Dictionary<string,string> Values = new Dictionary<string,string>();
        public readonly List<string> Reads = new List<string>();
        public string FailAt;
        public readonly Exception Failure = new InvalidOperationException("injected field read");
        private string Read(string name)
        {
            Reads.Add(name);
            if (name == FailAt) throw Failure;
            return Values[name];
        }
        public string Id { get { return Read("Id"); } }
        public string ArticleId { get { return Read("ArticleId"); } }
        public string Code { get { return Read("Code"); } }
        public string Article { get { return Read("Article"); } }
        public string Family { get { return Read("Family"); } }
        public string Subfamily { get { return Read("Subfamily"); } }
        public string Group { get { return Read("Group"); } }
        public string Description { get { return Read("Description"); } }
        public string PurchasePrice { get { return Read("PurchasePrice"); } }
        public string AveragePrice { get { return Read("AveragePrice"); } }
        public string SalePrice { get { return Read("SalePrice"); } }
        public string SecondSalePrice { get { return Read("SecondSalePrice"); } }
        public string QuantityPrice { get { return Read("QuantityPrice"); } }
        public string MinimumQuantity { get { return Read("MinimumQuantity"); } }
        public string Stock { get { return Read("Stock"); } }
        public string Alert { get { return Read("Alert"); } }
        public string CreationDate { get { return Read("CreationDate"); } }
        public string InventoryDate { get { return Read("InventoryDate"); } }
        public string OpeningStock { get { return Read("OpeningStock"); } }
        public string VatRate { get { return Read("VatRate"); } }
        public string Unit { get { return Read("Unit"); } }
        public string Reference { get { return Read("Reference"); } }
        public string Supplier { get { return Read("Supplier"); } }
        public string StockMode { get { return Read("StockMode"); } }
        public string Printer { get { return Read("Printer"); } }
        public string DuplicatePrinter { get { return Read("DuplicatePrinter"); } }
        public string ImageName { get { return Read("ImageName"); } }
        public string Size { get { return Read("Size"); } }
        public string Color { get { return Read("Color"); } }
        public string Location { get { return Read("Location"); } }
        public string Promotion { get { return Read("Promotion"); } }
        public string WeighingWindow { get { return Read("WeighingWindow"); } }
        public string Balance { get { return Read("Balance"); } }
    }

    private static Input MakeInput()
    {
        var input = new Input();
        foreach (string name in new[] { "Id","ArticleId","Code","Article","Family","Subfamily","Group","Description","PurchasePrice","AveragePrice","SalePrice","SecondSalePrice","QuantityPrice","MinimumQuantity","Stock","Alert","CreationDate","InventoryDate","OpeningStock","VatRate","Unit","Reference","Supplier","StockMode","Printer","DuplicatePrinter","ImageName","Size","Color","Location","Promotion","WeighingWindow","Balance" })
            input.Values[name] = "value-" + name;
        input.Values["Id"] = "42"; input.Values["ArticleId"] = "ART000007";
        input.Values["Code"] = " CI_CODE "; input.Values["Article"] = " CI article ";
        foreach (string name in new[] { "PurchasePrice", "SalePrice", "SecondSalePrice", "QuantityPrice", "Promotion" })
            input.Values[name] = 10.25m.ToString(CultureInfo.CurrentCulture);
        input.Values["AveragePrice"] = 88.5m.ToString(CultureInfo.CurrentCulture);
        input.Values["MinimumQuantity"] = "3.5units";
        return input;
    }

    private static DataRow MakeRow()
    {
        var table = new DataTable();
        foreach (string name in new[] { "ID","ID_ARTICLE","Code","Article","Famille","Sous_Famille","GROUPE","Description","Prix_A","PRIX_MP","PRIX_V_1","PRIX_V_2","PRIX_QTE","PRIX_QTE_MIN","STOCK","Alert","DATES","DATE_INVENTAIRE","STOCK_INITIAL","TAUX_TVA","UNITE","REFERENCE","FOURNISSEUR","MODE_STOCK","PRINTER","PRINTER_DUPLICATA","Images","Taille","Couleur","Emplacement","PROMOTION","FENETRE_PESAGE","BALANCE" })
            table.Columns.Add(name, typeof(object));
        var row = table.NewRow(); table.Rows.Add(row); return row;
    }

    public static int Main()
    {
        var original = CultureInfo.CurrentCulture;
        int assertions = 0;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                var input = MakeInput(); var row = MakeRow();
                CatalogueRowMapper.PopulateNew(row, 42, "ART000007", input);
                assertions += 8;
                if ((int)row["ID"] != 42 || (string)row["Code"] != "CI_CODE" || (string)row["Article"] != "CI article" ||
                    (string)row["PRIX_MP"] != 10.25m.ToString("N2") || (double)row["PRIX_QTE_MIN"] != 3.5 ||
                    (string)row["DATE_INVENTAIRE"] != input.Values["CreationDate"] ||
                    (string)row["STOCK_INITIAL"] != input.Values["Stock"] ||
                    input.Reads.Contains("Id") || input.Reads.Contains("AveragePrice") || input.Reads.Contains("InventoryDate") || input.Reads.Contains("OpeningStock"))
                    throw new Exception("Creation values or branch reads changed");
                assertions += 3;
                if (input.Reads.FindAll(delegate(string n) { return n == "PurchasePrice"; }).Count != 2 ||
                    input.Reads.FindAll(delegate(string n) { return n == "CreationDate"; }).Count != 2 ||
                    input.Reads.FindAll(delegate(string n) { return n == "Stock"; }).Count != 2)
                    throw new Exception("Repeated reads were eagerly cached");
                input = MakeInput(); row = MakeRow();
                CatalogueRowMapper.PopulateEdited(row, input);
                assertions += 4;
                if ((string)row["ID"] != "42" || (string)row["PRIX_MP"] != 88.5m.ToString("N2") ||
                    (string)row["DATE_INVENTAIRE"] != input.Values["InventoryDate"] ||
                    (string)row["STOCK_INITIAL"] != input.Values["OpeningStock"])
                    throw new Exception("Edit mapping differences changed");
                foreach (bool creating in new[] { true, false })
                {
                    input = MakeInput(); row = MakeRow(); input.FailAt = "SalePrice";
                    Exception caught = null;
                    try { if (creating) CatalogueRowMapper.PopulateNew(row, 42, "ART000007", input); else CatalogueRowMapper.PopulateEdited(row, input); }
                    catch (Exception error) { caught = error; }
                    assertions += 4;
                    if (!Object.ReferenceEquals(caught, input.Failure) || row["PRIX_MP"] == DBNull.Value ||
                        row["PRIX_V_1"] != DBNull.Value || input.Reads.Contains("SecondSalePrice"))
                        throw new Exception("Partial assignment or exception timing changed");
                }
            }
            Console.WriteLine("PASS catalogue row mapper: " + assertions + " assertions; culture, branch differences, repeated reads and partial failure");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
