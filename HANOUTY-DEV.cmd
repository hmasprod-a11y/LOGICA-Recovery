@echo off
powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0scripts\Run-HanoutyDev.ps1"
if errorlevel 1 pause
