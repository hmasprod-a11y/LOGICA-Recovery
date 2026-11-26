param(
    [ValidateSet('win-x64', 'win-x86')][string]$Runtime = 'win-x64',
    [string]$OutputRoot = './dist',
    [switch]$SkipInstaller
)

$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest

$root = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$architecture = Join-Path $root 'modernization/architecture/Hanouty.ArchitectureBridge/Hanouty.ArchitectureBridge.csproj'
$checkout = Join-Path $root 'modernization/checkout-mariadb-production/CheckoutMariaDbProduction.csproj'
Push-Location $root
try {
    Write-Host '=== [1/5] Checking Windows prerequisites (.NET 10 SDK) ===' -ForegroundColor Cyan
    $dotnetVersion = (& dotnet --version).Trim()
    if ($LASTEXITCODE -ne 0 -or [string]::IsNullOrWhiteSpace($dotnetVersion)) {
        throw '.NET SDK not found. Install .NET 10 SDK on Windows first.'
    }
    Write-Host "Using dotnet SDK: $dotnetVersion"

    $tests = @(
        'modernization/architecture/Hanouty.ArchitectureBridge.Tests/Hanouty.ArchitectureBridge.Tests.csproj',
        'modernization/architecture/CashboxLifecycle.Tests/CashboxLifecycle.Tests.csproj',
        'modernization/architecture/Hanouty.WpfContractAdapter.Tests/Hanouty.WpfContractAdapter.Tests.csproj',
        'modernization/Hanouty.Desktop.Wpf.Tests/Hanouty.Desktop.Wpf.Tests.csproj'
    )

    Write-Host '=== [2/5] Building core app and test projects ===' -ForegroundColor Cyan
    foreach ($proj in ($tests + @('modernization/Hanouty.Desktop.Bootstrap/Hanouty.Desktop.Bootstrap.csproj'))) {
        & dotnet build $proj -c Release -m:1
        if ($LASTEXITCODE -ne 0) { throw "Build failed: $proj" }
    }
    & dotnet build licensing/Hanouty.Licensing.Smoke/Hanouty.Licensing.Smoke.csproj -c Release -f net10.0
    if ($LASTEXITCODE -ne 0) { throw 'Build failed: Hanouty.Licensing.Smoke' }

    Write-Host '=== [3/5] Running unit and WPF UI tests ===' -ForegroundColor Cyan
    foreach ($proj in $tests) {
        Write-Host "Running $proj ..."
        & dotnet run --project $proj -c Release --no-build
        if ($LASTEXITCODE -ne 0) { throw "Test failed: $proj" }
    }
    Write-Host 'Running licensing smoke test (net10.0)...'
    & dotnet run --project licensing/Hanouty.Licensing.Smoke/Hanouty.Licensing.Smoke.csproj -c Release -f net10.0 --no-build
    if ($LASTEXITCODE -ne 0) { throw 'Licensing smoke test failed.' }

    Write-Host '=== [4/5] Publishing engineering candidate (without acceptance code) ===' -ForegroundColor Cyan
    $publishDir = Join-Path ([IO.Path]::GetFullPath($OutputRoot)) 'publish'
    if (Test-Path -LiteralPath $publishDir) { throw 'Choose a new output directory; existing published files are preserved.' }
    & dotnet publish modernization/Hanouty.Desktop.Bootstrap/Hanouty.Desktop.Bootstrap.csproj `
        -c Release -r $Runtime --self-contained true `
        -p:PublishSingleFile=false -p:HanoutyWpfAsLibrary=true `
        "-p:ArchitectureProject=$architecture" `
        "-p:CheckoutProductionProject=$checkout" `
        -o $publishDir
    if ($LASTEXITCODE -ne 0) { throw 'dotnet publish failed.' }

    Write-Host '=== [5/5] Candidate built; financial package acceptance remains required ===' -ForegroundColor Cyan
    Write-Host "Candidate EXE: $(Join-Path $publishDir 'Hanouty.Desktop.Bootstrap.exe')"
    Write-Host 'Use the W2 workflow and verified customer-delivery builder for a distributable installer.'

}
finally {
    Pop-Location
}
