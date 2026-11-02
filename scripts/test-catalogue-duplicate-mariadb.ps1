# Standalone Track B acceptance test. QA owns workflow wiring and exact-SHA gates.
# Requires the existing disposable loopback logica_ci MariaDB and built dist/LOGICA.exe.
$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$dist = Join-Path $root 'dist'
$compiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe'
$exe = Join-Path $dist 'CatalogueDuplicateMariaDbSmoke.exe'
$config = $exe + '.config'
if (-not (Test-Path (Join-Path $dist 'LOGICA.exe'))) { throw 'Build LOGICA.exe first' }
try {
    & $compiler /nologo /platform:x86 /target:exe /r:System.Data.dll "/out:$exe" (Join-Path $PSScriptRoot 'test-catalogue-duplicate-mariadb.cs')
    if ($LASTEXITCODE -ne 0) { throw 'Catalogue MariaDB harness compilation failed' }
    Copy-Item (Join-Path $dist 'LOGICA.exe.config') $config -Force
    & $exe
    if ($LASTEXITCODE -ne 0) { throw 'Isolated MariaDB duplicate catalogue regression failed' }
    Write-Host 'PASS production CatalogueDuplicateLookup against isolated MariaDB'
} finally {
    Remove-Item -LiteralPath $exe,$config -Force -ErrorAction SilentlyContinue
}
