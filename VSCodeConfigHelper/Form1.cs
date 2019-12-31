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

        private void ButtonViewMinGW_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                textBoxMinGWPath.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void TextBoxMinGWPath_TextChanged(object sender, EventArgs e)
        {
            isMinGWOk = false;
            if (textBoxMinGWPath.Text != string.Empty)
            {
                if (Directory.Exists(textBoxMinGWPath.Text) && File.Exists(textBoxMinGWPath.Text + "\\bin\\g++.exe"))
                {
                    labelMinGWState.ForeColor = Color.Green;
                    labelMinGWState.Text = "检测到编译器：";
                    string version = GetGxxVersion(textBoxMinGWPath.Text + "\\bin\\g++.exe");
                    labelMinGWState.Text += '\n' + version;
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
                labelPathState.Text = "MinGW路径 尚未配置完成。";
                return;
            }
            string path = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("PATH") + ";" + minGWPath + "\\bin", EnvironmentVariableTarget.Machine);
            if (path.Contains(minGWPath))
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
            string mingw64Link = @"https://sourceforge.net/projects/mingw-w64/files/";
            Process.Start(mingw64Link);
        }

        private void LinkLabelVSCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string vsCodeLink = @"https://code.visualstudio.com/#alt-downloads";
            Process.Start(vsCodeLink);
        }

        private void ButtonViewWorkspace_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
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
                if (workspacePath == string.Empty || minGWPath == string.Empty)
                {
                    labelConfigState.ForeColor = Color.Red;
                    labelConfigState.Text = "MinGW路径 或 工作文件夹 尚未配置完成。";
                    return;
                }
                if(Directory.Exists(workspacePath + "\\.vscode"))
                {
                    labelConfigState.ForeColor = Color.Red;
                    labelConfigState.Text = "检测到已有配置，若继续请先删除 .vscode 文件夹。";
                    return;
                }
                Directory.CreateDirectory(workspacePath + "\\.vscode");
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
    }
}
