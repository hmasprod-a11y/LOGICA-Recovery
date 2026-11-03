using Hanouty.ArchitectureBridge;

static void Assert(bool value, string name)
{
    if (!value) throw new Exception("FAILED: " + name);
    Console.WriteLine("PASS: " + name);
}
static ArticleCandidate A(string id, string code) => new(id, code);

var original = new[] { A("11", "123"), A("12", "123") };
var chosen = CheckoutSelectionGateway.ResolveBarcode(original, _ => 1, () => original);
Assert(chosen.Outcome == SelectionOutcome.Selected && chosen.Article?.ArticleId == "12", "duplicate barcode explicit variant");
var cancelled = CheckoutSelectionGateway.ResolveBarcode(original, _ => -1, () => throw new Exception("refresh must not run"));
Assert(cancelled.Outcome == SelectionOutcome.Cancelled, "cancel before live refresh");
var removed = CheckoutSelectionGateway.ResolveBarcode(original, _ => 1, () => new[] { A("11", "123") });
Assert(removed.Outcome != SelectionOutcome.Selected, "stale variant fails closed");
var changed = CheckoutSelectionGateway.ResolveBarcode(new[] { A("11", "123") }, null, () => new[] { A("11", "456") });
Assert(changed.Outcome != SelectionOutcome.Selected, "changed barcode fails closed");
var blank = CheckoutSelectionGateway.ResolveImage(A("21", ""), () => new[] { A("21", "") });
Assert(blank.Outcome == SelectionOutcome.Selected && blank.Article?.ArticleId == "21", "image-only blank barcode");
var swapped = CheckoutSelectionGateway.ResolveImage(A("21", ""), () => new[] { A("22", "") });
Assert(swapped.Outcome != SelectionOutcome.Selected, "image tile reused identity fails closed");
var none = CheckoutSelectionGateway.ResolveBarcode(Array.Empty<ArticleCandidate>(), null, () => throw new Exception("refresh must not run"));
Assert(none.Outcome == SelectionOutcome.Missing, "no candidates");
Console.WriteLine("Production selection gateway regression suite passed.");
