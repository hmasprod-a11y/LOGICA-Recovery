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
                // The legacy basket loop used Code alone; selecting another article
                // with the same code would incorrectly increment the first line.
                DataTable basket = Candidates();
                DataRow firstLine = basket.Rows[0];
                int comparisons = 0;
                Func<object, object, bool> equal = delegate(object left, object right) {
                    comparisons++;
                    return Object.Equals(left, right);
                };
                if (!CheckoutBarcodeSelectionService.IsSameBasketArticle(
                        firstLine, "ABC-001", "1", equal) || comparisons != 2)
                    throw new Exception("Same article must increment existing basket line");
                checks++;
                comparisons = 0;
                if (CheckoutBarcodeSelectionService.IsSameBasketArticle(
                        firstLine, "ABC-001", "2", equal) || comparisons != 2)
                    throw new Exception("Different variant must remain separate");
                checks++;
                comparisons = 0;
                if (CheckoutBarcodeSelectionService.IsSameBasketArticle(
                        firstLine, "OTHER", "1", equal) || comparisons != 1)
                    throw new Exception("Different code must short circuit before ID comparison");
                checks++;
                comparisons = 0;
                if (CheckoutBarcodeSelectionService.IsSameBasketArticle(
                        firstLine, "ABC-001", "3", equal) || comparisons != 2)
                    throw new Exception("Third duplicate variant must not merge into first");
                checks++;
                Expect<ArgumentNullException>(delegate {
                    CheckoutBarcodeSelectionService.IsSameBasketArticle(null, "ABC-001", "1", equal);
                });
                Expect<ArgumentNullException>(delegate {
                    CheckoutBarcodeSelectionService.IsSameBasketArticle(firstLine, "ABC-001", "1", null);
                });
                checks += 2;
                Exception identityFailure = new InvalidOperationException("comparison failure");
                try {
                    CheckoutBarcodeSelectionService.IsSameBasketArticle(
                        firstLine, "ABC-001", "1",
                        delegate(object left, object right) { throw identityFailure; });
                    throw new Exception("Basket comparison failure swallowed");
                } catch (InvalidOperationException ex) {
                    if (!Object.ReferenceEquals(ex, identityFailure))
                        throw new Exception("Basket comparison exception identity changed");
                }
                checks++;
                // Real Form_3_VENTE passes the original DataTable into a modal
                // chooser. A timer/refresh can reorder its rows before the
                // selected index is consumed: never sell the next variant.
                DataTable reordered = Candidates();
                DataRow intended = reordered.Rows[1];
                DataRow reorderedResult = CheckoutBarcodeSelectionService.Select(reordered,
                    delegate(DataTable data) {
                        data.Rows.RemoveAt(0);
                        return 1; // Originally displayed ID 2, now index 1 is ID 3.
                    });
                if (!Object.ReferenceEquals(reorderedResult, intended) ||
                    reorderedResult["ID_ARTICLE"].ToString() != "2")
                    throw new Exception("Modal row shift must preserve selected article identity");
                checks++;

                DataTable removed = Candidates();
                if (CheckoutBarcodeSelectionService.Select(removed,
                    delegate(DataTable data) { data.Rows.RemoveAt(1); return 1; }) != null)
                    throw new Exception("Removed chosen article must not sell another variant");
                checks++;

                DataTable changedBarcode = Candidates();
                if (CheckoutBarcodeSelectionService.Select(changedBarcode,
                    delegate(DataTable data) { data.Rows[1]["Code"] = "OTHER"; return 1; }) != null)
                    throw new Exception("Barcode changed during dialog must fail closed");
                checks++;

                DataTable reusedId = Candidates();
                if (CheckoutBarcodeSelectionService.Select(reusedId,
                    delegate(DataTable data) { data.Rows[1]["ID_ARTICLE"] = "REUSED"; return 1; }) != null)
                    throw new Exception("Reused article ID during dialog must fail closed");
                checks++;

                DataTable unrelatedDuplicate = Candidates();
                if (CheckoutBarcodeSelectionService.Select(unrelatedDuplicate,
                    delegate(DataTable data) { data.Rows[2]["ID_ARTICLE"] = "1"; return 1; }) != null)
                    throw new Exception("Duplicate unrelated live article identity must fail closed");
                checks++;

                DataTable invalidLive = Candidates();
                if (CheckoutBarcodeSelectionService.Select(invalidLive,
                    delegate(DataTable data) { data.Rows[2]["Code"] = DBNull.Value; return 1; }) != null)
                    throw new Exception("Malformed unrelated live row must fail closed");
                checks++;

                DataTable deleted = Candidates();
                deleted.AcceptChanges();
                if (CheckoutBarcodeSelectionService.Select(deleted,
                    delegate(DataTable data) { data.Rows[1].Delete(); return 1; }) != null)
                    throw new Exception("Pending-deleted chosen variant must fail closed");
                checks++;

                DataTable preDeleted = Candidates();
                preDeleted.AcceptChanges();
                preDeleted.Rows[0].Delete();
                int invalidChooserCalls = 0;
                if (CheckoutBarcodeSelectionService.Select(preDeleted,
                    delegate(DataTable data) { invalidChooserCalls++; return 0; }) != null ||
                    invalidChooserCalls != 0)
                    throw new Exception("Deleted row must not shift modal display indices");
                checks++;

                DataTable corruptInitial = Candidates();
                corruptInitial.Rows[2]["ID_ARTICLE"] = "1";
                if (CheckoutBarcodeSelectionService.Select(corruptInitial,
                    delegate(DataTable data) { throw new Exception("Corrupt catalogue displayed"); }) != null)
                    throw new Exception("Duplicate initial catalogue identities must fail closed");
                checks++;

                DataTable repriced = Candidates();
                DataRow repricedChoice = CheckoutBarcodeSelectionService.Select(repriced,
                    delegate(DataTable data) {
                        data.Rows[1]["Prix_V_1"] = 25m;
                        return 1;
                    });
                if (!Object.ReferenceEquals(repricedChoice, repriced.Rows[1]) ||
                    (decimal)repricedChoice["Prix_V_1"] != 25m)
                    throw new Exception("Valid repricing retains the same chosen article");
                // The original shared production pricing rule is used by the
                // checkout path. Selection must not change sale/return signs.
                if (LOGICA.Domain.SalesLinePricing.CalculateNetAmount(
                        (decimal)repricedChoice["Prix_V_1"], 2m, 10m) != 45m ||
                    LOGICA.Domain.SalesLinePricing.CalculateNetAmount(
                        (decimal)repricedChoice["Prix_V_1"], -2m, 10m) != -45m)
                    throw new Exception("Selection must preserve sale/return net amounts");
                checks++;

                DataTable oneDeleted = Candidates();
                oneDeleted.Rows.RemoveAt(2);
                oneDeleted.Rows.RemoveAt(1);
                oneDeleted.AcceptChanges();
                oneDeleted.Rows[0].Delete();
                if (CheckoutBarcodeSelectionService.Select(oneDeleted, null) != null)
                    throw new Exception("Deleted single candidate must not be sold");
                checks++;

                // Exercise the exact bridge the Windows modal can adopt. The
                // chosen variant index belongs to the original displayed table;
                // monetary and tax columns must come from the fresh live row.
                DataTable displayedLive = Candidates();
                displayedLive.Columns.Add("REMISE", typeof(decimal));
                displayedLive.Columns.Add("TAUX_TVA", typeof(decimal));
                DataTable liveReordered = displayedLive.Clone();
                liveReordered.Rows.Add("3", "ABC-001", "Variant 2", 30m, 0m, 20m);
                liveReordered.Rows.Add("2", "ABC-001", "Variant", 42m, 15m, 7m);
                liveReordered.Rows.Add("1", "ABC-001", "Ordinary", 10m, 0m, 20m);
                int modalCalls = 0;
                int liveCalls = 0;
                CheckoutVariantChoiceResult freshChoice =
                    CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                        delegate(DataTable shown) {
                            if (!Object.ReferenceEquals(shown, displayedLive))
                                throw new Exception("Modal must display the original table");
                            modalCalls++;
                            return 1;
                        }, delegate { liveCalls++; return liveReordered; });
                if (freshChoice.Status != CheckoutVariantChoiceStatus.Selected ||
                    !Object.ReferenceEquals(freshChoice.SelectedRow, liveReordered.Rows[1]) ||
                    (decimal)freshChoice.SelectedRow["Prix_V_1"] != 42m ||
                    (decimal)freshChoice.SelectedRow["REMISE"] != 15m ||
                    (decimal)freshChoice.SelectedRow["TAUX_TVA"] != 7m ||
                    modalCalls != 1 || liveCalls != 1)
                    throw new Exception("Modal choice must use fresh ID, price, discount and tax");
                checks++;
                if (LOGICA.Domain.SalesLinePricing.CalculateNetAmount(
                    (decimal)freshChoice.SelectedRow["Prix_V_1"], 2m,
                    (decimal)freshChoice.SelectedRow["REMISE"]) != 71.4m ||
                    LOGICA.Domain.SalesLinePricing.CalculateNetAmount(
                    (decimal)freshChoice.SelectedRow["Prix_V_1"], -2m,
                    (decimal)freshChoice.SelectedRow["REMISE"]) != -71.4m)
                    throw new Exception("Refreshed variant preserves sale and return net values");
                checks++;
                DataTable liveMissing = liveReordered.Copy();
                liveMissing.Rows.RemoveAt(1);
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                    delegate(DataTable shown) { return 1; },
                    delegate { return liveMissing; }).Status != CheckoutVariantChoiceStatus.Missing)
                    throw new Exception("Removed live variant must fail closed");
                checks++;
                DataTable liveReused = liveReordered.Copy();
                liveReused.Rows[1]["Code"] = "REASSIGNED";
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                    delegate(DataTable shown) { return 1; },
                    delegate { return liveReused; }).Status != CheckoutVariantChoiceStatus.Ambiguous)
                    throw new Exception("Reused ID with changed barcode must fail closed");
                checks++;
                DataTable liveDuplicate = liveReordered.Copy();
                liveDuplicate.Rows[0]["ID_ARTICLE"] = "2";
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                    delegate(DataTable shown) { return 1; },
                    delegate { return liveDuplicate; }).Status != CheckoutVariantChoiceStatus.Ambiguous)
                    throw new Exception("Duplicate live ID must not reach the basket");
                checks++;
                DataTable liveInvalid = liveReordered.Copy();
                liveInvalid.Rows[0]["ID_ARTICLE"] = DBNull.Value;
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                    delegate(DataTable shown) { return 1; },
                    delegate { return liveInvalid; }).Status != CheckoutVariantChoiceStatus.InvalidCandidates)
                    throw new Exception("Invalid live catalogue must fail closed");
                checks++;
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                    delegate(DataTable shown) { return 1; },
                    delegate { return null; }).Status != CheckoutVariantChoiceStatus.InvalidCandidates)
                    throw new Exception("Null local query must never fall back to displayed price");
                checks++;
                int noRead = 0;
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                    delegate(DataTable shown) { return -1; },
                    delegate { noRead++; return liveReordered; }).Status != CheckoutVariantChoiceStatus.Cancelled ||
                    noRead != 0)
                    throw new Exception("Cancel must not requery or post");
                checks++;
                DataTable emptyDisplayed = displayedLive.Clone();
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(emptyDisplayed, null,
                    delegate { noRead++; return liveReordered; }).Status != CheckoutVariantChoiceStatus.Missing ||
                    noRead != 0)
                    throw new Exception("No-match must not read current catalogue");
                checks++;
                DataTable corruptDisplayed = displayedLive.Copy();
                corruptDisplayed.Rows[2]["ID_ARTICLE"] = "1";
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(corruptDisplayed,
                    delegate(DataTable shown) { throw new Exception("Unsafe chooser invoked"); },
                    delegate { noRead++; return liveReordered; }).Status != CheckoutVariantChoiceStatus.Ambiguous ||
                    noRead != 0)
                    throw new Exception("Invalid displayed identities must not open modal or query");
                checks++;
                DataTable singleDisplayed = Candidates();
                singleDisplayed.Rows.RemoveAt(2);
                singleDisplayed.Rows.RemoveAt(1);
                DataTable singleLive = singleDisplayed.Copy();
                singleLive.Rows[0]["Prix_V_1"] = 16m;
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(singleDisplayed, null,
                    delegate { noRead++; return singleLive; }).SelectedRow != singleLive.Rows[0] ||
                    noRead != 1)
                    throw new Exception("Single barcode candidate must also be refreshed");
                checks++;
                Exception readFailure = new InvalidOperationException("local store unavailable");
                try {
                    CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                        delegate(DataTable shown) { return 1; },
                        delegate { throw readFailure; });
                    throw new Exception("Local store failure swallowed");
                } catch (InvalidOperationException error) {
                    if (!Object.ReferenceEquals(error, readFailure))
                        throw new Exception("Local store failure identity changed");
                }
                checks++;
                Expect<ArgumentNullException>(delegate {
                    CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                        delegate(DataTable shown) { return 1; }, null);
                });
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
