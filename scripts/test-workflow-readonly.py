"""Regression guard: Windows verification must not write source changes to GitHub."""
from pathlib import Path
import re

workflow = (Path(__file__).resolve().parent.parent /
            ".github/workflows/windows-reference-diagnostic.yml").read_text(encoding="utf-8")
checks = {
    "checkout remains": "actions/checkout@v4" in workflow,
    "read-only GitHub token": bool(re.search(r"(?m)^\s+contents:\s+read\s*$", workflow))
                              and "contents: write" not in workflow,
    "no automatic git commit or push": not re.search(r"(?m)^\s*git\s+(?:commit|push)\b", workflow),
    "repair still runs": "python scripts/repair-source.py" in workflow,
    "original Windows build remains": "dotnet build recovered-source/LOGICA.csproj" in workflow,
    "original POS checks remain": "./scripts/test-pos.ps1" in workflow,
}
for name, passed in checks.items():
    print(("PASS" if passed else "FAIL") + " " + name)
if not all(checks.values()):
    raise SystemExit("Workflow read-only regression failed")
