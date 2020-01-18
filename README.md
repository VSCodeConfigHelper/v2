# VSCodeConfigHelper

VSCodeConfigHelper 是一个配置 Visual Studio Code C++ 环境的工具。它专为编程新手打造，致力于让学生专注于编程的学习而非环境的配置工作上。

**[下载地址](https://github.com/Guyutongxue/VSCodeConfigHelper/releases)**

## 使用方法

此工具只能在 Windows （版本不低于 Windows 7 Service Pack 1）环境下使用。如果您使用的是 macOS，请参阅[此处](VS_Code_in_Mac.md)。如果您使用的是 GNU/Linux，您来这里做什么？

您**只**需要一个支持 7-Zip 解压缩的软件。您可以使用*任何*主流的工具包括 WinRAR、Bandizip 甚至“好压”。

然后，您只需要[下载](https://github.com/Guyutongxue/VSCodeConfigHelper/releases)此工具，然后按照上面的提示进行即可：

1. 第一步：点击工具中的下载地址获得 MinGW-w64 工具包。
2. 第二步：使用解压工具将刚才的文件解压，然后将其中 `mingw64` 这一文件夹的路径输入到工具中。此文件夹用于存放编译器等重要文件，请妥善保存。
3. 第三步：点击“设置环境变量”按钮即可。
4. 第四步：点击工具中的下载地址跳转到 Visual Studio Code 官网，下载最新版本的安装程序，然后双击运行安装程序，按照其提示完成安装。请保持默认选项。
5. 第五步：点击工具中的“安装插件...”按钮，跳转到插件安装网页。点击网页中的 “Install” ，并允许网页打开 Visual Studio Code 。在 Visual Studio Code 中选择 “Install”，完成插件的安装。
6. 第六步：选择一个工作文件夹（不能包含中文或中文字符），输入到工具中。
7. 第七步：点击“一键配置”按钮即可。

如果您在第七步中勾选了“生成测试代码”选项的话，你已经拥有一份 Hello World 代码。

如果您在第七步中勾选了“配置成功后启动”选项的话，你可能已经启动了 VS Code。若启动失败或者未勾选，请在 VS Code 中手动打开文件夹（<kbd>Ctrl</kbd>+<kbd>K</kbd>, <kbd>Ctrl</kbd>+<kbd>O</kbd>），选择**工作文件夹**，也就是你第六步填写的文件夹。**（不是 .vscode 文件夹。）**

按 <kbd>F5</kbd> （在不同设备上可能是 <kbd>Fn</kbd>+<kbd>F5</kbd>），期望在底部弹出一个终端并打印出 `Hello,world!` 。

## 遇到了 Windows Defender SmartScreen ... 的问题

请您选择“仍要运行”。

## 遇到了 .NET Framework ... 的问题

如果您无法启动工具，出现这种情况：

![.NET Framework not found](https://s2.ax1x.com/2020/01/14/lqbwOU.jpg)

请前往 [Microsoft 下载](https://www.microsoft.com/zh-CN/download/details.aspx?id=53344) 获取 .NET Framework 4.6.2 环境。

-----

## 关于此项目

本项目使用 Visual Studio 2019 开发，基于 .NET Framework 4.5 。代码采用 MIT 协议开源，欢迎您贡献出您自己的一份力量。您只需要克隆本仓库，然后使用 Visual Studio 打开解决方案文件即可生成、调试。
