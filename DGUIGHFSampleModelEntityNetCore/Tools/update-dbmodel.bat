@echo off
setlocal enabledelayedexpansion enableextensions

rem Scaffold database to model
rem Copyright (c) Davide Gironi, 2024

rem Enviroment dependencies
rem dotnet tool install --global dotnet-ef

rem Project dependencies
rem Microsoft.EntityFrameworkCore.SqlServer
rem Microsoft.EntityFrameworkCore.Tools
rem System.Configuration.ConfigurationManager

rem load config
if not exist config.update-dbmodel.bat exit
call config.update-dbmodel.bat

rem scaffold database
dotnet ef dbcontext scaffold "%CONFIGSTRING%" Microsoft.EntityFrameworkCore.SqlServer --project "%PROJECT%" %SCAFFOLDPARAMS% --no-onconfiguring --context %CONTEXT% --context-dir %CONTEXTDIR% --output-dir %OUTPUTDIR% --force --verbose

rem replace for ConnectionString modification
if %ERRORLEVEL% NEQ 1 (
  %SEDBIN% -e "s/protected override void OnModelCreating(ModelBuilder modelBuilder)/protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { if (optionsBuilder.IsConfigured == false) optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.AppSettings[\"%CONNECTIONSTRINGNAME%\"]); }%ADDITIONALSEDREPLACEMENT%\r\n        protected override void OnModelCreating(ModelBuilder modelBuilder)/g" "%CONTEXTBASEDIR%\%CONTEXT%.cs" >> "%CONTEXT%.cs"
  move /y "%CONTEXT%.cs" "%CONTEXTBASEDIR%\%CONTEXT%.cs"
)
