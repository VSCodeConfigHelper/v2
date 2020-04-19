// Copyright (C) 2020 Guyutongxue
// 
// This file is part of VSCodeConfigHelper.
// 
// VSCodeConfigHelper is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// VSCodeConfigHelper is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with VSCodeConfigHelper.  If not, see<http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace VSCodeConfigHelper
{

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            // 防止TabControl 切换时卡顿闪烁
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
        // 防止TabControl 切换时卡顿闪烁
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        public static int minGWDistro = 0;

        /*
         * -MinGW-w64  -64bit   -PKU
         * -TDM-GCC    -32bit   -Official
         * -WinLibs
         */
        static readonly string[,,] minGWLinks = new string[3,2,2]
        {
            {
                {
                    @"https://disk.pku.edu.cn:443/link/A866B63467924A54CB7DB67EC386F0B1",
                    @"https://sourceforge.net/projects/mingw-w64/files/Toolchains%20targetting%20Win64/Personal%20Builds/mingw-builds/8.1.0/threads-win32/seh/x86_64-8.1.0-release-win32-seh-rt_v6-rev0.7z",
                },
                {
                    @"https://disk.pku.edu.cn:443/link/774E14CD00311CCA1A8E2411DDF39288",
                    @"https://sourceforge.net/projects/mingw-w64/files/Toolchains%20targetting%20Win32/Personal%20Builds/mingw-builds/8.1.0/threads-win32/dwarf/i686-8.1.0-release-win32-dwarf-rt_v6-rev0.7z",
                }
            },
            {
                {
                    @"https://disk.pku.edu.cn:443/link/BA95F5AE50BD2F66CB9BE4CCB1D0B8AC",
                    @"https://github.com/jmeubank/tdm-gcc/releases/download/v9.2.0-tdm64-1/tdm64-gcc-9.2.0.exe"
                },
                {
                    @"https://disk.pku.edu.cn:443/link/EEEE7B7EB495F6C7FD0441FDEC3FB784",
                    @"https://github.com/jmeubank/tdm-gcc/releases/download/v9.2.0-tdm-1/tdm-gcc-9.2.0.exe"
                }
            },
            {
                {
                    @"https://disk.pku.edu.cn:443/link/C856C793201FF01FFB77BB5A9074D1FD",
                    @"https://github.com/brechtsanders/winlibs_mingw/releases/download/9.3.0-10.0.0-7.0.0-r3/winlibs-x86_64-posix-seh-gcc-9.3.0-llvm-10.0.0-mingw-w64-7.0.0-r3.7z"
                },
                {
                    @"https://disk.pku.edu.cn:443/link/A866B63467924A54CB7DB67EC386F0B1",
                    @"https://github.com/brechtsanders/winlibs_mingw/releases/download/9.3.0-10.0.0-7.0.0-r3/winlibs-i686-posix-dwarf-gcc-9.3.0-llvm-10.0.0-mingw-w64-7.0.0-r3.7z"
                }
            }
        };



        #region 路径们

        string workspacePath = string.Empty;
        string minGWPath = string.Empty;
        string vsCodePath = null;

        #endregion

        /// <summary>
        /// 存储所有可能的 MinGW 路径。
        /// </summary>
        List<string> minGWPathList = new List<string>();

        public static bool isMinGWPku = true;
        bool isMinGWFirstTime = true;

        public static bool isSuccess = false;
        public static JArray args = new JArray {
            "-g",
            "-std=c++17",
            "\"${file}\"",
            "-o",
            "\"${fileDirname}\\${fileBasenameNoExtension}.exe\""
        };

        public static bool isCpp = true;
        string FileExtension { get { return isCpp ? "cpp" : "c"; } }
        string Compiler { get { return isCpp ? "g++.exe" : "gcc.exe"; } }

        string TestCppCode
        {
            get
            {
                return @"// VS Code C++ 测试代码 ""Hello World""
// 由 VSCodeConfigHelper 生成

// 您可以在当前的文件夹（您第六步输入的文件夹）下编写代码。

// 按下 F5（部分设备上可能是 Fn + F5）编译调试。
// 按下 Ctrl + Shift + B 编译，但不运行。
// 按下 " + (IsInternal ? "Ctrl + F5（部分设备上可能是 Ctrl + Fn + F5）" : "F6（部分设备上可能是 Fn + F6）") + @"编译运行，但不调试。

#include <iostream>

/**
 * 程序执行的入口点。
 */
int main() {
    // 在标准输出中打印 ""Hello, world!""
    std::cout << ""Hello, world!"" << std::endl;
    return 0;
}

// 此文件编译运行将输出 ""Hello, world!""。
// 按下 " + (IsInternal ? "F5 后，您将在下方弹出的终端（Terminal）" : "F6 后，您将在弹出的") + @"窗口中看到这一行字。

// 如果遇到了问题，请您浏览
// https://github.com/Guyutongxue/VSCodeConfigHelper/blob/master/TroubleShooting.md 
// 获取帮助。如果问题未能得到解决，请联系开发者。";
            }
        }
        string TestCCode
        {
            get
            {
                return @"/**
 * VS Code C 测试代码 ""Hello World""
 * 由 VSCodeConfigHelper 生成
 *
 * 您可以在当前的文件夹（您第六步输入的文件夹）下编写代码。
 *
 * 按下 F5（部分设备上可能是 Fn + F5）编译调试。
 * 按下 Ctrl + Shift + B 编译，但不运行。
 * 按下 " + (IsInternal ? "Ctrl + F5（部分设备上可能是 Ctrl + Fn + F5）" : "F6（部分设备上可能是 Fn + F6）") + @"编译运行，但不调试。
 *
 */

#include <stdio.h>
#include <stdlib.h>

/**
 * 程序执行的入口点。
 */
int main(void) {
    /* 在标准输出中打印 ""Hello, world!"" */
    printf(""Hello, world!"");
    return EXIT_SUCCESS;
}

/**
 * 此文件编译运行将输出 ""Hello, world!""。
 * 按下 " + (IsInternal ? "F5 后，您将在下方弹出的终端（Terminal）" : "F6 后，您将在弹出的") + @"窗口中看到这一行字。
 *
 * 如果遇到了问题，请您浏览
 * https://github.com/Guyutongxue/VSCodeConfigHelper/blob/master/TroubleShooting.md
 * 获取帮助。如果问题未能得到解决，请联系开发者。
 * 
 */";
            }
        }

        readonly string consolePauserSrcCode = @"// This Code was licensed under GPL v2 by Bloodshed Dev-C++

// Execute & Pause
// Runs a program, then keeps the console window open after it finishes

#include <string>
using std::string;
#include <stdio.h>
#include <windows.h>

#define MAX_COMMAND_LENGTH 32768
#define MAX_ERROR_LENGTH 2048

LONGLONG GetClockTick() {
    LARGE_INTEGER dummy;
    QueryPerformanceCounter(&dummy);
    return dummy.QuadPart;
}

LONGLONG GetClockFrequency() {
    LARGE_INTEGER dummy;
    QueryPerformanceFrequency(&dummy);
    return dummy.QuadPart;
}

void PauseExit(int exitcode) {
    system(""pause"");
    exit(exitcode);
}

string GetErrorMessage() {
    string result(MAX_ERROR_LENGTH,0);
    
    FormatMessage(
        FORMAT_MESSAGE_FROM_SYSTEM|FORMAT_MESSAGE_IGNORE_INSERTS,
        NULL,GetLastError(),MAKELANGID(LANG_NEUTRAL,SUBLANG_DEFAULT),&result[0],result.size(),NULL);
    
    // Clear newlines at end of string
    for(int i = result.length()-1;i >= 0;i--) {
        if(isspace(result[i])) {
            result[i] = 0;
        } else {
            break;
        }
    }
    return result;
}

string GetCommand(int argc,char** argv) {
    string result;
    for(int i = 1;i < argc;i++) {
        // Quote the first argument in case the path name contains spaces
//        if(i == 1) {
//            result += string(""\"""") + string(argv[i]) + string(""\"""");
//        } else {
            result += string(argv[i]);
//        }
        
        // Add a space except for the last argument
        if(i != (argc-1)) {
            result += string("" "");
        }
    }
    
    if(result.length() > MAX_COMMAND_LENGTH) {
        printf(""\n--------------------------------"");
        printf(""\nError: Length of command line string is over %d characters\n"",MAX_COMMAND_LENGTH);
        PauseExit(EXIT_FAILURE);
    }
    
    return result;
}

DWORD ExecuteCommand(string& command) {
    STARTUPINFO si;
    PROCESS_INFORMATION pi;
    memset(&si,0,sizeof(si));
    si.cb = sizeof(si);
    memset(&pi,0,sizeof(pi));
    
    if(!CreateProcess(NULL, (LPSTR)command.c_str(), NULL, NULL, false, 0, NULL, NULL, &si, &pi)) {
        printf(""\n--------------------------------"");
        printf(""\nFailed to execute \""%s\"":"",command.c_str());
        printf(""\nError %lu: %s\n"",GetLastError(),GetErrorMessage().c_str());
        PauseExit(EXIT_FAILURE);
    }
    WaitForSingleObject(pi.hProcess, INFINITE); // Wait for it to finish
    
    DWORD result = 0;
    GetExitCodeProcess(pi.hProcess, &result);
    return result;
}

int main(int argc, char** argv) {
    
    // First make sure we aren't going to read nonexistent arrays
    if(argc < 2) {
        printf(""\n--------------------------------"");
        printf(""\nUsage: ConsolePauser.exe <filename> <parameters>\n"");
        PauseExit(EXIT_SUCCESS);
    }
    
    // Make us look like the paused program
    SetConsoleTitle(argv[1]);
    
    // Then build the to-run application command
    string command = GetCommand(argc,argv);
    
    // Save starting timestamp
    LONGLONG starttime = GetClockTick();
    
    // Then execute said command
    DWORD returnvalue = ExecuteCommand(command);
    
    // Get ending timestamp
    LONGLONG endtime = GetClockTick();
    double seconds = (endtime - starttime) / (double)GetClockFrequency();

    // Done? Print return value of executed program
    printf(""\n--------------------------------"");
    printf(""\nProcess exited after %.4g seconds with return value %lu\n"",seconds,returnvalue);
    PauseExit(EXIT_SUCCESS);
}";

        public static bool IsRunningOn64Bit { get { return IntPtr.Size == 8; } }

        public static bool IsAdministrator
        {
            get
            {

                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        public bool IsInternal { get { return radioButtonInternal.Checked; } }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControlMain.ItemSize = new Size(0, 1);
            labelAuthor.Text = $"v{Application.ProductVersion} 谷雨同学制作 guyutongxue@163.com";

            string specify = IsRunningOn64Bit ? "64" : "32";
            labelMinGWPathHint.Text = $"您解压后可以得到一个 mingw{specify} 文件夹。这里面包含着重要的编译必需文件，建议您将它移动到妥善的位置，如 C 盘根目录下。将它的路径输入在下面：";

            labelInternalHint.Text = "将使用 VS Code 自带的终端显示程序的输出。您将在代码区的下方看到这个内置终端，从而查看运行和调试的输出。" + Environment.NewLine +
                "因此您无需手动在程序结束之后暂停，您可以随时查看已有的程序输出。但是您可能在查看较长的输出时略显费力。" + Environment.NewLine +
                "这是 VS Code 推荐的输出方式。除非您特有需求，否则建议您选择此样式。";
            labelExternalHint.Text = "将使用 Windows 的终端窗口显示程序的输出。当您运行或调试时，将弹出终端窗口以显示程序输出。" + Environment.NewLine +
                "程序将在运行结束后暂停，但调试结束时不会暂停。这种方式方便您查看长输出以及代码运行的时间。" + Environment.NewLine +
                "这种样式会改变您的全局快捷键设置，因此可能导致冲突。请谨慎使用。";

            // 北大网盘有效期截止至此
            isMinGWPku = DateTime.Now.Date < new DateTime(2024, 10, 1);

            if (IsAdministrator) Text = "管理员: VS Code C++配置工具";

            if (File.Exists("VSCHcache.txt"))
            {
                StreamReader sr = new StreamReader("VSCHcache.txt");
                textBoxMinGWPath.Text = sr.ReadLine();
                textBoxWorkspacePath.Text = sr.ReadLine();
                sr.Close();
            }
        }

        private void ButtonViewMinGW_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxMinGWPath.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void TextBoxMinGWPath_TextChanged(object sender, EventArgs e)
        {
            buttonMinGWNext.Enabled = false;
            minGWPath = textBoxMinGWPath.Text;
            if (!string.IsNullOrWhiteSpace(minGWPath))
            {
                if (Directory.Exists(minGWPath) && File.Exists(minGWPath + "\\bin\\g++.exe"))
                {
                    labelMinGWState.ForeColor = Color.Green;
                    labelMinGWState.Text = "检测到编译器：";
                    string version = GetGxxVersion(minGWPath + "\\bin\\g++.exe");
                    labelMinGWState.Text += '\n' + version;
                    buttonMinGWNext.Enabled = true;
                }
                else
                {
                    labelMinGWState.ForeColor = Color.Red;
                    labelMinGWState.Text = "未检测到编译器，请重试。";
                }
            }

        }

        private void listViewMinGW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isMinGWFirstTime)
            {
                buttonMinGWNext.Enabled = listViewMinGW.SelectedItems.Count == 1;
            }
        }

        private void CheckCurrentMinGW()
        {
            EnvironmentVariableTarget current = IsAdministrator ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.User;
            string[] paths = Environment.GetEnvironmentVariable("Path", current).Split(Path.PathSeparator);
            minGWPathList.Clear();
            foreach (var i in paths)
            {
                if (File.Exists(i + "\\" + Compiler)) minGWPathList.Add(i);
            }
            isMinGWFirstTime = minGWPathList.Count == 0;
            panelMinGWTable.Visible = !isMinGWFirstTime;
            if (isMinGWFirstTime)
            {
                labelMinGWHint.Text = "您还没有安装 MinGW，请您点击右侧链接下载。";
            }
            else
            {
                labelMinGWHint.Text = "您已安装下列编译环境，请选中其中一个作为您的配置。您也可以点击右侧链接下载推荐的 MinGW-w64 环境。";
                listViewMinGW.Items.Clear();
                foreach (var i in minGWPathList)
                {
                    listViewMinGW.Items.Add(GenerateMinGWLVItem(i));
                }
                buttonMinGWNext.Enabled = listViewMinGW.SelectedItems.Count == 1;
            }
        }

        ListViewItem GenerateMinGWLVItem(string path)
        {

            ListViewItem lvi = new ListViewItem();
            lvi.Text = GuessDescription(path + "\\" + Compiler, out string hint);
            if (hint != null)
            {
                lvi.ForeColor = Color.Red;
                lvi.ToolTipText = hint;
            }
            lvi.SubItems.Add(path.Substring(0, path.Length - 4));
            lvi.SubItems.Add(GetGxxVersion(path + "\\" + Compiler));
            return lvi;
        }

        /// <summary>
        /// 输出某编译环境猜测的版本（发行版）
        /// </summary>
        /// <param name="path">编译器的路径</param>
        /// <param name="hint">如果该编译器兼容性较差，则输出提示</param>
        /// <returns></returns>
        private string GuessDescription(string path, out string hint)
        {
            string shortVersion = GetGxxVersion(path);
            string distribute;
            string versionNumber = Regex.Match(shortVersion, " [^ ]+$").Value;
            hint = null;
            if (shortVersion.Contains("tdm64"))
            {
                distribute = "TDM-GCC64";
                if (!IsRunningOn64Bit) hint = "该编译环境并非为 32 位系统设计，可能导致错误。";
            }
            else if (shortVersion.Contains("tdm"))
            {
                distribute = "TDM-GCC";
                if (IsRunningOn64Bit) hint = "该编译环境并非为 64 位系统设计，可能导致错误。";
            }
            else if (shortVersion.Contains("MinGW-W64"))
            {
                if (shortVersion.Contains("x86_64"))
                {

                    distribute = "MinGW-w64";
                    if (!IsRunningOn64Bit) hint = "该编译环境并非为 32 位系统设计，可能导致错误。";
                }
                else
                {
                    distribute = "MinGW-w64(i686)";
                    if (IsRunningOn64Bit) hint = "该编译环境并非为 64 位系统设计，可能导致错误。";
                }
            }
            else if (shortVersion.Contains("MinGW.org"))
            {
                distribute = "MinGW.org";
                if (IsRunningOn64Bit) hint = "该编译环境并非为 64 位系统设计，可能导致错误。";
            }
            else
            {
                string longVersion = GetGxxVersion(path, true);
                distribute = Regex.Match(longVersion, "(?<=Target: ).*$", RegexOptions.Multiline).Value.Split('-').Last();
                distribute = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(distribute);
            }
            if (int.Parse(versionNumber.Split('.').First()) < 5)
            {
                hint = "编译器版本较老，可能无法正常工作。";
            }
            return distribute + " " + versionNumber;
        }

        private static string GetGxxVersion(string path, bool verbose = false)
        {

            string result = string.Empty;
            using (Process proc = new Process())
            {
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.FileName = path;
                proc.StartInfo.Arguments = verbose ? "-v" : "--version";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                proc.WaitForExit();
                if (verbose) result = proc.StandardError.ReadToEnd();
                else result = proc.StandardOutput.ReadLine();
                proc.Close();
            }
            return result;
        }

        private void buttonMinGWAdd_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;

            string result = folderBrowserDialog1.SelectedPath;
            if (File.Exists(result + "\\bin\\" + Compiler))
            {
                listViewMinGW.Items.Add(GenerateMinGWLVItem(result + "\\bin"));
                minGWPathList.Add(result);
            }
            else if (File.Exists(result + "\\" + Compiler))
            {
                listViewMinGW.Items.Add(GenerateMinGWLVItem(result));
                minGWPathList.Add(result.Substring(0, result.Length - 4));
            }
            else
            {
                MessageBox.Show("未检测到有效编译器。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ButtonExtension_Click(object sender, EventArgs e)
        {
            // string cppLink = @"https://marketplace.visualstudio.com/items?itemName=ms-vscode.cpptools";
            // Process.Start(cppLink);
            using (Process proc = new Process())
            {
                proc.StartInfo.FileName = "cmd";
                proc.StartInfo.Arguments = "/C \"" + vsCodePath.ToLower().Replace("code.exe", "bin\\code.cmd") + "\" --install-extension ms-vscode.cpptools & pause";
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
                proc.WaitForExit(30000);
                proc.Close();
            }
            CheckExtension();
        }

        private void LinkLabelMinGW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Process.Start(minGWLinks[minGWDistro,Convert.ToInt32(!IsRunningOn64Bit),Convert.ToInt32(!isMinGWPku)]);
        }


        private void LinkLabelVSCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                string adminSpec = IsAdministrator ? "" : "-user";
                string bitSpec = IsRunningOn64Bit ? "-x64" : "";
                Process.Start("https://update.code.visualstudio.com/latest/win32" + bitSpec + adminSpec + "/stable");
            }
            catch (Exception)
            {
                // Shouldn't be executed
                MessageBox.Show("无法获得直接下载地址，请手动点击下载" + (IsAdministrator ? " System 版本安装包" : "") + "。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("https://code.visualstudio.com/Download");
            }
            // Hint image (Open by browser)
            // No use now
            // Process.Start("https://s2.ax1x.com/2020/01/18/1pRERI.png");
        }

        private void ButtonViewWorkspace_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxWorkspacePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private JObject GetLaunchJson()
        {
            JObject command = new JObject
            {
                {"description", "Enable pretty-printing for gdb"},
                {"text", "-enable-pretty-printing"},
                {"ignoreFailures", true}
            };
            JObject config = new JObject
            {
                {"name", Compiler + " build and debug active file"},
                {"type", "cppdbg"},
                {"request", "launch"},
                {"program", "${fileDirname}\\${fileBasenameNoExtension}.exe"},
                {"args", new JArray()},
                {"stopAtEntry", false},
                {"cwd", "${workspaceFolder}"},
                {"environment", new JArray()},
                {"externalConsole", !IsInternal},
                {"MIMode", "gdb"},
                {"miDebuggerPath", minGWPath+"\\bin\\gdb.exe"},
                {"setupCommands",new JArray{command} },
                {"preLaunchTask", Compiler + " build active file" },
                {"internalConsoleOptions", "neverOpen" }
            };

            JObject launch = new JObject
            {
                { "version", "0.2.0" },
                {"configurations",new JArray{config} }
            };
            return launch;
        }

        private JObject GetTasksJson()
        {
            JObject group = new JObject
            {
                {"kind", "build"},
                {"isDefault", true}
            };
            JObject presentation = new JObject
            {
                {"echo", true},
                {"reveal", "always"},
                {"focus", false},
                {"panel", "shared"},
                {"showReuseMessage", true},
                {"clear", false}
            };
            JObject problemMatcher = new JObject
            {
                { "owner", "cpp" },
                { "fileLocation", "absolute"},
                { "pattern",new JObject{
                    {"regexp", "^(.*):(\\d+):(\\d+):\\s+(error):\\s+(.*)$"},
                    {"file", 1},
                    {"line", 2},
                    {"column", 3},
                    {"severity", 4},
                    {"message", 5}
                } }
            };

            JArray taskList = new JArray
            {
                new JObject
                    {
                        {"type", "shell"},
                        {"label", Compiler + " build active file"},
                        {"command", Compiler},
                        {"args",args},
                        {"group",group},
                        {"presentation",presentation},
                        {"problemMatcher",problemMatcher}
                    }
            };
            // Add another task for external running
            if (!IsInternal)
            {
                taskList.Add(new JObject
                {
                    { "label", "run_pause" },
                    { "type", "shell" },
                    { "command", "cmd"},
                    { "dependsOn", Compiler + " build active file"},
                    { "args", new JArray {
                        "/C",
                        "START",
                        minGWPath + "\\bin\\ConsolePauser.exe",
                        "\"${fileDirname}\\${fileBasenameNoExtension}.exe\""
                    }},
                    { "presentation", new JObject {
                        { "reveal", "never" }
                    }},
                    { "problemMatcher", new JArray()},
                    { "group", new JObject{
                        { "kind", "test" },
                        { "isDefault", true }
                    }}
                });
            }

            JObject tasks = new JObject
            {
                { "version","2.0.0" },
                { "tasks",taskList },
                // https://github.com/microsoft/vscode/issues/70509
                { "options",new JObject
                    { {
                        "shell", new JObject
                        {
                            { "executable", "cmd.exe" },
                            { "args", new JArray("/c") }
                        }
                    } }
                }
            };
            return tasks;
        }

        private JObject GetSettingsJson()
        {
            return new JObject
            {
                {"C_Cpp.default.intelliSenseMode", "gcc-x" + (IsRunningOn64Bit ? "64" : "86")},
                {"C_Cpp.default.compilerPath", minGWPath + "\\bin\\" + Compiler}
            };
        }

        private string GenerateTestFile(string path)
        {
            string filepath = $"{path}\\helloworld." + FileExtension;
            if (File.Exists(filepath))
            {
                for (int i = 1; ; i++)
                {
                    filepath = $"{path}\\helloworld({i})." + FileExtension;
                    if (!File.Exists(filepath)) break;
                }
            }
            // Remove BOM
            StreamWriter sw = new StreamWriter(filepath, false, new UTF8Encoding(false));
            if (isCpp) sw.Write(TestCppCode);
            else sw.Write(TestCCode);
            sw.Flush();
            sw.Close();
            return filepath;
        }

        private string GetVSCodePath(bool crossTest = false)
        {
            RegistryKey root;
            if (IsAdministrator ^ crossTest)
            {
                root = Registry.LocalMachine;
            }
            else
            {
                root = Registry.CurrentUser;
            }
            RegistryKey rk = root.OpenSubKey("SOFTWARE\\Classes\\Applications\\Code.exe\\shell\\open\\command");
            if (rk == null)
            {
                return null;
            }
            string value = (string)rk.GetValue("", null);
            // The value should be like:
            // "C:\Program Files\Microsoft VS Code\Code.exe" --open-url -- "%1"
            // and we just use the string inside the first quatation marks
            value = value.Split('"')[1];
            if (!File.Exists(value)) return null;
            return value;
        }

        private void LoadVSCode(string folderpath, string filepath = null)
        {
            try
            {
                using (Process proc = new Process())
                {
                    // proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    proc.StartInfo.CreateNoWindow = true;
                    // proc.StartInfo.UseShellExecute = true;
                    if (string.IsNullOrEmpty(vsCodePath))
                        throw new Exception("VS Code path not found.");
                    proc.StartInfo.FileName = vsCodePath;
                    if (string.IsNullOrEmpty(filepath))
                    {
                        proc.StartInfo.Arguments = $"\"{folderpath}\"";
                    }
                    else
                    {
                        proc.StartInfo.Arguments = $" -g \"{filepath}:1\" \"{folderpath}\"";
                    }
                    proc.Start();
                    // proc.WaitForExit();
                    proc.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("暂时无法启动 VS Code。" + Environment.NewLine +
                    "这可能是您没有完整安装 VS Code 导致的。请尝试通过本工具重新安装。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                throw new Exception("启动 VS Code 失败。");
            }
        }


        private void LinkLabelManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string manualLink = @"https://github.com/Guyutongxue/VSCodeConfigHelper/blob/master/README.md";
            Process.Start(manualLink);
        }

        private void TextBoxWorkspacePath_TextChanged(object sender, EventArgs e)
        {
            workspacePath = textBoxWorkspacePath.Text;
            if (string.IsNullOrWhiteSpace(workspacePath))
            {
                buttonWelcomeNext.Enabled = false;
                labelWorkspaceStatus.Visible = false;
                return;
            }
            if (!Regex.IsMatch(workspacePath, "^[ -~]*$"))
            {
                buttonWelcomeNext.Enabled = false;
                labelWorkspaceStatus.Visible = true;
            }
            else
            {
                buttonWelcomeNext.Enabled = true;
                labelWorkspaceStatus.Visible = false;
            }
            // If the helloworld.cpp exists already, then do not generate by default
            if (Directory.Exists(textBoxWorkspacePath.Text) &&
                File.Exists(textBoxWorkspacePath.Text + "\\helloworld." + FileExtension))
            {
                checkBoxGenTest.Checked = false;
            }
        }




        private void buttonAuth_Click(object sender, EventArgs e)
        {
            try
            {
                var exeName = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                startInfo.Verb = "runas";
                Process.Start(startInfo);
                Application.Exit();
            }
            catch (Win32Exception)
            {
                // Do nothing.
                // If user cancel the operation by UAC, Process.Start will
                // throw an exception. Just ignore it.
            }
        }

        private void radioButtonPKU_CheckedChanged(object sender, EventArgs e)
        {
            if (isMinGWPku)
            {
                linkLabelMinGW.Text = "下载地址";
            }
            else
            {
                linkLabelMinGW.Text = "下载地址...";
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSuccess)
            {
                DialogResult dr = MessageBox.Show("确定中止本次配置？您所有已进行的配置将被保存。", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                StreamWriter sw = new StreamWriter("VSCHcache.txt");
                sw.WriteLine(minGWPath);
                sw.WriteLine(workspacePath);
                sw.Flush();
                sw.Close();
            }
            else
            {
                if (File.Exists("VSCHcache.txt"))
                {
                    File.Delete("VSCHcache.txt");
                }
            }
        }

        private void buttonWelcomeNext_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(workspacePath + "\\.vscode"))
            {
                DialogResult result = MessageBox.Show("检测到已有配置，是否立即移除它们？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel) return;
                Directory.Delete(workspacePath + "\\.vscode", true);
            }
            workspacePath = textBoxWorkspacePath.Text;
            tabControlMain.SelectedIndex++;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex--;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMinGWNext_Click(object sender, EventArgs e)
        {
            try
            {
                buttonMinGWNext.Enabled = false;
                buttonMinGWNext.Text = "正在设置...";
                Application.DoEvents();
                EnvironmentVariableTarget current = IsAdministrator ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.User;
                string path = Environment.GetEnvironmentVariable("Path", current);
                if (isMinGWFirstTime)
                {
                    GuessDescription(minGWPath + "\\bin\\" + Compiler, out string hint);
                    if (hint != null)
                    {
                        DialogResult dr = MessageBox.Show($"您选择的 MinGW 环境不推荐，因为：{hint} 确定继续吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Cancel) return;
                    }
                    Environment.SetEnvironmentVariable("Path", path + ";" + minGWPath + "\\bin", current);
                }
                else
                {
                    if (!string.IsNullOrEmpty(listViewMinGW.SelectedItems[0].ToolTipText))
                    {
                        DialogResult dr = MessageBox.Show($"您选择的 MinGW 环境不推荐，因为：{listViewMinGW.SelectedItems[0].ToolTipText} 确定继续吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Cancel) return;
                    }
                    minGWPath = listViewMinGW.SelectedItems[0].SubItems[1].Text;
                    // If only one in the list, just ignore.
                    // Because the ony one is detected from PATH, and there is no need to remove or add.
                    if (minGWPathList.Count > 1)
                    {
                        DialogResult dr = MessageBox.Show("程序将从 PATH 环境变量中移除其余 MinGW 环境，但不会删除您的任何文件。确定继续吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Cancel) return;

                        List<string> splitedPath = new List<string>(path.Split(Path.PathSeparator));
                        for (int i = 0; i < splitedPath.Count;)
                        {
                            if (minGWPathList.Contains(splitedPath[i])) splitedPath.RemoveAt(i);
                            else i++;
                        }
                        string result = string.Empty;
                        foreach (var i in splitedPath)
                        {
                            result += i + Path.PathSeparator;
                        }
                        result += minGWPath + "\\bin";
                        Environment.SetEnvironmentVariable("Path", result, current);
                    }
                }
                tabControlMain.SelectedIndex++;
            }
            finally
            {
                buttonMinGWNext.Enabled = true;
                buttonMinGWNext.Text = "下一步";
            }
        }

        void CheckExtension()
        {
            bool isExtensionOk = false;
            using (Process proc = new Process())
            {
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                // The command line aparameter should be passed to batch file not the exe
                proc.StartInfo.FileName = vsCodePath.ToLower().Replace("code.exe", "bin\\code.cmd");
                proc.StartInfo.Arguments = "--list-extensions";
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                // System.Threading.Thread.Sleep(1000);
                proc.WaitForExit(5000);
                while (!proc.StandardOutput.EndOfStream)
                {
                    if (proc.StandardOutput.ReadLine() == "ms-vscode.cpptools")
                    {
                        isExtensionOk = true;
                        break;
                    }
                }
                proc.Close();
            }
            if (isExtensionOk)
            {
                labelExtensionHint.Text = "C/C++ 扩展已安装好。点击下一步以继续。";
                buttonExtension.Enabled = false;
                buttonExtension.Text = "已安装";
                buttonCodeNext.Enabled = true;
            }
            else
            {
                labelExtensionHint.Text = "请点击左侧按钮安装 C/C++ 扩展。";
                buttonExtension.Enabled = true;
                buttonExtension.Text = "安装扩展";
                buttonCodeNext.Enabled = false;
            }
        }

        void CheckCodeAndExtension()
        {
            labelCodeHint.Text = labelExtensionHint.Text = "正在自动检测，请稍候...";
            labelCodeHint.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            buttonCodeNext.Enabled = buttonExtension.Enabled = buttonRefresh.Enabled = false;
            vsCodePath = GetVSCodePath();
            string alternativePathToVSCode = GetVSCodePath(true);
            if (!string.IsNullOrEmpty(vsCodePath))
            {
                labelCodeHint.Text = "检测到已安装VS Code。位于：" + Environment.NewLine + vsCodePath;
                buttonRefresh.Enabled = false;
                buttonRefresh.Text = "已安装";
                CheckExtension();
            }
            else if (!string.IsNullOrEmpty(alternativePathToVSCode))
            {
                vsCodePath = GetVSCodePath(true);
                labelCodeHint.Text = "检测到 VS Code，但是该版本可能与 MinGW 配置发生冲突。建议您点击右侧链接重新安装。";
                labelCodeHint.ForeColor = Color.Red;
                buttonRefresh.Enabled = true;
                buttonRefresh.Text = "刷新";
                CheckExtension();
            }
            else
            {
                labelCodeHint.Text = "未检测到已安装的VS Code。" + Environment.NewLine + "请点击右侧地址下载安装。" + Environment.NewLine + "（若您已安装但未检测到，请您卸载并通过右侧地址重新安装。）";
                labelExtensionHint.Text = "请点击左侧按钮安装 C/C++ 扩展。";
                buttonExtension.Enabled = false;
                buttonExtension.Text = "安装扩展";
                buttonRefresh.Enabled = true;
                buttonRefresh.Text = "刷新";
                buttonCodeNext.Enabled = false;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelNavigate.Refresh();
            switch (tabControlMain.SelectedIndex)
            {
                // If switch to page MinGW, check the Path
                case 1:
                    CheckCurrentMinGW();
                    break;
                // If switch to page Code, check the installation
                case 2:
                    CheckCodeAndExtension();
                    break;
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            CheckCodeAndExtension();
        }

        private void buttonCodeNext_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex++;
        }

        void CompileConsolePauser()
        {
            StreamWriter sw = new StreamWriter(Path.GetTempPath() + "\\ConsolePauser.cpp");
            sw.Write(consolePauserSrcCode);
            sw.Flush();
            sw.Close();

            using (Process proc = new Process())
            {
                proc.StartInfo.FileName = minGWPath + "\\bin\\g++.exe";
                proc.StartInfo.Arguments = $"\"{Path.GetTempPath()}\\ConsolePauser.cpp\" -o \"{minGWPath}\\bin\\ConsolePauser.exe\"";
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                proc.WaitForExit();
                if (proc.ExitCode != 0) throw new Exception("Compilation Error.");
            }

        }

        JArray GetKeyboardBindingJson()
        {
            return new JArray
            {
                new JObject{
                    { "key", "f6" },
                    { "command", "workbench.action.tasks.runTask" },
                    { "args", "run_pause" }
                }
            };
        }

        private void buttonConfigNext_Click(object sender, EventArgs e)
        {
            isSuccess = false;
            try
            {
                JObject launchJson = GetLaunchJson();
                JObject tasksJson = GetTasksJson();
                JObject settingsJson = GetSettingsJson();

                // Kill VS Code process to apply PATH env and prevent occupy
                Process[] processList = Process.GetProcesses();
                foreach (var process in processList)
                {
                    if (process.ProcessName.ToLower() == "code")
                    {
                        process.Kill();
                    }
                }

                if (!IsInternal)
                {
                    if (!File.Exists(minGWPath + "\\bin\\ConsolePauser.exe")) CompileConsolePauser();
                    JArray keybindJson = GetKeyboardBindingJson();
                    StreamWriter keybindsw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Code\\User\\keybindings.json");
                    keybindsw.Write(keybindJson.ToString());
                    keybindsw.Flush();
                    keybindsw.Close();
                }

                Directory.CreateDirectory(workspacePath + "\\.vscode");
                File.SetAttributes(workspacePath + "\\.vscode", FileAttributes.Hidden);
                StreamWriter launchsw = new StreamWriter(workspacePath + "\\.vscode\\launch.json");
                launchsw.Write(launchJson.ToString());
                launchsw.Flush();
                launchsw.Close();
                StreamWriter taskssw = new StreamWriter(workspacePath + "\\.vscode\\tasks.json");
                taskssw.Write(tasksJson.ToString());
                taskssw.Flush();
                taskssw.Close();
                StreamWriter settingssw = new StreamWriter(workspacePath + "\\.vscode\\settings.json");
                settingssw.Write(settingsJson.ToString());
                settingssw.Flush();
                settingssw.Close();
                isSuccess = true;
                tabControlMain.SelectedIndex++;
            }
            catch (Exception)
            {

            }
        }

        public bool CreateDesktopShortcut()
        {
            try
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Visual Studio Code.lnk";
                if (File.Exists(desktop))
                {
                    File.Delete(desktop);
                }
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(desktop);
                shortcut.TargetPath = vsCodePath;
                shortcut.WorkingDirectory = Path.GetDirectoryName(vsCodePath);
                shortcut.WindowStyle = 1; // normal size
                shortcut.Description = "Visual Studio Code";
                shortcut.IconLocation = vsCodePath;
                shortcut.Arguments = $"\"{workspacePath}\"";
                shortcut.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void buttonFinishAll_Click(object sender, EventArgs e)
        {
            if (checkBoxGenTest.Checked)
            {
                string filepath = GenerateTestFile(workspacePath);
                if (checkBoxOpen.Checked) LoadVSCode(workspacePath, filepath);
            }
            else if (checkBoxOpen.Checked) LoadVSCode(workspacePath);
            if (checkBoxDesktopShortcut.Checked) CreateDesktopShortcut();
            Close();
        }

        private void panelNavigate_Paint(object sender, PaintEventArgs e)
        {
            string[] texts =
            {
                "- 欢迎",
                "- 配置 MinGW",
                "- 安装扩展",
                "- 选择样式",
                "- 完成"
            };
            Point pt;
            int index = tabControlMain.SelectedIndex;
            int height = 20;
            for (int i = 0; i < index; i++)
            {
                pt = new Point(0, i * height);
                TextRenderer.DrawText(e.Graphics, texts[i] + Environment.NewLine, new Font(FontFamily.GenericSerif, 9, FontStyle.Regular), pt, Color.Black);
            }
            pt = new Point(0, index * height);
            TextRenderer.DrawText(e.Graphics, texts[index] + Environment.NewLine, new Font(FontFamily.GenericSerif, 9, FontStyle.Bold), pt, Color.Black);
            for (int i = index + 1; i < 5; i++)
            {
                pt = new Point(0, i * height);
                TextRenderer.DrawText(e.Graphics, texts[i] + Environment.NewLine, new Font(FontFamily.GenericSerif, 9, FontStyle.Regular), pt, Color.Gray);
            }
        }
    }
}
