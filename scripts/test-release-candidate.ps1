$ErrorActionPreference = 'Stop'
$dist = Join-Path (Get-Location) 'dist'
if (-not (Test-Path -LiteralPath $dist -PathType Container)) { throw 'Release candidate dist folder missing' }
$exe = Join-Path $dist 'LOGICA.exe'
if (-not (Test-Path -LiteralPath $exe -PathType Leaf)) { throw 'LOGICA.exe missing from release candidate' }
$dlls = @(Get-ChildItem -LiteralPath $dist -Filter '*.dll' -File)
if ($dlls.Count -eq 0) { throw 'No runtime DLLs in release candidate' }
foreach ($name in @('Launch-LOGICA.ps1', 'Start-LOGICA.cmd')) {
  if (-not (Test-Path -LiteralPath (Join-Path $dist $name) -PathType Leaf)) { throw "Missing launcher: $name" }
}
$forbidden = @('mysql-credential.xml', 'mysql-import-complete.txt')
foreach ($name in $forbidden) {
  $matches = @(Get-ChildItem -LiteralPath $dist -Recurse -File -ErrorAction Stop | Where-Object { $_.Name -eq $name })
  if ($matches.Count -gt 0) { throw "Private test/runtime state included: $name" }
}
$mysqlData = Join-Path $dist 'bd/mysql-data'
if (Test-Path -LiteralPath $mysqlData) { throw 'Test database state leaked into release package' }
# Check that the distributed runtime is self-contained and does not inherit shop state.
if (-not (Test-Path -LiteralPath (Join-Path $dist 'LOGICA.exe.config') -PathType Leaf)) {
  throw 'LOGICA.exe.config missing from release candidate'
}
$expectedSettings = @{
  'CHEMIN_DB.sni' = '127.0.0.1'
  'CHEMIN_FOLDER.sni' = 'Application.StartupPath'
  'hash_licence.sni' = ''
  'log_erreur.sni' = ''
}
foreach ($printer in @('CL','ADD','RAPPORT','C1','C2','C3','C4','C5','C6','C7')) {
  $expectedSettings["PRINTER_$printer.sni"] = '0'
}
foreach ($name in $expectedSettings.Keys) {
  $path = Join-Path $dist $name
  if (-not (Test-Path -LiteralPath $path -PathType Leaf)) { throw "Missing portable startup setting: $name" }
  $actual = [IO.File]::ReadAllText($path).Trim()
  if ($actual -cne $expectedSettings[$name]) { throw "Unsafe beta startup setting: $name" }
}
if (@(Get-ChildItem -LiteralPath $dist -Recurse -File | Where-Object { $_.Name -like 'PosSmoke*' }).Count -gt 0) {
  throw 'POS test harness leaked into release candidate'
}
$files = @(Get-ChildItem -LiteralPath $dist -Recurse -File)
if ($files.Count -eq 0) { throw 'Empty release candidate' }
$manifest = foreach ($file in $files) {
  [pscustomobject]@{ path = $file.FullName.Substring($dist.Length + 1).Replace([char]92, '/'); size = $file.Length; sha256 = (Get-FileHash -LiteralPath $file.FullName -Algorithm SHA256).Hash }
}
New-Item -ItemType Directory -Force results | Out-Null
$manifest | Sort-Object path | ConvertTo-Json -Depth 4 | Set-Content -LiteralPath results/release-candidate-manifest.json -Encoding UTF8
Write-Host "PASS: release candidate contains LOGICA.exe, $($dlls.Count) DLLs and $($files.Count) files, without persisted test database credentials"
