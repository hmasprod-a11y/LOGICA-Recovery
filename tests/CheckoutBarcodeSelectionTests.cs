using System;
using System.Data;
using System.Globalization;
using LOGICA.ApplicationLayer.Checkout;

internal static class CheckoutBarcodeSelectionTests
{
    private static DataTable Candidates()
    {
        DataTable rows = new DataTable();
        rows.Columns.Add("ID_ARTICLE", typeof(string));
        rows.Columns.Add("Code", typeof(string));
        rows.Columns.Add("Article", typeof(string));
        rows.Columns.Add("Prix_V_1", typeof(decimal));
        rows.Rows.Add("1", "ABC-001", "Ordinary", 10m);
        rows.Rows.Add("2", "ABC-001", "Variant", 20m);
        rows.Rows.Add("3", "ABC-001", "Variant 2", 30m);
        return rows;
    }

    private static void Expect<T>(Action action) where T : Exception
    {
        try { action(); }
        catch (T) { return; }
        throw new Exception("Expected " + typeof(T).Name);
    }

    public static int Main()
    {
        int checks = 0;
        CultureInfo previous = CultureInfo.CurrentCulture;
        try
        {
            foreach (string culture in new[] { "fr-MA", "fr-FR", "en-US" })
            {
                CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
                DataTable rows = Candidates();
                int calls = 0;
                Func<DataTable, int> chooser = delegate(DataTable data) {
                    if (!Object.ReferenceEquals(data, rows)) throw new Exception("Result table copied");
                    calls++;
                    return 1;
                };
                if (!Object.ReferenceEquals(CheckoutBarcodeSelectionService.Select(rows, chooser), rows.Rows[1])
                    || calls != 1) throw new Exception("Duplicate must choose exact original row");
                checks++;
                if (CheckoutBarcodeSelectionService.Select(rows, delegate(DataTable data) { return 0; }) != rows.Rows[0])
                    throw new Exception("First duplicate option not selectable");
                checks++;
                if (CheckoutBarcodeSelectionService.Select(rows, delegate(DataTable data) { return 2; }) != rows.Rows[2])
                    throw new Exception("Last duplicate option not selectable");
                checks++;
                if (CheckoutBarcodeSelectionService.Select(rows, delegate(DataTable data) { return -1; }) != null)
                    throw new Exception("Cancellation must not post a sale");
                checks++;
                Expect<ArgumentOutOfRangeException>(delegate {
                    CheckoutBarcodeSelectionService.Select(rows, delegate(DataTable data) { return 3; });
                });
                Expect<ArgumentOutOfRangeException>(delegate {
                    CheckoutBarcodeSelectionService.Select(rows, delegate(DataTable data) { return -2; });
                });
                checks += 2;
                Expect<ArgumentNullException>(delegate { CheckoutBarcodeSelectionService.Select(null, chooser); });
                Expect<ArgumentNullException>(delegate { CheckoutBarcodeSelectionService.Select(rows, null); });
                checks += 2;
                Exception failure = new InvalidOperationException("chooser failure");
                try {
                    CheckoutBarcodeSelectionService.Select(rows, delegate(DataTable data) { throw failure; });
                    throw new Exception("Chooser exception was swallowed");
                } catch (InvalidOperationException ex) {
                    if (!Object.ReferenceEquals(ex, failure)) throw new Exception("Exception identity changed");
                }
                checks++;
                rows.Rows.RemoveAt(2);
                rows.Rows.RemoveAt(1);
                if (CheckoutBarcodeSelectionService.Select(rows, null) != rows.Rows[0])
                    throw new Exception("Single barcode match must retain original first row");
                checks++;
                rows.Rows.Clear();
                if (CheckoutBarcodeSelectionService.Select(rows, null) != null)
                    throw new Exception("No-match scanner must remain no-match");
                checks++;
            }
        }
        finally { CultureInfo.CurrentCulture = previous; }
        Console.WriteLine("PASS checkout duplicate barcode selection: " + checks +
            " cases across 3 cultures, explicit variant, cancel, bounds, single and empty");
        return 0;
    }
}
