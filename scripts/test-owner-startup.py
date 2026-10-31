"""Static startup regression for owner's no-activation-key LOGICA build."""
from pathlib import Path

source = (Path(__file__).resolve().parents[1] /
          "recovered-source/LOGICA/Form_0_TEMPLATE.cs").read_text(encoding="utf-8")
start = source.index("private void Form_0_TEMPLATE_Load(")
end = source.index("\n\tpublic void _Tentative_Connect_Database(", start)
startup = source[start:end]
checks = {
    "database check preserved": "_Tentative_Connect_Database();" in startup,
    "database failure returns early": "Panel_TENTATIVE_CONNEXION).Visible" in startup,
    "login form shown": "MyProject.Forms.Form_1_LOGIN).Show();" in startup,
    "login panel shown": "Form_1_LOGIN.Panel_login).Visible = true" in startup,
    "registration panel hidden": "Panel_clé).Visible = false;" in startup,
    "no hardware fingerprint requirement": "GetMotherbaordID()" not in startup and "GetVolumeSerial()" not in startup,
    "no registry activation comparison": 'screenColorsF' not in startup,
    "no activation entry screen": "Panel_clé).Visible = true;" not in startup,
}
for name, passed in checks.items():
    print(("PASS" if passed else "FAIL") + " " + name)
if not all(checks.values()):
    raise SystemExit("Owner build startup regression failed")
