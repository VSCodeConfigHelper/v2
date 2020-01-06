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
using System.Diagnostics;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSCodeConfigHelper
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string minGWPath = string.Empty;
        bool isMinGWOk = false;
        bool isWorkspaceOk = false;
        static readonly string helpText =
            "========================================" + Environment.NewLine +
            "什么是 MinGW-w64 ？" + Environment.NewLine +
            "----------------------------------------" + Environment.NewLine +
            "MinGW (Minimalist GNU for Windows)，是一个适用于" +
            "Windows 应用程序的极简开发环境， 提供了一个完整的" +
            "开源编程工具集，Mingw-w64 则是 MinGW 的“升级版” " +
            "，提供了对 64 位计算机的支持。" + Environment.NewLine +
             Environment.NewLine + Environment.NewLine +
            "========================================" + Environment.NewLine +
            "下载下来的 MinGW-w64 文件打不开，怎么办？" + Environment.NewLine +
            "----------------------------------------" + Environment.NewLine +
            "您刚刚所下载的文件是 7-Zip 格式，一种效率较高的压" +
            "缩文件。您可以通过任何主流的解压缩工具（如 WinRAR、" +
            "Bandizip 等）解压，也可以使用专门的 7-Zip 工具（ht" +
            "tps://www.7-zip.org/）解压。" + Environment.NewLine +
            Environment.NewLine + Environment.NewLine +
            "========================================" + Environment.NewLine +
            "设置环境变量是什么意思？" + Environment.NewLine +
            "----------------------------------------" + Environment.NewLine +
            "环境变量是指在操作系统中用来指定操作系统运行环境" +
            "的一些参数。这里的设置是将 MinGW 相关程序添加到 " +
            "Path 这一环境变量当中，允许用户可以轻松地键入 `g" +
            "++` 等命令直接编译。" + Environment.NewLine +
            Environment.NewLine + Environment.NewLine +
            "========================================" + Environment.NewLine +
            "“安装插件”是在做什么？" + Environment.NewLine +
            "----------------------------------------" + Environment.NewLine +
            "VS Code 本身仅仅是一个文本编辑器，正是由于它强大的" +
            "插件生态，才能让它实现程序的编译、运行和调试。这里" +
            "安装的插件是微软官方制作的 C/C++ 插件，提供了简洁易" +
            "用的调试和 IntelliSense 智能提示功能。" + Environment.NewLine +
            Environment.NewLine + Environment.NewLine +
            "========================================" + Environment.NewLine +
            "为什么要选择工作文件夹？“一键配置”都做了什么？" + Environment.NewLine +
            "----------------------------------------" + Environment.NewLine +
            " VS Code 的核心理念和 Visual Studio 类似也是基于" +
            "“项目”这一基本单位的。在 VS Code 中，项目的表现形" +
            "式就是“工作区”（Workspace）。您的一切编译、运行配" +
            "置都只适用于工作区内部，这样您可以针对不同的语言、" +
            "不同的用途进行个性化的配置。" + Environment.NewLine +
            "当 VS Code 打开工作区文件夹时，会读取 `.vscode` 子" +
            "文件夹内部的数个 JSON 文件作为配置信息。这些 JSON " +
            "文件将通过固定的格式指示 VS Code 如何调用编译器，" +
            "如何调试，并提供运行路径等必要的信息。本工具所做的就" +
            "是通过您输入的 MinGW 路径自动配置好上述 JSON 文件。" +
            Environment.NewLine + Environment.NewLine +
            "========================================" + Environment.NewLine +
            "为什么工作文件夹不支持中文？" + Environment.NewLine +
            "----------------------------------------" + Environment.NewLine +
            "由于 MinGW 中 gdb 调试器并不支持 Unicode (UTF-16) 编码" +
            "的路径参数，详情可见 https://github.com/Microsoft/vscode-cpptools/issues/1998 " +
            "的讨论。对此我感到十分抱歉，还请您尝试其它命名，谢谢。" +
            Environment.NewLine + Environment.NewLine +
            "========================================" + Environment.NewLine +
            "如果您还有相关问题，欢迎通过下方的邮件地址联系开发者" +
            "谷雨同学。"
            ;

        public static bool IsRunningOn64Bit { get { return IntPtr.Size == 8; } }
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
            isMinGWOk = false;
            if (!string.IsNullOrWhiteSpace(textBoxMinGWPath.Text))
            {
                if (Directory.Exists(textBoxMinGWPath.Text) && File.Exists(textBoxMinGWPath.Text + "\\bin\\g++.exe"))
                {
                    labelMinGWState.ForeColor = Color.Green;
                    labelMinGWState.Text = "检测到编译器：";
                    string version = GetGxxVersion(textBoxMinGWPath.Text + "\\bin\\g++.exe");
                    labelMinGWState.Text += '\n' + version;
                    // prevent duplicate
                    minGWPath = textBoxMinGWPath.Text.ToLower();
                    isMinGWOk = true;
                }
                else
                {
                    labelMinGWState.ForeColor = Color.Red;
                    labelMinGWState.Text = "未检测到编译器，请重试。";

                }
            }

        }

        private void ButtonSetEnv_Click(object sender, EventArgs e)
        {
            if (!isMinGWOk)
            {
                labelPathState.ForeColor = Color.Red;
                labelPathState.Text = "MinGW 路径尚未配置完成。";
                return;
            }
            string path = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            if (path.Contains(minGWPath + "\\bin"))
            {
                labelPathState.ForeColor = Color.Green;
                labelPathState.Text = "环境变量已设置。";
                return;
            }
            Environment.SetEnvironmentVariable("Path", path + ";" + minGWPath + "\\bin", EnvironmentVariableTarget.Machine);
            // Check
            path = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            if (path.Contains(minGWPath + "\\bin"))
            {
                labelPathState.ForeColor = Color.Green;
                labelPathState.Text = "设置环境变量成功。";
            }
            else
            {
                labelPathState.ForeColor = Color.Red;
                labelPathState.Text = "设置环境变量失败，请重试。";
            }
        }

        public static string GetGxxVersion(string path)
        {

            string result = string.Empty;
            using (Process proc = new Process())
            {
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.FileName = path;
                proc.StartInfo.Arguments = "--version";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                result = proc.StandardOutput.ReadLine();
                proc.WaitForExit();
                proc.Close();
            }
            return result;
        }

        private void ButtonExtension_Click(object sender, EventArgs e)
        {
            string cppLink = @"https://marketplace.visualstudio.com/items?itemName=ms-vscode.cpptools";
            Process.Start(cppLink);
        }

        private void LinkLabelMinGW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mingwLink;
            if (IsRunningOn64Bit)
                mingwLink = @"https://sourceforge.net/projects/mingw-w64/files/Toolchains%20targetting%20Win64/Personal%20Builds/mingw-builds/8.1.0/threads-win32/seh/x86_64-8.1.0-release-win32-seh-rt_v6-rev0.7z";
            else
                mingwLink = @"https://sourceforge.net/projects/mingw-w64/files/Toolchains%20targetting%20Win32/Personal%20Builds/mingw-builds/8.1.0/threads-win32/dwarf/i686-8.1.0-release-win32-dwarf-rt_v6-rev0.7z";
            Process.Start(mingwLink);
        }


        private void LinkLabelVSCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string vsCodeLink = @"https://code.visualstudio.com/#alt-downloads";
            Process.Start(vsCodeLink);
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
                {"name", "g++.exe build and debug active file"},
                {"type", "cppdbg"},
                {"request", "launch"},
                {"program", "${fileDirname}\\${fileBasenameNoExtension}.exe"},
                {"args", new JArray()},
                {"stopAtEntry", false},
                {"cwd", "${workspaceFolder}"},
                {"environment", new JArray()},
                {"externalConsole", false},
                {"MIMode", "gdb"},
                {"miDebuggerPath", minGWPath+"\\bin\\gdb.exe"},
                {"setupCommands",new JArray{command} },
                {"preLaunchTask", "g++.exe build active file" },
                {"internalConsoleOptions", "neverOpen" }
            };

            JObject launch = new JObject
            {
                { "version", "0.2.0" },
                {"configurations",new JArray{config} }
            };
            return launch;
        }

        private JObject getTasksJson()
        {
            JArray args = new JArray
            {
                "-g",
                "-std=c++17",
                "${file}",
                "-o",
                "${fileDirname}\\${fileBasenameNoExtension}.exe"
            };
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
            JObject tasks = new JObject
            {
                { "version","2.0.0" },
                { "tasks",new JArray
                    {
                        new JObject
                        {
                            {"type", "shell"},
                            {"label", "g++.exe build active file"},
                            {"command", "g++.exe"},
                            {"args",args},
                            {"group",group},
                            {"presentation",presentation},
                            {"problemMatcher",problemMatcher}
                        }
                    }
                }
            };
            return tasks;
        }

        private JObject GetSettingsJson()
        {
            return new JObject
            {{
                "C_Cpp.default.intelliSenseMode", "gcc-x64"
            }};
        }

        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            try
            {
                string workspacePath = textBoxWorkspacePath.Text;
                JObject launchJson = GetLaunchJson();
                JObject tasksJson = getTasksJson();
                JObject settingsJson = GetSettingsJson();
                if (!isWorkspaceOk || !isMinGWOk)
                {
                    labelConfigState.ForeColor = Color.Red;
                    labelConfigState.Text = "MinGW 路径或工作文件夹尚未配置完成。";
                    return;
                }
                if (Directory.Exists(workspacePath + "\\.vscode"))
                {
                    labelConfigState.ForeColor = Color.Red;
                    labelConfigState.Text = "检测到已有配置，若继续请先删除 .vscode 文件夹。";
                    return;
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
                labelConfigState.ForeColor = Color.Green;
                labelConfigState.Text = "配置成功。";
            }
            catch (Exception ex)
            {
                labelConfigState.ForeColor = Color.Red;
                labelConfigState.Text = "配置失败：" + ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxHelp.Text = helpText;
        }

        private void LinkLabelManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string manualLink = @"https://github.com/Guyutongxue/VSCodeConfigHelper/blob/master/README.md";
            Process.Start(manualLink);
        }

        private void TextBoxWorkspacePath_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxWorkspacePath.Text))
            {
                isWorkspaceOk = false;
                labelWorkspaceStatus.Visible = false;
                return;
            }
            if (!Regex.IsMatch(textBoxWorkspacePath.Text, "^[ -~]*$"))
            {
                isWorkspaceOk = false;
                labelWorkspaceStatus.Visible = true;
            }
            else
            {
                isWorkspaceOk = true;
                labelWorkspaceStatus.Visible = false;
            }
        }
    }
}
