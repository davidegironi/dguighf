@echo off

rem load config secret
if not exist config.update-dbmodel-secret.bat exit
call config.update-dbmodel-secret.bat

rem Configuration string
set CONFIGSTRING=%CONFIGSTRINGSECRET%
rem Project path
set PROJECT=..\DGUIGHFSampleModelEFCore.csproj
rem Set the database name
set DATABASE=dguighfsamplemodel
rem Set the context name
set CONTEXT=%DATABASE%Context
rem Connectionstring name, as in appSettings App.Config section
set CONNECTIONSTRINGNAME=%DATABASE%ConnectionString
rem Additional scaffold parameters
set SCAFFOLDPARAMS=--no-pluralize --use-database-names

rem SED executable path
set SEDBIN=Sed\sed.exe
rem Context dir
set CONTEXTDIR=Entity\Context
rem Models dir
set OUTPUTDIR=Entity\Models
rem Base context folder
set CONTEXTBASEDIR=..\Entity\Context
rem Addition lines on SED replacement
set ADDITIONALSEDREPLACEMENT=
