@ECHO OFF
CD %~dp0\VSCodeConfigHelper\bin\Release
SET /P versionNumber=Enter version number:
7z a -tzip Release-v%versionNumber%.zip VSCodeConfigHelper.exe Newtonsoft.Json.dll
ECHO {"version":"%versionNumber%","link":"https://github.com/Guyutongxue/VSCodeConfigHelper/releases/download/v%versionNumber%/Release-v%versionNumber%.zip","date":"%DATE:~0,10%"} > %~dp0/docs/version.json
ECHO Finished.
PAUSE