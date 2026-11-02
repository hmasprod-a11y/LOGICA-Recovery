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
function Assert-LoginScreen([object]$report, [string]$entrypoint) {
    # A responsive window without the PIN screen is a startup regression.
    # This read-only gate does not enter a PIN or assert a licensed cashier.
    if ($report.inspectionStatus -ne 'inspected' -or $report.loginScreenVisible -ne $true) {
        throw "Extracted $entrypoint did not expose a visible cashier PIN login screen; see activation probe JSON"
    }
    Write-Host "PASS: extracted $entrypoint exposes cashier PIN login screen (license and cashier access NOT verified)"
}
# Compare actual article and ticket contents across all three customer entrypoints.
# Counts alone miss edits, deleted/reinserted rows, or duplicate sales. Hashes are
# kept only in memory; no shop data or recovered fixture rows enter artifacts.
$script:isolatedSalesDigestBaseline = $null
$script:isolatedSalesDigestChecks = 0
function Get-IsolatedSalesDigest([string]$entrypoint, [string]$clientExe, [string]$clientConfig) {
    $pieces = New-Object 'System.Collections.Generic.List[string]'
    foreach ($table in @('TABLE_ARTICLES', 'TABLE_VENTES_ENTETE')) {
        # --batch escapes embedded newlines/tabs. ORDER BY the original identity
        # keeps the canonical representation stable between independent queries.
        $rows = @(& $clientExe "--defaults-extra-file=$clientConfig" '--batch' '--skip-column-names' 'logica_recovered' '-e' "SELECT * FROM $table ORDER BY 1;" 2>&1)
        if ($LASTEXITCODE -ne 0) { throw "Could not fingerprint isolated $table after $entrypoint" }
        $pieces.Add("$table`n$($rows.Count)`n$($rows -join "`n")")
    }
    $sha = [Security.Cryptography.SHA256]::Create()
    try {
        $bytes = [Text.Encoding]::UTF8.GetBytes(($pieces -join "`n--NEXT-TABLE--`n"))
        return [BitConverter]::ToString($sha.ComputeHash($bytes)).Replace('-', '')
    } finally { $sha.Dispose() }
}
# Read-only database invariant while the actual extracted EXE is running.
# The credentials are generated by the isolated launcher inside RUNNER_TEMP;
# never print, copy, archive, or persist them in CI results.
function Assert-IsolatedStartupCounts([string]$entrypoint) {
    $clientConfig = Join-Path $extract 'bd/mysql-client-temporary.ini'
    $clientExe = Join-Path $server.Directory.FullName 'mariadb.exe'
    if (-not (Test-Path -LiteralPath $clientConfig -PathType Leaf) -or
        -not (Test-Path -LiteralPath $clientExe -PathType Leaf)) {
        throw "Isolated MariaDB client/config missing while testing $entrypoint"
    }
    $counts = @(& $clientExe "--defaults-extra-file=$clientConfig" '--batch' '--raw' '--skip-column-names' 'logica_recovered' '-e' 'SELECT COUNT(*) FROM TABLE_ARTICLES; SELECT COUNT(*) FROM TABLE_VENTES_ENTETE;' 2>&1)
    if ($LASTEXITCODE -ne 0 -or $counts.Count -ne 2 -or
        [string]$counts[0] -ne '120' -or [string]$counts[1] -ne '11') {
        throw "Extracted $entrypoint startup changed or could not read the isolated product/ticket counts"
    }
    $digest = Get-IsolatedSalesDigest $entrypoint $clientExe $clientConfig
    if ($null -eq $script:isolatedSalesDigestBaseline) {
        $script:isolatedSalesDigestBaseline = $digest
    } elseif ($digest -ne $script:isolatedSalesDigestBaseline) {
        throw "Isolated article/ticket CONTENT changed across extracted entrypoints at $entrypoint (counts alone would miss this)"
    }
    $script:isolatedSalesDigestChecks++
    Write-Host "PASS: $entrypoint preserved 120 articles, 11 ticket headers, and their canonical contents across entrypoints"
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

    # The direct-EXE path is verified below, after offline server binaries have
    # been provisioned. Never let CI download MariaDB or touch port 3306.
    $directWithoutOverrideAttempted = $false
    $directWithoutOverrideResponsive = $false
    $directWithoutOverrideActivation = $null
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
        Assert-LoginScreen $launcherActivation 'launcher'
        Assert-IsolatedStartupCounts 'launcher'
        if ($launcherActivation.activationScreenVisible -eq $true) {
            throw 'REGRESSION: packaged launcher displayed legacy activation screen'
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
        Assert-LoginScreen $cmdActivation 'Start-LOGICA.cmd'
        Assert-IsolatedStartupCounts 'Start-LOGICA.cmd'
        if ($cmdActivation.activationScreenVisible -eq $true) {
            throw 'REGRESSION: Start-LOGICA.cmd displayed legacy activation screen'
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

    # Real double-click regression: no CI connection string, no network download.
    # The EXE must delegate to the bundled launcher, which authenticates and
    # queries the fresh 3308 MariaDB before it can start the second EXE process.
    $directServerDir = Join-Path $extract 'bd/mysql-server'
    $directParent = $null
    $directChild = $null
    try {
        Copy-Item -LiteralPath $server.Directory.Parent.FullName -Destination $directServerDir -Recurse -Force
        if (-not (Get-ChildItem -LiteralPath $directServerDir -Recurse -Filter mariadbd.exe -File | Select-Object -First 1)) {
            throw 'Direct EXE regression: offline MariaDB binaries unavailable'
        }
        $savedOverride = [string]$env:LOGICA_DB_CONNECTION_STRING
        try {
            Remove-Item Env:LOGICA_DB_CONNECTION_STRING -ErrorAction SilentlyContinue
            $directParent = Start-Process -FilePath (Join-Path $extract 'LOGICA.exe') -WorkingDirectory $extract -PassThru
            $directWithoutOverrideAttempted = $true
        } finally {
            $env:LOGICA_DB_CONNECTION_STRING = $savedOverride
        }
        $watch = [Diagnostics.Stopwatch]::StartNew()
        do {
            Start-Sleep -Seconds 2
            $directParent.Refresh()
            $directChild = @(Get-Process -Name LOGICA -ErrorAction SilentlyContinue | Where-Object {
                try { $_.Id -ne $directParent.Id -and $_.Path -ieq (Join-Path $extract 'LOGICA.exe') } catch { $false }
            } | Select-Object -First 1)[0]
            if ($directChild) {
                $directChild.Refresh()
                if (-not $directChild.HasExited -and $directChild.MainWindowHandle -ne 0 -and $directChild.Responding) {
                    $directWithoutOverrideResponsive = $true
                    break
                }
            }
        } while ($watch.Elapsed.TotalSeconds -lt 90)
        if (-not $directWithoutOverrideResponsive) {
            throw 'Double-click LOGICA.exe did not launch a responsive authenticated child on MariaDB 3308'
        }
        $directWithoutOverrideActivation = Inspect-ActivationUI $directChild 'extracted-release-direct-no-override-activation.json'
        Assert-LoginScreen $directWithoutOverrideActivation 'direct EXE without override'
        Assert-IsolatedStartupCounts 'direct EXE'
        if ($directWithoutOverrideActivation.activationScreenVisible -eq $true) {
            throw 'Direct EXE displayed the legacy activation panel'
        }
        Write-Host 'PASS: direct EXE delegated to launcher and opened real WinForms app after authenticated MariaDB 3308 checks'
    } finally {
        if ($directChild) {
            try { $directChild.Refresh(); if (-not $directChild.HasExited) { $directChild.Kill(); $directChild.WaitForExit(10000) | Out-Null } } catch {}
        }
        if ($directParent) {
            try { $directParent.Refresh(); if (-not $directParent.HasExited) { $directParent.Kill(); $directParent.WaitForExit(10000) | Out-Null } } catch {}
        }
        Start-Sleep -Seconds 2
        if (Test-Path -LiteralPath $directServerDir) {
            Remove-Item -LiteralPath $directServerDir -Recurse -Force -ErrorAction Stop
        }
    }
    Assert-RuntimeHashes $extract $baseline
    Assert-PackagedCodeHashes $extract $codeBaseline
    # A missing activation label is not proof that no activation UI exists.
    # Preserve tri-state evidence rather than silently treating null as false.
    if ($null -eq $launcherActivation.activationScreenVisible -or
        $null -eq $cmdActivation.activationScreenVisible -or
        $null -eq $directWithoutOverrideActivation.activationScreenVisible) {
        Write-Warning 'Activation visibility was indeterminate in at least one entrypoint; cashier license acceptance remains BLOCKED.'
    }
    if ($script:isolatedSalesDigestChecks -ne 3) {
        throw "Expected three independent isolated data fingerprints; got $script:isolatedSalesDigestChecks"
    }
    Write-Warning 'RELEASE ACCEPTANCE BLOCKED: PIN login screen is not proof of a valid license, successful cashier login, completed sale, printer or scanner.'
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
        # These require an authorized cashier session and/or real peripherals.
        # Do not promote a green headless startup smoke to field acceptance.
        releaseAcceptanceDecision = 'BLOCKED_FIELD_ACCEPTANCE'
        authorizedCashierLoginVerified = $false
        settingsScreenOpenedVerified = $false
        articleCreatedViaUiVerified = $false
        articleImageSavedViaUiVerified = $false
        solderCashPaymentVerified = $false
        salePostedExactlyOnceVerified = $false
        startupReadOnlyDatabaseCountsVerified = $true
        isolatedArticleTicketContentStableAcrossEntrypoints = ($script:isolatedSalesDigestChecks -eq 3)
        isolatedSalesDigestCheckCount = $script:isolatedSalesDigestChecks
        returnPostedViaUiVerified = $false
        stockMovementPostedViaUiVerified = $false
        barcodeScannerHardwareVerified = $false
        printerHardwareVerified = $false
        cashDrawerHardwareVerified = $false
        launcherLoginPinScreenVisible = $launcherActivation.loginScreenVisible
        startCmdLoginPinScreenVisible = $cmdActivation.loginScreenVisible
        directExeLoginPinScreenVisible = $directWithoutOverrideActivation.loginScreenVisible
        launcherActivationInspectionStatus = $launcherActivation.inspectionStatus
        launcherActivationScreenVisible = $launcherActivation.activationScreenVisible
        launcherActivationAbsenceConfirmed = ($launcherActivation.activationScreenVisible -eq $false)
        startCmdActivationAbsenceConfirmed = ($cmdActivation.activationScreenVisible -eq $false)
        directExeActivationAbsenceConfirmed = ($directWithoutOverrideActivation.activationScreenVisible -eq $false)
        startCmdActivationInspectionStatus = $cmdActivation.inspectionStatus
        startCmdActivationScreenVisible = $cmdActivation.activationScreenVisible
        directExeWithoutConnectionOverrideVerified = $directWithoutOverrideResponsive
        directExeWithoutOverrideAttempted = $directWithoutOverrideAttempted
        directExeWithoutOverrideResponsiveWindow = $directWithoutOverrideResponsive
        directExeActivationInspectionStatus = $directWithoutOverrideActivation.inspectionStatus
        directExeWithoutOverrideActivationScreenVisible = $(if ($directWithoutOverrideActivation) { $directWithoutOverrideActivation.activationScreenVisible } else { $null })
        # A responsive PIN window and independent SQL checks do NOT prove that
        # the child EXE itself authenticated; require a separate connection trace.
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
