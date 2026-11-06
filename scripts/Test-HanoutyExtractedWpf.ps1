param(
    [Parameter(Mandatory=$true)][string]$ExtractedDirectory,
    [Parameter(Mandatory=$true)][string]$EvidenceDirectory
)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
# Reject directory junctions/symlinks before even resolving required files or reading runtime metadata.
# A linked directory can hide payload outside the extracted archive; rejecting
# linked files alone does not cover directory junctions or symbolic links.
$packageDirectories = @((Get-Item -LiteralPath $ExtractedDirectory)) +
    @(Get-ChildItem -LiteralPath $ExtractedDirectory -Directory -Recurse -Force)
foreach ($directory in $packageDirectories) {
    if (($directory.Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) {
        throw "Extracted WPF package contains a linked directory: $($directory.FullName)"
    }
}
# Reject linked files before reading runtimeconfig.json or executing the host.
$packageFiles = @(Get-ChildItem -LiteralPath $ExtractedDirectory -File -Recurse -Force | Sort-Object FullName)
if ($packageFiles.Count -lt 4) { throw 'Extracted WPF package has an incomplete payload.' }
foreach ($item in $packageFiles) {
    if (($item.Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) {
        throw "Extracted WPF package contains a linked file: $($item.FullName)"
    }
}
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
if ($null -eq $runtime.runtimeOptions -or $runtime.runtimeOptions.tfm -notin @('net10.0', 'net10.0-windows')) {
    throw 'Extracted WPF package is not a .NET 10 build.'
}
# Snapshot every payload hash BEFORE any executable is launched. A package that
# changes during the runtime gate must not receive a valid provenance manifest.
$preExecutionHashes = @{}
foreach ($item in $packageFiles) {
    $preExecutionHashes[$item.FullName] = (Get-FileHash -LiteralPath $item.FullName -Algorithm SHA256).Hash.ToLowerInvariant()
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
# Capture the caller's process environment before the disposable-only test marker is set.
# StrictMode requires this variable to be initialized on both success and failure paths.
$previousDisposableMarker = [Environment]::GetEnvironmentVariable('HANOUTY_W1_DISPOSABLE_MARKER', 'Process')
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
    # Disposable-only permission must not leak into subsequent checks.
    $env:HANOUTY_W1_DISPOSABLE_MARKER = 'I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY'
    $evidence = Join-Path ([IO.Path]::GetFullPath($EvidenceDirectory)) 'wpf-extracted-runtime'
    # Never accept an acceptance report left by an earlier run. A failed or
    # prematurely exited bootstrap must produce fresh evidence to pass this gate.
    $acceptancePath = Join-Path $evidence 'acceptance.json'
    if (Test-Path -LiteralPath $acceptancePath) {
        Remove-Item -LiteralPath $acceptancePath -Force -ErrorAction Stop
    }
    & (Join-Path $PSScriptRoot 'test-w1-bootstrap.ps1') -MariaDbBin $bin -HostExe $exe -EvidenceDirectory $evidence
    if ($LASTEXITCODE -ne 0 -and $null -ne $LASTEXITCODE) { throw 'Extracted WPF host failed runtime verification.' }
    $report = Get-Content -LiteralPath (Join-Path $evidence 'acceptance.json') -Raw | ConvertFrom-Json
    if ($report.W2Accepted -or -not $report.WindowLoaded -or $report.StagedSelections -ne 3) {
        throw 'Unacceptable extracted WPF runtime evidence.'
    }
    # Persist exact package identity next to the runtime acceptance evidence.
    # This is W1 provenance only: no financial W2 acceptance is implied.
    # Record every extracted payload file, not only the bootstrap assembly.
    # A dependency DLL must not be replaceable without changing the manifest.
    $packageRoot = [IO.Path]::GetFullPath($ExtractedDirectory).TrimEnd([IO.Path]::DirectorySeparatorChar) + [IO.Path]::DirectorySeparatorChar
    # Recheck directory reparse points AFTER host execution as well: the host
    # could replace a payload subdirectory with a junction during the W1 run.
    # Never hash or attest files reachable through a newly linked directory.
    $postExecutionDirectories = @((Get-Item -LiteralPath $ExtractedDirectory)) +
        @(Get-ChildItem -LiteralPath $ExtractedDirectory -Directory -Recurse -Force)
    foreach ($directory in $postExecutionDirectories) {
        if (($directory.Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) {
            throw "Extracted WPF package gained a linked directory during runtime verification: $($directory.FullName)"
        }
    }
    $postExecutionFiles = @(Get-ChildItem -LiteralPath $ExtractedDirectory -File -Recurse -Force)
    if ($postExecutionFiles.Count -ne $packageFiles.Count) {
        throw 'Extracted WPF payload file count changed during runtime verification.'
    }
    foreach ($postItem in $postExecutionFiles) {
        if (-not $preExecutionHashes.ContainsKey($postItem.FullName) -or
            ($postItem.Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) {
            throw "Extracted WPF payload file added or linked during runtime verification: $($postItem.FullName)"
        }
    }
    $hashes = @()
    foreach ($item in $packageFiles) {
        $relative = $item.FullName.Substring($packageRoot.Length).Replace('\', '/')
        if (-not (Test-Path -LiteralPath $item.FullName -PathType Leaf)) {
            throw "Extracted WPF payload disappeared during runtime verification: $relative"
        }
        $currentHash = (Get-FileHash -LiteralPath $item.FullName -Algorithm SHA256).Hash.ToLowerInvariant()
        if ($currentHash -cne $preExecutionHashes[$item.FullName]) {
            throw "Extracted WPF payload changed during runtime verification: $relative"
        }
        $hashes += [ordered]@{
            file = $relative
            sha256 = $currentHash
            bytes = $item.Length
        }
    }
    $provenance = [ordered]@{
        schema = 'hanouty-extracted-wpf-w1-provenance-v1'
        targetFramework = $runtime.runtimeOptions.tfm
        w1WindowLoaded = [bool]$report.WindowLoaded
        w1StagedSelections = [int]$report.StagedSelections
        w2Accepted = $false
        files = $hashes
    }
    $provenancePath = Join-Path $evidence 'package-provenance.json'
    $provenance | ConvertTo-Json -Depth 6 | Set-Content -LiteralPath $provenancePath -Encoding UTF8
    Write-Host 'PASS extracted HANOUTY WPF W1 runtime on disposable MariaDB; package SHA256 provenance recorded (W2 not accepted).'
} finally {
    # Cleanup failure must never leave the disposable-only authorization marker
    # enabled in the caller's PowerShell process. Restore it even if stopping
    # the MariaDB child process throws (for example, an access-denied race).
    try {
        if ($null -ne $server -and -not $server.HasExited) { Stop-Process -Id $server.Id -Force -ErrorAction Stop }
    } finally {
        [Environment]::SetEnvironmentVariable('HANOUTY_W1_DISPOSABLE_MARKER', $previousDisposableMarker, 'Process')
    }
}
