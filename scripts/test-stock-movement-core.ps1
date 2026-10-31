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
        (Join-Path $root 'recovered-source/LOGICA/Domain/ILegacyStockMovementQuerySemantics.cs'),
        (Join-Path $root 'recovered-source/LOGICA/Infrastructure/Inventory/StockMovementQueryText.cs'),
        (Join-Path $application 'IStockMovementSearchContext.cs'),
        (Join-Path $application 'StockMovementSearchService.cs'),
        (Join-Path $application 'IStockMovementRefreshContext.cs'),
        (Join-Path $application 'StockMovementRefreshService.cs'),
        (Join-Path $application 'IStockMovementFilterLayoutContext.cs'),
        (Join-Path $application 'StockMovementFilterLayoutService.cs')
    )
    foreach ($source in $sources) {
        if (-not (Test-Path -LiteralPath $source)) { throw "Missing inventory core source: $source" }
    }
    foreach ($testName in @('StockMovementCoreIsolationTests.cs','StockMovementFilterLayoutTests.cs')) {
        $testSource = Join-Path $root ('tests/' + $testName)
        if (-not (Test-Path -LiteralPath $testSource)) { throw "Missing inventory characterization: $testName" }
        $binary = Join-Path $temporary ($testName.Replace('.cs', '.exe'))
        # No Microsoft.VisualBasic, WinForms, MySQL or Bunifu references.
        & $compiler /nologo /platform:x86 /target:exe "/out:$binary" $sources $testSource
        if ($LASTEXITCODE -ne 0) { throw "Stock movement core failed independent compilation: $testName" }
        & $binary
        if ($LASTEXITCODE -ne 0) { throw "Stock movement isolated tests failed: $testName" }
    }
    Write-Host 'PASS inventory Domain/Application and filter event orchestration compile without VB, WinForms, MySQL or Bunifu'
} finally {
    Remove-Item -LiteralPath $temporary -Recurse -Force -ErrorAction SilentlyContinue
}
