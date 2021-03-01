# VSCodeConfigHelper

VSCodeConfigHelper 是一个配置 Visual Studio Code C++ 环境的工具。它专为编程新手打造，致力于让学生专注于编程的学习而非环境的配置工作上。

**[下载地址](https://github.com/Guyutongxue/VSCodeConfigHelper/releases)**

## 使用方法

此工具只能在 Windows （版本不低于 Windows 7 Service Pack 1）环境下使用。如果您使用的是 macOS，请参阅[此处](VS_Code_in_Mac.md)。如果您使用的是 GNU/Linux，您来这里做什么？

您**只**需要一个支持 7-Zip 解压缩的软件。您可以使用*任何*主流的工具包括 WinRAR、Bandizip 甚至“好压”。

然后，您只需要[下载](https://github.com/Guyutongxue/VSCodeConfigHelper/releases)此工具，然后按照上面的提示进行即可：

1. 第一步：输入一个**不包含中文**或者特殊字符的文件夹，作为您的工作文件夹。您的一切代码和程序都将存放在该文件夹下。若一切顺利，请点击下一步。
2. 第二步：配置您的 MinGW-w64。
   - 如果您是第一次配置，请您点击下载链接，然后使用 7-Zip 解压缩工具解压。请妥善保存解压得到的文件，并将其路径输入到工具中。若一切顺利，你将看到绿色的输出。此时请您点击下一步。
   - 如果这不是您第一次配置，请您选中您想要使用的编译环境。请注意，如果该编译环境是红色字体，说明该编译环境并不推荐，可能导致异常。选择完毕后，请您点击下一步。
3. 第三步：安装 VS Code 和插件。
   - 如果您已经安装了 VS Code，则工具会自动检测并提示您。如果您观察到了红色字体的输出，说明您当前安装的 VS Code 可能与 MinGW-w64 不兼容。建议您重新通过工具提供的链接下载并安装。安装完成后，请点击刷新按钮。
   - 如果您未安装 VS Code，请通过工具提供的链接下载并安装。安装完成后，请点击刷新按钮。
   - 请您点击下方的安装扩展按钮。若安装成功，则提示“已安装”。此时您可以点击下一步。
4. 第四步：选择您喜爱的样式。建议您选择内置终端样式，避免意外情形发生。选择完成后，点击下一步进行配置。
5. 第五步：您的配置已完成。您可以选择生成 “Hello World” 测试代码，或者启动 VS Code。

若您选择内置终端样式，请按 <kbd>F5</kbd> （在不同设备上可能是 <kbd>Fn</kbd>+<kbd>F5</kbd>），期望在底部弹出一个终端并打印出 `Hello,world!` 。

若您选择弹出窗口样式，请安 <kbd>F6</kbd>（在不同设备上可能是 <kbd>Fn</kbd>+<kbd>F6</kbd>），期望在弹出一个终端窗口并打印出 `Hello,world!` 。

之后您启动 VS Code 时，请选择打开**工作文件夹**，也就是您第一步填写的文件夹。**（不是 .vscode 文件夹。）**

## 遇到了 Windows Defender SmartScreen ... 的问题

请您选择“仍要运行”。

## 遇到了 .NET Framework ... 的问题

如果您无法启动工具，出现这种情况：

![.NET Framework not found](https://s2.ax1x.com/2020/01/14/lqbwOU.jpg)

请前往 [Microsoft 下载](https://www.microsoft.com/zh-CN/download/details.aspx?id=53344) 获取 .NET Framework 4.6.2 环境。

## 参阅

### [FAQ](FAQ.md)

### [疑难解答](TroubleShooting.md)

-----

## 关于此项目

本项目使用 Visual Studio 2019 开发，基于 .NET Framework 4.5 。代码采用 GPLv2 协议开源，欢迎您贡献出您自己的一份力量。您只需要克隆本仓库，然后使用 Visual Studio 打开解决方案文件即可生成、调试。
