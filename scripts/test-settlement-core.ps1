$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
# Match the domain gate's Roslyn compiler: the .NET Framework inbox csc cannot parse
# nullable reference directives in shared settlement source. Preserve x86 and
# the existing isolated source list; do not change any business assertions.
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio/Installer/vswhere.exe'
if (-not (Test-Path -LiteralPath $vswhere)) { throw 'Visual Studio vswhere.exe missing; modern C# compiler required.' }
$vs = (& $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -property installationPath | Select-Object -First 1)
if (-not $vs) { throw 'Visual Studio MSBuild installation missing; cannot compile settlement tests.' }
$compiler = Join-Path $vs 'MSBuild/Current/Bin/Roslyn/csc.exe'
if (-not (Test-Path -LiteralPath $compiler)) { throw 'Visual Studio Roslyn csc.exe missing.' }
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
