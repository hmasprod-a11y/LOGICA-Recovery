param(
    [Parameter(Mandatory=$true)][string]$ExtractedDirectory,
    [Parameter(Mandatory=$true)][string]$EvidenceDirectory
)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
$exe = Join-Path ([IO.Path]::GetFullPath($ExtractedDirectory)) 'Hanouty.Desktop.Bootstrap.exe'
if (-not (Test-Path -LiteralPath $exe -PathType Leaf)) { throw 'Extracted WPF executable not found.' }
# A standalone net10 Windows release must carry its runtime metadata and
# managed entry assembly. A legacy LOGICA executable cannot satisfy this gate.
$required = @(
    'Hanouty.Desktop.Bootstrap.dll',
    'Hanouty.Desktop.Bootstrap.runtimeconfig.json',
    'Hanouty.Desktop.Bootstrap.deps.json'
)
foreach ($name in $required) {
    if (-not (Test-Path -LiteralPath (Join-Path $ExtractedDirectory $name) -PathType Leaf)) {
        throw "Extracted standalone WPF package missing required file: $name"
    }
}
$runtime = Get-Content -LiteralPath (Join-Path $ExtractedDirectory 'Hanouty.Desktop.Bootstrap.runtimeconfig.json') -Raw | ConvertFrom-Json
if ($null -eq $runtime.runtimeOptions -or $runtime.runtimeOptions.tfm -ne 'net10.0-windows') {
    throw 'Extracted WPF package is not a net10.0-windows build.'
}
$root = Join-Path ([IO.Path]::GetFullPath($EvidenceDirectory)) 'disposable-mariadb'
New-Item -ItemType Directory -Path $root -Force | Out-Null
$archive = 'mariadb-10.11.14-winx64.zip'
$url = 'https://archive.mariadb.org/mariadb-10.11.14/winx64-packages'
Invoke-WebRequest "$url/$archive" -OutFile (Join-Path $root $archive)
$checks = (Invoke-WebRequest "$url/sha256sums.txt").Content
# Parse GNU sha256sum format (two spaces or binary '*') and optional ./ prefix.
# Require exactly one archive entry and a full 64-character digest; never bypass integrity.
$matching = @()
foreach ($line in ($checks -split '\r?\n')) {
    if ($line -match '^([0-9a-fA-F]{64})[ \t]+\*?(?:\./)?([^/\\]+)[ \t]*$' -and
        $Matches[2] -ceq $archive) {
        $matching += $Matches[1].ToLowerInvariant()
    }
}
if ($matching.Count -ne 1) { throw "MariaDB archive checksum entry missing or ambiguous: $($matching.Count) matching entries." }
$expected = $matching[0]
if ((Get-FileHash (Join-Path $root $archive) -Algorithm SHA256).Hash.ToLowerInvariant() -ne $expected) {
    throw 'Disposable MariaDB archive integrity check failed.'
}
Expand-Archive -LiteralPath (Join-Path $root $archive) -DestinationPath (Join-Path $root 'server')
$installer = Get-ChildItem (Join-Path $root 'server') -Recurse -Filter 'mariadb-install-db.exe' | Select-Object -First 1
if ($null -eq $installer) { throw 'MariaDB installer executable missing.' }
$bin = $installer.Directory.FullName
$dbdata = Join-Path $root 'db'
& (Join-Path $bin 'mariadb-install-db.exe') "--datadir=$dbdata" '--password=logica-ci-only' '--port=3307'
if ($LASTEXITCODE -ne 0) { throw 'Disposable MariaDB initialization failed.' }
$server = $null
try {
    $server = Start-Process -FilePath (Join-Path $bin 'mariadbd.exe') -ArgumentList @(
        "--defaults-file=`"$dbdata/my.ini`"",
        '--bind-address=127.0.0.1', '--port=3307'
    ) -WindowStyle Hidden -PassThru
    $ready = $false
    for ($i=0; $i -lt 40; $i++) {
        Start-Sleep -Seconds 1
        & (Join-Path $bin 'mariadb-admin.exe') --host=127.0.0.1 --port=3307 --user=root --password=logica-ci-only ping 2>$null | Out-Null
        if ($LASTEXITCODE -eq 0) { $ready = $true; break }
        if ($server.HasExited) { throw 'Disposable MariaDB exited before readiness.' }
    }
    if (-not $ready) { throw 'Disposable MariaDB failed to become ready.' }
    $env:HANOUTY_W1_DISPOSABLE_MARKER = 'I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY'
    $evidence = Join-Path ([IO.Path]::GetFullPath($EvidenceDirectory)) 'wpf-extracted-runtime'
    & (Join-Path $PSScriptRoot 'test-w1-bootstrap.ps1') -MariaDbBin $bin -HostExe $exe -EvidenceDirectory $evidence
    if ($LASTEXITCODE -ne 0 -and $null -ne $LASTEXITCODE) { throw 'Extracted WPF host failed runtime verification.' }
    $report = Get-Content -LiteralPath (Join-Path $evidence 'acceptance.json') -Raw | ConvertFrom-Json
    if ($report.W2Accepted -or -not $report.WindowLoaded -or $report.StagedSelections -ne 3) {
        throw 'Unacceptable extracted WPF runtime evidence.'
    }
    Write-Host 'PASS extracted self-contained HANOUTY WPF exe on disposable MariaDB, real window and scanner.'
} finally {
    if ($null -ne $server -and -not $server.HasExited) { Stop-Process -Id $server.Id -Force }
}
