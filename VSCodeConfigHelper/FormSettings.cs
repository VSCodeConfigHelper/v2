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
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Cache;
using System.Net;

namespace VSCodeConfigHelper
{
    public partial class FormSettings : Form
    {

        #region Add Shield Icon

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        ///     Enables the elevated shield icon on the given button control
        /// </summary>
        /// <param name="ThisButton">
        ///     Button control to enable the elevated shield icon on.
        /// </param>
        private void EnableElevateIcon_BCM_SETSHIELD(Button ThisButton)
        {
            // Input validation, validate that ThisControl is not null
            if (ThisButton == null) return;

            // Define BCM_SETSHIELD locally, declared originally in Commctrl.h
            uint BCM_SETSHIELD = 0x0000160C;

            // Set button style to the system style
            ThisButton.FlatStyle = FlatStyle.System;

            // Send the BCM_SETSHIELD message to the button control
            SendMessage(new HandleRef(ThisButton, ThisButton.Handle), BCM_SETSHIELD, new IntPtr(0), new IntPtr(1));
        }
        #endregion

        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonSaveArgs_Click(object sender, EventArgs e)
        {

            GenerateArgs();
            ShowArgs();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Date > new DateTime(2024, 10, 1)) radioButtonDisk.Enabled = false;
            if (Form1.isMinGWDisk)
                radioButtonDisk.Checked = true;
            else
                radioButtonOffical.Checked = true;

            switch (Form1.minGWDistro)
            {
                case 0:
                    radioButtonGytx.Checked = true;
                    break;
                case 1:
                    radioButtonTDM.Checked = true;
                    break;
                case 2:
                    radioButtonOfficial.Checked = true;
                    break;
            }
            string tempStandard = Form1.standard;
            if (Form1.isCpp)
                comboBoxLang.SelectedIndex = 0;
            else
                comboBoxLang.SelectedIndex = 1;
            LoadStandardComboBox();
            comboBoxStandard.Text = tempStandard;
            if (Form1.IsAdministrator)
            {
                labelAuth.Width = 409;
                labelAuth.Text = "当前权限：系统管理员" + Environment.NewLine;
                labelAuth.Text += "您在此工具进行的操作（包括安装、设置环境变量和启动等）" +
                    "将适用于所有用户，请谨慎操作。" + Environment.NewLine;
                labelAuth.Text += "若要使用普通用户权限，请重新使用非管理员权限运行此程序。";
                buttonAuth.Visible = false;

            }
            else
            {
                labelAuth.Text = "当前权限：普通用户" + Environment.NewLine;
                labelAuth.Text += "您在此工具进行的操作（包括安装、设置环境变量和启动等）" +
                    "将仅适用于此账户。" + Environment.NewLine;
                labelAuth.Text += "若要使用系统管理员权限，请点击右侧按钮。";
                EnableElevateIcon_BCM_SETSHIELD(buttonAuth);
            }
            labelDistroHint.Text =
                "谷雨同学个人搭建的版本集成了最新版本的编译器。"+ Environment.NewLine +
                "TDM-GCC 是基于 MinGW 的另一发行版，提供了一些优化。"+ Environment.NewLine +
                "官方版本是最稳定、最常用的版本，但是长期未更新。";
            ShowArgs();
        }

