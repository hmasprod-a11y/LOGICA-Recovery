$ErrorActionPreference = 'Stop'
$root = Split-Path $PSScriptRoot -Parent
$framework = Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319'
$compiler = Join-Path $framework 'csc.exe'
$visualBasic = Join-Path $framework 'Microsoft.VisualBasic.dll'
$temporary = Join-Path ([IO.Path]::GetTempPath()) ('logica-domain-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $temporary | Out-Null
$createdFiles = @()
try {
    $sources = @(Get-ChildItem -LiteralPath (Join-Path $root 'recovered-source/LOGICA/Domain') -Filter '*.cs' | ForEach-Object { $_.FullName })
    $tests = @(Get-ChildItem -LiteralPath (Join-Path $root 'tests') -Filter '*Tests.cs' | Sort-Object Name)
    if ($sources.Count -eq 0 -or $tests.Count -eq 0) { throw 'Domain sources or tests missing' }
    foreach ($test in $tests) {
        $executable = Join-Path $temporary ($test.BaseName + '.exe')
        $createdFiles += $executable
        & $compiler /nologo /platform:x86 /target:exe "/r:$visualBasic" "/out:$executable" $sources $test.FullName
        if ($LASTEXITCODE -ne 0) { throw "Domain test compilation failed: $($test.Name)" }
        & $executable
        if ($LASTEXITCODE -ne 0) { throw "Domain tests failed: $($test.Name)" }
    }
} finally {
    foreach ($createdFile in $createdFiles) {
        Remove-Item -LiteralPath $createdFile -Force -ErrorAction SilentlyContinue
    }
    Remove-Item -LiteralPath $temporary -ErrorAction SilentlyContinue
}
