param(
 [string]$DistPath='dist',
 [string]$OutputPath='update-binaries'
)
$ErrorActionPreference='Stop'
# Deliberately separate from the full first-install package. Never include
# shop-specific .sni, database files, startup scripts, or .exe.config.
$source=(Resolve-Path -LiteralPath $DistPath).Path
$target=[IO.Path]::GetFullPath($OutputPath)
$sourcePrefix=$source.TrimEnd([IO.Path]::DirectorySeparatorChar)+[IO.Path]::DirectorySeparatorChar
if($target.Equals($source,[StringComparison]::OrdinalIgnoreCase) -or
   $target.StartsWith($sourcePrefix,[StringComparison]::OrdinalIgnoreCase)){
 throw 'Update output must not be inside the full runtime directory'
}
$exe=Join-Path $source 'LOGICA.exe'
if(-not (Test-Path -LiteralPath $exe -PathType Leaf)){throw 'Missing LOGICA.exe'}
$files=@(Get-ChildItem -LiteralPath $source -File | Where-Object {
 $_.Name -ieq 'LOGICA.exe' -or $_.Extension -ieq '.dll'
})
if(-not ($files | Where-Object {$_.Extension -ieq '.dll'})){throw 'Missing runtime DLLs'}
if(Test-Path -LiteralPath $target){
 if(@(Get-ChildItem -LiteralPath $target -Force).Count -gt 0){throw 'Update output must be empty'}
} else {New-Item -ItemType Directory -Path $target -Force | Out-Null}
foreach($file in $files){Copy-Item -LiteralPath $file.FullName -Destination $target}
@'
LOGICA BINARIES-ONLY UPDATE CANDIDATE — NOT AN AUTOMATIC INSTALLER

Contains only LOGICA.exe and DLLs, never shop .sni settings, license,
database (bd), or LOGICA.exe.config. It is NOT a complete fresh installation.
Do not extract the LOGICA-Windows-complete archive over an existing shop.
Before a controlled update, close LOGICA and take an independently verified
backup of the entire existing installation and its database. Test a COPY of
the shop installation first. Review LOGICA.exe.config compatibility separately.
Physical peripherals, production licensing, and live shop data are not
certified by CI. Do not deploy without human approval.
'@ | Set-Content -LiteralPath (Join-Path $target 'UPDATE-README.txt') -Encoding UTF8
Write-Host ('PASS binaries-only update candidate: '+$files.Count+' runtime files, no shop settings')
