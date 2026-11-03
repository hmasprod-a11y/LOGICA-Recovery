# Adversarial release-candidate tests use disposable dummy files, never shop data.
$ErrorActionPreference = 'Stop'
$gate = Join-Path $PSScriptRoot 'test-release-candidate.ps1'
$work = Join-Path ([IO.Path]::GetTempPath()) ('logica-release-private-' + [Guid]::NewGuid().ToString('N'))
$dist = Join-Path $work 'dist'
New-Item -ItemType Directory -Force -Path $dist | Out-Null

function Write-Dummy([string]$relative, [string]$value) {
    $path = Join-Path $dist $relative
    New-Item -ItemType Directory -Force -Path (Split-Path -Parent $path) | Out-Null
    [IO.File]::WriteAllText($path, $value)
    return $path
}
function Assert-Rejected([string]$label, [string]$message) {
    $rejected = $false
    try { & $gate | Out-Null }
    catch {
        if ($_.Exception.Message -notlike "*$message*") { throw }
        $rejected = $true
    }
    if (-not $rejected) { throw "Candidate gate accepted private state: $label" }
    Write-Host "PASS: candidate gate rejected $label"
}
$entered = $false
try {
    Push-Location $work
    $entered = $true
    foreach ($file in @('LOGICA.exe','Dependency.dll','LOGICA.exe.config',
                       'Launch-LOGICA.ps1','Start-LOGICA.cmd')) {
        $null = Write-Dummy $file 'CI dummy, never a real executable'
    }
    foreach ($setting in @{'CHEMIN_DB.sni'='127.0.0.1';
                           'CHEMIN_FOLDER.sni'='Application.StartupPath';
                           'hash_licence.sni'=''; 'log_erreur.sni'=''}.GetEnumerator()) {
        $null = Write-Dummy $setting.Key $setting.Value
    }
    foreach ($printer in @('CL','ADD','RAPPORT','C1','C2','C3','C4','C5','C6','C7')) {
        $null = Write-Dummy "PRINTER_$printer.sni" '0'
    }
    & $gate | Out-Null
    Write-Host 'PASS: clean isolated release candidate accepted'
    foreach ($private in @('bd/mysql-client-temporary.ini',
                           'nested/MYSQL-CLIENT-TEMPORARY.INI',
                           'bd/mysql-credential.xml',
                           'bd/mysql-import-complete.txt')) {
        $path = Write-Dummy $private 'CI dummy private state'
        try { Assert-Rejected $private 'Private test/runtime state included:' }
        finally { Remove-Item -LiteralPath $path -Force }
    }
    $mysqlData = Join-Path $dist 'bd/mysql-data'
    New-Item -ItemType Directory -Force -Path $mysqlData | Out-Null
    try { Assert-Rejected 'bd/mysql-data' 'Test database state leaked into release package' }
    finally { Remove-Item -LiteralPath $mysqlData -Recurse -Force }
    & $gate | Out-Null
    Write-Host 'PASS: release candidate gate accepted clean fixture after all negative probes'
} finally {
    if ($entered) { Pop-Location }
    Remove-Item -LiteralPath $work -Recurse -Force -ErrorAction SilentlyContinue
}
