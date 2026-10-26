@echo off
cd /d "%~dp0"
powershell.exe -NoLogo -NoProfile -ExecutionPolicy Bypass -File "%~dp0Launch-LOGICA.ps1" -BackupOnly
if errorlevel 1 (
 echo Echec de sauvegarde. Les donnees sont conservees.
 exit /b 1
)
echo Sauvegarde terminee dans bd\backup.
