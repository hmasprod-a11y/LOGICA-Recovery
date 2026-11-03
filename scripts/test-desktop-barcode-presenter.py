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
