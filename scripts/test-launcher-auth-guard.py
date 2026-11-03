"""Fail-closed launcher authentication contract, with negative mutation fixtures.

This is a source-level regression; real MariaDB/WinForms smoke runs separately.
No credentials, license files or store databases are read or modified.
"""
from pathlib import Path

SOURCE = Path(__file__).with_name("Launch-LOGICA.ps1")
source = SOURCE.read_text(encoding="utf-8")


def check(text: str) -> None:
    init_query = text.index('$existing=& "$ServerBin/mariadb.exe"')
    init_guard = text.index("if($LASTEXITCODE -ne 0 -or @($existing).Count -ne 1", init_query)
    create_db = text.index('CREATE DATABASE $dbName', init_query)
    assert init_query < init_guard < create_db, "unauthenticated database probe could reach CREATE DATABASE"
    assert "[string]$existing -notmatch '^[0-9]+$'" in text[init_guard:create_db], (
        "database existence response must be a single numeric count"
    )

    final_query = text.index('$counts=& "$ServerBin/mariadb.exe"')
    final_guard = text.index("if($LASTEXITCODE -ne 0 -or @($counts).Count -ne 2", final_query)
    launch = text.index("Start-Process (Join-Path $root 'LOGICA.exe')", final_query)
    assert final_query < final_guard < launch, "failed authenticated query could launch EXE"
    assert "[string]$_ -notmatch '^[0-9]+$'" in text[final_guard:launch], (
        "final authenticated query must return exactly two numeric counts"
    )
    assert "LOGICA ne sera pas lance" in text[final_guard:launch], "failed query must fail closed"


check(source)
for label, mutated in [
    ("missing initial auth guard", source.replace(
        "if($LASTEXITCODE -ne 0 -or @($existing).Count -ne 1",
        "if($false -or @($existing).Count -ne 1", 1)),
    ("missing final auth guard", source.replace(
        "if($LASTEXITCODE -ne 0 -or @($counts).Count -ne 2",
        "if($false -or @($counts).Count -ne 2", 1)),
    ("missing final numeric validation", source.replace(
        "[string]$_ -notmatch '^[0-9]+$'", "$false", 1)),
    ("missing existence numeric validation", source.replace(
        "[string]$existing -notmatch '^[0-9]+$'", "$false", 1)),
    ("wrong final launch order", source.replace(
        "if($LASTEXITCODE -ne 0 -or @($counts).Count -ne 2",
        "Start-Process (Join-Path $root 'LOGICA.exe')\n if($LASTEXITCODE -ne 0 -or @($counts).Count -ne 2", 1)),
]:
    try:
        check(mutated)
    except (AssertionError, ValueError):
        print(f"PASS: rejected {label}")
    else:
        raise AssertionError(f"launcher auth contract accepted {label}")
print("PASS: launcher refuses failed MariaDB authentication/schema checks before import or EXE")
