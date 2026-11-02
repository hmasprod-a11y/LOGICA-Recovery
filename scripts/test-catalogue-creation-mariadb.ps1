# Inventory-owned isolated regression. QA owns CI wiring and release packaging.
# Compiles an x86 smoke that creates ONLY a fresh random logica_ci_catalogue_* schema
# on the configured loopback MariaDB, drops it after tests, and never reads shop data.
$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$dist = Join-Path $root 'dist'
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$exe = Join-Path $dist 'CatalogueCreationMariaDbSmoke.exe'
$config = $exe + '.config'
if (-not (Test-Path (Join-Path $dist 'LOGICA.exe'))) { throw 'Build LOGICA.exe first' }
if (-not (Test-Path $compiler)) { throw 'Windows .NET Framework C# compiler not found' }
if (-not $env:LOGICA_DB_CONNECTION_STRING -or
    $env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Database\s*=\s*logica_ci\s*(;|$)' -or
    $env:LOGICA_DB_CONNECTION_STRING -notmatch '(?i)(^|;)\s*Server\s*=\s*(127\.0\.0\.1|localhost)\s*(;|$)') {
    throw 'Refusing to run without an explicit loopback logica_ci test connection'
}
try {
    & $compiler /nologo /platform:x86 /target:exe /r:System.Data.dll "/out:$exe" (Join-Path $PSScriptRoot 'test-catalogue-creation-mariadb.cs')
    if ($LASTEXITCODE -ne 0) { throw 'Catalogue creation MariaDB harness compilation failed' }
    Copy-Item (Join-Path $dist 'LOGICA.exe.config') $config -Force
    & $exe
    if ($LASTEXITCODE -ne 0) { throw 'Isolated MariaDB catalogue creation regression failed' }
    Write-Host 'PASS production CatalogueCreationMovementWriter against disposable MariaDB scratch schema'
} finally {
    Remove-Item -LiteralPath $exe,$config -Force -ErrorAction SilentlyContinue
}
