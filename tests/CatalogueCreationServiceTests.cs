using System;
using System.Collections.Generic;
using System.Data;
using LOGICA.ApplicationLayer.Catalogue;
using LOGICA.Infrastructure.Compatibility;

internal static class CatalogueCreationServiceTests
{
    private sealed class Input : ICatalogueRowInput
    {
        public int Reads;
        public string FailAt;
        public readonly Exception Failure = new InvalidOperationException("input failure");
        private string Read(string name) { Reads++; if (name == FailAt) throw Failure; return "1"; }
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

    private sealed class Store : ICatalogueCreationStore
    {
        public readonly List<string> Calls = new List<string>();
        public readonly DataTable Table = new DataTable();
        public readonly Exception Failure = new InvalidOperationException("store failure");
        public string FailAt;
        public Store()
        {
            foreach (string column in new[] { "ID","ID_ARTICLE","Code","Article","Famille","Sous_Famille","GROUPE","Description","Prix_A","PRIX_MP","PRIX_V_1","PRIX_V_2","PRIX_QTE","PRIX_QTE_MIN","STOCK","Alert","DATES","DATE_INVENTAIRE","STOCK_INITIAL","TAUX_TVA","UNITE","REFERENCE","FOURNISSEUR","MODE_STOCK","PRINTER","PRINTER_DUPLICATA","Images","Taille","Couleur","Emplacement","PROMOTION","FENETRE_PESAGE","BALANCE" })
                Table.Columns.Add(column, typeof(object));
        }
        private void Step(string stage) { Calls.Add(stage); if (stage == FailAt) throw Failure; }
        public int ReadNextNumericId() { Step("id"); return 42; }
        public string ReadArticleId() { Step("articleId"); return "ART000007"; }
        public DataRow AppendNewRow() { Step("append"); var row = Table.NewRow(); Table.Rows.Add(row); return row; }
        public void Persist()
        {
            Step("persist");
            if ((int)Table.Rows[0]["ID"] != 42 || (string)Table.Rows[0]["ID_ARTICLE"] != "ART000007")
                throw new Exception("Identity did not reach mapped row before persistence");
            Table.AcceptChanges();
        }
        public void WriteMovement(string articleId, ICatalogueRowInput input)
        {
            Step("movement");
            if (articleId != "ART000007") throw new Exception("Movement identity changed");
            string code = input.Code, article = input.Article, stock = input.Stock;
        }
        public void AdvanceSequence() { Step("sequence"); }
    }

    public static int Main()
    {
        int assertions = 0;
        try
        {
            string[] stages = { "id", "articleId", "append", "persist", "movement", "sequence" };
            for (int fail = 0; fail <= stages.Length; fail++)
            {
                var store = new Store(); var input = new Input();
                if (fail < stages.Length) store.FailAt = stages[fail];
                Exception caught = null;
                try { new CatalogueCreationService(store, VisualBasicCatalogueSemantics.Instance).Create(input); } catch (Exception error) { caught = error; }
                int expectedCalls = fail < stages.Length ? fail + 1 : stages.Length;
                assertions++;
                if (store.Calls.Count != expectedCalls) throw new Exception("Later store effect ran after failure");
                for (int i = 0; i < expectedCalls; i++)
                {
                    assertions++;
                    if (store.Calls[i] != stages[i]) throw new Exception("Creation order changed");
                }
                assertions++;
                if (fail < stages.Length ? !Object.ReferenceEquals(caught, store.Failure) : caught != null)
                    throw new Exception("Creation exception identity changed");
                assertions++;
                if (fail <= 2 ? input.Reads != 0 : input.Reads == 0) throw new Exception("Input read eagerly or skipped");
                assertions++;
                if (store.Table.Rows.Count != (fail <= 2 ? 0 : 1)) throw new Exception("Append boundary changed");
                if (fail > 2)
                {
                    assertions++;
                    if (store.Table.Rows[0].RowState != (fail == 3 ? DataRowState.Added : DataRowState.Unchanged))
                        throw new Exception("Failure changed already-applied row state");
                }
            }
            var partial = new Store(); var brokenInput = new Input { FailAt = "PurchasePrice" };
            Exception mappingFailure = null;
            try { new CatalogueCreationService(partial, VisualBasicCatalogueSemantics.Instance).Create(brokenInput); } catch (Exception error) { mappingFailure = error; }
            assertions += 4;
            if (!Object.ReferenceEquals(mappingFailure, brokenInput.Failure) || partial.Calls.Count != 3 ||
                partial.Table.Rows[0].RowState != DataRowState.Added || partial.Table.Rows[0]["Prix_A"] != DBNull.Value)
                throw new Exception("Mapping failure did not preserve partial row and stop persistence");
            Console.WriteLine("PASS catalogue creation service: " + assertions + " assertions; ordered lazy steps, first failure identity and partial states");
            return 0;
        }
        catch (Exception error) { Console.Error.WriteLine(error); return 1; }
    }
}
