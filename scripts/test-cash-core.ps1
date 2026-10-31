$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$temporary = Join-Path ([IO.Path]::GetTempPath()) ('logica-cash-core-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
try {
    $sources = @(
        'recovered-source/LOGICA/Domain/ILegacyCashSemantics.cs',
        'recovered-source/LOGICA/Domain/CashCountInputRules.cs',
        'recovered-source/LOGICA/Domain/CashDenominationTotal.cs',
        'recovered-source/LOGICA/Application/Cash/ICashRecountContext.cs',
        'recovered-source/LOGICA/Application/Cash/CashRecountService.cs',
        'tests/CashCompatibilityPortTests.cs'
    ) | ForEach-Object { Join-Path $root $_ }
    foreach ($source in $sources) {
        if (-not (Test-Path -LiteralPath $source)) { throw "Missing cash core source: $source" }
    }
    $binary = Join-Path $temporary 'CashCoreWithoutVB.exe'
    # No Microsoft.VisualBasic, WinForms, MySQL, Bunifu or database references.
    & $compiler /nologo /platform:x86 /target:exe "/out:$binary" $sources
    if ($LASTEXITCODE -ne 0) { throw 'Cash core failed to compile without legacy/UI dependencies' }
    & $binary
    if ($LASTEXITCODE -ne 0) { throw 'Cash core isolated tests failed' }
    Write-Host 'PASS cash Domain/Application compiles without Microsoft.VisualBasic, WinForms, MySQL or Bunifu'
} finally {
    Remove-Item -LiteralPath $temporary -Recurse -Force -ErrorAction SilentlyContinue
}
