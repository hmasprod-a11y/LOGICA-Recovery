using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using LOGICA.Domain;
using LOGICA.ApplicationLayer.Checkout;

// Portable test implementation is deliberately NOT the production VB adapter.
// It proves source isolation and orchestration, not cross-runtime VB parity.
internal static class PortableCheckoutSmoke
{
    private sealed class Semantics : ILegacyCheckoutSemantics
    {
        public bool EqualsText(string a, string b) { return String.Equals(a ?? "", b ?? "", StringComparison.Ordinal); }
        public double ToDouble(string value) { return Convert.ToDouble(value, CultureInfo.InvariantCulture); }
        public decimal ToDecimal(string value) { return Convert.ToDecimal(value, CultureInfo.InvariantCulture); }
        public double Val(object value) { return Convert.ToDouble(value, CultureInfo.InvariantCulture); }
        public bool IsStockBelow(object a, object b)
        {
            return Convert.ToDouble(a, CultureInfo.InvariantCulture) < Convert.ToDouble(b, CultureInfo.InvariantCulture);
        }
    }
    private sealed class Lookup : IStockAvailabilityLookup
    {
        public int Calls;
        public int Names;
        public StockLookupResult FindByCode(object articleCode)
        {
            Calls++;
            return new StockLookupResult {
                Found = true,
                AvailableStock = 1m,
                ReadArticleName = delegate { Names++; return "First"; }
            };
        }
    }
    private static void Require(bool condition, string message)
    {
        if (!condition) throw new Exception(message);
    }
    public static int Run()
    {
        CultureInfo original = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var variants = new DataTable();
            variants.Columns.Add("Code", typeof(string));
            variants.Columns.Add("ID_ARTICLE", typeof(string));
            variants.Rows.Add("123", "A");
            variants.Rows.Add("123", "B");
            var snapshots = CheckoutVariantSnapshotService.Read(variants);
            bool nullReadRejected = false;
            try { CheckoutVariantSnapshotService.Read(null); }
            catch (ArgumentNullException) { nullReadRejected = true; }
            Require(nullReadRejected, "Null variant source rejected");
            bool nullResolveRejected = false;
            try { CheckoutVariantSnapshotService.Resolve(null, snapshots[0]); }
            catch (ArgumentNullException) { nullResolveRejected = true; }
            Require(nullResolveRejected, "Null candidate table rejected");
            Require(snapshots.Count == 2, "Duplicate barcode variants retained");
            Require(Object.ReferenceEquals(CheckoutVariantSnapshotService.Resolve(variants, snapshots[1]),
                variants.Rows[1]), "Selected variant must resolve exact ID");
            Require(Object.ReferenceEquals(
                CheckoutVariantSnapshotService.ResolveChosenVariant(variants, snapshots, 1),
                variants.Rows[1]), "Explicit duplicate-barcode choice must retain article ID");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(variants, snapshots, -1) == null,
                "Cancellation must not select the first variant");
            bool invalidIndexRejected = false;
            try { CheckoutVariantSnapshotService.ResolveChosenVariant(variants, snapshots, 2); }
            catch (ArgumentOutOfRangeException) { invalidIndexRejected = true; }
            Require(invalidIndexRejected, "Out-of-range choice must be rejected");
            invalidIndexRejected = false;
            try { CheckoutVariantSnapshotService.ResolveChosenVariant(variants, snapshots, -2); }
            catch (ArgumentOutOfRangeException) { invalidIndexRejected = true; }
            Require(invalidIndexRejected, "Negative index other than cancellation must be rejected");
            bool nullDisplayedRejected = false;
            try { CheckoutVariantSnapshotService.ResolveChosenVariant(variants, null, 0); }
            catch (ArgumentNullException) { nullDisplayedRejected = true; }
            Require(nullDisplayedRejected, "Missing displayed snapshot must be rejected");
            bool nullCurrentRejected = false;
            try { CheckoutVariantSnapshotService.ResolveChosenVariant(null, snapshots, -1); }
            catch (ArgumentNullException) { nullCurrentRejected = true; }
            Require(nullCurrentRejected, "Missing live query must be rejected even on cancellation");

