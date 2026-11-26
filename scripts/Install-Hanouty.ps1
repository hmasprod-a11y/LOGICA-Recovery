param(
    [string]$PackageZip = (Join-Path $PSScriptRoot 'HANOUTY-WPF-net10-FINANCIAL-ACCEPTED-win-x64.zip'),
    [string]$AcceptanceFile = (Join-Path $PSScriptRoot 'financial-package-acceptance.json'),
    [string]$InstallationDirectory = (Join-Path $env:LOCALAPPDATA 'Programs/HANOUTY'),
    [switch]$NoShortcuts
)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
Add-Type -AssemblyName System.IO.Compression.FileSystem
# Per-user installation of an accepted financial payload. Never start, create,
# migrate or replace a shop database; configuration remains outside versions.
$proof = Get-Content -LiteralPath $AcceptanceFile -Raw | ConvertFrom-Json
if ($proof.FinancialAcceptance -ne $true -or $proof.DoubleClickCashierWindow -ne $true -or
    $proof.SourceSha -notmatch '^[0-9a-f]{40}$' -or
    (Get-FileHash -LiteralPath $PackageZip -Algorithm SHA256).Hash -ine $proof.FinalPackageSha256) {
    throw 'La version choisie ne correspond pas à son contrôle d''intégrité.'
}
$install = [IO.Path]::GetFullPath($InstallationDirectory)
New-Item -ItemType Directory -Path $install -Force | Out-Null
if (((Get-Item -LiteralPath $install).Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) { throw 'Dossier d''installation lié interdit.' }
$versions = Join-Path $install 'versions'
New-Item -ItemType Directory -Path $versions -Force | Out-Null
if (((Get-Item -LiteralPath $versions).Attributes -band [IO.FileAttributes]::ReparsePoint) -ne 0) { throw 'Dossier de versions lié interdit.' }
$stage = Join-Path $versions ('stage-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $stage | Out-Null
$prefix = $stage.TrimEnd([char[]]@('/','\')) + [IO.Path]::DirectorySeparatorChar
$zip = [IO.Compression.ZipFile]::OpenRead([IO.Path]::GetFullPath($PackageZip))
try {
    $names = [Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
    foreach ($entry in $zip.Entries) {
        $relative = $entry.FullName.Replace('/', [IO.Path]::DirectorySeparatorChar)
        if ($relative.Contains(':') -or [IO.Path]::IsPathRooted($relative)) { throw 'Chemin absolu interdit dans la version.' }
        $resolved = [IO.Path]::GetFullPath((Join-Path $stage $relative))
        if (-not $resolved.StartsWith($prefix, [StringComparison]::OrdinalIgnoreCase) -or -not $names.Add($resolved)) { throw 'Chemin de version invalide ou dupliqué.' }
        if ($entry.Name.Length -eq 0) { New-Item -ItemType Directory -Path $resolved -Force | Out-Null; continue }
        # Debug symbols are deliberately outside the accepted runtime manifest.
        if ([IO.Path]::GetExtension($resolved) -in @('.pdb', '.mdb')) { continue }
        New-Item -ItemType Directory -Path ([IO.Path]::GetDirectoryName($resolved)) -Force | Out-Null
        [IO.Compression.ZipFileExtensions]::ExtractToFile($entry, $resolved, $false)
    }
} finally { $zip.Dispose() }
$manifest = Get-Content -LiteralPath (Join-Path $stage 'HANOUTY-MANIFEST.json') -Raw | ConvertFrom-Json
if ($manifest.mode -cne 'financial' -or $manifest.financialAcceptance -ne $true -or $manifest.acceptanceSha -cne $proof.SourceSha) { throw 'Version de caisse non validée.' }
$listed = [Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
foreach ($file in $manifest.files) {
    $path = [IO.Path]::GetFullPath((Join-Path $stage ([string]$file.file)))
    if (-not $path.StartsWith($prefix, [StringComparison]::OrdinalIgnoreCase) -or -not $listed.Add($path) -or
        -not (Test-Path -LiteralPath $path -PathType Leaf) -or (Get-FileHash -LiteralPath $path -Algorithm SHA256).Hash -ine $file.sha256) { throw 'Fichier de caisse absent ou modifié.' }
}
foreach ($file in Get-ChildItem -LiteralPath $stage -File -Recurse) {
    if ($file.Name -cne 'HANOUTY-MANIFEST.json' -and -not $listed.Contains($file.FullName)) { throw 'Fichier supplémentaire non validé.' }
}
$exe = Join-Path $stage 'Hanouty.Desktop.Bootstrap.exe'
if ((Get-FileHash -LiteralPath $exe -Algorithm SHA256).Hash -ine $proof.ExtractedExeSha256) { throw 'Exécutable de caisse non conforme.' }
# Never overwrite an installed version or its previous pointer. A failed copy
# cannot damage the currently running application.
$version = Join-Path $versions ($proof.SourceSha + '-' + [Guid]::NewGuid().ToString('N'))
if (-not ([IO.Path]::GetFullPath($version)).StartsWith(([IO.Path]::GetFullPath($versions) + [IO.Path]::DirectorySeparatorChar), [StringComparison]::OrdinalIgnoreCase)) { throw 'Destination de version invalide.' }
Move-Item -LiteralPath $stage -Destination $version
$currentPath = Join-Path $install 'current.json'
$previous = if (Test-Path -LiteralPath $currentPath) { Get-Content -LiteralPath $currentPath -Raw | ConvertFrom-Json } else { $null }
$record = [ordered]@{ Version = $version; SourceSha = $proof.SourceSha; PreviousVersion = $(if ($null -ne $previous) { $previous.Version } else { $null }) }
$pending = Join-Path $install ('current-' + [Guid]::NewGuid().ToString('N') + '.tmp')
$record | ConvertTo-Json | Set-Content -LiteralPath $pending -Encoding UTF8
if (Test-Path -LiteralPath $currentPath) { [IO.File]::Replace($pending, $currentPath, (Join-Path $install 'current.previous.json')) }
else { [IO.File]::Move($pending, $currentPath) }
if (-not $NoShortcuts) {
    $shell = New-Object -ComObject WScript.Shell
    $menu = Join-Path ([Environment]::GetFolderPath('Programs')) 'HANOUTY'
    New-Item -ItemType Directory -Path $menu -Force | Out-Null
    foreach ($link in @((Join-Path ([Environment]::GetFolderPath('Desktop')) 'HANOUTY.lnk'), (Join-Path $menu 'HANOUTY.lnk'), (Join-Path $menu 'Paramètres du poste.lnk'))) {
        $shortcut = $shell.CreateShortcut($link)
        $shortcut.TargetPath = Join-Path $version 'Hanouty.Desktop.Bootstrap.exe'
        $shortcut.WorkingDirectory = $version
        $shortcut.IconLocation = $shortcut.TargetPath
        if ([IO.Path]::GetFileName($link) -eq 'Paramètres du poste.lnk') { $shortcut.Arguments = '--configure-workstation' }
        $shortcut.Save()
    }
}
Write-Host 'HANOUTY est installé. Ouvrez le raccourci HANOUTY pour configurer et utiliser cette caisse.'
