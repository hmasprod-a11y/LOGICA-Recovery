$ErrorActionPreference='Stop'
$dist=(Resolve-Path dist).Path
# Keep startup settings portable. Existing installations should retain their own settings.
$defaults=@{
 'CHEMIN_DB.sni'='127.0.0.1';'CHEMIN_FOLDER.sni'='Application.StartupPath';'poste.sni'='01';'mode_windows.sni'='False';'log_erreur.sni'='';'raccourcies.sni'='';'hash_licence.sni'='';
 'splitterdistance_v.sni'='400';'acces_rfid.sni'='False';'afficher_ecran_pub.sni'='False';'choix_client.sni'='False';'choix_vendeur.sni'='False';'gestion_credit.sni'='False'
}
foreach($n in @('CL','C1','C2','C3','C4','C5','C6','C7','ADD','RAPPORT')){$defaults["PRINTER_$n.sni"]='0'}
if(Test-Path input/original-startup.json){
 $original=Get-Content input/original-startup.json -Raw | ConvertFrom-Json
 foreach($p in $original.PSObject.Properties){$defaults[$p.Name]=[string]$p.Value}
}
$defaults['CHEMIN_FOLDER.sni']='Application.StartupPath'
$defaults['log_erreur.sni']=''
foreach($entry in $defaults.GetEnumerator()){[IO.File]::WriteAllText((Join-Path $dist $entry.Key),$entry.Value)}
Copy-Item docs/RUNNING.md dist/RUNNING.md -Force
Copy-Item scripts/Launch-LOGICA.ps1,scripts/Start-LOGICA.cmd dist -Force
Remove-Item dist/PosSmoke* -Force -ErrorAction SilentlyContinue
$manifest=@(Get-ChildItem dist -File | ForEach-Object {
 $hash=(Get-FileHash $_.FullName -Algorithm SHA256).Hash
 $version=$null
 if($_.Extension -in @('.dll','.exe')){try{$version=[Reflection.AssemblyName]::GetAssemblyName($_.FullName).Version.ToString()}catch{}}
 [pscustomobject]@{file=$_.Name;size=$_.Length;sha256=$hash;assemblyVersion=$version}
})
$manifest | ConvertTo-Json | Set-Content results/runtime-manifest.json
@{sourceCommit=(git rev-parse HEAD);workflowRun=$env:GITHUB_RUN_ID;target='net48';architecture='x86';originalShopDatabaseIncluded=$false} | ConvertTo-Json | Set-Content results/build-metadata.json
Copy-Item results/runtime-manifest.json,results/build-metadata.json dist -Force
