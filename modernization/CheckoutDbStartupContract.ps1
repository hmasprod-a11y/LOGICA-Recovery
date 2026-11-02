Set-StrictMode -Version Latest
function Get-CheckoutDbStartupContract {
    param(
        [Parameter(Mandatory=$true)][string]$ModuleSource,
        [Parameter(Mandatory=$true)][string]$LauncherSource
    )
    $directPort = [regex]::Match($ModuleSource, '_PORT_DB\s*=\s*"(?<port>\d+)"\s*;')
    $launcherPort = [regex]::Match($LauncherSource, '\[int\]\s*\$Port\s*=\s*(?<port>\d+)')
    $envRead = $ModuleSource.Contains('Environment.GetEnvironmentVariable("LOGICA_DB_CONNECTION_STRING")')
    $envExport = $LauncherSource.Contains('$env:LOGICA_DB_CONNECTION_STRING=')
    if (-not $directPort.Success -or -not $launcherPort.Success) {
        throw 'Cannot identify the direct EXE fallback and launcher default DB ports; review startup code.'
    }
    [pscustomobject]@{
        DirectExeFallbackPort = [int]$directPort.Groups['port'].Value
        LauncherDefaultPort = [int]$launcherPort.Groups['port'].Value
        DirectExeAcceptsEnvironmentOverride = $envRead
        LauncherExportsEnvironmentOverride = $envExport
        BareExeMatchesLauncher = ($directPort.Groups['port'].Value -eq $launcherPort.Groups['port'].Value)
        LauncherPassesEndpoint = ($envRead -and $envExport)
    }
}
