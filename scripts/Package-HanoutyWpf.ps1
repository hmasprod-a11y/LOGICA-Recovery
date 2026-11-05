param(
    [Parameter(Mandatory=$true)][string]$OutputDirectory,
    [ValidateSet('win-x64','win-x86')][string]$Runtime = 'win-x64'
)
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
$root = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$project = Join-Path $root 'modernization/Hanouty.Desktop.Bootstrap/Hanouty.Desktop.Bootstrap.csproj'
$dest = [IO.Path]::GetFullPath($OutputDirectory)
$publish = Join-Path $dest 'publish'
$extract = Join-Path $dest 'extracted-verification'
$zip = Join-Path $dest "HANOUTY-WPF-net10-CATALOGUE-ONLY-$Runtime.zip"
if (-not (Test-Path -LiteralPath $project)) { throw "WPF bootstrap project is missing." }
New-Item -ItemType Directory -Path $dest -Force | Out-Null
foreach ($dir in @($publish,$extract)) {
    if (Test-Path -LiteralPath $dir) { Remove-Item -LiteralPath $dir -Recurse -Force }
    New-Item -ItemType Directory -Path $dir | Out-Null
}
& dotnet publish $project -c Release -r $Runtime --self-contained true -p:PublishSingleFile=false -o $publish
if ($LASTEXITCODE -ne 0) { throw "HANOUTY WPF .NET 10 publish failed." }
$exe = Join-Path $publish 'Hanouty.Desktop.Bootstrap.exe'
if (-not (Test-Path -LiteralPath $exe)) { throw "Actual WPF bootstrap EXE is missing." }
if (Test-Path -LiteralPath (Join-Path $publish 'LOGICA.exe')) { throw "Legacy WinForms executable is forbidden." }
$wpfAssembly = Join-Path $publish 'Hanouty.Desktop.Wpf.dll'
if (-not (Test-Path -LiteralPath $wpfAssembly)) { throw "HANOUTY WPF assembly is missing." }
if (-not (Test-Path -LiteralPath (Join-Path $publish 'Hanouty.ArchitectureBridge.dll'))) {
    throw "Shared Architecture bridge is missing."
}
$readme = @'
HANOUTY POS — .NET 10 WPF catalogue-only engineering candidate
This archive contains the independent WPF bootstrap, not LOGICA WinForms.
It is NOT Beta 1 and it is NOT authorized for retail financial transactions.
Run only on a disposable local MariaDB with a test catalogue, following
modernization/Hanouty.Desktop.Bootstrap/README.md.
This build requires --catalogue-only. Financial posting deliberately fails closed.
No real shop databases, credentials or license state are included.
'@
Set-Content -LiteralPath (Join-Path $publish 'HANOUTY-CANDIDATE-STATUS.txt') -Value $readme -Encoding UTF8
$files = @(Get-ChildItem -LiteralPath $publish -Recurse -File | Where-Object {
    $_.Extension -notin @('.pdb','.mdb')
})
foreach ($f in $files) {
    if ($f.Name -match '(?i)(password|credential|secret|\.env)' -or $f.Name -eq 'LOGICA.exe') {
        throw "Unsafe file detected in WPF package: $($f.Name)"
    }
}
$hashes = @($files | Sort-Object FullName | ForEach-Object {
    [pscustomobject]@{
        file = [IO.Path]::GetRelativePath($publish, $_.FullName).Replace('\\','/')
        sha256 = (Get-FileHash -LiteralPath $_.FullName -Algorithm SHA256).Hash.ToLowerInvariant()
    }
})
$manifest = [ordered]@{
    application = 'HANOUTY POS WPF'
    runtime = $Runtime
    framework = 'net10.0-windows'
    financialAcceptance = $false
    candidate = 'catalogue-only'
    files = $hashes
}
$manifest | ConvertTo-Json -Depth 6 | Set-Content -LiteralPath (Join-Path $publish 'HANOUTY-MANIFEST.json') -Encoding UTF8
if (Test-Path -LiteralPath $zip) { Remove-Item -LiteralPath $zip -Force }
Compress-Archive -Path (Join-Path $publish '*') -DestinationPath $zip
Expand-Archive -LiteralPath $zip -DestinationPath $extract
foreach ($required in @('Hanouty.Desktop.Bootstrap.exe','Hanouty.Desktop.Wpf.dll','Hanouty.ArchitectureBridge.dll','HANOUTY-MANIFEST.json')) {
    if (-not (Test-Path -LiteralPath (Join-Path $extract $required))) {
        throw "Extracted package missing $required"
    }
}
$checked = Get-Content -LiteralPath (Join-Path $extract 'HANOUTY-MANIFEST.json') -Raw | ConvertFrom-Json
foreach ($entry in $checked.files) {
    $file = Join-Path $extract ([string]$entry.file)
    if (-not (Test-Path -LiteralPath $file) -or
        (Get-FileHash -LiteralPath $file -Algorithm SHA256).Hash.ToLowerInvariant() -ne $entry.sha256) {
        throw "Extracted package hash mismatch: $($entry.file)"
    }
}
Write-Host "VERIFIED extracted HANOUTY WPF package: $zip"
Write-Host "FINANCIAL ACCEPTANCE: FALSE — real cashier/MariaDB E2E still required."
