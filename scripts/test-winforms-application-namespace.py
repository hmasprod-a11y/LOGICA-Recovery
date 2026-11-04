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
    "Form_5_CLIENTS_ETAT_CREDITS.cs",
    "Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL.cs",
    "Form_5_CLIENTS_LISTE.cs",
    "Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL.cs",
    "Form_5_CLIENTS_RDV.cs",
    "Form_5_CLIENTS_REGLE.cs",
    "Form_5_CLIENTS.cs",
    "Form_6_COMMANDES.cs",
    "Form_6_DEPENSES.cs",
)
members = ("StartupPath", "DoEvents", "Run", "OpenForms")
total = 0
for filename in forms:
    source = (root / "recovered-source/LOGICA" / filename).read_text(encoding="utf-8")
    for member in members:
        matches = re.findall(r"(?<![\w.])Application\." + member + r"\b", source)
        assert not matches, f"{filename}: {len(matches)} unqualified Application.{member}"
    count = source.count("System.Windows.Forms.Application.")
    assert count > 0, f"{filename}: missing qualified WinForms Application reference"
    total += count
assert total >= 313, f"Unexpected WinForms qualification count: {total}"
print(f"PASS: {total} WinForms Application references qualified across {len(forms)} forms")
