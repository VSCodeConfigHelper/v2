#!/bin/bash
if [ ! -n "$1" ]
then
    echo "Usage: $0 <version number without v>" && exit
fi
DP0="$( cd "$( dirname "$0" )" && pwd )" # Get the path of this script
echo -e "\033[32mCreating release...\033[0m"
release_id=$( curl -u Guyutongxue:$github_token https://api.github.com/repos/Guyutongxue/VSCodeConfigHelper/releases -X POST -d "{\"tag_name\": \"v$1\", \"name\": \"v$1 Release\"}" | jq '.id' )
echo Release ID is $release_id
echo -e "\033[32mUploading asset...\033[0m"
curl -i -u Guyutongxue:$github_token https://uploads.github.com/repos/Guyutongxue/VSCodeConfigHelper/releases/$release_id/assets\?name\=Release-v$1.zip -X POST --data-binary @"$DP0/VSCodeConfigHelper/bin/Release/Release-v$1.zip" -H "Content-Type:application/zip" | jq
echo -e "\033[32mFinished.\033[0m"