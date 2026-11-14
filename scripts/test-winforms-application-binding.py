"""Regression guard for namespace LOGICA.Application shadowing WinForms Application.
Run: python scripts/test-winforms-application-binding.py
Windows compiler CI remains the authoritative build gate.
"""
from pathlib import Path
import re

root = Path(__file__).resolve().parents[1]
files = [
    "recovered-source/LOGICA.My/MyApplication.cs",
    "recovered-source/LOGICA/Form_0_TEMPLATE.cs",
    "recovered-source/LOGICA/Form_00_BACKOFFICE.cs",
    "recovered-source/LOGICA/Form_1_LOGIN.cs",
    "recovered-source/LOGICA/Form_2_ARTICLES.cs",
]
members = r"(?:StartupPath|DoEvents|Restart|SetCompatibleTextRenderingDefault)"
bare = re.compile(r"(?<![\w.])(?<!System\.Windows\.Forms\.)Application\." + members + r"\b")
qualified = re.compile(r"System\.Windows\.Forms\.Application\." + members + r"\b")
total = 0
for relative in files:
    content = (root / relative).read_text(encoding="utf-8-sig")
    matches = list(bare.finditer(content))
    assert not matches, f"{relative}: {len(matches)} ambiguous Application member references"
    count = len(qualified.findall(content))
    assert count > 0, f"{relative}: no qualified WinForms members"
    total += count
assert total >= 100, f"Unexpectedly few WinForms calls retained: {total}"
print(f"PASS: {total} WinForms Application calls qualified across {len(files)} files")
