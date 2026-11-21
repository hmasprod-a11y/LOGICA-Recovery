# Standalone Track B acceptance test. QA owns workflow wiring and exact-SHA gates.
# Requires the existing disposable loopback logica_ci MariaDB and built dist/LOGICA.exe.
$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$dist = Join-Path $root 'dist'
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$exe = Join-Path $dist 'CatalogueDuplicateMariaDbSmoke.exe'
$config = $exe + '.config'
if (-not (Test-Path (Join-Path $dist 'LOGICA.exe'))) { throw 'Build LOGICA.exe first' }
if (-not $env:LOGICA_DB_CONNECTION_STRING -or
    $env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Database\s*=\s*logica_ci\s*(;|$)' -or
    $env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Server\s*=\s*(127\.0\.0\.1|localhost)\s*(;|$)' -or
    $env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Port\s*=\s*3307\s*(;|$)') {
    throw 'Refusing to run catalogue smoke outside explicit loopback logica_ci:3307'
}
try {
    & $compiler /nologo /platform:x86 /target:exe /r:System.Data.dll "/out:$exe" (Join-Path $PSScriptRoot 'test-catalogue-duplicate-mariadb.cs')
    if ($LASTEXITCODE -ne 0) { throw 'Catalogue MariaDB harness compilation failed' }
    Copy-Item (Join-Path $dist 'LOGICA.exe.config') $config -Force
    & $exe
    if ($LASTEXITCODE -ne 0) { throw 'Isolated MariaDB duplicate catalogue regression failed' }
    Write-Host 'PASS production CatalogueDuplicateLookup against isolated MariaDB'
    # Follow the lookup test with the real creation-movement writer in a fresh
    # disposable schema. Both are Inventory-owned; QA still owns CI wiring.
    & (Join-Path $PSScriptRoot 'test-catalogue-creation-mariadb.ps1')
} finally {
    Remove-Item -LiteralPath $exe,$config -Force -ErrorAction SilentlyContinue
}
