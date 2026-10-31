$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$temporary = Join-Path ([IO.Path]::GetTempPath()) ('logica-checkout-core-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
try {
    $sources = @(
        'recovered-source/LOGICA/Domain/ILegacyCheckoutSemantics.cs',
        'recovered-source/LOGICA/Domain/CheckoutAmountGuards.cs',
        'recovered-source/LOGICA/Domain/CheckoutSelectionRules.cs',
        'recovered-source/LOGICA/Domain/BasketTotalConsistency.cs',
        'recovered-source/LOGICA/Domain/SalesLinePricing.cs',
        'recovered-source/LOGICA/Domain/StockAvailability.cs',
        'recovered-source/LOGICA/Application/Checkout/StockValidationModels.cs',
        'recovered-source/LOGICA/Application/Checkout/StockValidationService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutPostingModels.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutPostingService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutStockPostingService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutTicketPostingService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutPaymentPostingService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutTransactionFinalizationService.cs',
        'recovered-source/LOGICA/Application/Checkout/CheckoutTransactionBoundaryService.cs',
        'modernization/PortableCheckoutSmoke.cs',
        'modernization/PortablePostingSmoke.cs',
        'modernization/PortableTransactionSmoke.cs',
        'tests/CheckoutCoreIsolationEntry.cs'
    ) | ForEach-Object { Join-Path $root $_ }
    foreach ($source in $sources) {
        if (-not (Test-Path -LiteralPath $source)) { throw "Missing checkout source: $source" }
    }
    $binary = Join-Path $temporary 'CheckoutCoreWithoutVB.exe'
    # No VB, WinForms, MySQL, Bunifu or database references.
    & $compiler /nologo /platform:x86 /target:exe "/out:$binary" $sources
    if ($LASTEXITCODE -ne 0) { throw 'Checkout core failed independent compilation' }
    & $binary
    if ($LASTEXITCODE -ne 0) { throw 'Checkout core isolated smoke failed' }
    Write-Host 'PASS checkout Domain/Application compiles without VB, WinForms, MySQL or Bunifu'
} finally {
    Remove-Item -LiteralPath $temporary -Recurse -Force -ErrorAction SilentlyContinue
}
