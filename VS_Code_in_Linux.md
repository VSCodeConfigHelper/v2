# GNU/Linux 下配置 VS Code

## 安装 G++ 编译器

Debian 或 Ubuntu：
```bash
sudo apt install g++
```
其它发行版：参考您所采用的软件包管理器的安装方法。

## 安装 VS Code

前往[官网](https://code.visualstudio.com/)获取 deb 或 rpm 包安装。

## 配置

选定任意（有足够权限的路径）为工作文件夹。建立 `.vscode` 子文件夹，其中包含以下文件：

```
.vscode
 ├─ settings.json
 ├─ tasks.json
 └─ launch.json
```
修改其内容为：
#### settings.json
```JSON
{
  "C_Cpp.default.intelliSenseMode": "gcc-x64",
  "C_Cpp.default.compilerPath": "/usr/bin/g++",
  "C_Cpp.default.cppStandard": "c++17"
}
```

#### tasks.json
```JSON
{
  "version": "2.0.0",
  "tasks": [
    {
      "type": "shell",
      "label": "g++ build active file",
      "command": "g++",
      "args": [
        "-g",
        "-std=c++20",
        "${file}",
        "-o",
        "${fileDirname}/${fileBasenameNoExtension}.out"
      ],
      "group": {
        "kind": "build",
        "isDefault": true
      },
      "presentation": {
        "echo": false,
        "reveal": "silent",
        "focus": false,
        "panel": "shared",
        "showReuseMessage": false,
        "clear": true
      },
      "problemMatcher": [ "$gcc" ]
    }
  ]
}
```

#### launch.json
```JSON
{
  "version": "0.2.0",
  "configurations": [
    {
      "name": "g++ build and debug active file",
      "type": "cppdbg",
      "request": "launch",
      "program": "${fileDirname}/${fileBasenameNoExtension}.out",
      "args": [],
      "stopAtEntry": false,
      "cwd": "${workspaceFolder}",
      "environment": [],
      "externalConsole": false,
      "MIMode": "gdb",
      "miDebuggerPath": "/usr/bin/gdb",
      "setupCommands": [
        {
          "description": "Enable pretty-printing for gdb",
          "text": "-enable-pretty-printing",
          "ignoreFailures": true
        }
      ],
      "preLaunchTask": "g++ build active file",
      "internalConsoleOptions": "neverOpen"
    }
  ]
}
```

## 尝试编译运行

新建任意 C++ 源文件，可以按 <kbd>F5</kbd> 编译并调试；按 <kbd>Ctrl</kbd>+<kbd>F5</kbd> 编译并运行；按 <kbd>Ctrl</kbd>+<kbd>Shift</kbd>+<kbd>F5</kbd> 编译。

