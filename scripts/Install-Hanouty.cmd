@echo off
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0Install-Hanouty.ps1"
if errorlevel 1 (
  echo Installation interrompue. La version precedente et les donnees restent conservees.
  pause
  exit /b 1
)
pause
