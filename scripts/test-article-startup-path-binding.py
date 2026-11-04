"""Regression for LOGICA.Application namespace shadowing WinForms Application.StartupPath.

Run: python scripts/test-article-startup-path-binding.py
This is a source-level guard, not a replacement for the Windows compiler gate.
"""
from pathlib import Path
import re

source = (Path(__file__).resolve().parents[1] / "recovered-source/LOGICA/Form_2_ARTICLES.cs").read_text(encoding="utf-8-sig")
qualified = re.findall(r"(?<![\w.])System\.Windows\.Forms\.Application\.StartupPath", source)
unqualified = re.findall(r"(?<![\w.])(?<!System\.Windows\.Forms\.)Application\.StartupPath", source)
assert len(qualified) >= 20, "Expected legacy article image/log/keyboard paths were lost"
assert not unqualified, f"Unqualified Application.StartupPath references remain: {len(unqualified)}"
for fragment in ('\\\\tchak\\\\', 'log_erreur.sni', 'CLAVIER.exe', 'CANVA.sni'):
    assert fragment in source, f"Legacy path usage removed: {fragment}"
print(f"PASS: {len(qualified)} qualified article startup paths; legacy path usages retained")
