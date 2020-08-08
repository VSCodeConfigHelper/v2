# 在 Mac 上安装 VS Code

## 安装编译器

打开终端（ Spotlight 搜索 “Terminal.app” ），输入

```bash
xcode-select --install
```
选择“安装”。

## 安装 VS Code

前往 https://code.visualstudio.com/ 下载安装包，然后双击打开，将 `Visual Studio Code.app` 拖到 应用程序 （`Applications`）文件夹。

## 配置 VS Code

前往[此处](https://marketplace.visualstudio.com/items?itemName=ms-vscode.cpptools)安装 C/C++ 插件。点击 Install 即可。

打开一个保存 C++ 文档的文件夹（Open Folder）。按 ⌘+⇧+P，搜索选择“ C/C++: Edit Configurations... (UI)”。

将“编译器路径”（Compiler Path）设置为 `/usr/bin/clang` ， IntelliSense 模式设置为 `clang-x64` 。

按 ⌘+⇧+P，搜索选择 “Tasks: Configure Default Build Task”，选择 “Create tasks.json file from template”，再选择 “Others” 选项。将生成的 `tasks.json` 用以下文本覆盖：

```JSON
{
    "version": "2.0.0",
    "tasks": [
        {
            "label": "Build with Clang",
            "type": "shell",
            "command": "clang++",
            "args": [
                "-std=c++17",
                "-stdlib=libc++",
                "${file}",
                "-o",
                "${fileDirname}/${fileBasenameNoExtension}.out",
                "--debug"
            ],
            "group": {
                "kind": "build",
                "isDefault": true
            }
        }
    ]
}
```

最后，按 ⌘+⇧+P，搜索选择 “Debug: Open launch.json”，选择 “GDB/LLDB” 。将生成的 `launch.json` 用以下文本覆盖：

```JSON
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": "(lldb) Launch",
            "type": "cppdbg",
            "request": "launch",
            "program": "${fileDirname}/${fileBasenameNoExtension}.out",
            "args": [],
            "stopAtEntry": false,
            "cwd": "${workspaceFolder}",
            "environment": [],
            "externalConsole": true,
            "MIMode": "lldb",
            "logging": {
                "trace": true,
                "traceResponse": true,
                "engineLogging": true
            },
            "preLaunchTask": "Build with Clang"
        }
    ]
}
```

## 尝试编译调试

**在该文件夹下**打开或新建一个 C++ 源代码，后缀名为 `.cpp`。比如：

```C++
#include<iostream>
using namespace std;
int main(){
    cout<<"Hello,world!"<<endl;
}
```

按 <kbd>F5</kbd> ，期望弹出一个终端并打印出 `Hello,world!` 。

-----

**重要提示** VS Code 在 macOS 上调试仍然存在问题：可能无法弹出调试窗口。

暂时的解决方案如下：

将 `tasks.json` 修改为：
```JSON
// tasks.json
{
    "version": "2.0.0",
    "tasks": [
        {
            "label": "Build with Clang",
            "type": "shell",
            "command": "clang++",
            "args": [
                "-std=c++17",
                "-stdlib=libc++",
                "${file}",
                "-o",
                "${fileDirname}/${fileBasenameNoExtension}.out",
                "--debug"
            ],
            "group": {
                "kind": "build",
                "isDefault": true
            }
        },
        {
            "label": "Open Terminal",
            "type": "shell",
            "command": "osascript -e 'tell application \"Terminal\"\ndo script \"echo hello\"\nend        tell'",
            "problemMatcher": []
        }
    ]
}
```

每次启动 VS Code 后，先按 ⌘+⇧+P，键入 `Run Tasks` 并选中，选择 `Open Terminal` 运行一次即可。


<!-- C/C++ 插件 0.27.0 更新已解决此问题。若问题仍存在，以下说明可作为备用方案。

~~如果你使用的是 macOS Catalina ，你的断点调试功能可能[暂时无法使用](https://github.com/microsoft/vscode-cpptools/issues/3829)。请耐心等待 VS Code 更新，或者使用以下解决方案：~~

前往[此处](https://marketplace.visualstudio.com/items?itemName=vadimcn.vscode-lldb)获得 CodeLLDB 插件。

更改你的 `launch.json` 为：

```JSON
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": "Launch",
            "type": "lldb",
            "request": "launch",
            "program": "${fileDirname}/${fileBasenameNoExtension}.out",
            "args": [],
            "preLaunchTask": "Build with Clang"
        }
    ]
}
``` -->