# Run the real customer-packaging script against synthetic shop settings only.
# No production database, license, printer, or user installation is accessed.
$ErrorActionPreference = 'Stop'
$root = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$work = Join-Path ([IO.Path]::GetTempPath()) ('hanouty-package-isolation-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Force -Path $work | Out-Null
try {
    foreach ($dir in @('dist','input/migrations','docs','results')) {
        New-Item -ItemType Directory -Force -Path (Join-Path $work $dir) | Out-Null
    }
    [IO.File]::WriteAllText((Join-Path $work 'docs/RUNNING.md'), 'synthetic packaging fixture')
    [IO.File]::WriteAllText((Join-Path $work 'input/migrations/20261102-article-add-compatibility.sql'), '-- synthetic migration')
    $original = @{
        'poste.sni' = 'SHOP-SECRET-POST'
        'mode_windows.sni' = 'True'
        'acces_rfid.sni' = 'True'
        'afficher_ecran_pub.sni' = 'True'
        'choix_client.sni' = 'True'
        'choix_vendeur.sni' = 'True'
        'gestion_credit.sni' = 'True'
        'raccourcies.sni' = 'SHOP-SECRET-SHORTCUTS'
        'PRINTER_CL.sni' = 'REAL-SHOP-PRINTER'
        'CHEMIN_DB.sni' = '192.0.2.55'
        'CHEMIN_FOLDER.sni' = 'C:\\RealShop'
        'hash_licence.sni' = 'PRIVATE-LICENSE'
        'log_erreur.sni' = 'PRIVATE-ERROR-LOG'
        'splitterdistance_v.sni' = '455'
        'interfaces_a.sni' = 'SyntheticLayoutA'
        'unknown_private_setting.sni' = 'PRIVATE-UNKNOWN'
    }
    $original | ConvertTo-Json | Set-Content -LiteralPath (Join-Path $work 'input/original-startup.json') -Encoding UTF8
    # The package script records sourceCommit; give its isolated fixture its own git HEAD.
    Push-Location $work
    try {
        & git init -q
        if ($LASTEXITCODE -ne 0) { throw 'Could not initialize synthetic git fixture' }
        & git -c user.name=QA -c user.email=qa@example.invalid commit --allow-empty -q -m 'synthetic package fixture'
        if ($LASTEXITCODE -ne 0) { throw 'Could not commit synthetic git fixture' }
        & (Join-Path $root 'scripts/package-runtime.ps1')
        $expected = @{
            'poste.sni' = '01'
            'mode_windows.sni' = 'False'
            'acces_rfid.sni' = 'False'
            'afficher_ecran_pub.sni' = 'False'
            'choix_client.sni' = 'False'
            'choix_vendeur.sni' = 'False'
            'gestion_credit.sni' = 'False'
            'raccourcies.sni' = ''
            'PRINTER_CL.sni' = '0'
            'CHEMIN_DB.sni' = '127.0.0.1'
            'CHEMIN_FOLDER.sni' = 'Application.StartupPath'
            'hash_licence.sni' = ''
            'log_erreur.sni' = ''
            'splitterdistance_v.sni' = '455'
            'interfaces_a.sni' = 'SyntheticLayoutA'
        }
        foreach ($item in $expected.GetEnumerator()) {
            $file = Join-Path $work ('dist/' + $item.Key)
            if (-not (Test-Path -LiteralPath $file -PathType Leaf)) { throw "Missing packaged default: $($item.Key)" }
            $actual = [IO.File]::ReadAllText($file)
            if ($actual -cne $item.Value) {
                throw "Inherited unsafe shop setting in portable runtime: $($item.Key) (expected isolated default)"
            }
        }
        if (Test-Path -LiteralPath (Join-Path $work 'dist/unknown_private_setting.sni')) {
            throw 'Unexpected private startup setting copied into portable runtime'
        }
        $runtime = Get-ChildItem -LiteralPath (Join-Path $work 'dist') -File
        foreach ($file in $runtime) {
            $value = [IO.File]::ReadAllText($file.FullName)
            if ($value -match 'SHOP-SECRET|REAL-SHOP|PRIVATE-LICENSE|PRIVATE-ERROR|192\.0\.2\.55') {
                throw "Portable runtime leaked synthetic shop state in $($file.Name)"
            }
        }
        Write-Host 'PASS: portable package preserves approved visual preferences only; private shop, device, login and license defaults are isolated'
    } finally { Pop-Location }
} finally {
    Remove-Item -LiteralPath $work -Recurse -Force -ErrorAction Stop
}
