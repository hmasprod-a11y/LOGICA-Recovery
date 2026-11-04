#!/usr/bin/env python3
"""Prevent LOGICA.Application shadowing legacy WinForms Application references.

Windows CI compilation remains the authoritative build verification.
"""
from pathlib import Path
import re

root = Path(__file__).resolve().parents[1]
forms = (
    "Form_3_VENTE_JOURNAL.cs",
    "Form_2_Familles.cs",
    "Form_3_VENTE_ENTETE.cs",
    "Form_3_VENTE_MARGE.cs",
    "Form_3_VENTE_RETOURS.cs",
    "Form_3_VENTE.cs",
)
members = ("StartupPath", "DoEvents", "Run")
total = 0
for filename in forms:
    source = (root / "recovered-source/LOGICA" / filename).read_text(encoding="utf-8")
    for member in members:
        matches = re.findall(r"(?<![\w.])Application\." + member + r"\b", source)
        assert not matches, f"{filename}: {len(matches)} unqualified Application.{member}"
    count = source.count("System.Windows.Forms.Application.")
    assert count > 0, f"{filename}: missing qualified WinForms Application reference"
    total += count
assert total >= 166, f"Unexpected WinForms qualification count: {total}"
print(f"PASS: {total} WinForms Application references qualified across {len(forms)} forms")
