# Exercise the actual extracted customer ZIP, not just the mutable dist/ build tree.
# Runs only on an isolated Windows Actions runner with its temporary MariaDB fixture.
$ErrorActionPreference = 'Stop'
$root = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$release = Join-Path $root 'release'
$zip = Join-Path $release 'LOGICA-2.0-Beta-RC1-Windows-x86.zip'
$verifier = Join-Path $release 'verify-beta-rc.ps1'
$results = Join-Path $root 'results'
$ciDb = [string]$env:LOGICA_DB_CONNECTION_STRING
if ($ciDb -notmatch '(?i)(?:^|;)\s*Server=127\.0\.0\.1\s*;' -or
    $ciDb -notmatch '(?i)(?:^|;)\s*Port=3307\s*;' -or
    $ciDb -notmatch '(?i)(?:^|;)\s*Database=logica_ci\s*;') {
    throw 'Refusing extracted EXE smoke without the isolated CI database on loopback port 3307'
}
if (-not (Test-Path -LiteralPath $zip -PathType Leaf) -or
    -not (Test-Path -LiteralPath $verifier -PathType Leaf)) {
    throw 'Signed-off release ZIP or independent verifier missing'
}
$commit = (& git -C $root rev-parse HEAD).Trim()
if ($LASTEXITCODE -ne 0 -or $commit -notmatch '^[0-9a-f]{40}$') { throw 'Cannot resolve checked-out source SHA' }
& $verifier -ReleaseDirectory $release -ExpectedCommit $commit

$server = Get-ChildItem (Join-Path $env:RUNNER_TEMP 'logica-mariadb/server') -Recurse -Filter mariadbd.exe -File |
    Select-Object -First 1
