# Offline, read-only verification of the Windows beta RC1 release artifact.
# Works on Windows PowerShell 5.1 and PowerShell 7. Does not extract or execute the POS.
[CmdletBinding()]
param(
    [string]$ReleaseDirectory = $PSScriptRoot,
    [string]$ExpectedCommit = '',
    [string]$ZipPath = '',
    [string]$ManifestPath = '',
    [string]$SumsPath = ''
)
$ErrorActionPreference = 'Stop'
$zipName = 'LOGICA-2.0-Beta-RC1-Windows-x86.zip'
if (-not $ZipPath) { $ZipPath = Join-Path $ReleaseDirectory $zipName }
if (-not $ManifestPath) { $ManifestPath = Join-Path $ReleaseDirectory 'LOGICA-2.0-Beta-RC1-file-manifest.json' }
if (-not $SumsPath) { $SumsPath = Join-Path $ReleaseDirectory 'SHA256SUMS.txt' }
foreach ($path in @($ZipPath, $ManifestPath, $SumsPath)) {
    if (-not (Test-Path -LiteralPath $path -PathType Leaf)) { throw "Missing release verification input: $path" }
}
$sumLines = @(Get-Content -LiteralPath $SumsPath | Where-Object { -not [string]::IsNullOrWhiteSpace($_) })
if ($sumLines.Count -ne 1) { throw 'Invalid SHA256SUMS.txt: expected exactly one ZIP digest' }
$sumMatch = [regex]::Match($sumLines[0], '^([a-fA-F0-9]{64})  LOGICA-2\.0-Beta-RC1-Windows-x86\.zip$')
if (-not $sumMatch.Success) { throw 'Invalid SHA256SUMS.txt: expected ZIP digest and exact filename' }
$zipHash = (Get-FileHash -LiteralPath $ZipPath -Algorithm SHA256).Hash
if ($zipHash -ine $sumMatch.Groups[1].Value) { throw 'Release ZIP SHA256 mismatch' }
function Assert-SafePath([string]$name) {
    if ([string]::IsNullOrWhiteSpace($name) -or $name.StartsWith('/') -or
        $name.Contains([char]92) -or $name.Contains(':') -or
        ($name.Split('/') | Where-Object { $_ -eq '..' -or $_ -eq '.' -or $_ -eq '' }).Count -gt 0) {
        throw "Unsafe archive or manifest path: $name"
    }
    foreach ($segment in $name.Split('/')) {
        # Reject Windows filename aliases, control characters and trailing-dot/space collisions.
        if ($segment -match '[\x00-\x1F]' -or $segment -match '[. ]$' -or
            $segment -match '^(?i:CON|PRN|AUX|NUL|COM[1-9]|LPT[1-9])(?:\.|$)') {
            throw "Unsafe Windows archive or manifest path: $name"
        }
    }
}
$expected = @((Get-Content -LiteralPath $ManifestPath -Raw | ConvertFrom-Json))
if ($expected.Count -lt 5 -or $expected.Count -gt 10000) { throw 'Invalid release manifest entry count' }
$byPath = [System.Collections.Generic.Dictionary[string,object]]::new([System.StringComparer]::OrdinalIgnoreCase)
foreach ($item in $expected) {
    $name = [string]$item.path
    Assert-SafePath $name
    if ($byPath.ContainsKey($name)) { throw "Duplicate manifest path (including case collision): $name" }
    if ([string]$item.sha256 -notmatch '^[a-fA-F0-9]{64}$' -or [long]$item.size -lt 0) {
        throw "Invalid manifest hash or size: $name"
    }
    if ($name -match '(^|/)(mysql-credential\.xml|mysql-import-complete\.txt)$' -or $name -match '^bd/mysql-data(/|$)') {
        throw "Forbidden persisted test data in manifest: $name"
    }
    $byPath.Add($name, $item)
}
Add-Type -AssemblyName System.IO.Compression.FileSystem
$archive = [System.IO.Compression.ZipFile]::OpenRead($ZipPath)
try {
    $seen = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::OrdinalIgnoreCase)
    $metadata = $null
    foreach ($entry in $archive.Entries) {
        $name = $entry.FullName
        if ($name.EndsWith('/')) {
            Assert-SafePath $name.TrimEnd('/')
            continue
        }
        Assert-SafePath $name
        if ((($entry.ExternalAttributes -shr 16) -band 0xF000) -eq 0xA000) { throw "Symbolic link forbidden in beta ZIP: $name" }
        if (-not $seen.Add($name)) { throw "Duplicate ZIP entry (including case collision): $name" }
        if (-not $byPath.ContainsKey($name)) { throw "Unexpected ZIP file: $name" }
        $record = $byPath[$name]
        if ($entry.Length -ne [long]$record.size) { throw "ZIP file size mismatch: $name" }
        $stream = $entry.Open()
        try {
            $sha = [System.Security.Cryptography.SHA256]::Create()
            try { $actualHash = [BitConverter]::ToString($sha.ComputeHash($stream)).Replace('-', '') }
            finally { $sha.Dispose() }
        } finally { $stream.Dispose() }
        if ($actualHash -ine [string]$record.sha256) { throw "ZIP file SHA256 mismatch: $name" }
        if ($name -eq 'build-metadata.json') {
            $stream = $entry.Open()
            try {
                $reader = New-Object System.IO.StreamReader($stream)
                try { $metadata = $reader.ReadToEnd() | ConvertFrom-Json }
                finally { $reader.Dispose() }
            } finally { $stream.Dispose() }
        }
        if ($name -eq 'CHEMIN_DB.sni') {
            $stream = $entry.Open()
            try {
                $reader = New-Object System.IO.StreamReader($stream)
                try { $hostSetting = $reader.ReadToEnd().Trim() }
                finally { $reader.Dispose() }
            } finally { $stream.Dispose() }
            if ($hostSetting -ne '127.0.0.1') { throw 'Beta package contains a nonlocal database host' }
        }
        if ($name -eq 'hash_licence.sni' -and $entry.Length -ne 0) {
            throw 'Non-empty license state found in beta ZIP'
        }
        if ($name -eq 'log_erreur.sni' -and $entry.Length -ne 0) {
            throw 'Previous runtime error log found in beta ZIP'
        }
        if ($name -eq 'CHEMIN_FOLDER.sni' -or $name -match '^PRINTER_(CL|C[1-7]|ADD|RAPPORT)\.sni$') {
            $stream = $entry.Open()
            try {
                $reader = New-Object System.IO.StreamReader($stream)
                try { $setting = $reader.ReadToEnd().Trim() }
                finally { $reader.Dispose() }
            } finally { $stream.Dispose() }
            if ($name -eq 'CHEMIN_FOLDER.sni' -and $setting -ne 'Application.StartupPath') {
                throw 'Non-portable folder path in beta ZIP'
            }
            if ($name -ne 'CHEMIN_FOLDER.sni' -and $setting -ne '0') {
                throw "Beta package inherited a printer configuration: $name"
            }
        }
    }
    if ($seen.Count -ne $byPath.Count) { throw "Missing ZIP files: expected $($byPath.Count), found $($seen.Count)" }
    foreach ($required in @('LOGICA.exe','LOGICA.exe.config','Launch-LOGICA.ps1','Start-LOGICA.cmd','RUNNING.md','build-metadata.json','CHEMIN_DB.sni','CHEMIN_FOLDER.sni','hash_licence.sni','log_erreur.sni','PRINTER_CL.sni','PRINTER_ADD.sni','PRINTER_RAPPORT.sni','PRINTER_C1.sni','PRINTER_C2.sni','PRINTER_C3.sni','PRINTER_C4.sni','PRINTER_C5.sni','PRINTER_C6.sni','PRINTER_C7.sni')) {
        if (-not $seen.Contains($required)) { throw "Missing required runtime file: $required" }
    }
    if (@($seen | Where-Object { $_ -like '*.dll' }).Count -lt 1) { throw 'Runtime DLLs missing' }
    if ($null -eq $metadata -or $metadata.target -ne 'net48' -or $metadata.architecture -ne 'x86' -or
        $metadata.originalShopDatabaseIncluded -ne $false -or
        [string]$metadata.sourceCommit -notmatch '^[a-fA-F0-9]{40}$') {
        throw 'Unexpected or incomplete build provenance'
    }
    if ($ExpectedCommit -and $metadata.sourceCommit -ine $ExpectedCommit) {
        throw 'Release provenance commit does not match expected commit'
    }
    Write-Host "PASS: offline beta RC1 verification: $($seen.Count) files; commit $($metadata.sourceCommit); ZIP SHA256 $zipHash"
} finally {
    $archive.Dispose()
}
 -or
            $segment -match '^(?i:CON|PRN|AUX|NUL|COM[1-9]|LPT[1-9])(?:\.|$)') {
            throw "Unsafe Windows archive or manifest path: $name"
        }
    }
}
$expected = @((Get-Content -LiteralPath $ManifestPath -Raw | ConvertFrom-Json))
if ($expected.Count -lt 5 -or $expected.Count -gt 10000) { throw 'Invalid release manifest entry count' }
$byPath = [System.Collections.Generic.Dictionary[string,object]]::new([System.StringComparer]::OrdinalIgnoreCase)
foreach ($item in $expected) {
    $name = [string]$item.path
    Assert-SafePath $name
    if ($byPath.ContainsKey($name)) { throw "Duplicate manifest path (including case collision): $name" }
    if ([string]$item.sha256 -notmatch '^[a-fA-F0-9]{64}$' -or [long]$item.size -lt 0) {
        throw "Invalid manifest hash or size: $name"
    }
    if ($name -match '(^|/)(mysql-credential\.xml|mysql-import-complete\.txt)$' -or $name -match '^bd/mysql-data(/|$)') {
        throw "Forbidden persisted test data in manifest: $name"
    }
    $byPath.Add($name, $item)
}
Add-Type -AssemblyName System.IO.Compression.FileSystem
$archive = [System.IO.Compression.ZipFile]::OpenRead($ZipPath)
try {
    $seen = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::OrdinalIgnoreCase)
    $metadata = $null
    foreach ($entry in $archive.Entries) {
        $name = $entry.FullName
        if ($name.EndsWith('/')) {
            Assert-SafePath $name.TrimEnd('/')
            continue
        }
        Assert-SafePath $name
        if (-not $seen.Add($name)) { throw "Duplicate ZIP entry (including case collision): $name" }
        if (-not $byPath.ContainsKey($name)) { throw "Unexpected ZIP file: $name" }
        $record = $byPath[$name]
        if ($entry.Length -ne [long]$record.size) { throw "ZIP file size mismatch: $name" }
        $stream = $entry.Open()
        try {
            $sha = [System.Security.Cryptography.SHA256]::Create()
            try { $actualHash = [BitConverter]::ToString($sha.ComputeHash($stream)).Replace('-', '') }
            finally { $sha.Dispose() }
        } finally { $stream.Dispose() }
        if ($actualHash -ine [string]$record.sha256) { throw "ZIP file SHA256 mismatch: $name" }
        if ($name -eq 'build-metadata.json') {
            $stream = $entry.Open()
            try {
                $reader = New-Object System.IO.StreamReader($stream)
                try { $metadata = $reader.ReadToEnd() | ConvertFrom-Json }
                finally { $reader.Dispose() }
            } finally { $stream.Dispose() }
        }
        if ($name -eq 'CHEMIN_DB.sni') {
            $stream = $entry.Open()
            try {
                $reader = New-Object System.IO.StreamReader($stream)
                try { $hostSetting = $reader.ReadToEnd().Trim() }
                finally { $reader.Dispose() }
            } finally { $stream.Dispose() }
            if ($hostSetting -ne '127.0.0.1') { throw 'Beta package contains a nonlocal database host' }
        }
        if ($name -eq 'hash_licence.sni' -and $entry.Length -ne 0) {
            throw 'Non-empty license state found in beta ZIP'
        }
    }
    if ($seen.Count -ne $byPath.Count) { throw "Missing ZIP files: expected $($byPath.Count), found $($seen.Count)" }
    foreach ($required in @('LOGICA.exe','Launch-LOGICA.ps1','Start-LOGICA.cmd','RUNNING.md','build-metadata.json','CHEMIN_DB.sni','hash_licence.sni')) {
        if (-not $seen.Contains($required)) { throw "Missing required runtime file: $required" }
    }
    if (@($seen | Where-Object { $_ -like '*.dll' }).Count -lt 1) { throw 'Runtime DLLs missing' }
    if ($null -eq $metadata -or $metadata.target -ne 'net48' -or $metadata.architecture -ne 'x86' -or
        $metadata.originalShopDatabaseIncluded -ne $false -or
        [string]$metadata.sourceCommit -notmatch '^[a-fA-F0-9]{40}$') {
        throw 'Unexpected or incomplete build provenance'
    }
    if ($ExpectedCommit -and $metadata.sourceCommit -ine $ExpectedCommit) {
        throw 'Release provenance commit does not match expected commit'
    }
    Write-Host "PASS: offline beta RC1 verification: $($seen.Count) files; commit $($metadata.sourceCommit); ZIP SHA256 $zipHash"
} finally {
    $archive.Dispose()
}
) {
            $stream = $entry.Open()
            try {
                $reader = New-Object System.IO.StreamReader($stream)
                try { $setting = $reader.ReadToEnd().Trim() }
                finally { $reader.Dispose() }
            } finally { $stream.Dispose() }
            if ($name -eq 'CHEMIN_FOLDER.sni' -and $setting -ne 'Application.StartupPath') {
                throw 'Non-portable folder path in beta ZIP'
            }
            if ($name -ne 'CHEMIN_FOLDER.sni' -and $setting -ne '0') {
                throw "Beta package inherited a printer configuration: $name"
            }
        }
    }
    if ($seen.Count -ne $byPath.Count) { throw "Missing ZIP files: expected $($byPath.Count), found $($seen.Count)" }
    foreach ($required in @('LOGICA.exe','Launch-LOGICA.ps1','Start-LOGICA.cmd','RUNNING.md','build-metadata.json','CHEMIN_DB.sni','hash_licence.sni')) {
        if (-not $seen.Contains($required)) { throw "Missing required runtime file: $required" }
    }
    if (@($seen | Where-Object { $_ -like '*.dll' }).Count -lt 1) { throw 'Runtime DLLs missing' }
    if ($null -eq $metadata -or $metadata.target -ne 'net48' -or $metadata.architecture -ne 'x86' -or
        $metadata.originalShopDatabaseIncluded -ne $false -or
        [string]$metadata.sourceCommit -notmatch '^[a-fA-F0-9]{40}$') {
        throw 'Unexpected or incomplete build provenance'
    }
    if ($ExpectedCommit -and $metadata.sourceCommit -ine $ExpectedCommit) {
        throw 'Release provenance commit does not match expected commit'
    }
    Write-Host "PASS: offline beta RC1 verification: $($seen.Count) files; commit $($metadata.sourceCommit); ZIP SHA256 $zipHash"
} finally {
    $archive.Dispose()
}
 -or
            $segment -match '^(?i:CON|PRN|AUX|NUL|COM[1-9]|LPT[1-9])(?:\.|$)') {
            throw "Unsafe Windows archive or manifest path: $name"
        }
    }
}
$expected = @((Get-Content -LiteralPath $ManifestPath -Raw | ConvertFrom-Json))
if ($expected.Count -lt 5 -or $expected.Count -gt 10000) { throw 'Invalid release manifest entry count' }
$byPath = [System.Collections.Generic.Dictionary[string,object]]::new([System.StringComparer]::OrdinalIgnoreCase)
foreach ($item in $expected) {
    $name = [string]$item.path
    Assert-SafePath $name
    if ($byPath.ContainsKey($name)) { throw "Duplicate manifest path (including case collision): $name" }
    if ([string]$item.sha256 -notmatch '^[a-fA-F0-9]{64}$' -or [long]$item.size -lt 0) {
        throw "Invalid manifest hash or size: $name"
    }
    if ($name -match '(^|/)(mysql-credential\.xml|mysql-import-complete\.txt)$' -or $name -match '^bd/mysql-data(/|$)') {
        throw "Forbidden persisted test data in manifest: $name"
    }
    $byPath.Add($name, $item)
}
Add-Type -AssemblyName System.IO.Compression.FileSystem
$archive = [System.IO.Compression.ZipFile]::OpenRead($ZipPath)
try {
    $seen = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::OrdinalIgnoreCase)
    $metadata = $null
    foreach ($entry in $archive.Entries) {
        $name = $entry.FullName
        if ($name.EndsWith('/')) {
            Assert-SafePath $name.TrimEnd('/')
            continue
        }
        Assert-SafePath $name
        if (-not $seen.Add($name)) { throw "Duplicate ZIP entry (including case collision): $name" }
        if (-not $byPath.ContainsKey($name)) { throw "Unexpected ZIP file: $name" }
        $record = $byPath[$name]
        if ($entry.Length -ne [long]$record.size) { throw "ZIP file size mismatch: $name" }
        $stream = $entry.Open()
        try {
            $sha = [System.Security.Cryptography.SHA256]::Create()
            try { $actualHash = [BitConverter]::ToString($sha.ComputeHash($stream)).Replace('-', '') }
            finally { $sha.Dispose() }
        } finally { $stream.Dispose() }
        if ($actualHash -ine [string]$record.sha256) { throw "ZIP file SHA256 mismatch: $name" }
        if ($name -eq 'build-metadata.json') {
            $stream = $entry.Open()
            try {
                $reader = New-Object System.IO.StreamReader($stream)
                try { $metadata = $reader.ReadToEnd() | ConvertFrom-Json }
                finally { $reader.Dispose() }
            } finally { $stream.Dispose() }
        }
        if ($name -eq 'CHEMIN_DB.sni') {
            $stream = $entry.Open()
            try {
                $reader = New-Object System.IO.StreamReader($stream)
                try { $hostSetting = $reader.ReadToEnd().Trim() }
                finally { $reader.Dispose() }
            } finally { $stream.Dispose() }
            if ($hostSetting -ne '127.0.0.1') { throw 'Beta package contains a nonlocal database host' }
        }
        if ($name -eq 'hash_licence.sni' -and $entry.Length -ne 0) {
            throw 'Non-empty license state found in beta ZIP'
        }
    }
    if ($seen.Count -ne $byPath.Count) { throw "Missing ZIP files: expected $($byPath.Count), found $($seen.Count)" }
    foreach ($required in @('LOGICA.exe','Launch-LOGICA.ps1','Start-LOGICA.cmd','RUNNING.md','build-metadata.json','CHEMIN_DB.sni','hash_licence.sni')) {
        if (-not $seen.Contains($required)) { throw "Missing required runtime file: $required" }
    }
    if (@($seen | Where-Object { $_ -like '*.dll' }).Count -lt 1) { throw 'Runtime DLLs missing' }
    if ($null -eq $metadata -or $metadata.target -ne 'net48' -or $metadata.architecture -ne 'x86' -or
        $metadata.originalShopDatabaseIncluded -ne $false -or
        [string]$metadata.sourceCommit -notmatch '^[a-fA-F0-9]{40}$') {
        throw 'Unexpected or incomplete build provenance'
    }
    if ($ExpectedCommit -and $metadata.sourceCommit -ine $ExpectedCommit) {
        throw 'Release provenance commit does not match expected commit'
    }
    Write-Host "PASS: offline beta RC1 verification: $($seen.Count) files; commit $($metadata.sourceCommit); ZIP SHA256 $zipHash"
} finally {
    $archive.Dispose()
}
