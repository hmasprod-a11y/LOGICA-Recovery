param([Parameter(Mandatory=$true)][string]$PackageDirectory, [Parameter(Mandatory=$true)][string]$EvidenceDirectory)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
$root = Join-Path ([IO.Path]::GetFullPath($EvidenceDirectory)) ('install-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $root -Force | Out-Null
$package = Join-Path $PackageDirectory 'HANOUTY-WPF-net10-FINANCIAL-ACCEPTED-win-x64.zip'
$proofPath = Join-Path $PackageDirectory 'financial-package-acceptance.json'
$installed = Join-Path $root 'application'
$installer = Join-Path $PSScriptRoot 'Install-Hanouty.ps1'
foreach ($pass in 1..2) {
    & powershell.exe -NoProfile -ExecutionPolicy Bypass -File $installer -PackageZip $package -AcceptanceFile $proofPath -InstallationDirectory $installed -NoShortcuts
    if ($LASTEXITCODE -ne 0) { throw "Real Windows installer failed on pass $pass." }
    $current = Get-Content -LiteralPath (Join-Path $installed 'current.json') -Raw | ConvertFrom-Json
    if (-not (Test-Path -LiteralPath (Join-Path $current.Version 'Hanouty.Desktop.Bootstrap.exe'))) { throw 'Installed application executable missing.' }
    if ($pass -eq 1) { $first = $current.Version }
}
if ($current.PreviousVersion -cne $first -or -not (Test-Path -LiteralPath $first)) { throw 'Update did not preserve the previous installed application.' }
$pointer = Get-Content -LiteralPath (Join-Path $installed 'current.json') -Raw
$bad = Get-Content -LiteralPath $proofPath -Raw | ConvertFrom-Json
$bad.FinalPackageSha256 = '0' * 64
$badPath = Join-Path $root 'tampered-acceptance.json'
$bad | ConvertTo-Json | Set-Content -LiteralPath $badPath -Encoding UTF8
& powershell.exe -NoProfile -ExecutionPolicy Bypass -File $installer -PackageZip $package -AcceptanceFile $badPath -InstallationDirectory $installed -NoShortcuts *> (Join-Path $root 'rejected-package.txt')
if ($LASTEXITCODE -eq 0 -or (Get-Content -LiteralPath (Join-Path $installed 'current.json') -Raw) -cne $pointer) { throw 'Unaccepted package replaced the installed version.' }
[ordered]@{WindowsInstaller=$true;AcceptedPayloadInstalled=$true;PreviousVersionPreserved=$true;TamperedPackageRefused=$true;NoDatabaseCommands=$true} |
    ConvertTo-Json | Set-Content -LiteralPath (Join-Path $EvidenceDirectory 'installation.json') -Encoding UTF8
Write-Host 'PASS Windows installation, version preservation and rejected-package isolation.'
$global:LASTEXITCODE = 0
