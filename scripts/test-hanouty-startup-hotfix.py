"""Fail-closed regression guard for the isolated Hanouty Windows bootstrap.

This static test is necessary but NOT sufficient: Windows UI and real MariaDB
integration must also pass before a customer build is accepted.
"""
from pathlib import Path

root = Path(__file__).resolve().parents[1]
startup = (root / "recovered-source/LOGICA/Form_0_TEMPLATE.cs").read_text(encoding="utf-8")
entry = (root / "recovered-source/LOGICA.My/MyApplication.cs").read_text(encoding="utf-8")
launcher = (root / "scripts/Launch-LOGICA.ps1").read_text(encoding="utf-8")
module = (root / "recovered-source/LOGICA/Module1.cs").read_text(encoding="utf-8")
begin = startup.index("private void Form_0_TEMPLATE_Load(")
end = startup.find("\n\tprivate void ", begin + 15)
if end < 0:
    raise SystemExit("FAIL: cannot isolate startup method")
load = startup[begin:end]
checks = {
    "legacy activation gate absent from startup": not any(
        token in load for token in ("GetVolumeSerial()", "GetMotherbaordID()", "screenColorsF", "Panel_clé).Visible = true")
    ),
    "existing DB checks retained": "_Tentative_Connect_Database();" in load
        and "Panel_TENTATIVE_CONNEXION).Visible" in load,
    "real login requested": "MyProject.Forms.Form_1_LOGIN).Show();" in load,
    "activation panel hidden": "Panel_clé).Visible = false;" in load,
    "direct EXE detects missing authenticated connection": 'GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING")' in entry,
    "direct EXE routes to portable launcher": '"Launch-LOGICA.ps1"' in entry
        and "Process.Start(start)" in entry and "return; // Launcher" in entry,
    "launcher supplies isolated localhost connection": 'Server=127.0.0.1;Port=$Port;' in launcher
        and "$env:LOGICA_DB_CONNECTION_STRING=" in launcher,
    "launcher verifies real SQL query before starting EXE": "SELECT COUNT(*) FROM TABLE_ARTICLES;" in launcher
        and "LOGICA ne sera pas lance" in launcher,
    "legacy installation override preserved": 'Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING")' in module,
}
for label, passed in checks.items():
    print(("PASS" if passed else "FAIL") + ": " + label)
if not all(checks.values()):
    raise SystemExit("Startup/bootstrap regression failed")
print("NOTE: source guards do not prove an interactive login or direct-EXE MariaDB connection")