            DataTable reordered = variants.Clone();
            reordered.Rows.Add("123", "B");
            reordered.Rows.Add("123", "A");
            Require(Object.ReferenceEquals(
                CheckoutVariantSnapshotService.ResolveChosenVariant(reordered, snapshots, 1),
                reordered.Rows[0]), "Reordered live query must resolve identity rather than index");
            reordered.Rows[0]["ID_ARTICLE"] = "C";
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(reordered, snapshots, 1) == null,
                "Changed article identity must fail closed");
            Require(snapshots[1].ArticleId == "B" && snapshots[1].Code == "123",
                "Displayed snapshot must not mutate when query rows change");
            DataTable ambiguous = variants.Clone();
            ambiguous.Rows.Add("123", "B");
            ambiguous.Rows.Add("123", "B");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(ambiguous, snapshots, 1) == null,
                "Ambiguous identical identities must never post a sale");
            DataTable missingIdentity = variants.Clone();
            missingIdentity.Rows.Add(DBNull.Value, "A");
            bool invalidIdentityRejected = false;
            try { CheckoutVariantSnapshotService.Read(missingIdentity); }
            catch (InvalidOperationException) { invalidIdentityRejected = true; }
            Require(invalidIdentityRejected, "Null barcode must not enter displayed snapshot");
            Require(variants.Rows.Count == 2 && variants.Rows[0]["ID_ARTICLE"].ToString() == "A",
                "Selection must never modify the live table");
            variants.Rows.RemoveAt(1);
            Require(CheckoutVariantSnapshotService.Resolve(variants, snapshots[1]) == null,
                "Stale variant must fail closed");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(variants, snapshots, 1) == null,
                "Stale explicit choice must fail closed");
            // Typed modern UI outcomes are read-only and never equate cancel
            // with missing, corrupt or ambiguous inventory identities.
            DataTable outcomeRows = variants.Clone();
            outcomeRows.Rows.Add("123", "A");
            outcomeRows.Rows.Add("123", "B");
            // Modern chooser snapshot creation is all-or-nothing. Distinct
            // article IDs may share a barcode, but an ID cannot occur twice.
            var validRead = CheckoutVariantSnapshotService.EvaluateSnapshot(outcomeRows);
            Require(validRead.Status == CheckoutVariantSnapshotReadStatus.Ready &&
                validRead.Snapshots.Count == 2 &&
                validRead.Snapshots[0].ArticleId == "A" &&
                validRead.Snapshots[1].ArticleId == "B",
                "Typed snapshot must retain distinct variants sharing a barcode");
            bool typedReadNullRejected = false;
            try { CheckoutVariantSnapshotService.EvaluateSnapshot(null); }
            catch (ArgumentNullException) { typedReadNullRejected = true; }
            Require(typedReadNullRejected, "Typed snapshot must reject null query");

            DataTable missingReadSchema = new DataTable();
            missingReadSchema.Columns.Add("ID_ARTICLE", typeof(string));
            missingReadSchema.Rows.Add("A");
            var missingRead = CheckoutVariantSnapshotService.EvaluateSnapshot(missingReadSchema);
            Require(missingRead.Status == CheckoutVariantSnapshotReadStatus.InvalidCandidates &&
                missingRead.Snapshots.Count == 0, "Incomplete snapshot schema must fail closed");
            bool missingReadThrowsControlled = false;
            try { CheckoutVariantSnapshotService.Read(missingReadSchema); }
            catch (InvalidOperationException) { missingReadThrowsControlled = true; }
            Require(missingReadThrowsControlled, "Legacy Read must throw controlled invalid-schema error");

            DataTable duplicateReadIds = outcomeRows.Clone();
            duplicateReadIds.Rows.Add("123", "A");
            duplicateReadIds.Rows.Add("OTHER", "A");
            var duplicateRead = CheckoutVariantSnapshotService.EvaluateSnapshot(duplicateReadIds);
            Require(duplicateRead.Status == CheckoutVariantSnapshotReadStatus.Ambiguous &&
                duplicateRead.Snapshots.Count == 0,
                "Repeated ID under another barcode must not produce a partial snapshot");
            bool duplicateReadRejected = false;
            try { CheckoutVariantSnapshotService.Read(duplicateReadIds); }
            catch (InvalidOperationException) { duplicateReadRejected = true; }
            Require(duplicateReadRejected, "Read must reject repeated catalogue ID");

            DataTable corruptDuplicateRead = duplicateReadIds.Copy();
            corruptDuplicateRead.Rows.Add(DBNull.Value, "BROKEN");
            var corruptDuplicateResult = CheckoutVariantSnapshotService.EvaluateSnapshot(corruptDuplicateRead);
            Require(corruptDuplicateResult.Status == CheckoutVariantSnapshotReadStatus.InvalidCandidates &&
                corruptDuplicateResult.Snapshots.Count == 0,
                "Malformed row must take precedence over repeated ID during snapshot read");

            DataTable missingReadId = outcomeRows.Clone();
            missingReadId.Rows.Add("123", DBNull.Value);
            Require(CheckoutVariantSnapshotService.EvaluateSnapshot(missingReadId).Status ==
                CheckoutVariantSnapshotReadStatus.InvalidCandidates, "Null ID invalidates snapshot");
            DataTable emptyReadId = outcomeRows.Clone();
            emptyReadId.Rows.Add("123", "");
            Require(CheckoutVariantSnapshotService.EvaluateSnapshot(emptyReadId).Status ==
                CheckoutVariantSnapshotReadStatus.InvalidCandidates, "Empty ID invalidates snapshot");

            DataTable deletedDuplicateRead = duplicateReadIds.Copy();
            deletedDuplicateRead.AcceptChanges();
            deletedDuplicateRead.Rows[1].Delete();
            var deletedDuplicateResult = CheckoutVariantSnapshotService.EvaluateSnapshot(deletedDuplicateRead);
            Require(deletedDuplicateResult.Status == CheckoutVariantSnapshotReadStatus.Ready &&
                deletedDuplicateResult.Snapshots.Count == 1 &&
                deletedDuplicateResult.Snapshots[0].ArticleId == "A",
                "Deleted duplicate row must not poison active snapshot");
            DataTable emptyRead = outcomeRows.Clone();
            Require(CheckoutVariantSnapshotService.EvaluateSnapshot(emptyRead).Status ==
                CheckoutVariantSnapshotReadStatus.Ready &&
                CheckoutVariantSnapshotService.Read(emptyRead).Count == 0,
                "Valid empty catalogue result is a ready empty snapshot");
            DataTable ordinalRead = outcomeRows.Clone();
            ordinalRead.Rows.Add("SAME", "id");
            ordinalRead.Rows.Add("SAME", "ID");
            Require(CheckoutVariantSnapshotService.EvaluateSnapshot(ordinalRead).Status ==
                CheckoutVariantSnapshotReadStatus.Ready,
                "Identity comparison must preserve ordinal case-sensitive IDs");
            DataTable modifiedRead = outcomeRows.Copy();
            modifiedRead.AcceptChanges();
            modifiedRead.Rows[0]["Code"] = "UPDATED";
            var modifiedSnapshot = CheckoutVariantSnapshotService.EvaluateSnapshot(modifiedRead);
            Require(modifiedSnapshot.Status == CheckoutVariantSnapshotReadStatus.Ready &&
                modifiedSnapshot.Snapshots[0].Code == "UPDATED" &&
                modifiedRead.Rows[0].RowState == DataRowState.Modified,
                "Snapshot must read current values without mutating live row state");
            Require(validRead.Snapshots[0].Code == "123",
                "Already displayed snapshot must remain immutable after other reads");
            Console.WriteLine("PASS modern variant snapshot validation: duplicate IDs, invalid schema, corrupt precedence, deletion and immutability");
            var selectedOutcome = CheckoutVariantSnapshotService.EvaluateChoice(outcomeRows, snapshots, 1);
            Require(selectedOutcome.Status == CheckoutVariantChoiceStatus.Selected &&
                Object.ReferenceEquals(selectedOutcome.SelectedRow, outcomeRows.Rows[1]),
                "Typed outcome must preserve selected article identity");
            // A valid selected row must not conceal duplicate IDs elsewhere
            // in the *current* catalogue query. The snapshot and all chooser
            // entry points must agree on live candidate integrity.
            DataTable unrelatedLiveCollision = outcomeRows.Copy();
            unrelatedLiveCollision.Rows.Add("OTHER-CODE", "UNRELATED");
            unrelatedLiveCollision.Rows.Add("DIFFERENT-CODE", "UNRELATED");
            Require(CheckoutVariantSnapshotService.EvaluateSnapshot(unrelatedLiveCollision).Status ==
                CheckoutVariantSnapshotReadStatus.Ambiguous,
                "Snapshot rejects duplicate unrelated live IDs");
            var unrelatedLiveChoice = CheckoutVariantSnapshotService.EvaluateChoice(
                unrelatedLiveCollision, snapshots, 1);
            Require(unrelatedLiveChoice.Status == CheckoutVariantChoiceStatus.Ambiguous &&
                unrelatedLiveChoice.SelectedRow == null,
                "Typed choice rejects duplicate unrelated live IDs");
            Require(CheckoutVariantSnapshotService.Resolve(
                unrelatedLiveCollision, snapshots[1]) == null,
                "Null-returning resolver rejects duplicate unrelated live IDs");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(
                unrelatedLiveCollision, snapshots, 1) == null,
                "Index chooser rejects duplicate unrelated live IDs");
            var unrelatedLiveTile = CheckoutArticleTileSelectionService.TagFor(outcomeRows.Rows[1]);
            Require(CheckoutArticleTileSelectionService.EvaluateExact(
                unrelatedLiveCollision, unrelatedLiveTile).Status ==
                CheckoutVariantChoiceStatus.Ambiguous,
                "Image tile choice shares full live identity validation");
            Require(CheckoutArticleTileSelectionService.FindExact(
                unrelatedLiveCollision, unrelatedLiveTile) == null,
                "Image tile resolver rejects duplicate unrelated live IDs");
            Require(CheckoutVariantSnapshotService.EvaluateChoice(
                unrelatedLiveCollision,
                new[] { new CheckoutVariantSnapshot("NOT-PRESENT", "MISSING") }, 0).Status ==
                CheckoutVariantChoiceStatus.Ambiguous,
                "Unrelated live duplicate takes precedence over missing selection");
            unrelatedLiveCollision.Rows.Add(DBNull.Value, "BROKEN");
            Require(CheckoutVariantSnapshotService.EvaluateChoice(
                unrelatedLiveCollision, snapshots, 1).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Malformed live candidate takes precedence over unrelated duplicate");
            Require(CheckoutArticleTileSelectionService.FindExact(
                unrelatedLiveCollision, unrelatedLiveTile) == null,
                "Malformed live candidate never escapes image tile resolver");
            unrelatedLiveCollision.Rows.RemoveAt(unrelatedLiveCollision.Rows.Count - 1);
            unrelatedLiveCollision.AcceptChanges();
            unrelatedLiveCollision.Rows[3].Delete();
            Require(CheckoutVariantSnapshotService.EvaluateChoice(
                unrelatedLiveCollision, snapshots, 1).Status ==
                CheckoutVariantChoiceStatus.Selected,
                "Pending-deleted unrelated duplicate does not poison live selection");
            Require(CheckoutVariantSnapshotService.EvaluateSnapshot(
                unrelatedLiveCollision).Status == CheckoutVariantSnapshotReadStatus.Ready,
                "Snapshot and chooser agree after unrelated duplicate deletion");
            Require(Object.ReferenceEquals(CheckoutArticleTileSelectionService.FindExact(
                unrelatedLiveCollision, unrelatedLiveTile), unrelatedLiveCollision.Rows[1]),
                "Image tile revalidation retains exact selected row after deletion");
            Require(unrelatedLiveCollision.Rows[3].RowState == DataRowState.Deleted &&
                unrelatedLiveCollision.Rows[1]["ID_ARTICLE"].ToString() == "B",
                "Live candidate validation never mutates row states or identities");
            Console.WriteLine("PASS modern live catalogue uniqueness: unrelated duplicate IDs, invalid precedence, tile parity and deletion");
            // A modern caller can construct or modify an IList after the
            // snapshot was displayed. Do not trust only the selected entry:
            // duplicate IDs elsewhere in the displayed list make it unsafe.
            var duplicateDisplayed = new List<CheckoutVariantSnapshot> {
                new CheckoutVariantSnapshot("123", "A"),
                new CheckoutVariantSnapshot("123", "B"),
                new CheckoutVariantSnapshot("OTHER", "B")
            };
            Require(CheckoutVariantSnapshotService.EvaluateChoice(
                outcomeRows, duplicateDisplayed, 0).Status ==
                CheckoutVariantChoiceStatus.Ambiguous,
                "Duplicate displayed ID must invalidate even an unrelated selected entry");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(
                outcomeRows, duplicateDisplayed, 1) == null,
                "Null-returning chooser must reject duplicate displayed identities");
            var malformedDisplayed = new List<CheckoutVariantSnapshot> {
                new CheckoutVariantSnapshot("123", "B"),
                new CheckoutVariantSnapshot(null, "BROKEN")
            };
            Require(CheckoutVariantSnapshotService.EvaluateChoice(
                outcomeRows, malformedDisplayed, 0).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Malformed unrelated displayed barcode must invalidate selection");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(
                outcomeRows, malformedDisplayed, 0) == null,
                "Null-returning chooser must reject malformed displayed barcode");
            var nullDisplayedEntry = new List<CheckoutVariantSnapshot> {
                new CheckoutVariantSnapshot("123", "B"), null
            };
            Require(CheckoutVariantSnapshotService.EvaluateChoice(
                outcomeRows, nullDisplayedEntry, 0).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Null unrelated displayed entry must invalidate the whole chooser");
            var emptyDisplayedId = new List<CheckoutVariantSnapshot> {
                new CheckoutVariantSnapshot("123", "B"),
                new CheckoutVariantSnapshot("123", "")
            };
            Require(CheckoutVariantSnapshotService.EvaluateChoice(
                outcomeRows, emptyDisplayedId, 0).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Blank unrelated displayed ID must fail closed");
            var corruptAndDuplicateDisplayed = new List<CheckoutVariantSnapshot> {
                new CheckoutVariantSnapshot("123", "B"),
                new CheckoutVariantSnapshot("OTHER", "B"),
                new CheckoutVariantSnapshot(null, "INVALID")
            };
            Require(CheckoutVariantSnapshotService.EvaluateChoice(
                outcomeRows, corruptAndDuplicateDisplayed, 0).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Malformed displayed entry must take precedence over duplicate ID");
            Require(CheckoutVariantSnapshotService.EvaluateChoice(
                outcomeRows, duplicateDisplayed, -1).Status ==
                CheckoutVariantChoiceStatus.Cancelled &&
                CheckoutVariantSnapshotService.ResolveChosenVariant(
                    outcomeRows, duplicateDisplayed, -1) == null,
                "Explicit cancellation must remain independent of displayed list validation");
            Require(Object.ReferenceEquals(CheckoutVariantSnapshotService.ResolveChosenVariant(
                outcomeRows, snapshots, 1), outcomeRows.Rows[1]),
                "Distinct displayed IDs sharing one barcode must remain selectable");
            Require(outcomeRows.Rows.Count == 2 &&
                outcomeRows.Rows[0]["ID_ARTICLE"].ToString() == "A" &&
                outcomeRows.Rows[1]["ID_ARTICLE"].ToString() == "B",
                "Displayed list validation must not mutate the live query");
            Console.WriteLine("PASS modern displayed variant validation: duplicate IDs, malformed entries, precedence and cancellation");
            var cancelledOutcome = CheckoutVariantSnapshotService.EvaluateChoice(outcomeRows, snapshots, -1);
            Require(cancelledOutcome.Status == CheckoutVariantChoiceStatus.Cancelled &&
                cancelledOutcome.SelectedRow == null, "Explicit cancellation outcome");
            var absentRows = outcomeRows.Clone();
            absentRows.Rows.Add("123", "A");
            var missingOutcome = CheckoutVariantSnapshotService.EvaluateChoice(absentRows, snapshots, 1);
            Require(missingOutcome.Status == CheckoutVariantChoiceStatus.Missing &&
                missingOutcome.SelectedRow == null, "Stale variant is missing, not cancelled");
            var duplicatedRows = outcomeRows.Clone();
            duplicatedRows.Rows.Add("123", "B");
            duplicatedRows.Rows.Add("123", "B");
            var ambiguousOutcome = CheckoutVariantSnapshotService.EvaluateChoice(duplicatedRows, snapshots, 1);
            Require(ambiguousOutcome.Status == CheckoutVariantChoiceStatus.Ambiguous &&
                ambiguousOutcome.SelectedRow == null, "Ambiguous duplicate identity must fail closed");
            var invalidRows = outcomeRows.Clone();
            invalidRows.Rows.Add(DBNull.Value, "Z");
            invalidRows.Rows.Add("123", "B");
            var invalidOutcome = CheckoutVariantSnapshotService.EvaluateChoice(invalidRows, snapshots, 1);
            Require(invalidOutcome.Status == CheckoutVariantChoiceStatus.InvalidCandidates &&
                invalidOutcome.SelectedRow == null, "Corrupt live candidates must fail closed");
            var deletedRows = outcomeRows.Copy();
            deletedRows.AcceptChanges();
            deletedRows.Rows[1].Delete();
            var deletedOutcome = CheckoutVariantSnapshotService.EvaluateChoice(deletedRows, snapshots, 1);
            Require(deletedOutcome.Status == CheckoutVariantChoiceStatus.Missing &&
                deletedOutcome.SelectedRow == null, "Deleted but uncommitted article must not be selected");
            var reorderedOutcome = CheckoutVariantSnapshotService.EvaluateChoice(reordered, snapshots, 0);
            Require(reorderedOutcome.Status == CheckoutVariantChoiceStatus.Selected &&
                Object.ReferenceEquals(reorderedOutcome.SelectedRow, reordered.Rows[1]),
                "Typed outcome must resolve reorder by identity");
            bool invalidOutcomeIndex = false;
            try { CheckoutVariantSnapshotService.EvaluateChoice(outcomeRows, snapshots, 5); }
            catch (ArgumentOutOfRangeException) { invalidOutcomeIndex = true; }
            Require(invalidOutcomeIndex, "Typed outcome must reject out-of-range index");
            bool nullOutcomeSelection = false;
            try {
                CheckoutVariantSnapshotService.EvaluateChoice(outcomeRows,
                    new List<CheckoutVariantSnapshot> { null }, 0);
            }
            catch (ArgumentException) { nullOutcomeSelection = true; }
            Require(nullOutcomeSelection, "Typed outcome must reject null displayed entry");
            // Deleted rows remain in DataRowCollection before AcceptChanges.
            // A modern snapshot must exclude them rather than throw when
            // reading the inaccessible original row values.
            DataTable pendingDeletion = outcomeRows.Copy();
            pendingDeletion.AcceptChanges();
            pendingDeletion.Rows[1].Delete();
            var activeSnapshots = CheckoutVariantSnapshotService.Read(pendingDeletion);
            Require(activeSnapshots.Count == 1 && activeSnapshots[0].ArticleId == "A",
                "Snapshot must exclude uncommitted deleted rows");
            Require(CheckoutVariantSnapshotService.EvaluateChoice(pendingDeletion, snapshots, 1).Status ==
                CheckoutVariantChoiceStatus.Missing, "Deleted selected row remains unavailable");

            // The catalogue ID is unique even if two rows have different codes.
            DataTable collidingId = outcomeRows.Clone();
            collidingId.Rows.Add("ALT", "B");
            collidingId.Rows.Add("123", "B");
            Require(CheckoutVariantSnapshotService.EvaluateChoice(collidingId, snapshots, 1).Status ==
                CheckoutVariantChoiceStatus.Ambiguous,
                "Same ID with different barcodes must not select either row");

            // Corrupt rows cannot be hidden by an earlier duplicate identity.
            DataTable mixedInvalid = outcomeRows.Clone();
            mixedInvalid.Rows.Add("123", "B");
            mixedInvalid.Rows.Add("123", "B");
            mixedInvalid.Rows.Add(DBNull.Value, "BROKEN");
            Require(CheckoutVariantSnapshotService.EvaluateChoice(mixedInvalid, snapshots, 1).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Corrupt candidates must take precedence over ambiguity regardless of row order");
            DataTable emptyId = outcomeRows.Clone();
            emptyId.Rows.Add("123", "");
            bool emptyIdRejected = false;
            try { CheckoutVariantSnapshotService.Read(emptyId); }
            catch (InvalidOperationException) { emptyIdRejected = true; }
            Require(emptyIdRejected, "Empty article ID must not enter a modern snapshot");
            Require(CheckoutVariantSnapshotService.EvaluateChoice(emptyId, snapshots, 1).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Empty live article ID must fail closed");
            Require(CheckoutVariantSnapshotService.EvaluateChoice(outcomeRows,
                new List<CheckoutVariantSnapshot> { new CheckoutVariantSnapshot("123", "") }, 0).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Invalid displayed article ID must fail closed");
            // Image-only catalogue articles can legitimately have an empty
            // barcode; never confuse that with a missing ID_ARTICLE.
            DataTable imageOnly = outcomeRows.Clone();
            imageOnly.Rows.Add("", "IMAGE-ONLY");
            Require(CheckoutVariantSnapshotService.Read(imageOnly).Count == 1,
                "Empty barcode with valid ID must remain selectable");
            Require(CheckoutVariantSnapshotService.EvaluateChoice(imageOnly,
                CheckoutVariantSnapshotService.Read(imageOnly), 0).Status ==
                CheckoutVariantChoiceStatus.Selected, "Image-only article identity is valid");
            // Regression: the older null-returning modern APIs must enforce
            // exactly the same safety rules as the typed outcome API.
            Require(CheckoutVariantSnapshotService.Resolve(deletedRows, snapshots[1]) == null,
                "Resolve must skip pending-deleted selected rows without throwing");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(deletedRows, snapshots, 1) == null,
                "Explicit selection must not return a pending-deleted row");
            Require(Object.ReferenceEquals(
                CheckoutVariantSnapshotService.Resolve(pendingDeletion, snapshots[0]),
                pendingDeletion.Rows[0]), "Unrelated pending deletion must not hide a valid article");
            Require(CheckoutVariantSnapshotService.Resolve(duplicatedRows, snapshots[1]) == null,
                "Resolve must reject duplicate article identities");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(collidingId, snapshots, 1) == null,
                "Explicit selection must reject same ID under different barcodes");
            Require(CheckoutVariantSnapshotService.Resolve(mixedInvalid, snapshots[1]) == null,
                "Resolve must reject malformed unrelated live candidates");
            Require(CheckoutVariantSnapshotService.ResolveChosenVariant(mixedInvalid, snapshots, 1) == null,
                "Explicit selection must reject malformed unrelated live candidates");
            DataTable changedCode = outcomeRows.Clone();
            changedCode.Rows.Add("OTHER-CODE", "B");
            Require(CheckoutVariantSnapshotService.Resolve(changedCode, snapshots[1]) == null,
                "Reused article ID with changed barcode must fail closed");
            DataTable missingCodeColumn = new DataTable();
            missingCodeColumn.Columns.Add("ID_ARTICLE", typeof(string));
            missingCodeColumn.Rows.Add("B");
            Require(CheckoutVariantSnapshotService.Resolve(missingCodeColumn, snapshots[1]) == null,
                "Resolve must fail closed on missing barcode column");
            Require(CheckoutVariantSnapshotService.EvaluateChoice(missingCodeColumn, snapshots, 1).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Typed choice must report incomplete live schema as invalid");
            Require(Object.ReferenceEquals(CheckoutVariantSnapshotService.Resolve(
                imageOnly, CheckoutVariantSnapshotService.Read(imageOnly)[0]), imageOnly.Rows[0]),
                "Resolve must retain valid image-only products with blank barcode");
            Require(CheckoutVariantSnapshotService.Resolve(outcomeRows,
                new CheckoutVariantSnapshot("123", "")) == null,
                "Resolve must reject blank article identity");
            Require(outcomeRows.Rows.Count == 2 && outcomeRows.Rows[1]["ID_ARTICLE"].ToString() == "B",
                "Shared validation must not mutate live candidate rows");
            Console.WriteLine("PASS shared modern checkout resolution: pending deletion, duplicate ID, corrupt rows, schema and image-only");
            Console.WriteLine("PASS modern checkout snapshot deletion, ID collision and invalid-row precedence");
            Require(outcomeRows.Rows.Count == 2 && outcomeRows.Rows[1]["ID_ARTICLE"].ToString() == "B",
                "Typed evaluation must not mutate current query");
            Console.WriteLine("PASS typed modern checkout variant outcomes: selected, cancel, missing, ambiguity, invalid and deleted");
            Console.WriteLine("PASS portable checkout modern variant selection: cancellation, index, identity, reorder, ambiguity and stale rows");
            var port = new Semantics();
            Require(CheckoutAmountGuards.IsNegativeSale("VENTE", "-1", port), "Negative sale");
            Require(!CheckoutAmountGuards.IsNegativeSale("RETOUR", "-1", port), "Sale operation");
            Require(CheckoutAmountGuards.IsPositiveReturn("RETOUR CREDIT", "2", port), "Positive return");
            Require(CheckoutSelectionRules.IsMissing("", port) && !CheckoutSelectionRules.IsMissing(" ", port),
                "Selection must not trim");
            Require(!BasketTotalConsistency.AreDifferent(25.5m, "26", port), "Rounded basket");
            Require(BasketTotalConsistency.AreDifferent(25.5m, "25", port), "Basket mismatch");
            Require(SalesLinePricing.SelectQuantityPrice(10m, 10m, 8m, 12m, port) == 8m, "Tier threshold");
            Require(SalesLinePricing.SelectQuantityPrice(9m, 10m, 8m, 12m, port) == 12m, "Below tier");
            Require(!SalesLinePricing.SelectQuantityPrice(10m, 10m, 0m, 12m, port).HasValue, "Disabled tier");
            Require(SalesLinePricing.CalculateNetAmount(25m, 2m, 10m) == 45m, "Net amount");
            Require(StockAvailability.IsBelowRequested(1m, 2m, port), "Stock shortage");
            Require(!StockAvailability.IsBelowRequested(2m, 2m, port), "Stock equality");

            int quantities = 0;
            var lookup = new Lookup();
            var rows = new[] {
                new StockValidationRow { ArticleCode = "A", ReadQuantity = delegate { quantities++; return 2m; } },
                new StockValidationRow { ArticleCode = "B", ReadQuantity = delegate { throw new Exception("Second row must not be read"); } }
            };
            StockShortage shortage = StockValidationService.FindFirstShortage(lookup, rows, port);
            Require(shortage != null && Object.Equals(shortage.ArticleName, "First"), "First shortage name");
            Require(lookup.Calls == 1 && lookup.Names == 1 && quantities == 1, "Lazy first-shortage order");
            const string familySql = "select      *     from      TABLE_ARTICLES        WHERE      Famille = @family            order by Article asc ";
            Require(String.Equals(LOGICA.Infrastructure.Checkout.CheckoutArticleSearchQueryText.Family(), familySql,
                StringComparison.Ordinal), "Family tile SQL must preserve exact equality and bound parameter");
            DataTable tiles = new DataTable();
            tiles.Columns.Add("ID_ARTICLE", typeof(string));
            tiles.Columns.Add("Code", typeof(string));
            tiles.Rows.Add("11", "DUP");
            tiles.Rows.Add("12", "DUP");
            CheckoutArticleTileReference tile = CheckoutArticleTileSelectionService.TagFor(tiles.Rows[1]);
            Require(CheckoutArticleTileSelectionService.FindExact(tiles, tile) == tiles.Rows[1],
                "Image tile must select exact variant instead of first duplicate barcode");
            tiles.Rows.RemoveAt(1);
            Require(CheckoutArticleTileSelectionService.FindExact(tiles, tile) == null,
                "Stale image tile must fail closed");
            // Image tiles and barcode choosers must apply the same live-result
            // identity checks. A tile is not a licence to select a stale row.
            DataTable tileReordered = tiles.Clone();
            tileReordered.Rows.Add("12", "DUP");
            tileReordered.Rows.Add("11", "DUP");
            Require(Object.ReferenceEquals(
                CheckoutArticleTileSelectionService.EvaluateExact(tileReordered, tile).SelectedRow,
                tileReordered.Rows[0]), "Reordered image tiles must resolve exact article ID");
            Require(CheckoutArticleTileSelectionService.EvaluateExact(tiles, tile).Status ==
                CheckoutVariantChoiceStatus.Missing, "Missing tile must report Missing");
            DataTable reusedTileId = tiles.Clone();
            reusedTileId.Rows.Add("12", "NEW");
            Require(CheckoutArticleTileSelectionService.EvaluateExact(reusedTileId, tile).Status ==
                CheckoutVariantChoiceStatus.Ambiguous, "Reused tile ID with changed barcode must be ambiguous");
            Require(CheckoutArticleTileSelectionService.FindExact(reusedTileId, tile) == null,
                "Reused tile ID must never silently select a different barcode");
            DataTable duplicateTileId = tiles.Clone();
            duplicateTileId.Rows.Add("12", "DUP");
            duplicateTileId.Rows.Add("12", "DUP");
            Require(CheckoutArticleTileSelectionService.EvaluateExact(duplicateTileId, tile).Status ==
                CheckoutVariantChoiceStatus.Ambiguous, "Repeated image tile ID must be ambiguous");
            DataTable corruptTileRows = tiles.Clone();
            corruptTileRows.Rows.Add("12", "DUP");
            corruptTileRows.Rows.Add(DBNull.Value, "OTHER");
            Require(CheckoutArticleTileSelectionService.EvaluateExact(corruptTileRows, tile).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Corrupt unrelated tile candidate must invalidate selection");
            Require(CheckoutArticleTileSelectionService.FindExact(corruptTileRows, tile) == null,
                "Corrupt result must never return a valid-looking tile row");
            DataTable missingTileSchema = new DataTable();
            missingTileSchema.Columns.Add("ID_ARTICLE", typeof(string));
            missingTileSchema.Rows.Add("12");
            Require(CheckoutArticleTileSelectionService.EvaluateExact(missingTileSchema, tile).Status ==
                CheckoutVariantChoiceStatus.InvalidCandidates,
                "Missing barcode column must report invalid candidates");
            DataTable pendingTileDeletion = tileReordered.Copy();
            pendingTileDeletion.AcceptChanges();
            pendingTileDeletion.Rows[0].Delete();
            Require(CheckoutArticleTileSelectionService.EvaluateExact(pendingTileDeletion, tile).Status ==
                CheckoutVariantChoiceStatus.Missing,
                "Pending-deleted tile must not be returned");
            bool deletedTileTagRejected = false;
            try { CheckoutArticleTileSelectionService.TagFor(pendingTileDeletion.Rows[0]); }
            catch (InvalidOperationException) { deletedTileTagRejected = true; }
            Require(deletedTileTagRejected, "Pending-deleted article cannot become an image tile tag");
            DataTable imageOnlyTileRows = tiles.Clone();
            imageOnlyTileRows.Rows.Add("13", "");
            CheckoutArticleTileReference imageOnlyTile =
                CheckoutArticleTileSelectionService.TagFor(imageOnlyTileRows.Rows[0]);
            Require(imageOnlyTile.ToString() == "" &&
                CheckoutArticleTileSelectionService.EvaluateExact(imageOnlyTileRows, imageOnlyTile).Status ==
                    CheckoutVariantChoiceStatus.Selected,
                "Valid image-only article must retain blank barcode");
            DataTable blankTileId = tiles.Clone();
            blankTileId.Rows.Add("", "DUP");
            bool blankTileTagRejected = false;
            try { CheckoutArticleTileSelectionService.TagFor(blankTileId.Rows[0]); }
            catch (InvalidOperationException) { blankTileTagRejected = true; }
            Require(blankTileTagRejected, "Blank article ID cannot become an image tile tag");
            bool nullTileRejected = false;
            try { CheckoutArticleTileSelectionService.EvaluateExact(tileReordered, null); }
            catch (ArgumentNullException) { nullTileRejected = true; }
            Require(nullTileRejected, "Null image tile reference must be rejected");
            Require(tileReordered.Rows.Count == 2 &&
                tileReordered.Rows[0]["ID_ARTICLE"].ToString() == "12",
                "Image tile revalidation must never mutate live candidates");
            Console.WriteLine("PASS modern image tile validation: reordered, stale, reused ID, duplicates, corrupt, deleted and image-only");
            Console.WriteLine("PASS portable checkout image tile identity and stale variant rejection");
            Console.WriteLine("PASS portable checkout family SQL parameter and original order");
            Console.WriteLine("PASS portable checkout guards, basket, pricing and stock validation");
            return 0;
        }
        finally { CultureInfo.CurrentCulture = original; }
    }
}
