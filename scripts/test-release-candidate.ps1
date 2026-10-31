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
$files = @(Get-ChildItem -LiteralPath $dist -Recurse -File)
if ($files.Count -eq 0) { throw 'Empty release candidate' }
$manifest = foreach ($file in $files) {
  [pscustomobject]@{ path = $file.FullName.Substring($dist.Length + 1).Replace([char]92, '/'); size = $file.Length; sha256 = (Get-FileHash -LiteralPath $file.FullName -Algorithm SHA256).Hash }
}
New-Item -ItemType Directory -Force results | Out-Null
$manifest | Sort-Object path | ConvertTo-Json -Depth 4 | Set-Content -LiteralPath results/release-candidate-manifest.json -Encoding UTF8
Write-Host "PASS: release candidate contains LOGICA.exe, $($dlls.Count) DLLs and $($files.Count) files, without persisted test database credentials"
