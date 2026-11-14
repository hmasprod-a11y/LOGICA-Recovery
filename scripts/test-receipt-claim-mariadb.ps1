# Inventory-only transaction-contract smoke. QA owns Windows CI workflow wiring.
# Uses two independent connections and a new random InnoDB scratch schema.
# The legacy receipt posting handler is NOT wired to the new claim yet.
$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$dist = Join-Path $root 'dist'
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$exe = Join-Path $dist 'ReceiptClaimMariaDbSmoke.exe'
$config = $exe + '.config'
$mysql = Join-Path $dist 'MySql.Data.dll'
if (-not (Test-Path (Join-Path $dist 'LOGICA.exe'))) { throw 'Build LOGICA.exe first' }
if (-not (Test-Path $mysql)) { throw 'MySql.Data.dll missing from isolated Windows build' }
if (-not (Test-Path $compiler)) { throw 'Windows .NET Framework compiler missing' }
if (-not $env:LOGICA_DB_CONNECTION_STRING -or
    $env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Database\s*=\s*logica_ci\s*(;|$)' -or
    $env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Server\s*=\s*(127\.0\.0\.1|localhost)\s*(;|$)' -or
    $env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Port\s*=\s*3307\s*(;|$)') {
    throw 'Refusing receipt claim smoke outside explicit loopback logica_ci:3307'
}
try {
    & $compiler /nologo /platform:x86 /target:exe /r:System.Data.dll /r:System.Core.dll "/r:$mysql" "/out:$exe" (Join-Path $PSScriptRoot 'test-receipt-claim-mariadb.cs')
    if ($LASTEXITCODE -ne 0) { throw 'Receipt claim MariaDB smoke compilation failed' }
    Copy-Item (Join-Path $dist 'LOGICA.exe.config') $config -Force
    & $exe
    if ($LASTEXITCODE -ne 0) { throw 'Two-client receipt claim regression failed' }
    Write-Host 'PASS isolated two-connection receipt claim and rollback contract'
} finally {
    Remove-Item -LiteralPath $exe,$config -Force -ErrorAction SilentlyContinue
}
