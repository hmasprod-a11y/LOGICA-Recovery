# End-to-end offline licensing acceptance test; no POS, production data or external service.
$ErrorActionPreference = 'Stop'
$project = Join-Path $PSScriptRoot '../modernization/TODO.Licensing.Issuer/TODO.Licensing.Issuer.csproj'
$work = Join-Path ([IO.Path]::GetTempPath()) ('todo-license-ci-' + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $work -Force | Out-Null
$key = Join-Path $work 'issuer-private.pem'
$public = $key + '.pub.pem'
$license = Join-Path $work 'test.license.json'
$perpetual = Join-Path $work 'perpetual.license.json'
$device = 'a' * 64
function Invoke-License([int]$expected, [string[]]$arguments) {
    & dotnet run --no-build --project $project -c Release -- @arguments
    if ($LASTEXITCODE -ne $expected) {
        throw "License CLI exit code $LASTEXITCODE; expected $expected for $($arguments[0])"
    }
}
try {
    & dotnet build $project -c Release --nologo
    if ($LASTEXITCODE -ne 0) { throw 'Issuer build failed' }
    Invoke-License 0 @('keygen', $key)
    if (-not (Test-Path -LiteralPath $public)) { throw 'Public key not generated' }
    Invoke-License 1 @('keygen', $key)
    Invoke-License 0 @('issue', $key, [Guid]::NewGuid().ToString(), 'Standard', '1', '2099-12-31', $license, $device)
    Invoke-License 0 @('verify', $public, $license, $device)
    Invoke-License 2 @('verify', $public, $license, ('b' * 64))
    Invoke-License 1 @('issue', $key, [Guid]::NewGuid().ToString(), 'Standard', '1', '2099-12-31', $license, $device)
    Invoke-License 0 @('issue', $key, [Guid]::NewGuid().ToString(), 'Standard', '1', 'never', $perpetual)
    Invoke-License 0 @('verify', $public, $perpetual)
    $tampered = Join-Path $work 'tampered.license.json'
    (Get-Content -LiteralPath $license -Raw).Replace('"Payload"', '"PayloaX"') |
        Set-Content -LiteralPath $tampered -Encoding UTF8
    Invoke-License 2 @('verify', $public, $tampered, $device)
    # A deliberate negative CLI case exits 2; reset the external-process status on success.
    $global:LASTEXITCODE = 0
    Write-Host 'PASS: TODO POS offline issuer CLI, device binding, perpetual license and tamper rejection'
} finally {
    Remove-Item -LiteralPath $work -Recurse -Force -ErrorAction SilentlyContinue
}
