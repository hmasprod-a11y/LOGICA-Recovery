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
// Production workflow: validated selection is the only input to the checkout port.
var port = new RecordingCheckoutPort();
var workflow = new CheckoutSelectionWorkflow(port);
var added = workflow.AddBarcode(original, _ => 1, () => original, 3);
Assert(added.Outcome == SelectionOutcome.Selected && port.Calls.Count == 1 &&
       port.Calls[0] == ("12", 3), "barcode selection dispatches verified identity and quantity");
var before = port.Calls.Count;
var stale = workflow.AddBarcode(original, _ => 1, () => new[] { A("11", "123") });
Assert(stale.Outcome != SelectionOutcome.Selected && port.Calls.Count == before,
       "stale variant never reaches checkout");
var cancelledFlow = workflow.AddBarcode(original, _ => -1, () => throw new Exception("refresh must not run"));
Assert(cancelledFlow.Outcome == SelectionOutcome.Cancelled && port.Calls.Count == before,
       "cancelled choice never reaches checkout");
var imageFlow = workflow.AddImage(A("21", ""), () => new[] { A("21", "") }, 2);
Assert(imageFlow.Outcome == SelectionOutcome.Selected && port.Calls[^1] == ("21", 2),
       "barcode-free image dispatches by stable article ID");
before = port.Calls.Count;
var replaced = workflow.AddImage(A("21", ""), () => new[] { A("22", "") });
Assert(replaced.Outcome != SelectionOutcome.Selected && port.Calls.Count == before,
       "reused image tile never reaches checkout");
try { workflow.AddImage(A("21", ""), () => throw new Exception("must not refresh"), 0); throw new Exception("invalid quantity accepted"); }
catch (ArgumentOutOfRangeException) { Assert(port.Calls.Count == before, "invalid quantity fails before refresh"); }
var failingPort = new ThrowingCheckoutPort();
try { new CheckoutSelectionWorkflow(failingPort).AddImage(A("21", ""), () => new[] { A("21", "") }); throw new Exception("port failure swallowed"); }
catch (ApplicationException) { Assert(failingPort.Attempts == 1, "checkout port failure propagates without retry"); }
Console.WriteLine("Production selection-to-checkout workflow regression suite passed.");

sealed class RecordingCheckoutPort : ICheckoutArticlePort
{
    public List<(string, int)> Calls { get; } = new();
    public void AddSelectedArticle(string articleId, int quantity) => Calls.Add((articleId, quantity));
}
sealed class ThrowingCheckoutPort : ICheckoutArticlePort
{
    public int Attempts { get; private set; }
    public void AddSelectedArticle(string articleId, int quantity)
    {
        Attempts++;
        throw new ApplicationException("checkout unavailable");
    }
}
