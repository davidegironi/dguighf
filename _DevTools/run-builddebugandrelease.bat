@echo off

rem Build Debug and Release for a solution
rem Copyright (c) Davide Gironi, 2014

powershell -Command "& { [Console]::WindowWidth = 150; [Console]::WindowHeight = 50; Start-Transcript out.txt; Import-Module .\Tools\PSake\psake.psm1; Invoke-psake '.\Tools\AutoBuilder\AutoBuilder.ps1' -task BuildDebugAndRelease; Remove-Module psake; %*; Stop-Transcript; }"
@if "%NOPAUSE%"=="1" (echo stop) else (pause)
