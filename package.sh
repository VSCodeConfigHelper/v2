#!/bin/bash
if [ ! -n "$1" ]
then
    echo "Usage: $0 <version number without v>" && exit
fi
DP0="$( cd "$( dirname "$0" )" && pwd )" # Get the path of this script
echo -e "\033[32mPackaging binaries...\033[0m"
cd $DP0/VSCodeConfigHelper/bin/Release
ls
7z a -tzip Release-v$1.zip VSCodeConfigHelper.exe Newtonsoft.Json.dll
cd $DP0
echo -e "\033[32mGenerating version info...\033[0m"
echo -e "{\"version\":\"$1\",\"link\":\"https://github.com/Guyutongxue/VSCodeConfigHelper/releases/download/v$1/Release-v$1.zip\",\"date\":\"$( date "+%Y/%m/%d" )\"}" > $DP0/docs/version.json