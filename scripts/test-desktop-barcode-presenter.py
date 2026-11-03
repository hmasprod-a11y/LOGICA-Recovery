"""Source regression for WinForms scanner Enter presenter (run with Python 3)."""
from pathlib import Path
import re

source = (Path(__file__).resolve().parents[1] / "recovered-source/LOGICA/Form_3_VENTE.cs").read_text(encoding="utf-8")
handler = source.split("private void Text_CODE_KeyDown(object sender, KeyEventArgs e)", 1)[1].split("\n\tprivate void ", 1)[0]
assert "BarcodeEnterPresenter.ShouldSubmit(e.KeyCode, e.Modifiers)" in handler
assert "e.SuppressKeyPress = true;" in handler
assert handler.index("e.SuppressKeyPress = true;") < handler.index("Button_FIND_Click(")
assert "BarcodeEnterPresenter.ShouldSubmit" in handler
presenter = source.split("internal static class BarcodeEnterPresenter", 1)[1]
assert re.search(r"return key == Keys\.Enter && modifiers == Keys\.None;", presenter)
assert "namespace LOGICA.Presentation.Checkout" not in presenter
print("PASS: barcode Enter-only, no-modifier policy and single dispatch wiring")

# Search reset event contract: nonempty input clears once via TextChanged;
# empty input refreshes once explicitly, without the legacy space workaround.
reset = source.split("private static void ClearProductSearch(TextBox search, Action refreshWhenEmpty)", 1)[1].split("\n\tprivate void ", 1)[0]
assert "ProductSearchResetPresenter.ShouldClearText(search.Text)" in reset
assert "search.Clear();" in reset
assert "refreshWhenEmpty();" in reset
assert 'search.Text = " ";' not in reset
assert reset.index("search.Clear();") < reset.index("refreshWhenEmpty();")
assert "internal static class ProductSearchResetPresenter" in source
policy = source.split("internal static class ProductSearchResetPresenter", 1)[1]
assert "return !string.IsNullOrEmpty(currentText);" in policy
assert "Button_987_Click" in source and "ClearProductSearch(Text_FIND" in source
print("PASS: search reset presenter, one refresh for empty/nonempty input")

# Scanner and image tile lookup remain separate paths. Neither accepts an empty ID.
selection = source.split("internal static class ProductSelectionPresenter", 1)[1]
assert "CanLookup(bool barcodeSelection, string barcode, string articleId)" in selection
assert "barcodeSelection ? !string.IsNullOrWhiteSpace(barcode) : !string.IsNullOrWhiteSpace(articleId)" in selection
find_handler = source.split("private void Button_FIND_Click(object sender, EventArgs e)", 1)[1].split("\n\tprivate void ", 1)[0]
assert "ProductSelectionPresenter.CanLookup(clickedImage == null, Text_CODE.Text, clickedImage == null ? null : clickedImage.ArticleId)" in find_handler
assert "ExactImageArticleSql()" in find_handler
assert "CheckoutArticleSearchQueryText.ExactBarcode" in find_handler
assert find_handler.index("ProductSelectionPresenter.CanLookup") < find_handler.index("Module1.dt_find.Clear();")
print("PASS: scanner and image tile selection guard, empty identifiers blocked before SQL")

# Image grid scrollbar is a presentation policy, independent of catalogue SQL.
scroll_handler = source.split("private void UpdateArticleImageScrollBar()", 1)[1].split("\n\tpublic void ", 1)[0]
assert "ArticleImageScrollPresenter.Calculate(" in scroll_handler
assert "bar.Maximum = scroll.Maximum;" in scroll_handler
assert "bar.LargeChange = scroll.LargeChange;" in scroll_handler
assert "bar.Value = scroll.Value;" in scroll_handler
scroll_policy = source.split("internal static class ArticleImageScrollPresenter", 1)[1]
assert "Math.Max(0, contentHeight)" in scroll_policy
assert "Math.Max(0, viewportHeight)" in scroll_policy
assert "Math.Abs((long)scrollY)" in scroll_policy
assert "Math.Min((long)maxValue, position)" in scroll_policy
assert "(long)content + 1L" in scroll_policy
print("PASS: image grid scroll viewport policy is clamped and overflow-safe")
