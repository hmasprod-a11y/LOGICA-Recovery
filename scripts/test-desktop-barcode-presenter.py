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
