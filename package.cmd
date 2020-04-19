@ECHO OFF
CD %~dp0\VSCodeConfigHelper\bin\Release
SET /P versionNumber=Enter version number:
7z a -tzip Release-%versionNumber%.zip VSCodeConfigHelper.exe Newtonsoft.Json.dll
ECHO Finished.
PAUSE