param(
  [Parameter(Mandatory=$true)][string]$MariaDbBin,
  [Parameter(Mandatory=$true)][string]$HostExe,
  [Parameter(Mandatory=$true)][string]$EvidenceDirectory
)
$ErrorActionPreference = 'Stop'
if ($env:HANOUTY_W1_DISPOSABLE_MARKER -ne 'I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY') {
  throw 'An explicit disposable test marker is required'
}
$evidence = [IO.Path]::GetFullPath($EvidenceDirectory)
New-Item -ItemType Directory -Force -Path $evidence | Out-Null
$data = Join-Path $evidence 'fixture-data'
$images = Join-Path $data 'bd/images'
New-Item -ItemType Directory -Force -Path $images | Out-Null
[IO.File]::WriteAllBytes((Join-Path $images 'exists.png'), [Convert]::FromBase64String('iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAQAAAC1HAwCAAAAC0lEQVR42mP8/x8AAwMCAO+a7l8AAAAASUVORK5CYII='))
$sql = @"
CREATE DATABASE IF NOT EXISTS logica_ci CHARACTER SET utf8mb4;
DROP TABLE IF EXISTS logica_ci.TABLE_ARTICLES;
CREATE TABLE logica_ci.TABLE_ARTICLES (
 ID_ARTICLE VARCHAR(128) PRIMARY KEY, Code VARCHAR(128) NULL,
 Article VARCHAR(255), Images VARCHAR(255)
) ENGINE=InnoDB;
INSERT INTO logica_ci.TABLE_ARTICLES VALUES
 ('A-1','SINGLE','Ordinary',NULL),
 ('A-2','DUP','Variant A',NULL),
 ('A-3','DUP','Variant B','missing.png'),
 ('A-4',NULL,'Image-only','exists.png');
CREATE USER IF NOT EXISTS 'hanouty_w1_read'@'127.0.0.1' IDENTIFIED BY 'disposable-read-only';
GRANT SELECT ON logica_ci.TABLE_ARTICLES TO 'hanouty_w1_read'@'127.0.0.1';
"@
$client = Join-Path $MariaDbBin 'mariadb.exe'
& $client --host=127.0.0.1 --port=3307 --user=root --password=logica-ci-only -e $sql
if ($LASTEXITCODE -ne 0) { throw 'Disposable schema setup failed' }
$env:HANOUTY_CATALOGUE_CONNECTION = 'Server=127.0.0.1;Port=3307;Database=logica_ci;Uid=hanouty_w1_read;Pwd=disposable-read-only;SslMode=None;Connection Timeout=5;'
$env:HANOUTY_DATA_DIRECTORY = $data
$process = Start-Process -FilePath ([IO.Path]::GetFullPath($HostExe)) -ArgumentList @('--catalogue-only','--verify-disposable-catalogue',('"' + $evidence + '"')) -PassThru -WindowStyle Hidden
try {
  if (-not $process.WaitForExit(60000)) { throw 'WPF host did not finish acceptance within 60 seconds' }
  if ($process.ExitCode -ne 0) {
    if (Test-Path (Join-Path $evidence 'failure.txt')) { Get-Content (Join-Path $evidence 'failure.txt') | Write-Host }
    throw "WPF host acceptance exited $($process.ExitCode)"
  }
  $report = Get-Content (Join-Path $evidence 'acceptance.json') -Raw | ConvertFrom-Json
  if (-not $report.WindowLoaded -or $report.Rows -ne 4 -or $report.StagedSelections -ne 3 -or $report.FinancialSubmissionEnabled) {
    throw 'WPF acceptance evidence is incomplete'
  }
  $rows = & $client --host=127.0.0.1 --port=3307 --user=root --password=logica-ci-only --batch --skip-column-names -e 'SELECT COUNT(*) FROM logica_ci.TABLE_ARTICLES'
  if ($LASTEXITCODE -ne 0 -or [int]$rows -ne 4) { throw 'Read-only W1 acceptance altered fixture rows' }
  # Exercise the exact Explorer double-click path (zero arguments) against the
  # same disposable local SELECT-only database. A blocking error MessageBox is
  # NOT a successful launch: require the real read-only catalogue window title.
  $normal = Start-Process -FilePath ([IO.Path]::GetFullPath($HostExe)) -PassThru
  try {
    $windowReady = $false
    for ($attempt = 0; $attempt -lt 30; $attempt++) {
      Start-Sleep -Milliseconds 500
      $normal.Refresh()
      if ($normal.HasExited) { throw "Zero-argument WPF launcher exited $($normal.ExitCode)" }
      if ($normal.MainWindowTitle -eq 'Hanouty — Catalogue (read-only)') {
        $windowReady = $true
        break
      }
    }
    if (-not $windowReady) {
      throw "Zero-argument WPF launcher did not display the actual read-only catalogue window; observed title: $($normal.MainWindowTitle)"
    }
    Write-Host 'PASS zero-argument WPF double-click startup: actual read-only catalogue window visible.'
  } finally {
    $normal.Refresh()
    if (-not $normal.HasExited) { $normal.Kill(); $normal.WaitForExit(10000) | Out-Null }
  }
  Write-Host 'PASS actual Windows WPF host: real MariaDB rows, image-only tile, scanner, duplicate selection, search, financial submission disabled.'
  Write-Host 'W2 is not accepted by this catalogue-only gate.'
} finally {
  if (-not $process.HasExited) { $process.Kill() }
}
