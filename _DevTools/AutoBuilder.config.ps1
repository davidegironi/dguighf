
#solution name to build
$solutionName = "DGUIGHF"

#set version
$versionMajor = "1"
$versionMinor = "2"
$versionBuild = GetVersionBuild
$versionRevision = "5"
#build version number
$assemblyVersion = GetVersion $versionMajor $versionMinor $versionBuild $versionRevision
$fileVersion = $assemblyVersion

#base folder for of the solution
$baseDir  = Resolve-Path .\..\

#release folder for of the solution
$releaseDir = Resolve-Path .\..\..\Release

#builder parameters
$buildDebugAndRelease = $false
$treatWarningsAsErrors = $true
$releaseDebugFiles = $false

#remove elder release builds for the actual version
$removeElderReleaseWithSameVersion = $true

#folders and files to exclude from the packaged release Source
$releaseSrcExcludeFolders = @('"_DevTools"', '".git"');
$releaseSrcExcludeFiles = @('".git*"');

#builds array
#include here all the solutions file to build	
$builds = @(
	@{
		#solutions filename (.sln)
		Name = "DGUIGHF";
		#msbuild optionals contants
		Constants = "";
		#projects to exclude from the release binary package
		ReleaseBinExcludeProjects = @(
			@{
				Name = "DGUIGHFSample";
			},
			@{
				Name = "DGUIGHFSampleModel";
			}
		);
		#files to include in the release binary package
		ReleaseBinIncludeFiles = @();
		#unit tests to run
		Tests = @();
		#commands to run before packaging of the release source
		ReleaseSrcCmd = @(
			@{
				Cmd = ".\dbsql-backuptsql.bat ..\..\"
			},
			@{
				Cmd = ".\dbsql-backupsqlschema.bat ..\..\"
			},
			@{
				Cmd = "xcopy ..\..\_DBDump\* Working\Src\_DBDump\ /s /e /y"
			}
		);
		#commands to run before packaging of the release source
		ReleaseBinCmd = @(
			@{
				Cmd = ".\copylicense.bat"
			}
		);
	};
)