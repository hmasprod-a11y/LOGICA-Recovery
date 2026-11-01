$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$temporary = Join-Path ([IO.Path]::GetTempPath()) ('logica-export-core-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
try {
    $sources = @(
        (Join-Path $root 'recovered-source/LOGICA/Application/Export/ILegacyGridExportSource.cs'),
        (Join-Path $root 'recovered-source/LOGICA/Application/Export/LegacyGridExportProjectionService.cs'),
        (Join-Path $root 'tests/LegacyGridExportProjectionTests.cs')
    )
    $executable = Join-Path $temporary 'LegacyGridExportProjectionTests.exe'
    & $compiler /nologo /platform:x86 /target:exe /r:System.Data.dll "/out:$executable" $sources
    if ($LASTEXITCODE -ne 0) { throw 'Legacy grid export projection did not compile independently' }
    & $executable
    if ($LASTEXITCODE -ne 0) { throw 'Legacy grid export characterization failed' }
    Write-Host 'PASS shared export Application projection compiles without WinForms, VB, MySQL, ClosedXML or Bunifu'
} finally {
    Remove-Item -LiteralPath $temporary -Recurse -Force -ErrorAction SilentlyContinue
}
