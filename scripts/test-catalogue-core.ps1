$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$temporary = Join-Path ([IO.Path]::GetTempPath()) ('logica-catalogue-core-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
try {
    $sources = @(
        'recovered-source/LOGICA/Domain/ILegacyCatalogueSemantics.cs',
        'recovered-source/LOGICA/Domain/CatalogueRequiredFields.cs',
        'recovered-source/LOGICA/Domain/CataloguePromotionRules.cs',
        'recovered-source/LOGICA/Domain/CatalogueBarcodeChecksum.cs',
        'recovered-source/LOGICA/Application/Catalogue/ICatalogueRowInput.cs',
        'recovered-source/LOGICA/Application/Catalogue/ICatalogueCreationStore.cs',
        'recovered-source/LOGICA/Application/Catalogue/CatalogueRowMapper.cs',
        'recovered-source/LOGICA/Application/Catalogue/CatalogueCreationService.cs',
        'recovered-source/LOGICA/Application/Purchasing/PurchaseReceiptPreviewService.cs',
        'recovered-source/LOGICA/Application/Inventory/StockCountVarianceService.cs',
        'tests/BusinessOperationsSmoke.cs',
        'recovered-source/LOGICA/Application/Inventory/StockCountCoverageService.cs',
        'tests/StockCountCoverageSmoke.cs',
        'modernization/PortableCatalogueSmoke.cs',
        'tests/CatalogueCoreIsolationEntry.cs'
    ) | ForEach-Object { Join-Path $root $_ }
    foreach ($source in $sources) {
        if (-not (Test-Path -LiteralPath $source)) { throw "Missing catalogue source: $source" }
    }
    $binary = Join-Path $temporary 'CatalogueCoreWithoutVB.exe'
    # No VB, WinForms, MySQL or Bunifu reference. System.Data is framework-neutral.
    & $compiler /nologo /platform:x86 /target:exe /r:System.Data.dll "/out:$binary" $sources
    if ($LASTEXITCODE -ne 0) { throw 'Catalogue core failed independent compilation' }
    & $binary
    if ($LASTEXITCODE -ne 0) { throw 'Catalogue core isolated smoke failed' }
    Write-Host 'PASS catalogue creation Domain/Application compiles without VB, WinForms, MySQL or Bunifu'
} finally {
    Remove-Item -LiteralPath $temporary -Recurse -Force -ErrorAction SilentlyContinue
}