        private void LoadStandardComboBox()
        {
            if (comboBoxLang.SelectedIndex == 0)
            {
                comboBoxStandard.Items.Clear();
                comboBoxStandard.Items.AddRange(new string[]
                {
                    "c++98",
                    "c++03",
                    "c++11",
                    "c++14",
                    "c++17",
                    "c++20"
                });
                comboBoxStandard.Text = Form1.ChosenMinGW.standard;
                //comboBoxStandard.SelectedIndex = 4;
                //// WinLibs (g++10.1) supports C++20 partly
                //if (radioButtonOfficial.Checked)
                //    comboBoxStandard.SelectedIndex = 5;
            }
            else
            {
                comboBoxStandard.Items.Clear();
                comboBoxStandard.Items.AddRange(new string[]
                {
                    "c89",
                    "c99",
                    "c11",
                    "c18"
                });
                comboBoxStandard.SelectedIndex = 3;
            }
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.isMinGWDisk = radioButtonDisk.Checked;
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            try
            {
                var exeName = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                startInfo.Verb = "runas";
                // prevent pop-up message box
                Form1.isSuccess = true;
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

        private void GenerateArgs()
        {
            string text = textBoxArgs.Text.Trim();
            string[] argtext = text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            Form1.args = new JArray(argtext);
        }

        private void ShowArgs()
        {
            StringBuilder text = new StringBuilder();
            foreach (object i in Form1.args)
            {
                text.AppendLine(i.ToString());
            }
            textBoxArgs.Text = text.ToString().Trim();
        }

        private void SetDefaultArgs()
        {
            Form1.args = Form1.GetDefaultArgs();
            ShowArgs();
        }

        private void buttonArgDefault_Click(object sender, EventArgs e)
        {
            SetDefaultArgs();
        }

        /// <summary>
        /// 检测更新。
        /// </summary>
        /// <param name="show">是否在未检测到更新或出现错误时提示</param>
        public static void CheckUpdate(bool show)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                HttpWebRequest request = WebRequest.CreateHttp("https://api.github.com/repos/Guyutongxue/VSCodeConfigHelper3/releases/latest");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36 Edg/81.0.416.72";
                request.Method = "GET";
                request.Timeout = 10000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                JObject versionInfo = (JObject)JsonConvert.DeserializeObject(sr.ReadToEnd());
                sr.Close();
                response.Close();
                string latest = ((string)versionInfo["tag_name"]).Substring(1);
                if (show || !File.Exists("VSCHcache.txt"))
                {
                    DialogResult result = MessageBox.Show(
                        $"检测到新版本。{Environment.NewLine}最新版本：{latest}{Environment.NewLine}当前版本：{Application.ProductVersion}{Environment.NewLine}是否前往下载？",
                        "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information
                    );
                    if (result == DialogResult.Yes) Process.Start("https://vscch3.vercel.app");
                }
            }
            catch (Exception ex)
            {
                if (show) MessageBox.Show("检测更新时发生异常：" + ex.Message);
            }
            finally
            {
            }
        }


        // https://countapi.xyz/
        // with namespace 'guyutongxue.github.io', key: b54f2252-e54a-4bd0-b4c2-33b47db6aa98
        public static string HitCount()
        {
            try
            {
                // Logging.Log("Hit a count.");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                HttpWebRequest request = WebRequest.CreateHttp("https://api.countapi.xyz/hit/guyutongxue.github.io/b54f2252-e54a-4bd0-b4c2-33b47db6aa98");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36 Edg/81.0.416.72";
                request.Method = "GET";
                request.Timeout = 5000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                return sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                Logging.Log($"Error occured while hitting counts: {ex.Message}", LogType.Error);
                return null;
            }
        }

        private void linkLabelLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.gnu.org/licenses/gpl-2.0.html");
        }

        private void pictureGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Guyutongxue/VSCodeConfigHelper");
        }

        private void radioButtonMinGWw64_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGytx.Checked) Form1.minGWDistro = 0;
            LoadStandardComboBox();
        }

        private void radioButtonTDM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTDM.Checked) Form1.minGWDistro = 1;
            LoadStandardComboBox();
        }

        private void radioButtonWinLibs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOfficial.Checked) Form1.minGWDistro = 2;
            LoadStandardComboBox();
        }

        private void linkLabelMinGWw64_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sourceforge.net/projects/mingw-w64/");
        }

        private void linkLabelTDM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jmeubank.github.io/tdm-gcc/");
        }

        private void linkLabelWinLibs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://winlibs.com/");
        }

        private void comboBoxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.isCpp = comboBoxLang.SelectedIndex == 0;
            LoadStandardComboBox();
        }


        private void comboBoxStandard_TextChanged(object sender, EventArgs e)
        {
            Form1.standard = comboBoxStandard.Text;
            SetDefaultArgs();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonUpdate.Text = "正在连接服务器，请稍候……";
            CheckUpdate(true);
            buttonUpdate.Enabled = true;
            buttonUpdate.Text = "检查 VS Code Config Helper 更新";
        }
    }
}
