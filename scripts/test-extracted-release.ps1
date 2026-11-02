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
# Detect altered OR newly injected runnable content, including files that were
# not part of the historical 86-file immutable subset. Runtime preferences and
# MariaDB's disposable data directory are deliberately not treated as code.
function Get-PackagedCodeHashes([string]$directory) {
    $extensions = @('.exe','.dll','.config','.ps1','.psm1','.psd1','.cmd','.bat','.sql','.json','.md')
    $hashes = @{}
    $prefix = (Resolve-Path -LiteralPath $directory).Path.TrimEnd([char[]]@([char]92,[char]47))
    foreach ($file in @(Get-ChildItem -LiteralPath $prefix -Recurse -File -ErrorAction Stop)) {
        if ($extensions -notcontains $file.Extension.ToLowerInvariant()) { continue }
        $relative = $file.FullName.Substring($prefix.Length + 1).Replace([char]92, '/')
        if ($hashes.ContainsKey($relative)) { throw "Duplicate packaged code path: $relative" }
        $hashes[$relative] = (Get-FileHash -LiteralPath $file.FullName -Algorithm SHA256).Hash
    }
    return $hashes
}
function Assert-PackagedCodeHashes([string]$directory, [hashtable]$baseline) {
    $actual = Get-PackagedCodeHashes $directory
    foreach ($relative in $baseline.Keys) {
        if (-not $actual.ContainsKey($relative)) { throw "Packaged code removed: $relative" }
        if ($actual[$relative] -ne $baseline[$relative]) { throw "Packaged code modified: $relative" }
    }
    foreach ($relative in $actual.Keys) {
        if (-not $baseline.ContainsKey($relative)) { throw "Unexpected packaged code file: $relative" }
    }
}
# The activation UI probe is read-only and never supplies or modifies a license.
$activationProbe = Join-Path $PSScriptRoot 'probe-activation-ui.ps1'
if (-not (Test-Path -LiteralPath $activationProbe -PathType Leaf)) {
    throw 'Read-only activation UI probe missing'
}
function Inspect-ActivationUI([Diagnostics.Process]$target, [string]$name) {
    $output = Join-Path $results $name
    & powershell.exe -NoLogo -NoProfile -ExecutionPolicy Bypass -File $activationProbe -TargetProcessId $target.Id -OutputPath $output
    if ($LASTEXITCODE -ne 0 -or -not (Test-Path -LiteralPath $output -PathType Leaf)) {
        throw "Activation UI inspection failed to produce a report: $name"
    }
    return (Get-Content -LiteralPath $output -Raw | ConvertFrom-Json)
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
    foreach ($private in @('bd/mysql-data','bd/mysql-credential.xml','bd/mysql-import-complete.txt','bd/mysql-client-temporary.ini')) {
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
    $codeBaseline = Get-PackagedCodeHashes $extract
    if ($codeBaseline.Count -lt $dllsBefore.Count + 5) { throw 'Incomplete extracted code inventory' }
    # Negative regression uses a separate scratch fixture, not the real license.
    $probeDir = Join-Path $env:RUNNER_TEMP ('logica-integrity-probe-' + [Guid]::NewGuid().ToString('N'))
    New-Item -ItemType Directory -Force -Path $probeDir | Out-Null
    try {
        Copy-Item -LiteralPath (Join-Path $extract 'RUNNING.md') -Destination (Join-Path $probeDir 'RUNNING.md')
        $probeHashes = Get-RuntimeHashes $probeDir @('RUNNING.md')
        Add-Content -LiteralPath (Join-Path $probeDir 'RUNNING.md') -Value 'CI TAMPER PROBE'
        $rejected = $false
        try { Assert-RuntimeHashes $probeDir $probeHashes } catch {
            if ($_.Exception.Message -ne 'Runtime modified immutable file: RUNNING.md') { throw }
            $rejected = $true
        }
        if (-not $rejected) { throw 'Runtime integrity regression: modified file was accepted' }
        Remove-Item -LiteralPath (Join-Path $probeDir 'RUNNING.md') -Force
        $missingRejected = $false
        try { Assert-RuntimeHashes $probeDir $probeHashes } catch {
            if ($_.Exception.Message -ne 'Runtime removed immutable file: RUNNING.md') { throw }
            $missingRejected = $true
        }
        if (-not $missingRejected) { throw 'Runtime integrity regression: deleted file was accepted' }
    } finally { Remove-Item -LiteralPath $probeDir -Recurse -Force -ErrorAction Stop }
    Write-Host 'PASS: immutable runtime modification and deletion rejected in isolated fixture'
    # Negative fixture: a new executable payload must never go unnoticed.
    $inventoryProbe = Join-Path $env:RUNNER_TEMP ('logica-code-probe-' + [Guid]::NewGuid().ToString('N'))
    New-Item -ItemType Directory -Force -Path $inventoryProbe | Out-Null
    try {
        Copy-Item -LiteralPath (Join-Path $extract 'RUNNING.md') -Destination (Join-Path $inventoryProbe 'RUNNING.md')
        $inventoryBaseline = Get-PackagedCodeHashes $inventoryProbe
        [IO.File]::WriteAllText((Join-Path $inventoryProbe 'unexpected.cmd'), '@echo off')
        $injectionRejected = $false
        try { Assert-PackagedCodeHashes $inventoryProbe $inventoryBaseline } catch {
            if ($_.Exception.Message -ne 'Unexpected packaged code file: unexpected.cmd') { throw }
            $injectionRejected = $true
        }
        if (-not $injectionRejected) { throw 'Executable injection regression: new command file was accepted' }
        Remove-Item -LiteralPath (Join-Path $inventoryProbe 'unexpected.cmd') -Force
        Assert-PackagedCodeHashes $inventoryProbe $inventoryBaseline
    } finally { Remove-Item -LiteralPath $inventoryProbe -Recurse -Force -ErrorAction Stop }
    Write-Host 'PASS: newly injected executable rejected in isolated extracted-code fixture'

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
    Assert-PackagedCodeHashes $extract $codeBaseline
    Write-Host "PASS: extracted EXE startup preserved $($baseline.Count) immutable runtime files"

    # Reproduce the reported double-click path without the CI-only DB override.
    # Never attempt this if another service owns loopback 3306. A responsive
    # error dialog is NOT proof that the legacy fallback connected to MariaDB.
    $directWithoutOverrideAttempted = $false
    $directWithoutOverrideResponsive = $false
    $directWithoutOverrideActivation = $null
    $legacyHost = [IO.File]::ReadAllText((Join-Path $extract 'CHEMIN_DB.sni')).Trim()
    if ($legacyHost -ne '127.0.0.1') { throw 'Refusing unconfigured direct EXE probe: non-loopback legacy host' }
    $legacyPortOccupied = $false
    $portProbe = New-Object Net.Sockets.TcpClient
    try {
        $pending = $portProbe.BeginConnect('127.0.0.1', 3306, $null, $null)
        if ($pending.AsyncWaitHandle.WaitOne(500)) {
            try { $portProbe.EndConnect($pending); $legacyPortOccupied = $true } catch {}
        }
    } finally { $portProbe.Dispose() }
    if ($legacyPortOccupied) {
        Write-Warning 'Direct EXE without DB override skipped: port 3306 has an existing listener; no foreign DB touched.'
    } else {
        $directNoOverride = $null
        $savedConnection = [string]$env:LOGICA_DB_CONNECTION_STRING
        try {
            Remove-Item Env:LOGICA_DB_CONNECTION_STRING -ErrorAction SilentlyContinue
            $directNoOverride = Start-Process -FilePath (Join-Path $extract 'LOGICA.exe') -WorkingDirectory $extract -PassThru
            $directWithoutOverrideAttempted = $true
        } finally {
            $env:LOGICA_DB_CONNECTION_STRING = $savedConnection
        }
        try {
            $directTimer = [Diagnostics.Stopwatch]::StartNew()
            do {
                Start-Sleep -Seconds 2
                $directNoOverride.Refresh()
                if ($directNoOverride.HasExited) { break }
                if ($directNoOverride.MainWindowHandle -ne 0 -and $directNoOverride.Responding) {
                    $directWithoutOverrideResponsive = $true
                    $directWithoutOverrideActivation = Inspect-ActivationUI $directNoOverride 'extracted-release-direct-no-override-activation.json'
                    break
                }
            } while ($directTimer.Elapsed.TotalSeconds -lt 20)
            Write-Warning ("Direct EXE without DB override: responsiveWindow={0}; databaseConnectionVerified=False; expected legacy 3306 fallback may fail." -f $directWithoutOverrideResponsive)
        } finally {
            if ($directNoOverride) {
                try {
                    $directNoOverride.Refresh()
                    if (-not $directNoOverride.HasExited) {
                        $directNoOverride.Kill()
                        $directNoOverride.WaitForExit(10000) | Out-Null
                    }
                } catch { Write-Warning "Could not stop isolated direct EXE probe: $_" }
            }
        }
        Assert-RuntimeHashes $extract $baseline
        Assert-PackagedCodeHashes $extract $codeBaseline
    }
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
    # Verify the real customer startup path, not only -VerifyOnly. The launcher
    # starts an isolated MariaDB on 3308 and must actually spawn LOGICA.exe.
    # No activation state is fabricated: a responsive activation window is NOT
    # evidence that a licensed cashier can complete a sale.
    $launcherLog = Join-Path $results 'extracted-release-launcher-ui.log'
    $launcherErr = Join-Path $results 'extracted-release-launcher-ui.stderr.log'
    $launcherProcess = $null
    $launcherApp = $null
    $launcherResponsive = $false
    try {
        $launcherArgs = @('-NoLogo','-NoProfile','-ExecutionPolicy','Bypass','-File',
                          ('"' + (Join-Path $extract 'Launch-LOGICA.ps1') + '"'),
                          '-ServerBin',('"' + $server.Directory.FullName + '"'),'-Port','3308')
        $launcherProcess = Start-Process -FilePath 'powershell.exe' -ArgumentList $launcherArgs -WorkingDirectory $extract -PassThru -RedirectStandardOutput $launcherLog -RedirectStandardError $launcherErr
        $launchTimer = [Diagnostics.Stopwatch]::StartNew()
        do {
            Start-Sleep -Seconds 2
            $launcherProcess.Refresh()
            $launcherApp = @(Get-Process -Name LOGICA -ErrorAction SilentlyContinue | Where-Object {
                try { $_.Path -ieq (Join-Path $extract 'LOGICA.exe') } catch { $false }
            } | Select-Object -First 1)[0]
            if ($launcherApp) {
                $launcherApp.Refresh()
                if (-not $launcherApp.HasExited -and $launcherApp.MainWindowHandle -ne 0 -and $launcherApp.Responding) {
                    $launcherResponsive = $true
                    break
                }
            }
            if ($launcherProcess.HasExited) { break }
        } while ($launchTimer.Elapsed.TotalSeconds -lt 90)
        if (-not $launcherResponsive) {
            $details = if (Test-Path -LiteralPath $launcherLog) { (Get-Content -LiteralPath $launcherLog -Tail 12) -join ' | ' } else { 'No launcher output' }
            throw "Extracted customer launcher did not open responsive LOGICA.exe on local MariaDB 3308: $details"
        }
        Write-Host 'PASS: extracted customer launcher started actual LOGICA.exe with local MariaDB 3308'
        $launcherActivation = Inspect-ActivationUI $launcherApp 'extracted-release-launcher-activation.json'
        if ($launcherActivation.activationScreenVisible -eq $true) {
            Write-Warning 'BLOCKED: the extracted launcher displayed the legacy activation screen; licensed cashier not verified.'
        }
    } finally {
        if ($launcherApp) {
            try { $launcherApp.Refresh(); if (-not $launcherApp.HasExited) { $launcherApp.Kill(); $launcherApp.WaitForExit(10000) | Out-Null } } catch { Write-Warning "Could not stop launcher child EXE: $_" }
        }
        if ($launcherProcess) {
            try {
                if (-not $launcherProcess.WaitForExit(20000)) { $launcherProcess.Kill(); $launcherProcess.WaitForExit(10000) | Out-Null }
            } catch { Write-Warning "Could not stop isolated launcher: $_" }
        }
    }
    if ($launcherProcess.ExitCode -ne 0) { throw "Extracted launcher exited $($launcherProcess.ExitCode); see extracted-release-launcher-ui.log" }
    # Also exercise the exact Start-LOGICA.cmd entrypoint reported by the user.
    # Provision MariaDB from the CI runner's existing local binaries into the
    # disposable extraction only. Never download or modify an installed shop.
    $cmdServer = Join-Path $extract 'bd/mysql-server'
    $cmdProcess = $null
    $cmdApp = $null
    $cmdResponsive = $false
    try {
        Copy-Item -LiteralPath $server.Directory.Parent.FullName -Destination $cmdServer -Recurse -Force
        if (-not (Get-ChildItem -LiteralPath $cmdServer -Recurse -Filter mariadbd.exe -File | Select-Object -First 1)) {
            throw 'Offline CMD smoke did not provision a local MariaDB binary'
        }
        $cmdLog = Join-Path $results 'extracted-release-start-cmd.log'
        $cmdErr = Join-Path $results 'extracted-release-start-cmd.stderr.log'
        $cmdProcess = Start-Process -FilePath 'cmd.exe' -ArgumentList @('/d','/c','Start-LOGICA.cmd') -WorkingDirectory $extract -PassThru -RedirectStandardOutput $cmdLog -RedirectStandardError $cmdErr
        $cmdTimer = [Diagnostics.Stopwatch]::StartNew()
        do {
            Start-Sleep -Seconds 2
            $cmdProcess.Refresh()
            $cmdApp = @(Get-Process -Name LOGICA -ErrorAction SilentlyContinue | Where-Object {
                try { $_.Path -ieq (Join-Path $extract 'LOGICA.exe') } catch { $false }
            } | Select-Object -First 1)[0]
            if ($cmdApp) {
                $cmdApp.Refresh()
                if (-not $cmdApp.HasExited -and $cmdApp.MainWindowHandle -ne 0 -and $cmdApp.Responding) {
                    $cmdResponsive = $true
                    break
                }
            }
            if ($cmdProcess.HasExited) { break }
        } while ($cmdTimer.Elapsed.TotalSeconds -lt 90)
        if (-not $cmdResponsive) {
            $details = if (Test-Path -LiteralPath $cmdLog) { (Get-Content -LiteralPath $cmdLog -Tail 12) -join ' | ' } else { 'No CMD output' }
            throw "Extracted Start-LOGICA.cmd did not open responsive LOGICA.exe with offline local MariaDB: $details"
        }
        Write-Host 'PASS: extracted Start-LOGICA.cmd started actual LOGICA.exe using preprovisioned offline MariaDB'
        $cmdActivation = Inspect-ActivationUI $cmdApp 'extracted-release-cmd-activation.json'
        if ($cmdActivation.activationScreenVisible -eq $true) {
            Write-Warning 'BLOCKED: Start-LOGICA.cmd displayed the legacy activation screen; licensed cashier not verified.'
        }
    } finally {
        if ($cmdApp) {
            try { $cmdApp.Refresh(); if (-not $cmdApp.HasExited) { $cmdApp.Kill(); $cmdApp.WaitForExit(10000) | Out-Null } } catch { Write-Warning "Could not stop CMD child EXE: $_" }
        }
        if ($cmdProcess) {
            try { if (-not $cmdProcess.WaitForExit(20000)) { $cmdProcess.Kill(); $cmdProcess.WaitForExit(10000) | Out-Null } }
            catch { Write-Warning "Could not stop CMD launcher: $_" }
        }
        if (Test-Path -LiteralPath $cmdServer) {
            Remove-Item -LiteralPath $cmdServer -Recurse -Force -ErrorAction Stop
        }
    }
    if ($cmdProcess.ExitCode -ne 0) { throw "Extracted Start-LOGICA.cmd exited $($cmdProcess.ExitCode); see extracted-release-start-cmd.log" }
    Assert-RuntimeHashes $extract $baseline
    Assert-PackagedCodeHashes $extract $codeBaseline
    Write-Warning 'RELEASE ACCEPTANCE BLOCKED: responsive WinForms window does not prove valid license, cashier screen, printer, or direct EXE without DB override.'
    Assert-RuntimeHashes $extract $baseline
    Assert-PackagedCodeHashes $extract $codeBaseline
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
        extractedLauncherActualExeResponsive = $launcherResponsive
        extractedStartCmdActualExeResponsive = $cmdResponsive
        startCmdOfflineMariaDbPreprovisioned = $true
        licensedCashierScreenVerified = $false
        launcherActivationInspectionStatus = $launcherActivation.inspectionStatus
        launcherActivationScreenVisible = $launcherActivation.activationScreenVisible
        startCmdActivationInspectionStatus = $cmdActivation.inspectionStatus
        startCmdActivationScreenVisible = $cmdActivation.activationScreenVisible
        directExeWithoutConnectionOverrideVerified = $false
        directExeWithoutOverrideAttempted = $directWithoutOverrideAttempted
        directExeWithoutOverrideResponsiveWindow = $directWithoutOverrideResponsive
        directExeWithoutOverrideActivationScreenVisible = if ($directWithoutOverrideActivation) { $directWithoutOverrideActivation.activationScreenVisible } else { $null }
        directExeWithoutOverrideDatabaseConnectionVerified = $false
        realPrinterAndScannerVerified = $false
        immutableRuntimeFilesVerified = $baseline.Count
        packagedCodeFilesVerified = $codeBaseline.Count
        injectedExecutableProbeRejected = $true
        immutableTamperProbeRejected = $true
        immutableDeletionProbeRejected = $true
        temporaryMariaDbClientCredentialsCleaned = $true
        offlineServerPackageAbsent = $true
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
