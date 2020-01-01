# VSCodeConfigHelper

VSCodeConfigHelper 是一个配置 Visual Studio Code C++ 环境的工具。它专为编程新手打造，致力于让学生专注于编程的学习而非环境的配置工作上。

## 使用方法

此工具只能在 Windows 环境下使用。如果您使用的是 macOS，请参阅[此处](VS_Code_in_Mac.md)。如果您使用的是 GNU/Linux，您来这里做什么？

您**只**需要一个支持 7-Zip 解压缩的软件。您可以使用*任何*主流的工具包括 WinRAR、Bandizip 甚至“好压”。

然后，您只需要[下载](https://github.com/Guyutongxue/VSCodeConfigHelper/releases)此工具，然后按照上面的提示进行即可：

1. 第一步：点击工具中的下载地址获得 MinGW-w64 工具包。
2. 第二步：使用解压工具将刚才的文件解压，然后将其中 `mingw64` 这一文件夹的路径输入到工具中。
3. 第三步：点击“设置环境变量”按钮即可。
4. 第四步：点击工具中的下载地址跳转到 Visual Studio Code 官网，下载最新版本的安装程序，然后双击运行安装程序，按照其提示完成安装。
5. 第五步：点击工具中的“下载插件...”按钮，跳转到插件安装网页。点击网页中的 “Install” ，并允许网页打开 Visual Studio Code 。在 Visual Studio Code 中选择 “Install”，完成插件的安装。
6. 第六步：选择一个工作文件夹，输入到工具中。
7. 第七步：点击“一键配置”按钮即可。

至此您已经完成了 Visual Studio Code 的全部配置工作。您可以尝试编写您的第一个程序了！

## 尝试编译调试

在 Visual Studio 中打开您的工作文件夹（<Kbd>Ctrl</kbd>+<Kbd>K</kbd>, <Kbd>Ctrl</kbd>+<Kbd>O</kbd>）。然后在右侧工作区视图中新建 `helloworld.cpp` ：

```C++
#include<iostream>
using namespace std;
int main(){
    cout<<"Hello,world!"<<endl;
}
```

按 <kbd>F5</kbd> （在不同设备上可能是 <kbd>Fn</kbd>+<kbd>F5</kbd>），期望在底部弹出一个终端并打印出 `Hello,world!` 。

