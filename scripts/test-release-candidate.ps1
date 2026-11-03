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
# The launcher writes a plaintext client INI during database startup. Never ship it.
$forbidden = @('mysql-credential.xml', 'mysql-import-complete.txt', 'mysql-client-temporary.ini')
# Never ship credential/key material even when its filename differs from legacy defaults.
# Match case-insensitively on Windows; inspect the entire portable tree.
$privateNames = @('.env', '.env.local', 'id_rsa', 'id_ed25519', 'credentials.json', 'secrets.json')
$privateExtensions = @('.pem', '.pfx', '.p12', '.key', '.kdbx')
$excludedFolders = @('.git', '.ssh', '.aws', '.azure', '.gnupg')
foreach ($folder in @(Get-ChildItem -LiteralPath $dist -Recurse -Directory -Force)) {
  if ($excludedFolders -contains $folder.Name.ToLowerInvariant()) {
    throw "Excluded folder in release candidate: $($folder.FullName)"
  }
}

foreach ($candidate in @(Get-ChildItem -LiteralPath $dist -Recurse -File -Force -ErrorAction Stop)) {
  if ($privateNames -contains $candidate.Name.ToLowerInvariant() -or
      $privateExtensions -contains $candidate.Extension.ToLowerInvariant()) {
    throw "Credential or private-key material forbidden in customer package: $($candidate.Name)"
  }
}
foreach ($name in $forbidden) {
  $matches = @(Get-ChildItem -LiteralPath $dist -Recurse -File -Force -ErrorAction Stop | Where-Object { $_.Name -eq $name })
  if ($matches.Count -gt 0) { throw "Private test/runtime state included: $name" }
}
# Database data directories must never be embedded in a portable customer ZIP,
# including nested or renamed test fixture locations.
foreach ($directory in @(Get-ChildItem -LiteralPath $dist -Recurse -Directory -Force -ErrorAction Stop)) {
  if ($directory.Name -ieq 'mysql-data') {
    throw "Test database state leaked into release package: $($directory.FullName)"
  }
}
# Reject loose MariaDB table files even outside mysql-data folders.
$databaseFileExtensions = @('.ibd', '.frm', '.myd', '.myi', '.mad', '.mai', '.sst')
foreach ($candidate in @(Get-ChildItem -LiteralPath $dist -Recurse -File -Force -ErrorAction Stop)) {
  if ($databaseFileExtensions -contains $candidate.Extension.ToLowerInvariant()) {
    throw "Database table state forbidden in release package: $($candidate.FullName)"
  }
}
# SQL backups and database dumps are never part of the runtime. The one
# reviewed additive migration (.sql) remains allowed.
$databaseBackupNames = @('backup.sql', 'dump.sql', 'mysqldump.sql')
$databaseBackupExtensions = @('.dump', '.sql.gz', '.sql.zip', '.sql.bak')
foreach ($candidate in @(Get-ChildItem -LiteralPath $dist -Recurse -File -Force -ErrorAction Stop)) {
  $lowerName = $candidate.Name.ToLowerInvariant()
  if ($databaseBackupNames -contains $lowerName -or
      @($databaseBackupExtensions | Where-Object { $lowerName.EndsWith($_, [StringComparison]::Ordinal) }).Count -gt 0) {
    throw "Database backup forbidden in release package: $($candidate.FullName)"
  }
}
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
# Test harnesses must never ship in customer packages.
foreach ($candidate in @(Get-ChildItem -LiteralPath $dist -Recurse -File -Force -ErrorAction Stop)) {
  if ($candidate.Name -match 'Smoke[.]exe([.]config)?$') {
    throw "QA smoke harness forbidden in release package: $($candidate.FullName)"
  }
}
$files = @(Get-ChildItem -LiteralPath $dist -Recurse -File -Force)
if ($files.Count -eq 0) { throw 'Empty release candidate' }
# Windows file names are case-insensitive. Reject ambiguous release paths before ZIP creation.
$seen = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::OrdinalIgnoreCase)
foreach ($file in $files) {
  $relative = $file.FullName.Substring($dist.Length + 1).Replace([char]92, '/')
  if (-not $seen.Add($relative)) { throw "Case-colliding release file: $relative" }
  foreach ($segment in $relative.Split('/')) {
    if ($segment -match '[\x00-\x1F]' -or $segment -match '[. ]$' -or
        $segment -match '^(?i:CON|PRN|AUX|NUL|COM[1-9]|LPT[1-9])(?:\.|$)' ) {
      throw "Unsafe Windows release filename: $relative"
    }
  }
  if (($file.Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) { throw "Reparse-point file forbidden: $relative" }
}
foreach ($directory in @(Get-ChildItem -LiteralPath $dist -Directory -Recurse -Force)) {
  if (($directory.Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) { throw "Reparse-point directory forbidden: $($directory.FullName)" }
}
$manifest = foreach ($file in $files) {
  [pscustomobject]@{ path = $file.FullName.Substring($dist.Length + 1).Replace([char]92, '/'); size = $file.Length; sha256 = (Get-FileHash -LiteralPath $file.FullName -Algorithm SHA256).Hash }
}
New-Item -ItemType Directory -Force results | Out-Null
$manifest | Sort-Object path | ConvertTo-Json -Depth 4 | Set-Content -LiteralPath results/release-candidate-manifest.json -Encoding UTF8
Write-Host "PASS: release candidate contains LOGICA.exe, $($dlls.Count) DLLs and $($files.Count) files, without persisted test database credentials"
) {
    throw "QA smoke harness forbidden in release package: $($candidate.FullName)"
  }
}
$files = @(Get-ChildItem -LiteralPath $dist -Recurse -File -Force)
if ($files.Count -eq 0) { throw 'Empty release candidate' }
# Windows file names are case-insensitive. Reject ambiguous release paths before ZIP creation.
$seen = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::OrdinalIgnoreCase)
foreach ($file in $files) {
  $relative = $file.FullName.Substring($dist.Length + 1).Replace([char]92, '/')
  if (-not $seen.Add($relative)) { throw "Case-colliding release file: $relative" }
  foreach ($segment in $relative.Split('/')) {
    if ($segment -match '[\x00-\x1F]' -or $segment -match '[. ]$' -or
        $segment -match '^(?i:CON|PRN|AUX|NUL|COM[1-9]|LPT[1-9])(?:\.|$)' ) {
      throw "Unsafe Windows release filename: $relative"
    }
  }
  if (($file.Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) { throw "Reparse-point file forbidden: $relative" }
}
foreach ($directory in @(Get-ChildItem -LiteralPath $dist -Directory -Recurse -Force)) {
  if (($directory.Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) { throw "Reparse-point directory forbidden: $($directory.FullName)" }
}
$manifest = foreach ($file in $files) {
  [pscustomobject]@{ path = $file.FullName.Substring($dist.Length + 1).Replace([char]92, '/'); size = $file.Length; sha256 = (Get-FileHash -LiteralPath $file.FullName -Algorithm SHA256).Hash }
}
New-Item -ItemType Directory -Force results | Out-Null
$manifest | Sort-Object path | ConvertTo-Json -Depth 4 | Set-Content -LiteralPath results/release-candidate-manifest.json -Encoding UTF8
Write-Host "PASS: release candidate contains LOGICA.exe, $($dlls.Count) DLLs and $($files.Count) files, without persisted test database credentials"
