$ErrorActionPreference = 'Stop'
$root = (Get-Location).Path
$dist = Join-Path $root 'dist'
$manifestPath = Join-Path $root 'results/release-candidate-manifest.json'
if (-not (Test-Path -LiteralPath $manifestPath -PathType Leaf)) { throw 'Release gate manifest missing; run test-release-candidate.ps1 first' }
if (-not (Test-Path -LiteralPath $dist -PathType Container)) { throw 'Windows runtime dist missing' }
$expected = @(Get-Content -LiteralPath $manifestPath -Raw | ConvertFrom-Json)
if ($expected.Count -lt 3) { throw 'Release gate manifest is incomplete' }

function Assert-PackageContents([string]$directory, [array]$entries) {
  $directory = (Resolve-Path -LiteralPath $directory).Path.TrimEnd([char[]]@([char]92, [char]47))
  $byPath = @{}
  foreach ($entry in $entries) {
    $name = [string]$entry.path
    if ([string]::IsNullOrWhiteSpace($name) -or $name.StartsWith('/') -or $name.Contains('..') -or $name.Contains([char]92)) {
      throw "Invalid manifest path: $name"
    }
    if ($byPath.ContainsKey($name)) { throw "Duplicate manifest path: $name" }
    $byPath[$name] = $entry
  }
  $files = @(Get-ChildItem -LiteralPath $directory -Recurse -File)
  if ($files.Count -ne $entries.Count) { throw "Package file count differs: $($files.Count) versus $($entries.Count)" }
  foreach ($file in $files) {
    $relative = $file.FullName.Substring($directory.Length + 1).Replace([char]92, '/')
    if (-not $byPath.ContainsKey($relative)) { throw "Unexpected package file: $relative" }
    $entry = $byPath[$relative]
    if ($file.Length -ne [long]$entry.size) { throw "File size mismatch: $relative" }
    $hash = (Get-FileHash -LiteralPath $file.FullName -Algorithm SHA256).Hash
    if ($hash -ne [string]$entry.sha256) { throw "SHA256 mismatch: $relative" }
  }
}

Assert-PackageContents $dist $expected
$metadataPath = Join-Path $dist 'build-metadata.json'
if (-not (Test-Path -LiteralPath $metadataPath)) { throw 'Build provenance missing' }
$metadata = Get-Content -LiteralPath $metadataPath -Raw | ConvertFrom-Json
if ($metadata.target -ne 'net48' -or $metadata.architecture -ne 'x86' -or $metadata.originalShopDatabaseIncluded -ne $false) {
  throw 'Unexpected runtime architecture or database provenance'
}
$commit = (& git rev-parse HEAD).Trim()
if ($LASTEXITCODE -ne 0 -or $metadata.sourceCommit -ne $commit) { throw 'Package does not match checked-out commit' }
# GitHub pull_request runs normally check out a synthetic merge ref. A release
# candidate must instead be built from the exact reviewed PR head.
if ($env:GITHUB_EVENT_NAME -eq 'pull_request') {
  if (-not $env:GITHUB_EVENT_PATH -or -not (Test-Path -LiteralPath $env:GITHUB_EVENT_PATH)) {
    throw 'Missing GitHub PR event metadata for release provenance'
  }
  $event = Get-Content -LiteralPath $env:GITHUB_EVENT_PATH -Raw | ConvertFrom-Json
  $expectedHead = [string]$event.pull_request.head.sha
  if ($expectedHead -notmatch '^[0-9a-f]{40}
$releaseDir = Join-Path $root 'release'
New-Item -ItemType Directory -Force -Path $releaseDir | Out-Null
$zipName = 'LOGICA-2.0-Beta-RC1-Windows-x86.zip'
$zip = Join-Path $releaseDir $zipName
if (Test-Path -LiteralPath $zip) { Remove-Item -LiteralPath $zip -Force }
Compress-Archive -Path (Join-Path $dist '*') -DestinationPath $zip -CompressionLevel Optimal
$extract = Join-Path $env:RUNNER_TEMP ('logica-rc1-verify-' + $env:GITHUB_RUN_ID)
if (Test-Path -LiteralPath $extract) { Remove-Item -LiteralPath $extract -Recurse -Force }
try {
  Expand-Archive -LiteralPath $zip -DestinationPath $extract -Force
  Assert-PackageContents $extract $expected

  # The release verifier must reject a modified file, not merely compare file counts.
  $tamperTarget = Join-Path $extract 'RUNNING.md'
  if (-not (Test-Path -LiteralPath $tamperTarget)) { throw 'Expected user instructions missing' }
  Add-Content -LiteralPath $tamperTarget -Value 'CI TAMPER PROBE'
  $detected = $false
  try { Assert-PackageContents $extract $expected } catch { $detected = $true }
  if (-not $detected) { throw 'Tamper regression: modified release file was accepted' }
  Write-Host 'PASS: ZIP content verified; modified-file tamper probe rejected'
} finally {
  Remove-Item -LiteralPath $extract -Recurse -Force -ErrorAction SilentlyContinue
}
$zipHash = (Get-FileHash -LiteralPath $zip -Algorithm SHA256).Hash.ToLowerInvariant()
"$zipHash  $zipName" | Set-Content -LiteralPath (Join-Path $releaseDir 'SHA256SUMS.txt') -Encoding ASCII
Copy-Item -LiteralPath $manifestPath -Destination (Join-Path $releaseDir 'LOGICA-2.0-Beta-RC1-file-manifest.json') -Force
Copy-Item -LiteralPath (Join-Path $PSScriptRoot 'verify-beta-rc.ps1') -Destination (Join-Path $releaseDir 'verify-beta-rc.ps1') -Force
& (Join-Path $releaseDir 'verify-beta-rc.ps1') -ReleaseDirectory $releaseDir -ExpectedCommit $commit
Write-Host "PASS: $zipName ($((Get-Item $zip).Length) bytes); commit $commit; SHA256 $zipHash"
 -or $commit -ne $expectedHead) {
    throw "Refusing release ZIP from synthetic merge commit: checkout $commit; PR head $expectedHead"
  }
}

