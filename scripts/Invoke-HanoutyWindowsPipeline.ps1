param(
    [ValidateSet('win-x64', 'win-x86')][string]$Runtime = 'win-x64',
    [string]$OutputRoot = './dist',
    [switch]$SkipInstaller
)

$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest

$root = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
Push-Location $root
try {
    Write-Host '=== [1/5] Checking Windows prerequisites (.NET 10 SDK) ===' -ForegroundColor Cyan
    $dotnetVersion = (& dotnet --version).Trim()
    if ($LASTEXITCODE -ne 0 -or [string]::IsNullOrWhiteSpace($dotnetVersion)) {
        throw '.NET SDK not found. Install .NET 10 SDK on Windows first.'
    }
    Write-Host "Using dotnet SDK: $dotnetVersion"

    Write-Host '=== [2/5] Restoring and building unified Hanouty.sln ===' -ForegroundColor Cyan
    & dotnet restore Hanouty.sln
    if ($LASTEXITCODE -ne 0) { throw 'dotnet restore Hanouty.sln failed.' }
    & dotnet build Hanouty.sln -c Release --no-restore -m:1
    if ($LASTEXITCODE -ne 0) { throw 'dotnet build Hanouty.sln failed.' }

    Write-Host '=== [3/5] Running unit and WPF UI tests ===' -ForegroundColor Cyan
    $tests = @(
        'modernization/architecture/Hanouty.ArchitectureBridge.Tests/Hanouty.ArchitectureBridge.Tests.csproj',
        'modernization/architecture/CashboxLifecycle.Tests/CashboxLifecycle.Tests.csproj',
        'modernization/architecture/Hanouty.WpfContractAdapter.Tests/Hanouty.WpfContractAdapter.Tests.csproj',
        'modernization/Hanouty.Desktop.Wpf.Tests/Hanouty.Desktop.Wpf.Tests.csproj'
    )
    foreach ($proj in $tests) {
        Write-Host "Running $proj ..."
        & dotnet run --project $proj -c Release --no-build
        if ($LASTEXITCODE -ne 0) { throw "Test failed: $proj" }
    }
    Write-Host 'Running licensing smoke test (net10.0)...'
    & dotnet run --project licensing/Hanouty.Licensing.Smoke/Hanouty.Licensing.Smoke.csproj -c Release -f net10.0 --no-build
    if ($LASTEXITCODE -ne 0) { throw 'Licensing smoke test failed.' }

    Write-Host '=== [4/5] Publishing production self-contained EXE (without acceptance code) ===' -ForegroundColor Cyan
    $publishDir = Join-Path ([IO.Path]::GetFullPath($OutputRoot)) 'publish'
    if (Test-Path $publishDir) { Remove-Item $publishDir -Recurse -Force }
    & dotnet publish modernization/Hanouty.Desktop.Bootstrap/Hanouty.Desktop.Bootstrap.csproj `
        -c Release -r $Runtime --self-contained true `
        -p:PublishSingleFile=false -p:HanoutyWpfAsLibrary=true `
        -p:ArchitectureProject=modernization/architecture/Hanouty.ArchitectureBridge/Hanouty.ArchitectureBridge.csproj `
        -p:CheckoutProductionProject=modernization/checkout-mariadb-production/CheckoutMariaDbProduction.csproj `
        -o $publishDir
    if ($LASTEXITCODE -ne 0) { throw 'dotnet publish failed.' }

    Write-Host '=== [5/5] Building Windows Installer (Inno Setup) if available ===' -ForegroundColor Cyan
    if (-not $SkipInstaller) {
        $iscc = Get-Command iscc.exe -ErrorAction SilentlyContinue
        if ($null -ne $iscc) {
            & $iscc.Source "/DPublishDir=$publishDir" (Join-Path $root 'scripts/Hanouty-Installer.iss')
            if ($LASTEXITCODE -ne 0) { throw 'Inno Setup installer build failed.' }
        } else {
            Write-Warning 'iscc.exe (Inno Setup 6) not found in PATH; skipping installer packaging. Published EXE is ready.'
        }
    }

    Write-Host "DONE. Production EXE: $(Join-Path $publishDir 'Hanouty.Desktop.Bootstrap.exe')" -ForegroundColor Green
}
finally {
    Pop-Location
}
