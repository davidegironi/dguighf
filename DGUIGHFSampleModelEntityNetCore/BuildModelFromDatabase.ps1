# Build EF Core model from Database
# Davide Gironi (c), 2021
#
# Requirements:
#   Install-Package Microsoft.EntityFrameworkCore.Tools
#   Install-Package Microsoft.EntityFrameworkCore.SqlServer
#   Install-Package System.Configuration.ConfigurationManager
# The file BuildModelFromDatabase-Config.ps1 must contains the following variables
#   $ConnectionString      = ""  # Connection string
#   $Context               = ""  # Model name
#   $ConnectionStringName  = ""  # Connection string

# Set variables in the file below
. .\BuildModelFromDatabase-Config.ps1

# Import database to modal and update model files
Scaffold-DbContext $ConnectionString -Context "$Context" -Provider Microsoft.EntityFrameworkCore.SqlServer -Force -UseDatabaseNames -NoPluralize
(Get-Content "$Context.cs") | Where-Object {$_ -notmatch 'LinkId=723263'} | Set-Content "$Context.cs"
(Get-Content "$Context.cs") -replace '(?<=optionsBuilder.UseSqlServer\()[^\)]*', ('ConfigurationManager.AppSettings["' + $ConnectionStringName + '"]') | Set-Content "$Context.cs"
@("using System.Configuration;") +  (Get-Content "$Context.cs") | Set-Content "$Context.cs"
