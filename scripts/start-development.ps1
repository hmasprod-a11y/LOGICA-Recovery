$ErrorActionPreference='Stop'
$repo=Split-Path $PSScriptRoot -Parent
Push-Location $repo
try {
 if(-not (Get-Command dotnet -ErrorAction SilentlyContinue)){throw 'A .NET SDK is required to build the source project.'}
 if(-not (Test-Path dependencies)){Expand-Archive input/LOGICA-dependencies.zip dependencies}
 $runtime=Join-Path $repo '.development/runtime'
 New-Item -ItemType Directory -Force $runtime,"$runtime/bd","$runtime/tchak","$runtime/recovery" | Out-Null
 dotnet build recovered-source/LOGICA.csproj -c Debug --nologo -o $runtime
 if($LASTEXITCODE -ne 0){throw 'Development build failed'}
 $settings=Get-Content input/original-startup.json -Raw | ConvertFrom-Json
 foreach($p in $settings.PSObject.Properties){$target=Join-Path $runtime $p.Name;if(-not (Test-Path $target)){[IO.File]::WriteAllText($target,[string]$p.Value)}}
 foreach($n in @('log_erreur.sni','raccourcies.sni')){if(-not (Test-Path "$runtime/$n")){[IO.File]::WriteAllText("$runtime/$n",'')}}
 Copy-Item input/recovered-original.sql,input/mysql-compatibility.sql,input/database-inventory.json "$runtime/recovery" -Force
 Copy-Item scripts/Launch-LOGICA.ps1,scripts/Start-LOGICA.cmd $runtime -Force
 & "$runtime/Launch-LOGICA.ps1"
} finally {Pop-Location}
