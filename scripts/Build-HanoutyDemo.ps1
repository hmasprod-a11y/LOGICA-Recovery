param([Parameter(Mandatory=$true)][string]$AcceptedPackageDirectory,[Parameter(Mandatory=$true)][string]$MariaDbArchive,[Parameter(Mandatory=$true)][string]$MariaDbChecksums,[Parameter(Mandatory=$true)][string]$OutputDirectory)
$ErrorActionPreference='Stop'
Set-StrictMode -Version Latest
$repo=Split-Path $PSScriptRoot
$out=[IO.Path]::GetFullPath($OutputDirectory)
if((Test-Path -LiteralPath $out) -or (Test-Path -LiteralPath ($out+'.zip'))){throw 'Choose a new demo output directory.'}
$runtimeHash=(Get-FileHash -LiteralPath $MariaDbArchive).Hash
$lines=Get-Content -LiteralPath $MariaDbChecksums
$match=@($lines | Where-Object {$_ -match '^([0-9a-fA-F]{64})\s+\*?(?:\./)?mariadb-10\.11\.14-winx64\.zip\s*$'})
if($match.Count -ne 1 -or $match[0].Substring(0,64) -ine $runtimeHash){throw 'Official portable MariaDB archive hash mismatch.'}
$proof=Get-Content -LiteralPath (Join-Path $AcceptedPackageDirectory 'financial-package-acceptance.json') -Raw | ConvertFrom-Json
$payload=Join-Path $AcceptedPackageDirectory 'HANOUTY-WPF-net10-FINANCIAL-ACCEPTED-win-x64.zip'
if($proof.FinancialAcceptance -ne $true -or (Get-FileHash -LiteralPath $payload).Hash -ine $proof.FinalPackageSha256){throw 'Accepted financial payload required.'}
$original=[IO.File]::ReadAllText((Join-Path $repo 'input/recovered-original.sql'))
$tables=[regex]::Matches($original,'CREATE TABLE\s+`[^`]+`\s*\([\s\S]*?;', 'IgnoreCase')
if($tables.Count -lt 30){throw 'Original LOGICA schema missing.'}
$sql=[Text.StringBuilder]::new()
[void]$sql.AppendLine("CREATE DATABASE hanouty_demo CHARACTER SET utf8mb4; USE hanouty_demo; SET SESSION sql_mode='NO_AUTO_VALUE_ON_ZERO'; SET default_storage_engine=InnoDB;")
foreach($table in $tables){[void]$sql.AppendLine($table.Value)}
foreach($file in (Get-ChildItem -LiteralPath (Join-Path $repo 'input/migrations') -Filter '*.sql' | Sort-Object Name)){[void]$sql.AppendLine([IO.File]::ReadAllText($file.FullName))}
[void]$sql.AppendLine("INSERT INTO TABLE_NUM (ID,CL,CLIENT,INV,BC,BR,BS,ARTICLE) VALUES (0,0,0,0,0,0,0,0);")
$passDdl=($tables | Where-Object {$_.Value -match '^CREATE TABLE\s+`TABLE_PASS`'}).Value
$permissions=@([regex]::Matches($passDdl,'`([^`]+)`\s+varchar') | ForEach-Object {$_.Groups[1].Value} | Where-Object {$_ -notin @('ID_USER','ListUser','ListPass','Catégorie')})
$columns=(@('ID_USER','ListUser','ListPass','Catégorie')+$permissions | ForEach-Object {'`'+$_+'`'}) -join ','
$values=(@("'DEMO-ADMIN'","'Responsable DEMO'","'1234'","'ADMIN'")+@($permissions | ForEach-Object {"'VISIBLE'"})) -join ','
[void]$sql.AppendLine("INSERT INTO TABLE_PASS ($columns) VALUES ($values);")
foreach($pair in @(@('MODELE_TICKET','FR_3C'),@('BRANCHEMENT','USB'),@('AFFICHER_MODE_P','True'),@('AFFICHER_N_TICKET','True'),@('AFFICHER_CODE_BARRE','True'),@('PIED_TICKET','HANOUTY - DEMONSTRATION'),@('FENETRE_MODE_P','True'))){[void]$sql.AppendLine("INSERT INTO TABLE_PARAMETRES (OBJET,VALEUR) VALUES ('$($pair[0])','$($pair[1])');")}
foreach($pair in @(@('MODIF_STOCK_MANUEL','True'),@('GESTION_CLOTURE','True'),@('CLOTURE_CAISSIER_OBLIGER','False'),@('FONDS_CAISSE','0'))){[void]$sql.AppendLine("INSERT INTO TABLE_PARAMETRES (OBJET,VALEUR) VALUES ('$($pair[0])','$($pair[1])');")}
[void]$sql.AppendLine("INSERT INTO TABLE_MODE_P (MODE_P,Images) VALUES ('ESPECES','0'),('CARTE','0'); INSERT INTO TABLE_FAMILLES (Famille) VALUES ('Epicerie'),('Boissons'),('Entretien');")
$products=@(@('Lait 1 L','Epicerie',4.5,6),@('Eau 1.5 L','Boissons',3,5),@('Sucre 1 kg','Epicerie',7,9),@('Huile 1 L','Epicerie',14,18),@('Farine 1 kg','Epicerie',5,7),@('The 200 g','Epicerie',12,16),@('Cafe 250 g','Epicerie',20,25),@('Biscuit','Epicerie',1.5,2),@('Jus 1 L','Boissons',9,12),@('Savon','Entretien',4,6),@('Lessive','Entretien',16,20),@('Riz 1 kg','Epicerie',11,15))
$i=0
foreach($product in $products){$i++; $cost=([decimal]$product[2]).ToString([Globalization.CultureInfo]::InvariantCulture); $price=([decimal]$product[3]).ToString([Globalization.CultureInfo]::InvariantCulture); $name=$product[0].Replace("'","''"); [void]$sql.AppendLine("INSERT INTO TABLE_ARTICLES (ID_ARTICLE,Code,Article,Famille,PRIX_A,PRIX_MP,PRIX_V_1,PRIX_V_2,STOCK,Alert,TAUX_TVA,PROMOTION,Images,VISIBLE,TYPE) VALUES ('DEMO-$i','$('{0:D4}' -f (1000+$i))','$name','$($product[1])',$cost,$cost,$price,$price,100,5,0,0,'0','OUI','ARTICLE');")}
New-Item -ItemType Directory -Path $out -Force | Out-Null
[IO.File]::WriteAllText((Join-Path $out 'demo.sql'),$sql.ToString(),[Text.UTF8Encoding]::new($false))
$upgrade="UPDATE TABLE_NUM SET ARTICLE=0 WHERE ID=0 AND ARTICLE IS NULL AND NOT EXISTS (SELECT 1 FROM TABLE_ARTICLES WHERE ID_ARTICLE REGEXP '^ART[0-9]+$');`n"+[IO.File]::ReadAllText((Join-Path $repo 'input/migrations/20261122-daily-stock-adjustments.sql'))
foreach($pair in @(@('MODIF_STOCK_MANUEL','True'),@('GESTION_CLOTURE','True'),@('CLOTURE_CAISSIER_OBLIGER','False'),@('FONDS_CAISSE','0'))){$upgrade+="`nINSERT INTO TABLE_PARAMETRES (OBJET,VALEUR) SELECT '$($pair[0])','$($pair[1])' WHERE NOT EXISTS (SELECT 1 FROM TABLE_PARAMETRES WHERE BINARY OBJET=BINARY '$($pair[0])');"}
[IO.File]::WriteAllText((Join-Path $out 'demo-upgrades.sql'),$upgrade,[Text.UTF8Encoding]::new($false))
Copy-Item -LiteralPath $payload -Destination $out
Copy-Item -LiteralPath (Join-Path $AcceptedPackageDirectory 'financial-package-acceptance.json') -Destination $out
Copy-Item -LiteralPath $MariaDbArchive -Destination (Join-Path $out 'mariadb-10.11.14-winx64.zip')
Copy-Item -LiteralPath (Join-Path $PSScriptRoot 'Start-Hanouty-Demo.ps1'),(Join-Path $PSScriptRoot 'HANOUTY-DEMO.cmd') -Destination $out
$notice="HANOUTY - DEMONSTRATION AUTONOME`r`n`r`nDecompressez le dossier, puis double-cliquez HANOUTY-DEMO.cmd.`r`nCode : 1234 (Responsable DEMO).`r`nLe premier lancement prepare automatiquement les donnees, sans connexion LOGICA ni internet.`r`n12 articles : codes 1001 a 1012. Les essais restent conserves a la fermeture.`r`nFermez normalement HANOUTY avant de le rouvrir. Aucune base magasin n'est utilisee.`r`nLes donnees restent dans %LOCALAPPDATA%\HANOUTY-Demo.`r`nChoisissez votre imprimante dans Parametres pour tester l'impression.`r`n"
[IO.File]::WriteAllText((Join-Path $out 'LIRE-MOI.txt'),$notice,[Text.UTF8Encoding]::new($true))
$files=@(Get-ChildItem -LiteralPath $out -File | ForEach-Object {@{Name=$_.Name;Sha256=(Get-FileHash -LiteralPath $_.FullName).Hash.ToLowerInvariant()}})
@{Version=1;ApplicationSource=$proof.SourceSha;Files=$files} | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath (Join-Path $out 'DEMO-MANIFEST.json') -Encoding UTF8
Compress-Archive -LiteralPath @(Get-ChildItem -LiteralPath $out -File | ForEach-Object FullName) -DestinationPath ($out+'.zip')
Write-Host ('DEMO READY: '+$out+'.zip')
