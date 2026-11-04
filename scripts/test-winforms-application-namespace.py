#!/usr/bin/env python3
"""Regression: the LOGICA.Application namespace must not shadow WinForms Application.

The legacy sales journal must compile against the real System.Windows.Forms
Application class. This test is intentionally source-only; Windows CI is the
authoritative compiler check.
"""
from pathlib import Path
import re

root = Path(__file__).resolve().parents[1]
journal = (root / "recovered-source/LOGICA/Form_3_VENTE_JOURNAL.cs").read_text(encoding="utf-8")
for member in ("StartupPath", "Run"):
    unqualified = re.findall(r"(?<![\w.])Application\." + member + r"\b", journal)
    assert not unqualified, f"Unqualified Application.{member}: {len(unqualified)} occurrences"
    assert f"System.Windows.Forms.Application.{member}" in journal, f"Missing qualified {member}"
assert journal.count("System.Windows.Forms.Application.StartupPath") >= 1
print("PASS: WinForms Application references are fully qualified in sales journal")
