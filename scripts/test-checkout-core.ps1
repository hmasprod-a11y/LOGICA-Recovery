$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
# The inbox .NET Framework compiler cannot parse modern shared checkout C# models.
# Keep x86, exact sources, framework references and executable assertions.
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio/Installer/vswhere.exe'
if (-not (Test-Path -LiteralPath $vswhere)) { throw 'Visual Studio vswhere.exe missing; modern C# compiler required.' }
$vs = (& $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -property installationPath | Select-Object -First 1)
if (-not $vs) { throw 'Visual Studio MSBuild installation missing; cannot compile checkout tests.' }
$compiler = Join-Path $vs 'MSBuild/Current/Bin/Roslyn/csc.exe'
if (-not (Test-Path -LiteralPath $compiler)) { throw 'Visual Studio Roslyn csc.exe missing.' }
$temporary = Join-Path ([IO.Path]::GetTempPath()) ('logica-checkout-core-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
try {
    $sources = @(
        'recovered-source/LOGICA/Domain/ILegacyCheckoutSemantics.cs',
        'recovered-source/LOGICA/Domain/ILegacyCheckoutCompletionSemantics.cs',
        'recovered-source/LOGICA/Domain/ILegacyCheckoutTicketSequenceSemantics.cs',
        'recovered-source/LOGICA/Domain/ILegacyTicketPostingSemantics.cs',
        'recovered-source/LOGICA/Infrastructure/Checkout/CheckoutCompletionSql.cs',
        'recovered-source/LOGICA/Infrastructure/Checkout/CheckoutTicketSequenceSql.cs',
        'recovered-source/LOGICA/Infrastructure/Checkout/CheckoutTicketPostingSql.cs',
        'recovered-source/LOGICA/Domain/CheckoutAmountGuards.cs',
        'recovered-source/LOGICA/Domain/CheckoutSelectionRules.cs',
        'recovered-source/LOGICA/Domain/BasketTotalConsistency.cs',
        'recovered-source/LOGICA/Domain/SalesLinePricing.cs',
        'recovered-source/LOGICA/Domain/StockAvailability.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutArticleImageSelectionService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutBarcodeSelectionService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutArticleTileSelectionService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutVariantSnapshotService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutSelectionFlowService.cs',
        'recovered-source/LOGICA/Infrastructure/Checkout/CheckoutArticleSearchQueryText.cs',
        'recovered-source/LOGICA/Application/Checkout/StockValidationModels.cs',
        'recovered-source/LOGICA/Application/Checkout/StockValidationService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutPostingModels.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutPostingService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutStockPostingService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutTicketPostingService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutPaymentPostingService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutTransactionFinalizationService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutTransactionBoundaryService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutTicketSequenceService.cs',
        'modernization/PortableCheckoutSmoke.cs',
        'modernization/PortablePostingSmoke.cs',
        'modernization/PortableTransactionSmoke.cs',
        'modernization/PortableTicketSequenceSmoke.cs',
        'modernization/PortableTicketPostingSmoke.cs',
        'tests/CheckoutCoreIsolationEntry.cs'
    ) | ForEach-Object { Join-Path $root $_ }
    foreach ($source in $sources) {
        if (-not (Test-Path -LiteralPath $source)) { throw "Missing checkout source: $source" }
    }
    $binary = Join-Path $temporary 'CheckoutCoreWithoutVB.exe'
    # No VB, WinForms, MySQL, Bunifu or database references.
    & $compiler /nologo /platform:x86 /target:exe /r:System.Data.dll "/out:$binary" $sources
    if ($LASTEXITCODE -ne 0) { throw 'Checkout core failed independent compilation' }
    & $binary
    if ($LASTEXITCODE -ne 0) { throw 'Checkout core isolated smoke failed' }
    Write-Host 'PASS checkout Domain/Application compiles without VB, WinForms, MySQL or Bunifu'
} finally {
    Remove-Item -LiteralPath $temporary -Recurse -Force -ErrorAction SilentlyContinue
}
