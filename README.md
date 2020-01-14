# VSCodeConfigHelper

VSCodeConfigHelper 是一个配置 Visual Studio Code C++ 环境的工具。它专为编程新手打造，致力于让学生专注于编程的学习而非环境的配置工作上。

**[下载地址](https://github.com/Guyutongxue/VSCodeConfigHelper/releases)**

## 使用方法

此工具只能在 Windows 环境下使用。如果您使用的是 macOS，请参阅[此处](VS_Code_in_Mac.md)。如果您使用的是 GNU/Linux，您来这里做什么？

您**只**需要一个支持 7-Zip 解压缩的软件。您可以使用*任何*主流的工具包括 WinRAR、Bandizip 甚至“好压”。

然后，您只需要[下载](https://github.com/Guyutongxue/VSCodeConfigHelper/releases)此工具，然后按照上面的提示进行即可：

1. 第一步：点击工具中的下载地址获得 MinGW-w64 工具包。
2. 第二步：使用解压工具将刚才的文件解压，然后将其中 `mingw64` 这一文件夹的路径输入到工具中。此文件夹用于存放编译器等重要文件，请不要删除。
3. 第三步：点击“设置环境变量”按钮即可。
4. 第四步：点击工具中的下载地址跳转到 Visual Studio Code 官网，下载最新版本的安装程序，然后双击运行安装程序，按照其提示完成安装。
5. 第五步：点击工具中的“安装插件...”按钮，跳转到插件安装网页。点击网页中的 “Install” ，并允许网页打开 Visual Studio Code 。在 Visual Studio Code 中选择 “Install”，完成插件的安装。
6. 第六步：选择一个工作文件夹（不能包含中文或中文字符），输入到工具中。
7. 第七步：点击“一键配置”按钮即可。

至此您已经完成了 Visual Studio Code 的全部配置工作。您可以尝试编写您的第一个程序了！

在 Visual Studio 中打开您的工作文件夹（<Kbd>Ctrl</kbd>+<Kbd>K</kbd>, <Kbd>Ctrl</kbd>+<Kbd>O</kbd>）（**注意，并不是 .vscode 文件夹，而是它的上级文件夹，即在第六步中所填写的文件夹**）。然后在右侧工作区视图中新建 `helloworld.cpp` ：

```C++
#include<iostream>
using namespace std;
int main(){
    cout<<"Hello,world!"<<endl;
}
```

按 <kbd>F5</kbd> （在不同设备上可能是 <kbd>Fn</kbd>+<kbd>F5</kbd>），期望在底部弹出一个终端并打印出 `Hello,world!` 。

## 遇到了 Windows Defender SmartScreen ... 的问题

请您选择“仍要运行”。

## 遇到了 .NET Framework ... 的问题

如果您无法启动工具，出现这种情况：

![.NET Framework not found](https://s2.ax1x.com/2020/01/14/lqbwOU.jpg)

请前往 [Microsoft 下载](https://www.microsoft.com/en-us/download/details.aspx?id=42642) 获取该依赖 .NET Framework 4.5 环境。

-----

## 关于此项目

本项目使用 Visual Studio 2019 开发，基于 .NET Framework 4.0 。代码采用 MIT 协议开源，欢迎您贡献出您自己的一份力量。您只需要克隆本仓库，然后使用 Visual Studio 打开解决方案文件即可生成、调试。