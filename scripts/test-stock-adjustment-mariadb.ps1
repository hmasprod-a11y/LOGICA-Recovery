# Inventory-owned isolated acceptance runner; QA owns CI workflow wiring.
$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$dist = Join-Path $root 'dist'
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$exe = Join-Path $dist 'StockAdjustmentMariaDbSmoke.exe'
$config = $exe + '.config'
if (-not (Test-Path (Join-Path $dist 'LOGICA.exe'))) { throw 'Build LOGICA.exe first' }
if (-not $env:LOGICA_DB_CONNECTION_STRING) { throw 'Explicit disposable MariaDB connection required' }
# This script is run before loading MySql.Data; validate the literal endpoint here,
# and the C# harness rechecks parsed connection-string properties.
if ($env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Database\s*=\s*logica_ci\s*(;|$)' -or
    $env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Server\s*=\s*(127\.0\.0\.1|localhost)\s*(;|$)' -or
    $env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Port\s*=\s*3307\s*(;|$)') {
    throw 'Refusing stock adjustment test outside logica_ci loopback port 3307'
}
try {
    & $compiler /nologo /platform:x86 /target:exe /r:System.Data.dll "/r:$(Join-Path $dist 'MySql.Data.dll')" "/out:$exe" (Join-Path $PSScriptRoot 'test-stock-adjustment-mariadb.cs')
    if ($LASTEXITCODE -ne 0) { throw 'Stock adjustment MariaDB harness compilation failed' }
    Copy-Item (Join-Path $dist 'LOGICA.exe.config') $config -Force
    & $exe
    if ($LASTEXITCODE -ne 0) { throw 'Stock adjustment MariaDB acceptance failed' }
    Write-Host 'PASS isolated production stock writer acceptance'
} finally {
    Remove-Item -LiteralPath $exe,$config -Force -ErrorAction SilentlyContinue
}
