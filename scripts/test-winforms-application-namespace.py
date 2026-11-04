#!/usr/bin/env python3
"""Repository-wide guard against LOGICA.Application shadowing WinForms Application.

Only match known WinForms members; do not rewrite unrelated Application types.
"""
from pathlib import Path
import re

root = Path(__file__).resolve().parents[1] / "recovered-source"
pattern = re.compile(r"(?<![\w.])Application\.(StartupPath|DoEvents|OpenForms|Run)\b")
offenders = []
scanned = 0
for file in sorted(root.rglob("*.cs")):
    source = file.read_text(encoding="utf-8-sig")
    scanned += 1
    for match in pattern.finditer(source):
        line = source.count("\n", 0, match.start()) + 1
        offenders.append(f"{file.relative_to(root)}:{line}: Application.{match.group(1)}")
if offenders:
    print("UNQUALIFIED_WINFORMS_APPLICATION: " + str(len(offenders)))
    raise AssertionError(
        f"{len(offenders)} unqualified WinForms Application references in {scanned} C# files:\n"
        + "\n".join(offenders)
    )
print(f"PASS: scanned {scanned} C# files, no unqualified WinForms Application references")
