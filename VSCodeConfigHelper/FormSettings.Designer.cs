namespace VSCodeConfigHelper
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.groupBoxPrivil = new System.Windows.Forms.GroupBox();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.labelAuth = new System.Windows.Forms.Label();
            this.groupBoxArg = new System.Windows.Forms.GroupBox();
            this.buttonArgDefault = new System.Windows.Forms.Button();
            this.labelArgInstruction = new System.Windows.Forms.Label();
            this.buttonSaveArgs = new System.Windows.Forms.Button();
            this.labelArgWarning = new System.Windows.Forms.Label();
            this.textBoxArgs = new System.Windows.Forms.TextBox();
            this.groupBoxMinGWSrc = new System.Windows.Forms.GroupBox();
            this.labelMinGWSrcInstruction = new System.Windows.Forms.Label();
            this.radioButtonOffical = new System.Windows.Forms.RadioButton();
            this.radioButtonDisk = new System.Windows.Forms.RadioButton();
            this.linkLabelLicense = new System.Windows.Forms.LinkLabel();
            this.pictureGitHub = new System.Windows.Forms.PictureBox();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageDownload = new System.Windows.Forms.TabPage();
            this.groupBoxMinGWDistro = new System.Windows.Forms.GroupBox();
            this.linkLabelTDM = new System.Windows.Forms.LinkLabel();
            this.linkLabelMinGWw64 = new System.Windows.Forms.LinkLabel();
            this.labelDistroHint = new System.Windows.Forms.Label();
            this.radioButtonOfficial = new System.Windows.Forms.RadioButton();
            this.radioButtonGytx = new System.Windows.Forms.RadioButton();
            this.radioButtonTDM = new System.Windows.Forms.RadioButton();
            this.tabPageInstall = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.groupBoxStandard = new System.Windows.Forms.GroupBox();
            this.labelStandard = new System.Windows.Forms.Label();
            this.labelLang = new System.Windows.Forms.Label();
            this.comboBoxLang = new System.Windows.Forms.ComboBox();
            this.comboBoxStandard = new System.Windows.Forms.ComboBox();
            this.groupBoxPrivil.SuspendLayout();
            this.groupBoxArg.SuspendLayout();
            this.groupBoxMinGWSrc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGitHub)).BeginInit();
            this.tabControlSettings.SuspendLayout();
            this.tabPageDownload.SuspendLayout();
            this.groupBoxMinGWDistro.SuspendLayout();
            this.tabPageInstall.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.groupBoxStandard.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPrivil
            // 
            this.groupBoxPrivil.Controls.Add(this.buttonAuth);
            this.groupBoxPrivil.Controls.Add(this.labelAuth);
            this.groupBoxPrivil.Location = new System.Drawing.Point(2, 5);
            this.groupBoxPrivil.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPrivil.Name = "groupBoxPrivil";
            this.groupBoxPrivil.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPrivil.Size = new System.Drawing.Size(308, 132);
            this.groupBoxPrivil.TabIndex = 9;
            this.groupBoxPrivil.TabStop = false;
            this.groupBoxPrivil.Text = "当前权限";
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(196, 58);
            this.buttonAuth.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(106, 23);
            this.buttonAuth.TabIndex = 0;
            this.buttonAuth.Text = "使用管理员身份";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // labelAuth
            // 
            this.labelAuth.Location = new System.Drawing.Point(4, 17);
            this.labelAuth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(187, 113);
            this.labelAuth.TabIndex = 1;
            // 
            // groupBoxArg
            // 
            this.groupBoxArg.Controls.Add(this.buttonArgDefault);
            this.groupBoxArg.Controls.Add(this.labelArgInstruction);
            this.groupBoxArg.Controls.Add(this.buttonSaveArgs);
            this.groupBoxArg.Controls.Add(this.labelArgWarning);
            this.groupBoxArg.Controls.Add(this.textBoxArgs);
            this.groupBoxArg.Location = new System.Drawing.Point(2, 54);
            this.groupBoxArg.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxArg.Name = "groupBoxArg";
            this.groupBoxArg.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxArg.Size = new System.Drawing.Size(308, 167);
            this.groupBoxArg.TabIndex = 8;
            this.groupBoxArg.TabStop = false;
            this.groupBoxArg.Text = "配置编译参数";
            // 
            // buttonArgDefault
            // 
            this.buttonArgDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonArgDefault.Location = new System.Drawing.Point(4, 139);
            this.buttonArgDefault.Margin = new System.Windows.Forms.Padding(2);
            this.buttonArgDefault.Name = "buttonArgDefault";
            this.buttonArgDefault.Size = new System.Drawing.Size(63, 23);
            this.buttonArgDefault.TabIndex = 2;
            this.buttonArgDefault.Text = "恢复默认";
            this.buttonArgDefault.UseVisualStyleBackColor = true;
            this.buttonArgDefault.Click += new System.EventHandler(this.buttonArgDefault_Click);
            // 
            // labelArgInstruction
            // 
            this.labelArgInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelArgInstruction.Location = new System.Drawing.Point(140, 138);
            this.labelArgInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArgInstruction.Name = "labelArgInstruction";
            this.labelArgInstruction.Size = new System.Drawing.Size(170, 24);
            this.labelArgInstruction.TabIndex = 5;
            this.labelArgInstruction.Text = "每行一个参数；支持 VS Code 配置变量。";
            // 
            // buttonSaveArgs
            // 
            this.buttonSaveArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveArgs.Location = new System.Drawing.Point(72, 139);
            this.buttonSaveArgs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveArgs.Name = "buttonSaveArgs";
            this.buttonSaveArgs.Size = new System.Drawing.Size(63, 23);
            this.buttonSaveArgs.TabIndex = 4;
            this.buttonSaveArgs.Text = "保存";
            this.buttonSaveArgs.UseVisualStyleBackColor = true;
            this.buttonSaveArgs.Click += new System.EventHandler(this.buttonSaveArgs_Click);
            // 
            // labelArgWarning
            // 
            this.labelArgWarning.AutoSize = true;
            this.labelArgWarning.ForeColor = System.Drawing.Color.Red;
            this.labelArgWarning.Location = new System.Drawing.Point(4, 17);
            this.labelArgWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArgWarning.Name = "labelArgWarning";
            this.labelArgWarning.Size = new System.Drawing.Size(293, 12);
            this.labelArgWarning.TabIndex = 3;
            this.labelArgWarning.Text = "除非您知道自己在做什么，否则不要改动这里的内容。";
            // 
            // textBoxArgs
            // 
            this.textBoxArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArgs.Location = new System.Drawing.Point(7, 39);
            this.textBoxArgs.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxArgs.Multiline = true;
            this.textBoxArgs.Name = "textBoxArgs";
            this.textBoxArgs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxArgs.Size = new System.Drawing.Size(298, 96);
            this.textBoxArgs.TabIndex = 2;
            // 
            // groupBoxMinGWSrc
            // 
            this.groupBoxMinGWSrc.Controls.Add(this.labelMinGWSrcInstruction);
            this.groupBoxMinGWSrc.Controls.Add(this.radioButtonOffical);
            this.groupBoxMinGWSrc.Controls.Add(this.radioButtonDisk);
            this.groupBoxMinGWSrc.Location = new System.Drawing.Point(2, 5);
            this.groupBoxMinGWSrc.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMinGWSrc.Name = "groupBoxMinGWSrc";
            this.groupBoxMinGWSrc.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMinGWSrc.Size = new System.Drawing.Size(308, 72);
            this.groupBoxMinGWSrc.TabIndex = 7;
            this.groupBoxMinGWSrc.TabStop = false;
            this.groupBoxMinGWSrc.Text = "选择 MinGW 下载源";
            // 
            // labelMinGWSrcInstruction
            // 
            this.labelMinGWSrcInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinGWSrcInstruction.Location = new System.Drawing.Point(4, 46);
            this.labelMinGWSrcInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinGWSrcInstruction.Name = "labelMinGWSrcInstruction";
            this.labelMinGWSrcInstruction.Size = new System.Drawing.Size(299, 24);
            this.labelMinGWSrcInstruction.TabIndex = 2;
            this.labelMinGWSrcInstruction.Text = "网盘下载快速稳定，但有可能失效。官方下载长期有效，但速度受网络环境所限制。";
            // 
            // radioButtonOffical
            // 
            this.radioButtonOffical.AutoSize = true;
            this.radioButtonOffical.Location = new System.Drawing.Point(164, 19);
            this.radioButtonOffical.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonOffical.Name = "radioButtonOffical";
            this.radioButtonOffical.Size = new System.Drawing.Size(47, 16);
            this.radioButtonOffical.TabIndex = 1;
            this.radioButtonOffical.Text = "官方";
            this.radioButtonOffical.UseVisualStyleBackColor = true;
            // 
            // radioButtonDisk
            // 
            this.radioButtonDisk.AutoSize = true;
            this.radioButtonDisk.Checked = true;
            this.radioButtonDisk.Location = new System.Drawing.Point(34, 19);
            this.radioButtonDisk.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDisk.Name = "radioButtonDisk";
            this.radioButtonDisk.Size = new System.Drawing.Size(47, 16);
            this.radioButtonDisk.TabIndex = 1;
            this.radioButtonDisk.TabStop = true;
            this.radioButtonDisk.Text = "网盘";
            this.radioButtonDisk.UseVisualStyleBackColor = true;
            // 
            // linkLabelLicense
            // 
            this.linkLabelLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelLicense.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelLicense.Location = new System.Drawing.Point(14, 310);
            this.linkLabelLicense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelLicense.Name = "linkLabelLicense";
            this.linkLabelLicense.Size = new System.Drawing.Size(260, 24);
            this.linkLabelLicense.TabIndex = 10;
            this.linkLabelLicense.TabStop = true;
            this.linkLabelLicense.Text = "VSCodeConfigHelper 是自由软件，你可以基于 GPLv2 协议进行再发行或修改。";
            this.linkLabelLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLicense_LinkClicked);
            // 
            // pictureGitHub
            // 
            this.pictureGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureGitHub.Image = ((System.Drawing.Image)(resources.GetObject("pictureGitHub.Image")));
            this.pictureGitHub.Location = new System.Drawing.Point(287, 299);
            this.pictureGitHub.Margin = new System.Windows.Forms.Padding(2);
            this.pictureGitHub.Name = "pictureGitHub";
            this.pictureGitHub.Size = new System.Drawing.Size(38, 40);
            this.pictureGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGitHub.TabIndex = 11;
            this.pictureGitHub.TabStop = false;
            this.pictureGitHub.Click += new System.EventHandler(this.pictureGitHub_Click);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageDownload);
            this.tabControlSettings.Controls.Add(this.tabPageInstall);
            this.tabControlSettings.Controls.Add(this.tabPageConfig);
            this.tabControlSettings.Location = new System.Drawing.Point(9, 10);
            this.tabControlSettings.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(319, 284);
            this.tabControlSettings.TabIndex = 12;
            // 
            // tabPageDownload
            // 
            this.tabPageDownload.Controls.Add(this.groupBoxMinGWDistro);
            this.tabPageDownload.Controls.Add(this.groupBoxMinGWSrc);
            this.tabPageDownload.Location = new System.Drawing.Point(4, 22);
            this.tabPageDownload.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDownload.Name = "tabPageDownload";
            this.tabPageDownload.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDownload.Size = new System.Drawing.Size(311, 258);
            this.tabPageDownload.TabIndex = 0;
            this.tabPageDownload.Text = "下载";
            this.tabPageDownload.UseVisualStyleBackColor = true;
            // 
            // groupBoxMinGWDistro
            // 
            this.groupBoxMinGWDistro.Controls.Add(this.linkLabelTDM);
            this.groupBoxMinGWDistro.Controls.Add(this.linkLabelMinGWw64);
            this.groupBoxMinGWDistro.Controls.Add(this.labelDistroHint);
            this.groupBoxMinGWDistro.Controls.Add(this.radioButtonOfficial);
            this.groupBoxMinGWDistro.Controls.Add(this.radioButtonGytx);
            this.groupBoxMinGWDistro.Controls.Add(this.radioButtonTDM);
            this.groupBoxMinGWDistro.Location = new System.Drawing.Point(2, 82);
            this.groupBoxMinGWDistro.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMinGWDistro.Name = "groupBoxMinGWDistro";
            this.groupBoxMinGWDistro.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMinGWDistro.Size = new System.Drawing.Size(308, 174);
            this.groupBoxMinGWDistro.TabIndex = 8;
            this.groupBoxMinGWDistro.TabStop = false;
            this.groupBoxMinGWDistro.Text = "MinGW 版本";
            // 
            // linkLabelTDM
            // 
            this.linkLabelTDM.AutoSize = true;
            this.linkLabelTDM.Location = new System.Drawing.Point(238, 50);
            this.linkLabelTDM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelTDM.Name = "linkLabelTDM";
            this.linkLabelTDM.Size = new System.Drawing.Size(29, 12);
            this.linkLabelTDM.TabIndex = 14;
            this.linkLabelTDM.TabStop = true;
            this.linkLabelTDM.Text = "官网";
            this.linkLabelTDM.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTDM_LinkClicked);
            // 
            // linkLabelMinGWw64
            // 
            this.linkLabelMinGWw64.AutoSize = true;
            this.linkLabelMinGWw64.Location = new System.Drawing.Point(238, 70);
            this.linkLabelMinGWw64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelMinGWw64.Name = "linkLabelMinGWw64";
            this.linkLabelMinGWw64.Size = new System.Drawing.Size(29, 12);
            this.linkLabelMinGWw64.TabIndex = 13;
            this.linkLabelMinGWw64.TabStop = true;
            this.linkLabelMinGWw64.Text = "官网";
            this.linkLabelMinGWw64.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMinGWw64_LinkClicked);
            // 
            // labelDistroHint
            // 
            this.labelDistroHint.Location = new System.Drawing.Point(4, 111);
            this.labelDistroHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDistroHint.Name = "labelDistroHint";
            this.labelDistroHint.Size = new System.Drawing.Size(299, 61);
            this.labelDistroHint.TabIndex = 12;
            this.labelDistroHint.Text = "说明";
            // 
            // radioButtonOfficial
            // 
            this.radioButtonOfficial.AutoSize = true;
            this.radioButtonOfficial.Location = new System.Drawing.Point(34, 69);
            this.radioButtonOfficial.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonOfficial.Name = "radioButtonOfficial";
            this.radioButtonOfficial.Size = new System.Drawing.Size(83, 16);
            this.radioButtonOfficial.TabIndex = 11;
            this.radioButtonOfficial.Text = "官方 8.1.0";
            this.radioButtonOfficial.UseVisualStyleBackColor = true;
            this.radioButtonOfficial.CheckedChanged += new System.EventHandler(this.radioButtonWinLibs_CheckedChanged);
            // 
            // radioButtonGytx
            // 
            this.radioButtonGytx.AutoSize = true;
            this.radioButtonGytx.Checked = true;
            this.radioButtonGytx.Location = new System.Drawing.Point(34, 29);
            this.radioButtonGytx.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonGytx.Name = "radioButtonGytx";
            this.radioButtonGytx.Size = new System.Drawing.Size(113, 16);
            this.radioButtonGytx.TabIndex = 10;
            this.radioButtonGytx.TabStop = true;
            this.radioButtonGytx.Text = "谷雨同学 11.1.0";
            this.radioButtonGytx.UseVisualStyleBackColor = true;
            this.radioButtonGytx.CheckedChanged += new System.EventHandler(this.radioButtonMinGWw64_CheckedChanged);
            // 
            // radioButtonTDM
            // 
            this.radioButtonTDM.AutoSize = true;
            this.radioButtonTDM.Location = new System.Drawing.Point(34, 49);
            this.radioButtonTDM.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTDM.Name = "radioButtonTDM";
            this.radioButtonTDM.Size = new System.Drawing.Size(101, 16);
            this.radioButtonTDM.TabIndex = 9;
            this.radioButtonTDM.Text = "TDM-GCC 9.2.0";
            this.radioButtonTDM.UseVisualStyleBackColor = true;
            this.radioButtonTDM.CheckedChanged += new System.EventHandler(this.radioButtonTDM_CheckedChanged);
            // 
            // tabPageInstall
            // 
            this.tabPageInstall.Controls.Add(this.buttonUpdate);
            this.tabPageInstall.Controls.Add(this.groupBoxPrivil);
            this.tabPageInstall.Location = new System.Drawing.Point(4, 22);
            this.tabPageInstall.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageInstall.Name = "tabPageInstall";
            this.tabPageInstall.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageInstall.Size = new System.Drawing.Size(311, 258);
            this.tabPageInstall.TabIndex = 1;
            this.tabPageInstall.Text = "安装";
            this.tabPageInstall.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(94, 195);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(210, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "检查 VS Code Config Helper 更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.groupBoxStandard);
            this.tabPageConfig.Controls.Add(this.groupBoxArg);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Size = new System.Drawing.Size(311, 258);
            this.tabPageConfig.TabIndex = 2;
            this.tabPageConfig.Text = "配置";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // groupBoxStandard
            // 
            this.groupBoxStandard.Controls.Add(this.labelStandard);
            this.groupBoxStandard.Controls.Add(this.labelLang);
            this.groupBoxStandard.Controls.Add(this.comboBoxLang);
            this.groupBoxStandard.Controls.Add(this.comboBoxStandard);
            this.groupBoxStandard.Location = new System.Drawing.Point(2, 2);
            this.groupBoxStandard.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxStandard.Name = "groupBoxStandard";
            this.groupBoxStandard.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxStandard.Size = new System.Drawing.Size(308, 47);
            this.groupBoxStandard.TabIndex = 9;
            this.groupBoxStandard.TabStop = false;
            this.groupBoxStandard.Text = "设定语言标准";
            // 
            // labelStandard
            // 
            this.labelStandard.AutoSize = true;
            this.labelStandard.Location = new System.Drawing.Point(140, 22);
            this.labelStandard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStandard.Name = "labelStandard";
            this.labelStandard.Size = new System.Drawing.Size(53, 12);
            this.labelStandard.TabIndex = 3;
            this.labelStandard.Text = "标准版本";
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Location = new System.Drawing.Point(46, 22);
            this.labelLang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(29, 12);
            this.labelLang.TabIndex = 2;
            this.labelLang.Text = "语言";
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.Items.AddRange(new object[] {
            "C++",
            "C"});
            this.comboBoxLang.Location = new System.Drawing.Point(79, 19);
            this.comboBoxLang.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.Size = new System.Drawing.Size(42, 20);
            this.comboBoxLang.TabIndex = 1;
            this.comboBoxLang.SelectedIndexChanged += new System.EventHandler(this.comboBoxLang_SelectedIndexChanged);
            // 
            // comboBoxStandard
            // 
            this.comboBoxStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStandard.FormattingEnabled = true;
            this.comboBoxStandard.Location = new System.Drawing.Point(194, 19);
            this.comboBoxStandard.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStandard.Name = "comboBoxStandard";
            this.comboBoxStandard.Size = new System.Drawing.Size(60, 20);
            this.comboBoxStandard.TabIndex = 0;
            this.comboBoxStandard.TextChanged += new System.EventHandler(this.comboBoxStandard_TextChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 342);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.pictureGitHub);
            this.Controls.Add(this.linkLabelLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSettings";
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBoxPrivil.ResumeLayout(false);
            this.groupBoxArg.ResumeLayout(false);
            this.groupBoxArg.PerformLayout();
            this.groupBoxMinGWSrc.ResumeLayout(false);
            this.groupBoxMinGWSrc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGitHub)).EndInit();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageDownload.ResumeLayout(false);
            this.groupBoxMinGWDistro.ResumeLayout(false);
            this.groupBoxMinGWDistro.PerformLayout();
            this.tabPageInstall.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.groupBoxStandard.ResumeLayout(false);
            this.groupBoxStandard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrivil;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.GroupBox groupBoxArg;
        private System.Windows.Forms.Button buttonArgDefault;
        private System.Windows.Forms.Label labelArgInstruction;
        private System.Windows.Forms.Button buttonSaveArgs;
        private System.Windows.Forms.Label labelArgWarning;
        private System.Windows.Forms.TextBox textBoxArgs;
        private System.Windows.Forms.GroupBox groupBoxMinGWSrc;
        private System.Windows.Forms.Label labelMinGWSrcInstruction;
        private System.Windows.Forms.RadioButton radioButtonOffical;
        private System.Windows.Forms.RadioButton radioButtonDisk;
        private System.Windows.Forms.LinkLabel linkLabelLicense;
        private System.Windows.Forms.PictureBox pictureGitHub;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageDownload;
        private System.Windows.Forms.GroupBox groupBoxMinGWDistro;
        private System.Windows.Forms.RadioButton radioButtonOfficial;
        private System.Windows.Forms.RadioButton radioButtonGytx;
        private System.Windows.Forms.RadioButton radioButtonTDM;
        private System.Windows.Forms.TabPage tabPageInstall;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.Label labelDistroHint;
        private System.Windows.Forms.LinkLabel linkLabelTDM;
        private System.Windows.Forms.LinkLabel linkLabelMinGWw64;
        private System.Windows.Forms.GroupBox groupBoxStandard;
        private System.Windows.Forms.ComboBox comboBoxLang;
        private System.Windows.Forms.ComboBox comboBoxStandard;
        private System.Windows.Forms.Label labelStandard;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.Button buttonUpdate;
    }
}