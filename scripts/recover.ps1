param(
  [Parameter(Mandatory=$true)][string]$Archive,
  [string]$Output = (Join-Path (Get-Location) 'extracted-private')
)
$ErrorActionPreference='Stop'
$Archive=(Resolve-Path -LiteralPath $Archive).Path
if (-not (Get-Command dotnet -ErrorAction SilentlyContinue)) {
  throw 'Install the official .NET SDK from https://dotnet.microsoft.com/download'
}
New-Item -ItemType Directory -Force -Path $Output | Out-Null
$copy=Join-Path $Output 'archive-copy'
New-Item -ItemType Directory -Force -Path $copy | Out-Null
Expand-Archive -LiteralPath $Archive -DestinationPath $copy -Force
$exe=Join-Path $copy 'Debug/LOGICA.exe'
if (-not (Test-Path -LiteralPath $exe)) { throw "Missing LOGICA.exe in $copy" }
$tools=Join-Path $Output 'tools'
New-Item -ItemType Directory -Force -Path $tools | Out-Null
$env:PATH="$tools;$env:PATH"
dotnet tool install --tool-path $tools ilspycmd
$ilspy=Join-Path $tools 'ilspycmd.exe'
$dest=Join-Path $Output 'source'
New-Item -ItemType Directory -Force -Path $dest | Out-Null
& $ilspy -p -o $dest $exe
Write-Host "Extracted project under $dest"
Write-Host 'Do not upload the extracted code to a public repository without a security review.'
