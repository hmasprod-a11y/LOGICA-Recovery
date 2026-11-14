$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$framework = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319'
# Use the Visual Studio Roslyn compiler: the .NET Framework 4.x in-box csc.exe
# cannot parse the nullable reference syntax used by the shared production sources.
# Keep the same x86/.NET Framework references and execute the same test binaries.
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio/Installer/vswhere.exe'
if (-not (Test-Path -LiteralPath $vswhere)) { throw 'Visual Studio vswhere.exe missing; modern C# compiler required.' }
$vs = (& $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -property installationPath | Select-Object -First 1)
if (-not $vs) { throw 'Visual Studio MSBuild installation missing; cannot compile domain tests.' }
$compiler = Join-Path $vs 'MSBuild/Current/Bin/Roslyn/csc.exe'
if (-not (Test-Path -LiteralPath $compiler)) { throw 'Visual Studio Roslyn csc.exe missing.' }
$visualBasic = Join-Path $framework 'Microsoft.VisualBasic.dll'
$temporary = Join-Path ([IO.Path]::GetTempPath()) ('logica-domain-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
$createdFiles = @()
try {
    $sources = @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Domain') -Filter '*.cs' | ForEach-Object { $_.FullName })
    $sources += @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Application/Checkout') -Filter '*.cs' | ForEach-Object { $_.FullName })
    $sources += @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Application/Inventory') -Filter '*.cs' | ForEach-Object { $_.FullName })
    $sources += @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Application/Cash') -Filter '*.cs' | ForEach-Object { $_.FullName })
    $sources += @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Application/Catalogue') -Filter '*.cs' | ForEach-Object { $_.FullName })
    $sources += @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Presentation/Input') -Filter '*.cs' | ForEach-Object { $_.FullName })
    $sources += @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Presentation/Formatting') -Filter '*.cs' | ForEach-Object { $_.FullName })
    $sources += @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Application/Export') -Filter '*.cs' | ForEach-Object { $_.FullName })
    $sources += @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Application/Clients') -Filter '*.cs' | ForEach-Object { $_.FullName })
    $sources += @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Infrastructure/Compatibility') -Filter '*.cs' | ForEach-Object { $_.FullName })
    # Portable SQL text builders have no database or Visual Basic dependency.
    $sources += @(Join-Path $root 'recovered-source/LOGICA/Infrastructure/Inventory/StockMovementQueryText.cs')
    $sources += @(Join-Path $root 'recovered-source/LOGICA/Infrastructure/Checkout/CheckoutCompletionSql.cs')
    $sources += @(Join-Path $root 'recovered-source/LOGICA/Infrastructure/Checkout/CheckoutTicketSequenceSql.cs')
    $sources += @(Join-Path $root 'recovered-source/LOGICA/Infrastructure/Checkout/CheckoutTicketPostingSql.cs')
    $sources += @(Join-Path $root 'recovered-source/LOGICA/Infrastructure/Checkout/CheckoutArticleSearchQueryText.cs')
    $sources += @(Join-Path $root 'recovered-source/LOGICA/Infrastructure/Clients/ClientSettlementQueryText.cs')
    $tests = @(Get-ChildItem -LiteralPath (Join-Path $root 'tests') -Filter '*Tests.cs' | Sort-Object Name)
    if ($sources.Count -eq 0 -or $tests.Count -eq 0) { throw 'Domain sources or tests missing' }
    foreach ($test in $tests) {
        $executable = Join-Path $temporary ($test.BaseName + '.exe')
        $createdFiles += $executable
        & $compiler /nologo /platform:x86 /target:exe /r:System.Data.dll "/r:$visualBasic" "/out:$executable" $sources $test.FullName
        if ($LASTEXITCODE -ne 0) { throw "Domain test compilation failed: $($test.Name)" }
        & $executable
        if ($LASTEXITCODE -ne 0) { throw "Domain tests failed: $($test.Name)" }
    }
} finally {
    foreach ($createdFile in $createdFiles) {
        Remove-Item -LiteralPath $createdFile -Force -ErrorAction SilentlyContinue
    }
    Remove-Item -LiteralPath $temporary -ErrorAction SilentlyContinue
}
