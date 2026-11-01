$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$temporary = Join-Path ([IO.Path]::GetTempPath()) ('logica-settlement-core-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
try {
    $domain = Join-Path $root 'recovered-source/LOGICA/Domain'
    $application = Join-Path $root 'recovered-source/LOGICA/Application/Clients'
    $sources = @(
        (Join-Path $domain 'ILegacySettlementSemantics.cs'),
        (Join-Path $domain 'ClientSettlementAmountRule.cs'),
        (Join-Path $domain 'ClientSettlementSequence.cs'),
        (Join-Path $domain 'ClientCreditBalance.cs'),
        (Join-Path $application 'ClientSettlementValidationService.cs'),
        (Join-Path $application 'ClientSettlementRowWriter.cs'),
        (Join-Path $root 'tests/ClientSettlementCompatibilityPortTests.cs')
    )
    foreach ($source in $sources) {
        if (-not (Test-Path -LiteralPath $source)) { throw "Missing settlement core source: $source" }
    }
    $binary = Join-Path $temporary 'SettlementCoreWithoutVB.exe'
    # Deliberately do not reference Microsoft.VisualBasic, WinForms, MySQL or Bunifu.
    & $compiler /nologo /platform:x86 /target:exe "/out:$binary" $sources
    if ($LASTEXITCODE -ne 0) { throw 'Settlement core failed to compile without legacy/UI dependencies' }
    & $binary
    if ($LASTEXITCODE -ne 0) { throw 'Settlement core isolated tests failed' }
    Write-Host 'PASS settlement Domain/Application compiles without Microsoft.VisualBasic, WinForms, MySQL or Bunifu'
} finally {
    Remove-Item -LiteralPath $temporary -Recurse -Force -ErrorAction SilentlyContinue
}
