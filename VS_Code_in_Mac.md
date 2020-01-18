# 在 Mac 上安装 VS Code

## 安装 Xcode

在 App Store 上搜索下载 Xcode 作为编译器。

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
<!-- 
最终检查一下`.vscode/c_cpp_properties.json`，应如下：


```JSON
{
    "configurations": [
        {
            "name": "macOS",
            "includePath": ["${workspaceFolder}/**"],
            "defines": [],
            "macFrameworkPath": ["/System/Library/Frameworks", "/Library/Frameworks"],
            "compilerPath": "/usr/bin/clang",
            "cStandard": "c11",
            "cppStandard": "c++17",
            "intelliSenseMode": "clang-x64"
        }
    ],
    "version": 4
}
``` -->

按 ⌘+⇧+P，搜索选择 “Tasks: Configure Default Build Task”，选择 “Create tasks.json file from template”，再选择带有 “Clang” 字样的选项。将生成的 `tasks.json` 编辑为这样一个文件：

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

最后，按 ⌘+⇧+P，搜索选择 “Debug: Open launch.json”，选择 “GDB/LLDB” 。将生成的 `launch.json` 编辑为这样一个文件：

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

如果你使用的是 macOS Catalina ，你的断点调试功能可能暂时无法使用。请耐心等待 VS Code 更新，或者使用以下解决方案：

前往[此处](https://marketplace.visualstudio.com/items?itemName=vadimcn.vscode-lldb) 获得 CodeLLDB 插件。

更改你的 `launch.json` 为：

```JSON
{
    "name": "Launch",
    "type": "lldb",
    "request": "launch",
    "program": "${fileDirname}/${fileBasenameNoExtension}.out",
    "args": [],
    "preLaunchTask": "Build with Clang"
}
```