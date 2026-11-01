# Isolated contract and adversarial tests for the independent offline release verifier.
$ErrorActionPreference = 'Stop'
$verifier = Join-Path $PSScriptRoot 'verify-beta-rc.ps1'
$work = Join-Path ([IO.Path]::GetTempPath()) ('logica-beta-verifier-' + [Guid]::NewGuid().ToString('N'))
$src = Join-Path $work 'src'
$release = Join-Path $work 'release'
New-Item -ItemType Directory -Force $src,$release | Out-Null
$zip = Join-Path $release 'LOGICA-2.0-Beta-RC1-Windows-x86.zip'
$manifest = Join-Path $release 'LOGICA-2.0-Beta-RC1-file-manifest.json'
$sums = Join-Path $release 'SHA256SUMS.txt'
$commit = 'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa'
function Write-FixtureManifest {
    $entries = @(Get-ChildItem -LiteralPath $src -Recurse -File | ForEach-Object {
        [pscustomobject]@{
            path = $_.FullName.Substring($src.Length + 1).Replace([char]92, '/')
            size = $_.Length
            sha256 = (Get-FileHash -LiteralPath $_.FullName -Algorithm SHA256).Hash
        }
    })
    $entries | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $manifest -Encoding UTF8
}
function Write-FixtureZip {
    if (Test-Path -LiteralPath $zip) { Remove-Item -LiteralPath $zip -Force }
    Compress-Archive -Path (Join-Path $src '*') -DestinationPath $zip -CompressionLevel Optimal
    $digest = (Get-FileHash -LiteralPath $zip -Algorithm SHA256).Hash.ToLowerInvariant()
    "$digest  LOGICA-2.0-Beta-RC1-Windows-x86.zip" | Set-Content -LiteralPath $sums -Encoding ASCII
}
function Assert-Rejected([string]$label) {
    $rejected = $false
    try { & $verifier -ZipPath $zip -ManifestPath $manifest -SumsPath $sums -ExpectedCommit $commit | Out-Null }
    catch { $rejected = $true; Write-Host "PASS: verifier rejected $label" }
    if (-not $rejected) { throw "Release verifier accepted invalid fixture: $label" }
}
try {
    [IO.File]::WriteAllText((Join-Path $src 'LOGICA.exe'), 'isolated dummy executable')
    [IO.File]::WriteAllText((Join-Path $src 'Dependency.dll'), 'isolated dummy dependency')
    [IO.File]::WriteAllText((Join-Path $src 'Launch-LOGICA.ps1'), 'dummy launcher')
    [IO.File]::WriteAllText((Join-Path $src 'Start-LOGICA.cmd'), 'dummy launcher')
    [IO.File]::WriteAllText((Join-Path $src 'LOGICA.exe.config'), '<configuration />')
    [IO.File]::WriteAllText((Join-Path $src 'CHEMIN_FOLDER.sni'), 'Application.StartupPath')
    [IO.File]::WriteAllText((Join-Path $src 'log_erreur.sni'), '')
    foreach ($printer in @('CL','ADD','RAPPORT','C1','C2','C3','C4','C5','C6','C7')) {
        [IO.File]::WriteAllText((Join-Path $src ("PRINTER_$printer.sni")), '0')
    }
    [IO.File]::WriteAllText((Join-Path $src 'RUNNING.md'), 'dummy instructions')
    [IO.File]::WriteAllText((Join-Path $src 'hash_licence.sni'), '')
    [IO.File]::WriteAllText((Join-Path $src 'CHEMIN_DB.sni'), '127.0.0.1')
    @{sourceCommit=$commit;target='net48';architecture='x86';originalShopDatabaseIncluded=$false} |
        ConvertTo-Json | Set-Content -LiteralPath (Join-Path $src 'build-metadata.json') -Encoding UTF8
    Write-FixtureManifest
    Write-FixtureZip
    & $verifier -ZipPath $zip -ManifestPath $manifest -SumsPath $sums -ExpectedCommit $commit
    & $verifier -ZipPath $zip -ManifestPath $manifest -SumsPath $sums -ExpectedCommit $commit | Out-Null
    $originalSums = Get-Content -LiteralPath $sums -Raw
    ('0' * 64 + '  LOGICA-2.0-Beta-RC1-Windows-x86.zip') | Set-Content -LiteralPath $sums -Encoding ASCII
    Assert-Rejected 'wrong ZIP digest'
    [IO.File]::WriteAllText($sums, $originalSums)
    $originalManifest = Get-Content -LiteralPath $manifest -Raw
    $entries = @(Get-Content -LiteralPath $manifest -Raw | ConvertFrom-Json)
    $entries[0].sha256 = '0' * 64
    $entries | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $manifest -Encoding UTF8
    Assert-Rejected 'modified manifest file digest'
    [IO.File]::WriteAllText($manifest, $originalManifest)
    $entries = @(Get-Content -LiteralPath $manifest -Raw | ConvertFrom-Json)
    foreach ($invalidSize in @($null, 'not-a-number', '-1', '1.5', '9223372036854775808')) {
        $entries = @(Get-Content -LiteralPath $manifest -Raw | ConvertFrom-Json)
        $entries[0].size = $invalidSize
        $entries | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $manifest -Encoding UTF8
        Assert-Rejected "invalid manifest size $invalidSize"
        [IO.File]::WriteAllText($manifest, $originalManifest)
    }
    $entries = @(Get-Content -LiteralPath $manifest -Raw | ConvertFrom-Json)
    $entries[0].PSObject.Properties.Remove('size')
    $entries | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $manifest -Encoding UTF8
    Assert-Rejected 'missing manifest size property'
    [IO.File]::WriteAllText($manifest, $originalManifest)
    $entries = @(Get-Content -LiteralPath $manifest -Raw | ConvertFrom-Json)
    foreach ($collision in @('LOGICA.exe/child.dll', 'LOGICA.exe/empty/child.txt')) {
        $entries = @(Get-Content -LiteralPath $manifest -Raw | ConvertFrom-Json)
        $entries[1].path = $collision
        $entries | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $manifest -Encoding UTF8
        Assert-Rejected "manifest file/directory collision $collision"
        [IO.File]::WriteAllText($manifest, $originalManifest)
    }
    $entries = @(Get-Content -LiteralPath $manifest -Raw | ConvertFrom-Json)
    $entries[0].path = '../escape.txt'
    $entries | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $manifest -Encoding UTF8
    Assert-Rejected 'manifest path traversal'
    [IO.File]::WriteAllText($manifest, $originalManifest)
    foreach ($invalidName in @('CON.txt','folder/trailing.','folder/trailing ','LPT1/config.txt')) {
        $entries = @(Get-Content -LiteralPath $manifest -Raw | ConvertFrom-Json)
        $entries[0].path = $invalidName
        $entries | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $manifest -Encoding UTF8
        Assert-Rejected "unsafe Windows filename $invalidName"
        [IO.File]::WriteAllText($manifest, $originalManifest)
    }
    $entries = @(Get-Content -LiteralPath $manifest -Raw | ConvertFrom-Json)
    $entries[1].path = ([string]$entries[0].path).ToUpperInvariant()
    $entries | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $manifest -Encoding UTF8
    Assert-Rejected 'case-colliding manifest entries'
    [IO.File]::WriteAllText($manifest, $originalManifest)
    $rejected = $false
    try { & $verifier -ZipPath $zip -ManifestPath $manifest -SumsPath $sums -ExpectedCommit ('b' * 40) | Out-Null }
    catch { $rejected = $true }
    if (-not $rejected) { throw 'Release verifier accepted wrong expected commit' }
    Write-Host 'PASS: verifier rejected wrong commit'
    [IO.File]::WriteAllText((Join-Path $src 'unexpected.txt'), 'extra file')
    Write-FixtureZip
    Assert-Rejected 'unexpected ZIP file'
    Remove-Item -LiteralPath (Join-Path $src 'unexpected.txt') -Force
    Write-FixtureZip
    [IO.File]::WriteAllText((Join-Path $src 'hash_licence.sni'), 'private-license-value')
    Write-FixtureManifest
    Write-FixtureZip
    Assert-Rejected 'nonempty license state'
    [IO.File]::WriteAllText((Join-Path $src 'hash_licence.sni'), '')
    [IO.File]::WriteAllText((Join-Path $src 'CHEMIN_DB.sni'), '192.0.2.1')
    Write-FixtureManifest
    Write-FixtureZip
    Assert-Rejected 'nonlocal database host'
    [IO.File]::WriteAllText((Join-Path $src 'CHEMIN_DB.sni'), '127.0.0.1')
    foreach ($case in @(
        @{ name='PRINTER_CL.sni'; value='POS-80'; label='inherited shop printer' },
        @{ name='CHEMIN_FOLDER.sni'; value='C:\\Shop'; label='nonportable startup folder' },
        @{ name='log_erreur.sni'; value='previous shop exception'; label='previous runtime error log' }
    )) {
        $target = Join-Path $src $case.name
        $original = [IO.File]::ReadAllText($target)
        [IO.File]::WriteAllText($target, $case.value)
        Write-FixtureManifest
        Write-FixtureZip
        Assert-Rejected $case.label
        [IO.File]::WriteAllText($target, $original)
    }
    Write-FixtureManifest
    Write-FixtureZip
    Add-Type -AssemblyName System.IO.Compression.FileSystem
    $archive = [System.IO.Compression.ZipFile]::Open($zip, [System.IO.Compression.ZipArchiveMode]::Update)
    try {
        $entry = $archive.GetEntry('RUNNING.md')
        if ($null -eq $entry) { throw 'Fixture missing RUNNING.md for symlink probe' }
        $entry.ExternalAttributes = -1610612736 # Unix symbolic-link type bits (0xA000)
    } finally { $archive.Dispose() }
    $digest = (Get-FileHash -LiteralPath $zip -Algorithm SHA256).Hash.ToLowerInvariant()
    "$digest  LOGICA-2.0-Beta-RC1-Windows-x86.zip" | Set-Content -LiteralPath $sums -Encoding ASCII
    Assert-Rejected 'ZIP symbolic link'
    # Directory symlinks must also be rejected, not just file symlinks.
    Write-FixtureZip
    $archive = [System.IO.Compression.ZipFile]::Open($zip, [System.IO.Compression.ZipArchiveMode]::Update)
    try {
        $linkDir = $archive.CreateEntry('unsafe-link/')
        $linkDir.ExternalAttributes = -1610612736
    } finally { $archive.Dispose() }
    $digest = (Get-FileHash -LiteralPath $zip -Algorithm SHA256).Hash.ToLowerInvariant()
    "$digest  LOGICA-2.0-Beta-RC1-Windows-x86.zip" | Set-Content -LiteralPath $sums -Encoding ASCII
    Assert-Rejected 'ZIP symbolic-link directory'
    # Highly compressible payloads must fail before content is streamed or extracted.
    Write-FixtureZip
    $archive = [System.IO.Compression.ZipFile]::Open($zip, [System.IO.Compression.ZipArchiveMode]::Update)
    try {
        $huge = $archive.CreateEntry('compression-bomb.bin')
        $stream = $huge.Open()
        try {
            $buffer = New-Object byte[] 1048576
            for ($i = 0; $i -lt 4; $i++) { $stream.Write($buffer, 0, $buffer.Length) }
        } finally { $stream.Dispose() }
    } finally { $archive.Dispose() }
    $digest = (Get-FileHash -LiteralPath $zip -Algorithm SHA256).Hash.ToLowerInvariant()
    "$digest  LOGICA-2.0-Beta-RC1-Windows-x86.zip" | Set-Content -LiteralPath $sums -Encoding ASCII
    Assert-Rejected 'suspicious ZIP compression ratio'
    Write-Host 'PASS: independent verifier positive and adversarial tests'
} finally {
    Remove-Item -LiteralPath $work -Recurse -Force -ErrorAction SilentlyContinue
}
