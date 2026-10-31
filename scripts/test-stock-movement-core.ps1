$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$temporary = Join-Path ([IO.Path]::GetTempPath()) ('logica-stock-core-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
try {
    $domain = Join-Path $root 'recovered-source/LOGICA/Domain/ILegacyStockMovementSemantics.cs'
    $application = Join-Path $root 'recovered-source/LOGICA/Application/Inventory'
    $sources = @(
        $domain,
        (Join-Path $application 'IStockMovementSearchContext.cs'),
        (Join-Path $application 'StockMovementSearchService.cs'),
        (Join-Path $application 'IStockMovementRefreshContext.cs'),
        (Join-Path $application 'StockMovementRefreshService.cs'),
        (Join-Path $root 'tests/StockMovementCoreIsolationTests.cs')
    )
    foreach ($source in $sources) {
        if (-not (Test-Path -LiteralPath $source)) { throw "Missing inventory core source: $source" }
    }
    $binary = Join-Path $temporary 'StockMovementCoreWithoutVB.exe'
    # No Microsoft.VisualBasic, WinForms, MySQL or Bunifu references.
    & $compiler /nologo /platform:x86 /target:exe "/out:$binary" $sources
    if ($LASTEXITCODE -ne 0) { throw 'Stock movement core failed independent compilation' }
    & $binary
    if ($LASTEXITCODE -ne 0) { throw 'Stock movement core isolated tests failed' }
    Write-Host 'PASS inventory Domain/Application compiles without VB, WinForms, MySQL or Bunifu'
} finally {
    Remove-Item -LiteralPath $temporary -Recurse -Force -ErrorAction SilentlyContinue
}