if (-not $server) { throw 'Isolated CI MariaDB binary missing: no network fallback permitted' }
$extract = Join-Path $env:RUNNER_TEMP ('logica-rc1-field-smoke-' + [Guid]::NewGuid().ToString('N'))
# Inspect only the disposable extracted copy; never mutate an installed shop.
# A responsive WinForms window is not enough if startup rewrites a license,
# peripheral configuration, executable, library, or recovery SQL file.
function Get-RuntimeHashes([string]$directory, [string[]]$relativePaths) {
    $hashes = @{}
    foreach ($relative in $relativePaths) {
        $path = Join-Path $directory $relative
        if (-not (Test-Path -LiteralPath $path -PathType Leaf)) { throw "Missing immutable runtime file: $relative" }
        if ($hashes.ContainsKey($relative)) { throw "Duplicate immutable runtime path: $relative" }
        $hashes[$relative] = (Get-FileHash -LiteralPath $path -Algorithm SHA256).Hash
    }
    return $hashes
}
function Assert-RuntimeHashes([string]$directory, [hashtable]$baseline) {
    foreach ($relative in $baseline.Keys) {
        $path = Join-Path $directory $relative
        if (-not (Test-Path -LiteralPath $path -PathType Leaf)) { throw "Runtime removed immutable file: $relative" }
        $actual = (Get-FileHash -LiteralPath $path -Algorithm SHA256).Hash
        if ($actual -ne $baseline[$relative]) { throw "Runtime modified immutable file: $relative" }
    }
}
$app = $null
$started = [Diagnostics.Stopwatch]::StartNew()
try {
    Expand-Archive -LiteralPath $zip -DestinationPath $extract -Force
    foreach ($required in @('LOGICA.exe','LOGICA.exe.config','Launch-LOGICA.ps1','Start-LOGICA.cmd',
                            'RUNNING.md','build-metadata.json','CHEMIN_DB.sni','hash_licence.sni')) {
        if (-not (Test-Path -LiteralPath (Join-Path $extract $required) -PathType Leaf)) {
            throw "Extracted release is missing $required"
        }
    }
    foreach ($private in @('bd/mysql-data','bd/mysql-credential.xml','bd/mysql-import-complete.txt')) {
        if (Test-Path -LiteralPath (Join-Path $extract $private)) {
            throw "Extracted release includes private database state: $private"
        }
    }
    $metadata = Get-Content -LiteralPath (Join-Path $extract 'build-metadata.json') -Raw | ConvertFrom-Json
    if ($metadata.sourceCommit -ne $commit -or $metadata.target -ne 'net48' -or
        $metadata.architecture -ne 'x86' -or $metadata.originalShopDatabaseIncluded -ne $false) {
        throw 'Extracted release provenance differs from the checked-out source'
    }
    $immutable = @('LOGICA.exe', 'LOGICA.exe.config', 'Launch-LOGICA.ps1',
                   'Start-LOGICA.cmd', 'RUNNING.md', 'build-metadata.json',
                   'CHEMIN_DB.sni', 'CHEMIN_FOLDER.sni', 'hash_licence.sni',
                   'recovery/recovered-original.sql', 'recovery/mysql-compatibility.sql') +
                 @(Get-ChildItem -LiteralPath $extract -Filter '*.dll' -File | ForEach-Object { $_.Name }) +
                 @(Get-ChildItem -LiteralPath $extract -Filter 'PRINTER_*.sni' -File | ForEach-Object { $_.Name })
    $dllsBefore = @(Get-ChildItem -LiteralPath $extract -Filter '*.dll' -File | ForEach-Object { $_.Name })
    if ($dllsBefore.Count -lt 1) { throw 'Extracted runtime has no DLLs to verify' }
    $baseline = Get-RuntimeHashes $extract $immutable
    # Negative regression uses a separate scratch fixture, not the real license.
    $probeDir = Join-Path $env:RUNNER_TEMP ('logica-integrity-probe-' + [Guid]::NewGuid().ToString('N'))
    New-Item -ItemType Directory -Force -Path $probeDir | Out-Null
    try {
        Copy-Item -LiteralPath (Join-Path $extract 'RUNNING.md') -Destination (Join-Path $probeDir 'RUNNING.md')
        $probeHashes = Get-RuntimeHashes $probeDir @('RUNNING.md')
        Add-Content -LiteralPath (Join-Path $probeDir 'RUNNING.md') -Value 'CI TAMPER PROBE'
        $rejected = $false
        try { Assert-RuntimeHashes $probeDir $probeHashes } catch { $rejected = $true }
        if (-not $rejected) { throw 'Runtime integrity regression: modified file was accepted' }
    } finally { Remove-Item -LiteralPath $probeDir -Recurse -Force -ErrorAction Stop }
    Write-Host 'PASS: immutable runtime tamper probe rejected in isolated fixture'
    # Launch the packaged real Windows executable with the isolated CI database.
    # A live process alone is not sufficient: require a responsive WinForms main window.
    $app = Start-Process -FilePath (Join-Path $extract 'LOGICA.exe') -WorkingDirectory $extract -PassThru
    $windowReady = $false
    $timer = [Diagnostics.Stopwatch]::StartNew()
    do {
        Start-Sleep -Seconds 2
        $app.Refresh()
        if ($app.HasExited) { break }
        if ($app.MainWindowHandle -ne 0 -and $app.Responding) { $windowReady = $true; break }
    } while ($timer.Elapsed.TotalSeconds -lt 30)
    if (-not $windowReady) { throw 'Extracted LOGICA.exe did not open a responsive main window' }
    Write-Host 'PASS: extracted LOGICA.exe opened a responsive WinForms window'
    if (-not $app.HasExited) { $app.Kill(); $app.WaitForExit(10000) | Out-Null }
    $app = $null
    Assert-RuntimeHashes $extract $baseline
    Write-Host "PASS: extracted EXE startup preserved $($baseline.Count) immutable runtime files"

    # Verify the launcher *inside* the customer ZIP with the already-downloaded
    # CI MariaDB server, in a fresh isolated data directory (never a shop DB).
    $log = Join-Path $results 'extracted-release-launcher.log'
    & powershell.exe -NoLogo -NoProfile -ExecutionPolicy Bypass -File (Join-Path $extract 'Launch-LOGICA.ps1') -ServerBin $server.Directory.FullName -Port 3308 -VerifyOnly *> $log
    $exitCode = $LASTEXITCODE
    Get-Content -LiteralPath $log | Select-String 'PASS|Base locale|ERREUR' | ForEach-Object { Write-Host $_ }
    if ($exitCode -ne 0) { throw "Extracted portable launcher failed (exit $exitCode); see extracted-release-launcher.log" }
    if (-not (Select-String -LiteralPath $log -Pattern 'PASS portable launcher imports original database and preserves row counts' -Quiet)) {
        throw 'Extracted portable launcher did not report successful isolated database verification'
    }
    Write-Host 'PASS: extracted launcher imported original SQL fixture into a fresh loopback MariaDB instance'
    Assert-RuntimeHashes $extract $baseline
    if (Test-Path -LiteralPath (Join-Path $extract 'bd/mysql-client-temporary.ini')) {
        throw 'Extracted launcher left plaintext temporary MariaDB credentials on disk'
    }
    if (Test-Path -LiteralPath (Join-Path $extract 'bd/mysql-server')) {
        throw 'Extracted launcher unexpectedly downloaded MariaDB during offline CI smoke'
    }
    $dllsAfter = @(Get-ChildItem -LiteralPath $extract -Filter '*.dll' -File | ForEach-Object { $_.Name })
    if ($dllsAfter.Count -ne $dllsBefore.Count -or
        @($dllsAfter | Where-Object { $dllsBefore -notcontains $_ }).Count -ne 0) {
        throw 'Extracted launcher changed the runtime DLL inventory'
    }
    Write-Host "PASS: offline launcher preserved $($baseline.Count) immutable files and cleaned temporary credentials"
    [pscustomobject]@{
        sourceCommit = $commit
        extractedExeResponsive = $true
        extractedLauncherVerified = $true
        immutableRuntimeFilesVerified = $baseline.Count
        immutableTamperProbeRejected = $true
        temporaryMariaDbClientCredentialsCleaned = $true
        offlineServerDownloadNotAttempted = $true
        isolatedMariaDbPort = 3308
        originalShopDatabaseTouched = $false
        elapsedSeconds = [math]::Round($started.Elapsed.TotalSeconds, 1)
    } | ConvertTo-Json | Set-Content -LiteralPath (Join-Path $results 'extracted-release-smoke.json') -Encoding UTF8
} finally {
    if ($app) {
        try { $app.Refresh(); if (-not $app.HasExited) { $app.Kill(); $app.WaitForExit(10000) | Out-Null } }
        catch { Write-Warning "Could not stop temporary extracted application: $_" }
    }
    # The extracted launcher creates a temporary DB and local credentials; neither
    # must survive this CI run or enter any uploaded release artifact.
    if (Test-Path -LiteralPath $extract) {
        Remove-Item -LiteralPath $extract -Recurse -Force -ErrorAction Stop
    }
}
