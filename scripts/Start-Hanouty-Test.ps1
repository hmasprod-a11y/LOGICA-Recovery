param([switch]$VerifyOnly)
$ErrorActionPreference = 'Stop'
$ProgressPreference = 'SilentlyContinue'
Set-StrictMode -Version Latest

$bundle = $PSScriptRoot
$appZip = Join-Path $bundle 'HANOUTY-WPF-net10-FINANCIAL-ACCEPTED-win-x64.zip'
$acceptancePath = Join-Path $bundle 'financial-package-acceptance.json'
$appDir = Join-Path $bundle 'hanouty-app'
$exe = Join-Path $appDir 'Hanouty.Desktop.Bootstrap.exe'
$evidenceRoot = Join-Path $env:LOCALAPPDATA 'HANOUTY-Test\evidence'
$runtimeRoot = Join-Path $env:LOCALAPPDATA 'HANOUTY-Test\mariadb-10.11.14'
$sessionRoot = Join-Path $env:TEMP ('HANOUTY-Test-' + [guid]::NewGuid().ToString('N'))
$port = 3307
$dbPassword = 'hanouty-test-only'
$dbProcess = $null
$dbBin = $null
$dbData = Join-Path $sessionRoot 'data'
$evidence = Join-Path $evidenceRoot ([guid]::NewGuid().ToString('N'))
$completed = $false

function Stop-HanoutyTestDatabase {
    if ($null -eq $script:dbProcess) { return }
    if (-not $script:dbProcess.HasExited -and $script:dbBin) {
        & (Join-Path $script:dbBin 'mariadb-admin.exe') --host=127.0.0.1 --port=3307 --user=root "--password=$script:dbPassword" shutdown 2>$null | Out-Null
        if ($LASTEXITCODE -eq 0) { $script:dbProcess.WaitForExit(15000) }
    }
    if ($script:dbProcess.HasExited) {
        Remove-Item -LiteralPath $script:sessionRoot -Recurse -Force -ErrorAction SilentlyContinue
    } else {
        Write-Warning "The temporary test database is still stopping; its files were kept at $script:sessionRoot"
    }
}

