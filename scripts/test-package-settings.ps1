$ErrorActionPreference='Stop'
# Disposable packaging regression: never use shop settings or real license values.
$testDist=Join-Path ([IO.Path]::GetTempPath()) ('logica-package-settings-'+[guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $testDist -Force | Out-Null
try {
 [IO.File]::WriteAllText((Join-Path $testDist 'hash_licence.sni'),'CI_EXISTING_LICENSE_SENTINEL')
 [IO.File]::WriteAllText((Join-Path $testDist 'CHEMIN_DB.sni'),'CI_EXISTING_DB_HOST')
 & (Join-Path $PSScriptRoot 'package-runtime.ps1') -DistPath $testDist
 if((Get-Content (Join-Path $testDist 'hash_licence.sni') -Raw) -ne 'CI_EXISTING_LICENSE_SENTINEL'){throw 'Packaging overwrote license settings'}
 if((Get-Content (Join-Path $testDist 'CHEMIN_DB.sni') -Raw) -ne 'CI_EXISTING_DB_HOST'){throw 'Packaging overwrote database settings'}
 if(-not (Test-Path (Join-Path $testDist 'poste.sni'))){throw 'Packaging did not populate non-sensitive missing default'}
 Remove-Item (Join-Path $testDist 'hash_licence.sni') -Force
 & (Join-Path $PSScriptRoot 'package-runtime.ps1') -DistPath $testDist
 if(Test-Path (Join-Path $testDist 'hash_licence.sni')){throw 'Packaging generated empty license hash'}
 Write-Host 'PASS packaging preserves original license/DB settings and never synthesizes blank hash'
} finally {
 Remove-Item -LiteralPath $testDist -Force -Recurse -ErrorAction SilentlyContinue
}
