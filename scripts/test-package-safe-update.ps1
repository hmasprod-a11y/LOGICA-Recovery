$ErrorActionPreference='Stop'
# Disposable fake shop and fake runtime only. Never read or modify real shop data.
$root=Join-Path ([IO.Path]::GetTempPath()) ('logica-overlay-regression-'+[guid]::NewGuid().ToString('N'))
$source=Join-Path $root 'build'
$output=Join-Path $root 'binaries'
$shop=Join-Path $root 'fake-shop'
try {
 New-Item -ItemType Directory -Force $source,$shop,(Join-Path $source 'bd'),(Join-Path $shop 'bd') | Out-Null
 $samples=@{
  'LOGICA.exe'='NEW_EXE';'dependency.dll'='NEW_DLL';
  'CHEMIN_DB.sni'='PACKAGED_DEFAULT_DB';'hash_licence.sni'='BLANK_LICENSE';
  'LOGICA.exe.config'='PACKAGED_CONFIG';'Start-LOGICA.cmd'='LAUNCHER'
 }
 foreach($entry in $samples.GetEnumerator()){
  [IO.File]::WriteAllText((Join-Path $source $entry.Key),$entry.Value)
 }
 [IO.File]::WriteAllText((Join-Path $source 'bd/configue.sni'),'PACKAGED_DB')
 $existing=@{
  'LOGICA.exe'='OLD_EXE';'dependency.dll'='OLD_DLL';
  'CHEMIN_DB.sni'='SHOP_DB_HOST';'hash_licence.sni'='SHOP_LICENSE';
  'LOGICA.exe.config'='SHOP_CONFIG';'poste.sni'='SHOP_POS_NUMBER'
 }
 foreach($entry in $existing.GetEnumerator()){
  [IO.File]::WriteAllText((Join-Path $shop $entry.Key),$entry.Value)
 }
 [IO.File]::WriteAllText((Join-Path $shop 'bd/configue.sni'),'SHOP_DATABASE')
 & (Join-Path $PSScriptRoot 'package-safe-update.ps1') -DistPath $source -OutputPath $output
 $allowed=@('LOGICA.exe','dependency.dll','UPDATE-README.txt')
 $actual=@(Get-ChildItem -LiteralPath $output -File | Select-Object -ExpandProperty Name)
 if(@($actual | Where-Object {$_ -notin $allowed}).Count -gt 0 -or $actual.Count -ne $allowed.Count){
  throw ('Unsafe update payload: '+($actual -join ', '))
 }
 if(@(Get-ChildItem -LiteralPath $output -Directory).Count -ne 0){throw 'Unexpected update subdirectory'}
 Copy-Item -Path (Join-Path $output '*') -Destination $shop -Force
 foreach($name in @('CHEMIN_DB.sni','hash_licence.sni','LOGICA.exe.config','poste.sni')){
  if((Get-Content -LiteralPath (Join-Path $shop $name) -Raw) -ne $existing[$name]){throw "Changed existing shop file: $name"}
 }
 if((Get-Content -LiteralPath (Join-Path $shop 'bd/configue.sni') -Raw) -ne 'SHOP_DATABASE'){throw 'Changed shop database'}
 if((Get-Content -LiteralPath (Join-Path $shop 'LOGICA.exe') -Raw) -ne 'NEW_EXE'){throw 'EXE not updated'}
 if((Get-Content -LiteralPath (Join-Path $shop 'dependency.dll') -Raw) -ne 'NEW_DLL'){throw 'DLL not updated'}
 Write-Host 'PASS isolated binaries-only overlay preserves existing shop settings, license, config and bd'
} finally {
 Remove-Item -LiteralPath $root -Recurse -Force -ErrorAction SilentlyContinue
}
