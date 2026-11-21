param(
    [Parameter(Mandatory=$true)][string]$OutputDirectory,
    [ValidateSet('win-x64','win-x86')][string]$Runtime = 'win-x64',
    [ValidateSet('catalogue-only','financial')][string]$Mode = 'catalogue-only'
)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
$root = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$project = Join-Path $root 'modernization/Hanouty.Desktop.Bootstrap/Hanouty.Desktop.Bootstrap.csproj'
$architecture = Join-Path $root 'modernization/architecture/Hanouty.ArchitectureBridge/Hanouty.ArchitectureBridge.csproj'
$checkout = Join-Path $root 'modernization/checkout-mariadb-production/CheckoutMariaDbProduction.csproj'
$dest = [IO.Path]::GetFullPath($OutputDirectory)
$publish = Join-Path $dest 'publish'
$extract = Join-Path $dest 'extracted-verification'
$zip = Join-Path $dest ("HANOUTY-WPF-net10-" + $Mode.ToUpperInvariant() + "-$Runtime.zip")
if (-not (Test-Path $project) -or -not (Test-Path $architecture)) { throw 'WPF or Architecture project missing.' }
if ($Mode -eq 'financial' -and -not (Test-Path $checkout)) { throw 'Financial mode requires production Checkout.' }
New-Item -ItemType Directory -Path $dest -Force | Out-Null
foreach ($dir in @($publish,$extract)) {
    if (Test-Path $dir) { Remove-Item $dir -Recurse -Force }
    New-Item -ItemType Directory -Path $dir | Out-Null
}
$args = @('publish',$project,'-c','Release','-r',$Runtime,'--self-contained','true',
    '-p:PublishSingleFile=false','-p:HanoutyWpfAsLibrary=true',
    "-p:ArchitectureProject=$architecture",'-o',$publish)
if ($Mode -eq 'financial') { $args += "-p:CheckoutProductionProject=$checkout" }
& dotnet @args
if ($LASTEXITCODE -ne 0) { throw "WPF $Mode publish failed." }
foreach ($name in @('Hanouty.Desktop.Bootstrap.exe','Hanouty.Desktop.Wpf.dll','Hanouty.ArchitectureBridge.dll')) {
    if (-not (Test-Path (Join-Path $publish $name))) { throw "Published package missing $name." }
}
if (Test-Path (Join-Path $publish 'LOGICA.exe')) { throw 'Legacy WinForms executable is forbidden.' }
$status = if ($Mode -eq 'financial') {
    'Financial engineering candidate; cashier login required; extracted W2 acceptance pending; not a commercial release.'
} else {
    'Catalogue-only read-only diagnostic candidate; not W2 acceptance or a commercial release.'
}
Set-Content (Join-Path $publish 'HANOUTY-CANDIDATE-STATUS.txt') $status -Encoding UTF8
$files = @(Get-ChildItem $publish -Recurse -File | Where-Object { $_.Extension -notin @('.pdb','.mdb') })
foreach ($f in $files) {
    if ($f.Name -match '(?i)(password|credential|secret|\.env)' -or $f.Name -eq 'LOGICA.exe') {
        throw "Unsafe file in package: $($f.Name)"
    }
}
$hashes = @($files | Sort-Object FullName | ForEach-Object {
    [pscustomobject]@{ file=[IO.Path]::GetRelativePath($publish,$_.FullName).Replace('\','/'); sha256=(Get-FileHash $_.FullName -Algorithm SHA256).Hash.ToLowerInvariant() }
})
$manifest = [ordered]@{ application='HANOUTY POS WPF'; runtime=$Runtime; framework='net10.0-windows'; mode=$Mode; financialAcceptance=$false; candidate=$(if($Mode -eq 'financial'){'financial-pending-extracted-acceptance'}else{'catalogue-only'}); files=$hashes }
$manifest | ConvertTo-Json -Depth 6 | Set-Content (Join-Path $publish 'HANOUTY-MANIFEST.json') -Encoding UTF8
Compress-Archive (Join-Path $publish '*') $zip
Expand-Archive $zip $extract
$check = Get-Content (Join-Path $extract 'HANOUTY-MANIFEST.json') -Raw | ConvertFrom-Json
foreach ($entry in $check.files) {
    $file=Join-Path $extract ([string]$entry.file)
    if (-not (Test-Path $file) -or (Get-FileHash $file -Algorithm SHA256).Hash.ToLowerInvariant() -cne $entry.sha256) { throw "Extracted package hash mismatch: $($entry.file)" }
}
Write-Host "VERIFIED extracted WPF package: $zip"