try {
    if (-not [Environment]::Is64BitOperatingSystem) { throw 'This test bundle requires 64-bit Windows.' }
    if (-not (Test-Path -LiteralPath $appZip -PathType Leaf)) { throw 'The accepted WPF package ZIP is missing beside this launcher.' }
    if (-not (Test-Path -LiteralPath $acceptancePath -PathType Leaf)) { throw 'The package acceptance record is missing beside this launcher.' }
    $acceptedPackage = Get-Content -LiteralPath $acceptancePath -Raw | ConvertFrom-Json
    if ($acceptedPackage.FinancialAcceptance -ne $true) { throw 'The supplied package has no successful financial acceptance record.' }
    $expectedAppZipHash = ([string]$acceptedPackage.FinalPackageSha256).ToLowerInvariant()
    if ($expectedAppZipHash -notmatch '^[0-9a-f]{64}$') { throw 'The package acceptance record has no valid SHA-256.' }
    if ((Get-FileHash -LiteralPath $appZip -Algorithm SHA256).Hash.ToLowerInvariant() -cne $expectedAppZipHash) {
        throw 'The WPF package ZIP hash does not match the accepted package.'
    }

    if (Test-Path -LiteralPath $appDir) {
        $ownedMarker = Join-Path $appDir '.hanouty-test-package'
        if (-not (Test-Path -LiteralPath $ownedMarker -PathType Leaf) -or
            -not (Test-Path -LiteralPath $exe -PathType Leaf)) {
            throw "The existing extraction folder is incomplete or not owned by this test bundle: $appDir"
        }
    } else {
        New-Item -ItemType Directory -Path $appDir -Force | Out-Null
        Expand-Archive -LiteralPath $appZip -DestinationPath $appDir -Force
        Set-Content -LiteralPath (Join-Path $appDir '.hanouty-test-package') -Value 'This folder is extracted by the bundled test launcher.' -Encoding UTF8
    }
    if (-not (Test-Path -LiteralPath $exe -PathType Leaf)) { throw 'Hanouty cashier executable was not found in the package.' }
    $manifestPath = Join-Path $appDir 'HANOUTY-MANIFEST.json'
    if (-not (Test-Path -LiteralPath $manifestPath -PathType Leaf)) { throw 'The package manifest is missing.' }
    $manifest = Get-Content -LiteralPath $manifestPath -Raw | ConvertFrom-Json
    if ($manifest.mode -ne 'financial') { throw 'This bundle does not contain the financial WPF package.' }
    foreach ($file in $manifest.files) {
        $path = Join-Path $appDir ([string]$file.file)
        if (-not (Test-Path -LiteralPath $path -PathType Leaf) -or
            (Get-FileHash -LiteralPath $path -Algorithm SHA256).Hash.ToLowerInvariant() -cne [string]$file.sha256) {
            throw "Package integrity check failed for $($file.file)."
        }
    }

    New-Item -ItemType Directory -Path $evidence -Force | Out-Null
    New-Item -ItemType Directory -Path $runtimeRoot -Force | Out-Null
    $mariaZip = Join-Path $runtimeRoot 'mariadb-10.11.14-winx64.zip'
    $serverDir = Join-Path $runtimeRoot 'server'
    $url = 'https://archive.mariadb.org/mariadb-10.11.14/winx64-packages'
    $checksums = (Invoke-WebRequest "$url/sha256sums.txt" -UseBasicParsing).Content
    $checksumMatches = @()
    foreach ($line in ($checksums -split '\r?\n')) {
        if ($line -match '^([0-9a-fA-F]{64})[ \t]+\*?(?:\./)?([^/\\]+)[ \t]*$' -and $Matches[2] -ceq 'mariadb-10.11.14-winx64.zip') {
            $checksumMatches += $Matches[1].ToLowerInvariant()
        }
    }
    if ($checksumMatches.Count -ne 1) { throw 'Could not verify the official MariaDB download checksum.' }
    $expectedMariaHash = $checksumMatches[0]
    $needDownload = -not (Test-Path -LiteralPath $mariaZip -PathType Leaf)
    if (-not $needDownload) {
        $needDownload = (Get-FileHash -LiteralPath $mariaZip -Algorithm SHA256).Hash.ToLowerInvariant() -cne $expectedMariaHash
    }
    if ($needDownload) {
        Remove-Item -LiteralPath $mariaZip -Force -ErrorAction SilentlyContinue
        Invoke-WebRequest "$url/mariadb-10.11.14-winx64.zip" -OutFile $mariaZip -UseBasicParsing
    }
    if ((Get-FileHash -LiteralPath $mariaZip -Algorithm SHA256).Hash.ToLowerInvariant() -cne $expectedMariaHash) {
        throw 'MariaDB download integrity verification failed.'
    }
    $installer = Get-ChildItem -LiteralPath $serverDir -Recurse -Filter 'mariadb-install-db.exe' -ErrorAction SilentlyContinue | Select-Object -First 1
    $cachedServer = Get-ChildItem -LiteralPath $serverDir -Recurse -Filter 'mariadbd.exe' -ErrorAction SilentlyContinue | Select-Object -First 1
    if ($null -eq $installer -or $null -eq $cachedServer) {
        Remove-Item -LiteralPath $serverDir -Recurse -Force -ErrorAction SilentlyContinue
        New-Item -ItemType Directory -Path $serverDir -Force | Out-Null
        Expand-Archive -LiteralPath $mariaZip -DestinationPath $serverDir
        $installer = Get-ChildItem -LiteralPath $serverDir -Recurse -Filter 'mariadb-install-db.exe' | Select-Object -First 1
    }
    if ($null -eq $installer) { throw 'Verified MariaDB package did not contain its database initializer.' }
    $dbBin = $installer.Directory.FullName

    $probe = [Net.Sockets.TcpListener]::new([Net.IPAddress]::Loopback, $port)
    try { $probe.Start() } catch { throw 'Local test port 3307 is already in use. Close the other local database and retry.' }
    finally { $probe.Stop() }

    New-Item -ItemType Directory -Path $sessionRoot -Force | Out-Null
    & $installer.FullName "--datadir=$dbData" "--password=$dbPassword" "--port=$port" *> (Join-Path $sessionRoot 'database-setup.log')
    if ($LASTEXITCODE -ne 0) { throw 'Could not initialize the isolated test database.' }
    $defaultsArg = '--defaults-file="' + (Join-Path $dbData 'my.ini') + '"'
    $dbProcess = Start-Process -FilePath (Join-Path $dbBin 'mariadbd.exe') -ArgumentList @($defaultsArg, '--bind-address=127.0.0.1', "--port=$port") -WindowStyle Hidden -PassThru
    $ready = $false
    for ($i = 0; $i -lt 40; $i++) {
        Start-Sleep -Milliseconds 750
        & (Join-Path $dbBin 'mariadb-admin.exe') --host=127.0.0.1 "--port=$port" --user=root "--password=$dbPassword" ping 2>$null | Out-Null
        if ($LASTEXITCODE -eq 0) { $ready = $true; break }
        if ($dbProcess.HasExited) { throw 'The isolated MariaDB server stopped during startup.' }
    }
    if (-not $ready) { throw 'The isolated MariaDB server did not become ready.' }

    $sql = @'
CREATE DATABASE logica_ci CHARACTER SET utf8mb4;
CREATE USER 'w2_test'@'localhost' IDENTIFIED BY 'w2-disposable-only';
CREATE USER 'w2_test'@'127.0.0.1' IDENTIFIED BY 'w2-disposable-only';
GRANT ALL PRIVILEGES ON logica_ci.* TO 'w2_test'@'localhost';
GRANT ALL PRIVILEGES ON logica_ci.* TO 'w2_test'@'127.0.0.1';
'@
    $sql | & (Join-Path $dbBin 'mariadb.exe') --host=127.0.0.1 "--port=$port" --user=root "--password=$dbPassword"
    if ($LASTEXITCODE -ne 0) { throw 'Could not create the isolated Hanouty test database.' }

    $dataDirectory = Join-Path $sessionRoot 'app-data'
    New-Item -ItemType Directory -Path $dataDirectory -Force | Out-Null
    $env:HANOUTY_CATALOGUE_CONNECTION = 'Server=127.0.0.1;Port=3307;Database=logica_ci;Uid=w2_test;Pwd=w2-disposable-only;SslMode=Disabled;'
    $env:HANOUTY_DATA_DIRECTORY = $dataDirectory
    $env:HANOUTY_WORKSTATION = '01'
    $env:HANOUTY_W2_DISPOSABLE_MARKER = 'I_ACKNOWLEDGE_DISPOSABLE_DB_ONLY'
    $env:HANOUTY_W2_TEST_PIN = '1234'
    Write-Host 'Preparing a fresh, temporary MariaDB test database and running the WPF financial acceptance...' -ForegroundColor Cyan
    & $exe '--verify-disposable-cash-sale' $evidence
    if ($LASTEXITCODE -ne 0) { throw "Financial acceptance failed. Evidence: $evidence" }
    $reportPath = Join-Path $evidence 'w2-cash-sale.json'
    if (-not (Test-Path -LiteralPath $reportPath -PathType Leaf)) { throw "Acceptance evidence is missing. Evidence: $evidence" }
    $report = Get-Content -LiteralPath $reportPath -Raw | ConvertFrom-Json
    if ($report.W2Accepted -ne $true -or $report.FullCashReturnThroughWpfUi -ne $true) {
        throw "Financial acceptance did not report a successful cash sale and return. Evidence: $evidence"
    }
    $env:HANOUTY_W2_DISPOSABLE_MARKER = $null
    $env:HANOUTY_W2_TEST_PIN = $null
    Write-Host 'PASS: cash sale, full-ticket return, rollback and reconciliation verified on disposable data.' -ForegroundColor Green
    if (-not $VerifyOnly) {
        Write-Host "Opening the test cashier. Login: O'Neil | PIN: 1234. All records in this session are disposable." -ForegroundColor Cyan
        $cashier = Start-Process -FilePath $exe -WorkingDirectory $appDir -Wait -PassThru
        if ($cashier.ExitCode -ne 0) { throw "Cashier exited with code $($cashier.ExitCode). Evidence: $evidence" }
    }
    $completed = $true
    Write-Host "Evidence saved in: $evidence" -ForegroundColor Green
} catch {
    Write-Host "TEST SETUP FAILED: $($_.Exception.Message)" -ForegroundColor Red
    if (Test-Path -LiteralPath $evidence) { Write-Host "Evidence folder: $evidence" }
    exit 1
} finally {
    Stop-HanoutyTestDatabase
    if (-not $completed -and $dbProcess -and -not $dbProcess.HasExited) {
        Write-Warning 'The disposable test database was not removed because MariaDB did not stop cleanly.'
    }
}
