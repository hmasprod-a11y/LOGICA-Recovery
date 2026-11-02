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
 foreach($p in $original.PSObject.Properties){
  # Only the known visual/layout settings may extend the portable defaults.
  # Never copy arbitrary shop-specific files from the recovered startup fixture.
  if($defaults.ContainsKey($p.Name) -or $p.Name -in @('interfaces_a.sni','interfaces_f.sni','splitterdistance.sni')){
   $defaults[$p.Name]=[string]$p.Value
  }
 }
}
$defaults['CHEMIN_FOLDER.sni']='Application.StartupPath'
# Never distribute a developer/store connection host or license hash from startup fixtures.
# Real installations keep their own settings; this affects the candidate package only.
$defaults['CHEMIN_DB.sni']='127.0.0.1'
$defaults['hash_licence.sni']=''
$defaults['log_erreur.sni']=''
# RC1 must not inherit the original shop's printer names or enable devices.
# Real installations keep their own printer configuration; this changes only dist/.
foreach($key in @($defaults.Keys)){
 if($key -like 'PRINTER_*.sni'){$defaults[$key]='0'}
}
foreach($entry in $defaults.GetEnumerator()){[IO.File]::WriteAllText((Join-Path $dist $entry.Key),$entry.Value)}
Copy-Item docs/RUNNING.md dist/RUNNING.md -Force
Copy-Item scripts/Launch-LOGICA.ps1,scripts/Start-LOGICA.cmd dist -Force
# Ship the tested additive migration with the same Windows x86 build.
# Never apply schema changes automatically to an existing shop database.
$migrationSource = 'input/migrations/20261102-article-add-compatibility.sql'
if (-not (Test-Path -LiteralPath $migrationSource -PathType Leaf)) { throw 'Article schema migration missing from source checkout' }
Copy-Item -LiteralPath $migrationSource -Destination (Join-Path $dist '20261102-article-add-compatibility.sql') -Force
@'
ARTICLE SCHEMA COMPATIBILITY (MariaDB)
=====================================
This package contains an additive schema migration for older TABLE_ARTICLES tables.
It is NOT applied automatically: the shop database may contain irreplaceable data.

Before using the article editor with an old database:
1. Stop LOGICA and take a VERIFIED backup of the existing MariaDB shop database.
2. Confirm the database and TABLE_ARTICLES table are the correct shop database.
3. Have an authorized administrator apply 20261102-article-add-compatibility.sql
   to that database using a MariaDB client, then verify the six columns exist.
4. Start LOGICA and test creating and editing an article, including GROUPE.
Do not run the migration on an unknown or unbacked-up database.
The SQL is repeatable and adds missing columns only; it never drops rows.
'@ | Set-Content -LiteralPath (Join-Path $dist 'ARTICLE-SCHEMA-MIGRATION-README.txt') -Encoding UTF8

# Never package isolated QA executables/configs, even if the POS test script
# exited early before its own cleanup stage.
Remove-Item dist/PosSmoke*,dist/DesktopPaymentCultureSmoke*,dist/DesktopArticleDeleteSmoke*,dist/DesktopSolderGuardSmoke* -Force -ErrorAction SilentlyContinue
$manifest=@(Get-ChildItem dist -File | ForEach-Object {
 $hash=(Get-FileHash $_.FullName -Algorithm SHA256).Hash
 $version=$null
 if($_.Extension -in @('.dll','.exe')){try{$version=[Reflection.AssemblyName]::GetAssemblyName($_.FullName).Version.ToString()}catch{}}
 [pscustomobject]@{file=$_.Name;size=$_.Length;sha256=$hash;assemblyVersion=$version}
})
$manifest | ConvertTo-Json | Set-Content results/runtime-manifest.json
@{sourceCommit=(git rev-parse HEAD);workflowRun=$env:GITHUB_RUN_ID;target='net48';architecture='x86';originalShopDatabaseIncluded=$false} | ConvertTo-Json | Set-Content results/build-metadata.json
Copy-Item results/runtime-manifest.json,results/build-metadata.json dist -Force