$releaseDir = Join-Path $root 'release'
New-Item -ItemType Directory -Force -Path $releaseDir | Out-Null
$zipName = 'LOGICA-2.0-Beta-RC1-Windows-x86.zip'
$zip = Join-Path $releaseDir $zipName
if (Test-Path -LiteralPath $zip) { Remove-Item -LiteralPath $zip -Force }
Compress-Archive -Path (Join-Path $dist '*') -DestinationPath $zip -CompressionLevel Optimal
$extract = Join-Path $env:RUNNER_TEMP ('logica-rc1-verify-' + $env:GITHUB_RUN_ID)
if (Test-Path -LiteralPath $extract) { Remove-Item -LiteralPath $extract -Recurse -Force }
try {
  Expand-Archive -LiteralPath $zip -DestinationPath $extract -Force
  Assert-PackageContents $extract $expected

  # The release verifier must reject a modified file, not merely compare file counts.
  $tamperTarget = Join-Path $extract 'RUNNING.md'
  if (-not (Test-Path -LiteralPath $tamperTarget)) { throw 'Expected user instructions missing' }
  Add-Content -LiteralPath $tamperTarget -Value 'CI TAMPER PROBE'
  $detected = $false
  try { Assert-PackageContents $extract $expected } catch { $detected = $true }
  if (-not $detected) { throw 'Tamper regression: modified release file was accepted' }
  Write-Host 'PASS: ZIP content verified; modified-file tamper probe rejected'
} finally {
  Remove-Item -LiteralPath $extract -Recurse -Force -ErrorAction SilentlyContinue
}
$zipHash = (Get-FileHash -LiteralPath $zip -Algorithm SHA256).Hash.ToLowerInvariant()
"$zipHash  $zipName" | Set-Content -LiteralPath (Join-Path $releaseDir 'SHA256SUMS.txt') -Encoding ASCII
Copy-Item -LiteralPath $manifestPath -Destination (Join-Path $releaseDir 'LOGICA-2.0-Beta-RC1-file-manifest.json') -Force
Copy-Item -LiteralPath (Join-Path $PSScriptRoot 'verify-beta-rc.ps1') -Destination (Join-Path $releaseDir 'verify-beta-rc.ps1') -Force
& (Join-Path $releaseDir 'verify-beta-rc.ps1') -ReleaseDirectory $releaseDir -ExpectedCommit $commit
Write-Host "PASS: $zipName ($((Get-Item $zip).Length) bytes); commit $commit; SHA256 $zipHash"
