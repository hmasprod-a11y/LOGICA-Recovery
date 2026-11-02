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
                // The opt-in SQL-refresh adapter must not silently reuse the
                // mutable modal table and present stale pricing as a live read.
                int sameTableReads = 0;
                CheckoutVariantChoiceResult sameTable =
                    CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                        delegate(DataTable shown) { return 1; },
                        delegate { sameTableReads++; return displayedLive; });
                if (sameTable.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    sameTable.SelectedRow != null || sameTableReads != 1)
                    throw new Exception("A same-table refresh must fail closed");
                checks++;
                DataTable reloadedCopy = displayedLive.Copy();
                reloadedCopy.Rows[1]["Prix_V_1"] = 55m;
                reloadedCopy.Rows[1]["REMISE"] = 20m;
                reloadedCopy.Rows[1]["TAUX_TVA"] = 6m;
                CheckoutVariantChoiceResult copiedRefresh =
                    CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                        delegate(DataTable shown) { return 1; },
                        delegate { return reloadedCopy; });
                if (copiedRefresh.Status != CheckoutVariantChoiceStatus.Selected ||
                    !Object.ReferenceEquals(copiedRefresh.SelectedRow, reloadedCopy.Rows[1]) ||
                    (decimal)copiedRefresh.SelectedRow["Prix_V_1"] != 55m ||
                    (decimal)copiedRefresh.SelectedRow["REMISE"] != 20m ||
                    (decimal)copiedRefresh.SelectedRow["TAUX_TVA"] != 6m)
                    throw new Exception("Distinct live table must preserve refreshed price, discount and tax");
                checks++;
                // The existing real WinForms Select path intentionally has no
                // second SQL query yet. It must remain functional and distinct
                // from the strict opt-in refresh contract.
                DataTable legacyFallback = Candidates();
                if (!Object.ReferenceEquals(CheckoutBarcodeSelectionService.Select(
                    legacyFallback, delegate(DataTable shown) { return 1; }),
                    legacyFallback.Rows[1]))
                    throw new Exception("Original Windows modal fallback must keep working");
                checks++;
                // The snapshot-based modern scanner adapter has the same
                // exact-barcode SQL contract as the real WinForms modal bridge.
                // A correct selected ID does not make a mixed SQL result safe.
                CheckoutVariantChoiceResult modernFresh =
                    CheckoutSelectionFlowService.ChooseBarcodeWithRefresh(displayedLive,
                        delegate(System.Collections.Generic.IList<CheckoutVariantSnapshot> variants) {
                            return 1;
                        }, delegate { return liveReordered; });
                if (modernFresh.Status != CheckoutVariantChoiceStatus.Selected ||
                    modernFresh.SelectedRow != liveReordered.Rows[1] ||
                    (decimal)modernFresh.SelectedRow["Prix_V_1"] != 42m ||
                    (decimal)modernFresh.SelectedRow["REMISE"] != 15m ||
                    (decimal)modernFresh.SelectedRow["TAUX_TVA"] != 7m)
                    throw new Exception("Modern scanner must select fresh variant price, discount and TVA");
                checks++;
                DataTable modernMixedSql = liveReordered.Copy();
                modernMixedSql.Rows[0]["Code"] = "FOREIGN-CODE";
                CheckoutVariantChoiceResult modernMixedChoice =
                    CheckoutSelectionFlowService.ChooseBarcodeWithRefresh(displayedLive,
                        delegate(System.Collections.Generic.IList<CheckoutVariantSnapshot> variants) {
                            return 1;
                        }, delegate { return modernMixedSql; });
                if (modernMixedChoice.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    modernMixedChoice.SelectedRow != null)
                    throw new Exception("Modern scanner must reject foreign SQL row beside selected variant");
                checks++;
                DataTable modernWrongOnly = displayedLive.Clone();
                modernWrongOnly.Rows.Add("UNRELATED", "FOREIGN-CODE", "Wrong", 100m, 0m, 20m);
                if (CheckoutSelectionFlowService.ChooseBarcodeWithRefresh(displayedLive,
                    delegate(System.Collections.Generic.IList<CheckoutVariantSnapshot> variants) {
                        return 1;
                    }, delegate { return modernWrongOnly; }).Status !=
                    CheckoutVariantChoiceStatus.InvalidCandidates)
                    throw new Exception("Modern wrong-only SQL result must not masquerade as missing");
                checks++;
                DataTable modernNullCode = liveReordered.Copy();
                modernNullCode.Rows[2]["Code"] = DBNull.Value;
                if (CheckoutSelectionFlowService.ChooseBarcodeWithRefresh(displayedLive,
                    delegate(System.Collections.Generic.IList<CheckoutVariantSnapshot> variants) {
                        return 1;
                    }, delegate { return modernNullCode; }).Status !=
                    CheckoutVariantChoiceStatus.InvalidCandidates)
                    throw new Exception("Modern scanner cannot accept NULL barcode in live SQL");
                checks++;
                int modernCancelReads = 0;
                if (CheckoutSelectionFlowService.ChooseBarcodeWithRefresh(displayedLive,
                    delegate(System.Collections.Generic.IList<CheckoutVariantSnapshot> variants) {
                        return -1;
                    }, delegate { modernCancelReads++; return modernMixedSql; }).Status !=
                    CheckoutVariantChoiceStatus.Cancelled || modernCancelReads != 0)
                    throw new Exception("Cancelled modern scanner must not query or price a product");
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
                // A raw ID-based choice diagnoses reassignment as Ambiguous.
                // The scanner adapter has the stricter SQL exact-barcode
                // contract: ANY returned foreign barcode is InvalidCandidates,
                // before selected-ID resolution. Never allow either to post.
                CheckoutVariantChoiceResult reassignedScanner =
                    CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                        delegate(DataTable shown) { return 1; },
                        delegate { return liveReused; });
                if (reassignedScanner.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    reassignedScanner.SelectedRow != null)
                    throw new Exception("Scanner must reject changed-barcode SQL result as invalid");
                checks++;
                CheckoutVariantChoiceResult reassignedIdentity =
                    CheckoutVariantSnapshotService.EvaluateChoice(liveReused,
                        CheckoutVariantSnapshotService.Read(displayedLive), 1);
                if (reassignedIdentity.Status != CheckoutVariantChoiceStatus.Ambiguous ||
                    reassignedIdentity.SelectedRow != null)
                    throw new Exception("Raw identity resolver must report reassigned ID as ambiguous");
                checks++;
                DataTable liveDuplicate = liveReordered.Copy();
                liveDuplicate.Rows[0]["ID_ARTICLE"] = "2";
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                    delegate(DataTable shown) { return 1; },
                    delegate { return liveDuplicate; }).Status != CheckoutVariantChoiceStatus.Ambiguous)
                    throw new Exception("Duplicate live ID must not reach the basket");
                checks++;
                // A misfiltered exact-barcode SQL result must remain invalid
                // even if it also contains a duplicate article identity.
                // Never let duplicate-ID classification mask the query breach.
                DataTable duplicateAndForeignCode = liveReordered.Copy();
                duplicateAndForeignCode.Rows[0]["ID_ARTICLE"] = "2";
                duplicateAndForeignCode.Rows[1]["Code"] = "FOREIGN-CODE";
                int foreignSqlReads = 0;
                CheckoutVariantChoiceResult invalidBeforeAmbiguous =
                    CheckoutBarcodeSelectionService.SelectWithRefresh("ABC-001", displayedLive,
                        delegate(DataTable shown) { return 1; },
                        delegate { foreignSqlReads++; return duplicateAndForeignCode; });
                if (invalidBeforeAmbiguous.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    invalidBeforeAmbiguous.SelectedRow != null || foreignSqlReads != 1)
                    throw new Exception("Foreign SQL barcode must outrank duplicate-ID ambiguity");
                checks++;
                // The original modal fallback still uses only the displayed
                // catalogue and does not execute the opt-in local SQL callback.
                if (CheckoutBarcodeSelectionService.Select(Candidates(),
                        delegate(DataTable shown) { return 1; }) == null ||
                    foreignSqlReads != 1)
                    throw new Exception("Legacy scanner fallback must not issue refresh SQL");
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

                // The UI must capture the scan text before the modal. A query
                // returning a consistent but WRONG barcode is not proof that
                // the cashier scanned that article. This overload checks both
                // the initial display and the post-modal local SQL refresh.
                int capturedModalCalls = 0;
                int capturedSqlReads = 0;
                CheckoutVariantChoiceResult capturedChoice =
                    CheckoutBarcodeSelectionService.SelectWithRefresh("ABC-001", displayedLive,
                        delegate(DataTable shown) { capturedModalCalls++; return 1; },
                        delegate { capturedSqlReads++; return liveReordered; });
                if (capturedChoice.Status != CheckoutVariantChoiceStatus.Selected ||
                    !Object.ReferenceEquals(capturedChoice.SelectedRow, liveReordered.Rows[1]) ||
                    (decimal)capturedChoice.SelectedRow["Prix_V_1"] != 42m ||
                    (decimal)capturedChoice.SelectedRow["REMISE"] != 15m ||
                    (decimal)capturedChoice.SelectedRow["TAUX_TVA"] != 7m ||
                    capturedModalCalls != 1 || capturedSqlReads != 1)
                    throw new Exception("Captured scan must preserve fresh live pricing and selected variant");
                checks++;
                CheckoutVariantChoiceResult wrongCaptured =
                    CheckoutBarcodeSelectionService.SelectWithRefresh("NOT-SCANNED", displayedLive,
                        delegate(DataTable shown) { capturedModalCalls++; return 1; },
                        delegate { capturedSqlReads++; return liveReordered; });
                if (wrongCaptured.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    wrongCaptured.SelectedRow != null || capturedModalCalls != 1 || capturedSqlReads != 1)
                    throw new Exception("Wrong initial barcode must not open modal or query SQL");
                checks++;
                CheckoutVariantChoiceResult blankCaptured =
                    CheckoutBarcodeSelectionService.SelectWithRefresh(" ", displayedLive,
                        delegate(DataTable shown) { capturedModalCalls++; return 1; },
                        delegate { capturedSqlReads++; return liveReordered; });
                if (blankCaptured.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    blankCaptured.SelectedRow != null || capturedModalCalls != 1 || capturedSqlReads != 1)
                    throw new Exception("Blank captured scan must not enter barcode checkout");
                checks++;
                CheckoutVariantChoiceResult caseMismatch =
                    CheckoutBarcodeSelectionService.SelectWithRefresh("abc-001", displayedLive,
                        delegate(DataTable shown) { capturedModalCalls++; return 1; },
                        delegate { capturedSqlReads++; return liveReordered; });
                if (caseMismatch.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    capturedModalCalls != 1 || capturedSqlReads != 1)
                    throw new Exception("Scanner identity comparison must remain ordinal across cultures");
                checks++;
                CheckoutVariantChoiceResult capturedCancelled =
                    CheckoutBarcodeSelectionService.SelectWithRefresh("ABC-001", displayedLive,
                        delegate(DataTable shown) { return -1; },
                        delegate { capturedSqlReads++; return liveReordered; });
                if (capturedCancelled.Status != CheckoutVariantChoiceStatus.Cancelled ||
                    capturedSqlReads != 1)
                    throw new Exception("Captured scan cancellation must not requery local SQL");
                checks++;
                DataTable capturedMixedLive = liveReordered.Copy();
                capturedMixedLive.Rows[0]["Code"] = "DIFFERENT";
                CheckoutVariantChoiceResult capturedWrongLive =
                    CheckoutBarcodeSelectionService.SelectWithRefresh("ABC-001", displayedLive,
                        delegate(DataTable shown) { return 1; },
                        delegate { return capturedMixedLive; });
                if (capturedWrongLive.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    capturedWrongLive.SelectedRow != null)
                    throw new Exception("Captured scan rejects an unrelated live SQL barcode");
                checks++;

                // The actual scanner SQL is WHERE Code = @code. A mixed-code
                // initial result is never a legitimate duplicate-barcode list:
                // do not show the modal or read the store for such candidates.
                DataTable scanMixedDisplayed = Candidates();
                scanMixedDisplayed.Rows[2]["Code"] = "UNRELATED";
                int scanMixedDialogCalls = 0;
                int scanMixedReadCalls = 0;
                CheckoutVariantChoiceResult scanMixedChoice =
                    CheckoutBarcodeSelectionService.SelectWithRefresh(scanMixedDisplayed,
                        delegate(DataTable shown) { scanMixedDialogCalls++; return 1; },
                        delegate { scanMixedReadCalls++; return Candidates(); });
                if (scanMixedChoice.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    scanMixedChoice.SelectedRow != null || scanMixedDialogCalls != 0 ||
                    scanMixedReadCalls != 0 ||
                    CheckoutBarcodeSelectionService.Select(scanMixedDisplayed,
                        delegate(DataTable shown) { throw new Exception("Unsafe scanner modal"); }) != null)
                    throw new Exception("Mixed scanner barcode result must fail before modal or requery");
                checks++;

                // A new SQL result can accidentally contain another barcode,
                // e.g. when the UI callback loses the original scanner filter.
                // Even a still-valid selected ID must not reach legacy pricing.
                DataTable scanMixedLive = liveReordered.Copy();
                scanMixedLive.Rows[0]["Code"] = "UNRELATED";
                CheckoutVariantChoiceResult scanMixedRefresh =
                    CheckoutBarcodeSelectionService.SelectWithRefresh(displayedLive,
                        delegate(DataTable shown) { return 1; },
                        delegate { return scanMixedLive; });
                if (scanMixedRefresh.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    scanMixedRefresh.SelectedRow != null)
                    throw new Exception("Refreshed scanner candidates must all match the scanned barcode");
                checks++;

                // An exact-barcode SQL callback returning only unrelated IDs
                // must be InvalidCandidates, not a benign Missing selection.
                // The latter could incorrectly trigger a legacy fallback.
                DataTable wrongOnlyRefresh = liveReordered.Clone();
                wrongOnlyRefresh.ImportRow(liveReordered.Rows[0]);
                wrongOnlyRefresh.Rows[0]["ID_ARTICLE"] = "NOT-SELECTED";
                wrongOnlyRefresh.Rows[0]["Code"] = "WRONG-SQL-FILTER";
                CheckoutVariantChoiceResult wrongOnlyResult =
                    CheckoutBarcodeSelectionService.SelectWithRefresh("ABC-001", displayedLive,
                        delegate(DataTable dialogRows) { return 1; },
                        delegate { return wrongOnlyRefresh; });
                if (wrongOnlyResult.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    wrongOnlyResult.SelectedRow != null)
                    throw new Exception("Wrong-only SQL refresh must be invalid, not missing");
                checks++;
                DataTable trulyMissingRefresh = liveReordered.Clone();
                CheckoutVariantChoiceResult trulyMissingResult =
                    CheckoutBarcodeSelectionService.SelectWithRefresh("ABC-001", displayedLive,
                        delegate(DataTable dialogRows) { return 1; },
                        delegate { return trulyMissingRefresh; });
                if (trulyMissingResult.Status != CheckoutVariantChoiceStatus.Missing ||
                    trulyMissingResult.SelectedRow != null)
                    throw new Exception("Empty exact-barcode refresh must remain Missing");
                checks++;
                DataTable nullCodeRefresh = liveReordered.Clone();
                nullCodeRefresh.ImportRow(liveReordered.Rows[0]);
                nullCodeRefresh.Rows[0]["Code"] = DBNull.Value;
                if (CheckoutBarcodeSelectionService.SelectWithRefresh("ABC-001", displayedLive,
                    delegate(DataTable dialogRows) { return 1; },
                    delegate { return nullCodeRefresh; }).Status !=
                    CheckoutVariantChoiceStatus.InvalidCandidates)
                    throw new Exception("SQL NULL barcode must not masquerade as missing scanner variant");
                checks++;

                DataTable scanBlankDisplayed = Candidates();
                scanBlankDisplayed.Rows.RemoveAt(2);
                scanBlankDisplayed.Rows.RemoveAt(1);
                scanBlankDisplayed.Rows[0]["Code"] = "  ";
                int scanBlankReadCalls = 0;
                if (CheckoutBarcodeSelectionService.SelectWithRefresh(scanBlankDisplayed, null,
                    delegate { scanBlankReadCalls++; return scanBlankDisplayed.Copy(); }).Status !=
                    CheckoutVariantChoiceStatus.InvalidCandidates || scanBlankReadCalls != 0 ||
                    CheckoutBarcodeSelectionService.Select(scanBlankDisplayed, null) != null)
                    throw new Exception("Blank image-only barcode must not enter the scanner path");
                checks++;

                // SQL schema TABLE_ARTICLES.Code permits NULL. This is a valid
                // image-only tile, not a scanner barcode. Verify the exact
                // production selection services in all three POS cultures.
                DataTable imageNull = Candidates();
                imageNull.Rows.Clear();
                imageNull.Columns.Add("REMISE", typeof(decimal));
                imageNull.Columns.Add("TAUX_TVA", typeof(decimal));
                imageNull.Rows.Add("IMG-NULL", DBNull.Value, "Image only", 10m, 0m, 20m);
                CheckoutArticleTileReference imageNullTile =
                    CheckoutArticleTileSelectionService.TagFor(imageNull.Rows[0]);
                if (imageNullTile.Code != "" || imageNullTile.ArticleId != "IMG-NULL" ||
                    CheckoutArticleTileSelectionService.FindExact(imageNull, imageNullTile) != imageNull.Rows[0] ||
                    !imageNull.Rows[0].IsNull("Code"))
                    throw new Exception("Nullable image barcode must retain original catalogue identity");
                checks++;
                DataTable imageNullLive = imageNull.Copy();
                imageNullLive.Rows[0]["Prix_V_1"] = 15m;
                imageNullLive.Rows[0]["REMISE"] = 10m;
                imageNullLive.Rows[0]["TAUX_TVA"] = 7m;
                CheckoutVariantChoiceResult imageNullChoice =
                    CheckoutSelectionFlowService.ChooseImageWithRefresh(imageNullTile,
                        delegate { return imageNullLive; });
                if (imageNullChoice.Status != CheckoutVariantChoiceStatus.Selected ||
                    imageNullChoice.SelectedRow != imageNullLive.Rows[0] ||
                    (decimal)imageNullChoice.SelectedRow["Prix_V_1"] != 15m ||
                    (decimal)imageNullChoice.SelectedRow["REMISE"] != 10m ||
                    (decimal)imageNullChoice.SelectedRow["TAUX_TVA"] != 7m)
                    throw new Exception("Nullable image barcode must refresh price, discount and TVA by article ID");
                checks++;
                if (CheckoutBarcodeSelectionService.Select(imageNull, null) != null ||
                    CheckoutVariantSnapshotService.EvaluateSnapshot(imageNull).Status !=
                        CheckoutVariantSnapshotReadStatus.InvalidCandidates)
                    throw new Exception("Scanner must continue rejecting SQL NULL barcode");
                checks++;
                // A local image lookup is expected to be WHERE ID_ARTICLE=@id.
                // Do not accept a misfiltered result merely because it also
                // contains the selected image-only product with valid pricing.
                DataTable imageMixedIds = imageNullLive.Copy();
                imageMixedIds.Rows.Add("UNRELATED-NULL", DBNull.Value, "Other", 99m, 0m, 20m);
                CheckoutVariantChoiceResult imageMixedChoice =
                    CheckoutSelectionFlowService.ChooseImageWithRefresh(imageNullTile,
                        delegate { return imageMixedIds; });
                if (imageMixedChoice.Status != CheckoutVariantChoiceStatus.InvalidCandidates ||
                    imageMixedChoice.SelectedRow != null ||
                    CheckoutArticleTileSelectionService.FindExact(imageMixedIds, imageNullTile) !=
                        imageMixedIds.Rows[0])
                    throw new Exception("Exact-ID refresh must reject unrelated image SQL rows while broad lookup remains valid");
                checks++;
                DataTable imageWrongOnly = imageNullLive.Copy();
                imageWrongOnly.Rows[0]["ID_ARTICLE"] = "WRONG-ID";
                if (CheckoutSelectionFlowService.ChooseImageWithRefresh(imageNullTile,
                    delegate { return imageWrongOnly; }).Status !=
                    CheckoutVariantChoiceStatus.InvalidCandidates)
                    throw new Exception("Wrong-only image SQL query must not masquerade as missing");
                checks++;
                DataTable imageMissing = imageNullLive.Clone();
                if (CheckoutSelectionFlowService.ChooseImageWithRefresh(imageNullTile,
                    delegate { return imageMissing; }).Status != CheckoutVariantChoiceStatus.Missing)
                    throw new Exception("Empty exact-ID image query must remain Missing");
                checks++;
                DataTable imageDuplicate = imageNullLive.Copy();
                imageDuplicate.ImportRow(imageNullLive.Rows[0]);
                if (CheckoutSelectionFlowService.ChooseImageWithRefresh(imageNullTile,
                    delegate { return imageDuplicate; }).Status != CheckoutVariantChoiceStatus.Ambiguous)
                    throw new Exception("Duplicate exact image identity must be ambiguous");
                checks++;
                DataTable imageBadSchema = new DataTable();
                imageBadSchema.Columns.Add("Code", typeof(string));
                imageBadSchema.Rows.Add(DBNull.Value);
                if (CheckoutSelectionFlowService.ChooseImageWithRefresh(imageNullTile,
                    delegate { return imageBadSchema; }).Status !=
                    CheckoutVariantChoiceStatus.InvalidCandidates)
                    throw new Exception("Incomplete image SQL projection must fail closed");
                checks++;
                int malformedImageQueries = 0;
                if (CheckoutSelectionFlowService.ChooseImageWithRefresh(
                        new CheckoutArticleTileReference("", " "),
                        delegate { malformedImageQueries++; return imageNullLive; }).Status !=
                        CheckoutVariantChoiceStatus.InvalidCandidates || malformedImageQueries != 0)
                    throw new Exception("Malformed image identity must not query local SQL");
                checks++;
                Exception imageQueryFailure = new InvalidOperationException("image reader failed");
                try {
                    CheckoutSelectionFlowService.ChooseImageWithRefresh(imageNullTile,
                        delegate { throw imageQueryFailure; });
                    throw new Exception("Image query failure was swallowed");
                } catch (InvalidOperationException error) {
                    if (!Object.ReferenceEquals(error, imageQueryFailure))
                        throw new Exception("Image query failure identity changed");
                }
                checks++;
                imageNullLive.Rows[0]["Code"] = "REASSIGNED";
                if (CheckoutArticleTileSelectionService.EvaluateExact(imageNullLive, imageNullTile).Status !=
                    CheckoutVariantChoiceStatus.Ambiguous)
                    throw new Exception("Image-only article barcode reassignment must fail closed");
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
