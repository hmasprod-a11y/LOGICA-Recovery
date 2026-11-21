#Requires -Version 7.0
param(
    [Parameter(Mandatory=$true)][string]$FinancialZip,
    [Parameter(Mandatory=$true)][string]$AcceptanceFile,
    [Parameter(Mandatory=$true)][ValidatePattern('^[0-9a-f]{40}$')][string]$SourceSha,
    [Parameter(Mandatory=$true)][string]$OutputDirectory
)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
Add-Type -AssemblyName System.IO.Compression.FileSystem

function Assert-RegularFile([string]$Path) {
    if (-not (Test-Path -LiteralPath $Path -PathType Leaf) -or
        ((Get-Item -LiteralPath $Path).Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) {
        throw "Required delivery input is missing or linked: $Path"
    }
}
function Get-SafeRelativePath([string]$Name, [bool]$Directory) {
    if ([string]::IsNullOrWhiteSpace($Name) -or $Name.StartsWith('/') -or $Name.StartsWith('\') -or $Name.Contains(':')) {
        throw "Absolute or empty archive path refused: $Name"
    }
    $normalized = $Name.Replace('\','/')
    if ($Directory) { $normalized = $normalized.TrimEnd('/') }
    foreach ($part in $normalized.Split('/')) {
        if ($part -in @('', '.', '..') -or $part -match '[<>:"|?*\x00-\x1f]' -or
            $part.EndsWith('.') -or $part.EndsWith(' ') -or $part -match '^(CON|PRN|AUX|NUL|COM[1-9]|LPT[1-9])(\..*)?$') {
            throw "Unsafe Windows archive path refused: $Name"
        }
    }
    return $normalized
}
function Get-EntrySha256($Entry) {
    $stream = $Entry.Open()
    $hash = [Security.Cryptography.SHA256]::Create()
    try { return [Convert]::ToHexString($hash.ComputeHash($stream)).ToLowerInvariant() }
    finally { $hash.Dispose(); $stream.Dispose() }
}

$packagePath = [IO.Path]::GetFullPath($FinancialZip)
$proofPath = [IO.Path]::GetFullPath($AcceptanceFile)
Assert-RegularFile $packagePath
Assert-RegularFile $proofPath
$proof = Get-Content -LiteralPath $proofPath -Raw | ConvertFrom-Json
if ($proof.FinancialAcceptance -isnot [bool] -or -not $proof.FinancialAcceptance -or
    $proof.DoubleClickCashierWindow -isnot [bool] -or -not $proof.DoubleClickCashierWindow -or
    $proof.SourceSha -cne $SourceSha -or $proof.SourceSha -cnotmatch '^[0-9a-f]{40}$' -or
    $proof.FinalPackageSha256 -notmatch '^[0-9a-fA-F]{64}$' -or $proof.ExtractedExeSha256 -notmatch '^[0-9a-fA-F]{64}$') {
    throw 'Financial payload acceptance is absent, malformed, or belongs to a different exact source SHA.'
}
$packageHash = (Get-FileHash -LiteralPath $packagePath -Algorithm SHA256).Hash.ToLowerInvariant()
if ($packageHash -cne ([string]$proof.FinalPackageSha256).ToLowerInvariant()) { throw 'Accepted financial ZIP SHA256 mismatch.' }

# Inspect/hash the accepted payload in place. Do not execute it, extract a
# database, run an acceptance command, or alter its accepted bytes/manifest.
$zip = [IO.Compression.ZipFile]::OpenRead($packagePath)
try {
    $entries = [Collections.Generic.Dictionary[string,object]]::new([StringComparer]::OrdinalIgnoreCase)
    $allNames = [Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
    [long]$uncompressed = 0
    foreach ($entry in $zip.Entries) {
        $directory = $entry.Name.Length -eq 0
        $name = Get-SafeRelativePath $entry.FullName $directory
        if (-not $allNames.Add($name)) { throw "Duplicate/case-alias payload path: $name" }
        $unixType = ($entry.ExternalAttributes -shr 16) -band 0xF000
        if ($unixType -eq 0xA000 -or ($entry.ExternalAttributes -band [int][IO.FileAttributes]::ReparsePoint) -ne 0) {
            throw "Linked payload path refused: $name"
        }
        if ($directory) { continue }
        if ($entry.Length -gt 1GB) { throw "Unexpectedly large payload file: $name" }
        $uncompressed += $entry.Length
        if ($uncompressed -gt 4GB) { throw 'Unexpectedly large accepted payload.' }
        $leaf = [IO.Path]::GetFileName($name)
        if ($leaf -match '^(Start-Hanouty-Test|setup-test-db|mariadbd|mariadb-install-db)(\.|$)' -or
            [IO.Path]::GetExtension($leaf) -in @('.ps1','.cmd','.bat','.sh','.sql','.snidb','.ibd','.myd','.myi','.sqlite','.sqlite3') -or
            $leaf -in @('ibdata1','my.ini')) {
            throw "Test command/database payload is not a customer delivery: $name"
        }
        $entries.Add($name, $entry)
    }
    foreach ($name in $allNames) {
        $parts = $name.Split('/')
        for ($i=1; $i -lt $parts.Length; $i++) {
            if ($entries.ContainsKey(($parts[0..($i-1)] -join '/'))) { throw "Payload file/directory collision: $name" }
        }
    }
    if (-not $entries.ContainsKey('HANOUTY-MANIFEST.json') -or $entries['HANOUTY-MANIFEST.json'].Length -gt 4MB) {
        throw 'Accepted financial manifest missing or oversized.'
    }
    $reader = [IO.StreamReader]::new($entries['HANOUTY-MANIFEST.json'].Open(), [Text.Encoding]::UTF8, $true)
    try { $manifest = $reader.ReadToEnd() | ConvertFrom-Json } finally { $reader.Dispose() }
    if ($manifest.mode -cne 'financial' -or $manifest.financialAcceptance -isnot [bool] -or -not $manifest.financialAcceptance -or
        $manifest.acceptanceSha -cne $SourceSha -or $manifest.runtime -cne 'win-x64' -or $manifest.framework -cne 'net10.0-windows') {
        throw 'Manifest is not the same-SHA accepted Windows financial application.'
    }
    $listed = [Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
    foreach ($file in @($manifest.files)) {
        $name = Get-SafeRelativePath ([string]$file.file) $false
        if ($name -ieq 'HANOUTY-MANIFEST.json' -or -not $listed.Add($name) -or -not $entries.ContainsKey($name) -or
            $file.sha256 -notmatch '^[0-9a-fA-F]{64}$' -or (Get-EntrySha256 $entries[$name]) -cne ([string]$file.sha256).ToLowerInvariant()) {
            throw "Accepted payload file missing, duplicated or modified: $name"
        }
    }
    foreach ($required in @('Hanouty.Desktop.Bootstrap.exe','Hanouty.Desktop.Bootstrap.dll','Hanouty.Desktop.Bootstrap.runtimeconfig.json','Hanouty.Desktop.Bootstrap.deps.json')) {
        if (-not $listed.Contains($required)) { throw "Required accepted executable/runtime file is not manifested: $required" }
    }
    foreach ($name in $entries.Keys) {
        if ($name -ine 'HANOUTY-MANIFEST.json' -and -not $listed.Contains($name) -and [IO.Path]::GetExtension($name) -notin @('.pdb','.mdb')) {
            throw "Unmanifested runtime payload refused: $name"
        }
    }
    if ((Get-EntrySha256 $entries['Hanouty.Desktop.Bootstrap.exe']) -cne ([string]$proof.ExtractedExeSha256).ToLowerInvariant()) {
        throw 'Accepted cashier executable SHA256 mismatch.'
    }
} finally { $zip.Dispose() }

$installerPs = Join-Path $PSScriptRoot 'Install-Hanouty.ps1'
$installerCmd = Join-Path $PSScriptRoot 'Install-Hanouty.cmd'
$notice = Join-Path $PSScriptRoot 'HANOUTY-CUSTOMER-START-HERE.txt'
foreach ($file in @($installerPs,$installerCmd,$notice)) { Assert-RegularFile $file }
$destination = [IO.Path]::GetFullPath($OutputDirectory).TrimEnd([char[]]@('/','\'))
$deliveryZip = $destination + '.zip'
if ((Test-Path -LiteralPath $destination) -or (Test-Path -LiteralPath $deliveryZip)) { throw 'Choose a new customer delivery output; existing files are never overwritten.' }
$parent = [IO.Path]::GetDirectoryName($destination)
if ([string]::IsNullOrWhiteSpace($parent)) { throw 'A customer delivery folder name is required.' }
New-Item -ItemType Directory -Path $parent -Force | Out-Null
for ($ancestor = Get-Item -LiteralPath $parent; $null -ne $ancestor; $ancestor = $ancestor.Parent) {
    if (($ancestor.Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) { throw 'Linked delivery output directory refused.' }
}
$stage = $destination + '.building-' + [Guid]::NewGuid().ToString('N')
$zipStage = $stage + '.zip'
New-Item -ItemType Directory -Path $stage | Out-Null
Copy-Item -LiteralPath $installerPs -Destination (Join-Path $stage 'Install-Hanouty.ps1')
Copy-Item -LiteralPath $installerCmd -Destination (Join-Path $stage 'Install-Hanouty.cmd')
Copy-Item -LiteralPath $packagePath -Destination (Join-Path $stage 'HANOUTY-WPF-net10-FINANCIAL-ACCEPTED-win-x64.zip')
Copy-Item -LiteralPath $proofPath -Destination (Join-Path $stage 'financial-package-acceptance.json')
Copy-Item -LiteralPath $notice -Destination (Join-Path $stage 'LIRE-MOI-INSTALLATION.txt')
if ((Get-FileHash -LiteralPath (Join-Path $stage 'HANOUTY-WPF-net10-FINANCIAL-ACCEPTED-win-x64.zip') -Algorithm SHA256).Hash -ine $packageHash) { throw 'Copied financial payload changed.' }
if (@(Get-ChildItem -LiteralPath $stage -Force).Count -ne 5) { throw 'Customer delivery must contain exactly the five intended files.' }
Compress-Archive -LiteralPath @(Get-ChildItem -LiteralPath $stage -File | ForEach-Object FullName) -DestinationPath $zipStage -CompressionLevel Optimal
[IO.Directory]::Move($stage, $destination)
[IO.File]::Move($zipStage, $deliveryZip)
[pscustomobject]@{ Directory=$destination; Zip=$deliveryZip; SourceSha=$SourceSha; FinancialPackageSha256=$packageHash; RuntimeManifestFiles=$listed.Count; CustomerFiles=5 }
