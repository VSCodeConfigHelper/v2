namespace VSCodeConfigHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.checkBoxGenTest = new System.Windows.Forms.CheckBox();
            this.checkBoxOpen = new System.Windows.Forms.CheckBox();
            this.labelWorkspaceStatus = new System.Windows.Forms.Label();
            this.labelConfigState = new System.Windows.Forms.Label();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonViewWorkspace = new System.Windows.Forms.Button();
            this.textBoxWorkspacePath = new System.Windows.Forms.TextBox();
            this.labelWorkspaceHint = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabelVSCode = new System.Windows.Forms.LinkLabel();
            this.linkLabelMinGW = new System.Windows.Forms.LinkLabel();
            this.labelMinGWPathHint = new System.Windows.Forms.Label();
            this.labelExtensionHint = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExtension = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMinGWState = new System.Windows.Forms.Label();
            this.labelPathState = new System.Windows.Forms.Label();
            this.buttonSetEnv = new System.Windows.Forms.Button();
            this.textBoxMinGWPath = new System.Windows.Forms.TextBox();
            this.buttonViewMinGW = new System.Windows.Forms.Button();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.linkLabelManual = new System.Windows.Forms.LinkLabel();
            this.labelFAQ = new System.Windows.Forms.Label();
            this.labelManual = new System.Windows.Forms.Label();
            this.textBoxHelp = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
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
            this.radioButtonPKU = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            this.tabPageHelp.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            this.groupBoxPrivil.SuspendLayout();
            this.groupBoxArg.SuspendLayout();
            this.groupBoxMinGWSrc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStart);
            this.tabControlMain.Controls.Add(this.tabPageHelp);
            this.tabControlMain.Controls.Add(this.tabPageSetting);
            this.tabControlMain.Location = new System.Drawing.Point(16, 15);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(435, 591);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageStart
            // 
            this.tabPageStart.Controls.Add(this.checkBoxGenTest);
            this.tabPageStart.Controls.Add(this.checkBoxOpen);
            this.tabPageStart.Controls.Add(this.labelWorkspaceStatus);
            this.tabPageStart.Controls.Add(this.labelConfigState);
            this.tabPageStart.Controls.Add(this.buttonConfig);
            this.tabPageStart.Controls.Add(this.label7);
            this.tabPageStart.Controls.Add(this.buttonViewWorkspace);
            this.tabPageStart.Controls.Add(this.textBoxWorkspacePath);
            this.tabPageStart.Controls.Add(this.labelWorkspaceHint);
            this.tabPageStart.Controls.Add(this.label6);
            this.tabPageStart.Controls.Add(this.linkLabelVSCode);
            this.tabPageStart.Controls.Add(this.linkLabelMinGW);
            this.tabPageStart.Controls.Add(this.labelMinGWPathHint);
            this.tabPageStart.Controls.Add(this.labelExtensionHint);
            this.tabPageStart.Controls.Add(this.label5);
            this.tabPageStart.Controls.Add(this.label4);
            this.tabPageStart.Controls.Add(this.buttonExtension);
            this.tabPageStart.Controls.Add(this.label3);
            this.tabPageStart.Controls.Add(this.label2);
            this.tabPageStart.Controls.Add(this.label1);
            this.tabPageStart.Controls.Add(this.labelMinGWState);
            this.tabPageStart.Controls.Add(this.labelPathState);
            this.tabPageStart.Controls.Add(this.buttonSetEnv);
            this.tabPageStart.Controls.Add(this.textBoxMinGWPath);
            this.tabPageStart.Controls.Add(this.buttonViewMinGW);
            this.tabPageStart.Location = new System.Drawing.Point(4, 25);
            this.tabPageStart.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageStart.Size = new System.Drawing.Size(427, 562);
            this.tabPageStart.TabIndex = 0;
            this.tabPageStart.Text = "开始";
            this.tabPageStart.UseVisualStyleBackColor = true;
            // 
            // checkBoxGenTest
            // 
            this.checkBoxGenTest.AutoSize = true;
            this.checkBoxGenTest.Checked = true;
            this.checkBoxGenTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGenTest.Location = new System.Drawing.Point(139, 468);
            this.checkBoxGenTest.Name = "checkBoxGenTest";
            this.checkBoxGenTest.Size = new System.Drawing.Size(119, 19);
            this.checkBoxGenTest.TabIndex = 26;
            this.checkBoxGenTest.Text = "生成测试代码";
            this.checkBoxGenTest.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpen
            // 
            this.checkBoxOpen.AutoSize = true;
            this.checkBoxOpen.Checked = true;
            this.checkBoxOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpen.Location = new System.Drawing.Point(274, 468);
            this.checkBoxOpen.Name = "checkBoxOpen";
            this.checkBoxOpen.Size = new System.Drawing.Size(134, 19);
            this.checkBoxOpen.TabIndex = 25;
            this.checkBoxOpen.Text = "配置成功后启动";
            this.checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // labelWorkspaceStatus
            // 
            this.labelWorkspaceStatus.AutoSize = true;
            this.labelWorkspaceStatus.ForeColor = System.Drawing.Color.Red;
            this.labelWorkspaceStatus.Location = new System.Drawing.Point(8, 439);
            this.labelWorkspaceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorkspaceStatus.Name = "labelWorkspaceStatus";
            this.labelWorkspaceStatus.Size = new System.Drawing.Size(277, 15);
            this.labelWorkspaceStatus.TabIndex = 24;
            this.labelWorkspaceStatus.Text = "路径中不能包含中文或者其它特殊字符。";
            this.labelWorkspaceStatus.Visible = false;
            // 
            // labelConfigState
            // 
            this.labelConfigState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConfigState.Location = new System.Drawing.Point(152, 500);
            this.labelConfigState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfigState.Name = "labelConfigState";
            this.labelConfigState.Size = new System.Drawing.Size(258, 50);
            this.labelConfigState.TabIndex = 23;
            this.labelConfigState.Text = "     ";
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(8, 493);
            this.buttonConfig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(113, 29);
            this.buttonConfig.TabIndex = 22;
            this.buttonConfig.Text = "一键配置";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 469);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "第七步：一键配置";
            // 
            // buttonViewWorkspace
            // 
            this.buttonViewWorkspace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewWorkspace.Location = new System.Drawing.Point(316, 409);
            this.buttonViewWorkspace.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewWorkspace.Name = "buttonViewWorkspace";
            this.buttonViewWorkspace.Size = new System.Drawing.Size(100, 26);
            this.buttonViewWorkspace.TabIndex = 20;
            this.buttonViewWorkspace.Text = "浏览...";
            this.buttonViewWorkspace.UseVisualStyleBackColor = true;
            this.buttonViewWorkspace.Click += new System.EventHandler(this.ButtonViewWorkspace_Click);
            // 
            // textBoxWorkspacePath
            // 
            this.textBoxWorkspacePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkspacePath.Location = new System.Drawing.Point(7, 409);
            this.textBoxWorkspacePath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWorkspacePath.Name = "textBoxWorkspacePath";
            this.textBoxWorkspacePath.Size = new System.Drawing.Size(300, 25);
            this.textBoxWorkspacePath.TabIndex = 19;
            this.textBoxWorkspacePath.TextChanged += new System.EventHandler(this.TextBoxWorkspacePath_TextChanged);
            // 
            // labelWorkspaceHint
            // 
            this.labelWorkspaceHint.AutoSize = true;
            this.labelWorkspaceHint.Location = new System.Drawing.Point(4, 390);
            this.labelWorkspaceHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorkspaceHint.Name = "labelWorkspaceHint";
            this.labelWorkspaceHint.Size = new System.Drawing.Size(322, 15);
            this.labelWorkspaceHint.TabIndex = 18;
            this.labelWorkspaceHint.Text = "选择一个文件夹，将来您的程序都存放在此处：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "第六步：选择工作文件夹";
            // 
            // linkLabelVSCode
            // 
            this.linkLabelVSCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelVSCode.Location = new System.Drawing.Point(317, 270);
            this.linkLabelVSCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelVSCode.Name = "linkLabelVSCode";
            this.linkLabelVSCode.Size = new System.Drawing.Size(91, 15);
            this.linkLabelVSCode.TabIndex = 16;
            this.linkLabelVSCode.TabStop = true;
            this.linkLabelVSCode.Text = "下载地址";
            this.linkLabelVSCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelVSCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelVSCode_LinkClicked);
            // 
            // linkLabelMinGW
            // 
            this.linkLabelMinGW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelMinGW.Location = new System.Drawing.Point(317, 15);
            this.linkLabelMinGW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelMinGW.Name = "linkLabelMinGW";
            this.linkLabelMinGW.Size = new System.Drawing.Size(91, 15);
            this.linkLabelMinGW.TabIndex = 15;
            this.linkLabelMinGW.TabStop = true;
            this.linkLabelMinGW.Text = "下载地址...";
            this.linkLabelMinGW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelMinGW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMinGW_LinkClicked);
            // 
            // labelMinGWPathHint
            // 
            this.labelMinGWPathHint.Location = new System.Drawing.Point(4, 57);
            this.labelMinGWPathHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinGWPathHint.Name = "labelMinGWPathHint";
            this.labelMinGWPathHint.Size = new System.Drawing.Size(412, 56);
            this.labelMinGWPathHint.TabIndex = 14;
            this.labelMinGWPathHint.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelExtensionHint
            // 
            this.labelExtensionHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExtensionHint.Location = new System.Drawing.Point(136, 315);
            this.labelExtensionHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExtensionHint.Name = "labelExtensionHint";
            this.labelExtensionHint.Size = new System.Drawing.Size(275, 36);
            this.labelExtensionHint.TabIndex = 11;
            this.labelExtensionHint.Text = "点击左侧按钮，选择 Install 。如失败，请检查 VS Code 是否安装。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 296);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "第五步：安装插件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "第四步：下载 VS Code 并安装";
            // 
            // buttonExtension
            // 
            this.buttonExtension.Location = new System.Drawing.Point(8, 315);
            this.buttonExtension.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtension.Name = "buttonExtension";
            this.buttonExtension.Size = new System.Drawing.Size(113, 29);
            this.buttonExtension.TabIndex = 8;
            this.buttonExtension.Text = "安装插件...";
            this.buttonExtension.UseVisualStyleBackColor = true;
            this.buttonExtension.Click += new System.EventHandler(this.ButtonExtension_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "第三步：设置环境变量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "第二步：输入 MinGW 路径";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "第一步：下载 MinGW-w64 并解压";
            // 
            // labelMinGWState
            // 
            this.labelMinGWState.Location = new System.Drawing.Point(5, 150);
            this.labelMinGWState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinGWState.Name = "labelMinGWState";
            this.labelMinGWState.Size = new System.Drawing.Size(411, 45);
            this.labelMinGWState.TabIndex = 4;
            this.labelMinGWState.Text = "     ";
            // 
            // labelPathState
            // 
            this.labelPathState.Location = new System.Drawing.Point(129, 231);
            this.labelPathState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPathState.Name = "labelPathState";
            this.labelPathState.Size = new System.Drawing.Size(261, 15);
            this.labelPathState.TabIndex = 3;
            this.labelPathState.Text = "     ";
            // 
            // buttonSetEnv
            // 
            this.buttonSetEnv.Location = new System.Drawing.Point(8, 225);
            this.buttonSetEnv.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetEnv.Name = "buttonSetEnv";
            this.buttonSetEnv.Size = new System.Drawing.Size(113, 29);
            this.buttonSetEnv.TabIndex = 2;
            this.buttonSetEnv.Text = "设置环境变量";
            this.buttonSetEnv.UseVisualStyleBackColor = true;
            this.buttonSetEnv.Click += new System.EventHandler(this.ButtonSetEnv_Click);
            // 
            // textBoxMinGWPath
            // 
            this.textBoxMinGWPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinGWPath.Location = new System.Drawing.Point(7, 118);
            this.textBoxMinGWPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinGWPath.Name = "textBoxMinGWPath";
            this.textBoxMinGWPath.Size = new System.Drawing.Size(300, 25);
            this.textBoxMinGWPath.TabIndex = 1;
            this.textBoxMinGWPath.TextChanged += new System.EventHandler(this.TextBoxMinGWPath_TextChanged);
            // 
            // buttonViewMinGW
            // 
            this.buttonViewMinGW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewMinGW.Location = new System.Drawing.Point(316, 116);
            this.buttonViewMinGW.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewMinGW.Name = "buttonViewMinGW";
            this.buttonViewMinGW.Size = new System.Drawing.Size(100, 26);
            this.buttonViewMinGW.TabIndex = 0;
            this.buttonViewMinGW.Text = "浏览...";
            this.buttonViewMinGW.UseVisualStyleBackColor = true;
            this.buttonViewMinGW.Click += new System.EventHandler(this.ButtonViewMinGW_Click);
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.linkLabelManual);
            this.tabPageHelp.Controls.Add(this.labelFAQ);
            this.tabPageHelp.Controls.Add(this.labelManual);
            this.tabPageHelp.Controls.Add(this.textBoxHelp);
            this.tabPageHelp.Controls.Add(this.labelAuthor);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 25);
            this.tabPageHelp.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageHelp.Size = new System.Drawing.Size(427, 562);
            this.tabPageHelp.TabIndex = 1;
            this.tabPageHelp.Text = "帮助";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // linkLabelManual
            // 
            this.linkLabelManual.AutoSize = true;
            this.linkLabelManual.Location = new System.Drawing.Point(169, 4);
            this.linkLabelManual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelManual.Name = "linkLabelManual";
            this.linkLabelManual.Size = new System.Drawing.Size(37, 15);
            this.linkLabelManual.TabIndex = 4;
            this.linkLabelManual.TabStop = true;
            this.linkLabelManual.Text = "此处";
            this.linkLabelManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelManual_LinkClicked);
            // 
            // labelFAQ
            // 
            this.labelFAQ.AutoSize = true;
            this.labelFAQ.Location = new System.Drawing.Point(8, 32);
            this.labelFAQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFAQ.Name = "labelFAQ";
            this.labelFAQ.Size = new System.Drawing.Size(121, 15);
            this.labelFAQ.TabIndex = 3;
            this.labelFAQ.Text = "常见问题（FAQ）";
            // 
            // labelManual
            // 
            this.labelManual.AutoSize = true;
            this.labelManual.Location = new System.Drawing.Point(8, 4);
            this.labelManual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManual.Name = "labelManual";
            this.labelManual.Size = new System.Drawing.Size(157, 15);
            this.labelManual.TabIndex = 2;
            this.labelManual.Text = "更详细的使用方法参见";
            // 
            // textBoxHelp
            // 
            this.textBoxHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHelp.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxHelp.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxHelp.Location = new System.Drawing.Point(8, 51);
            this.textBoxHelp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHelp.Multiline = true;
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.ReadOnly = true;
            this.textBoxHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHelp.Size = new System.Drawing.Size(407, 484);
            this.textBoxHelp.TabIndex = 1;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAuthor.Location = new System.Drawing.Point(5, 540);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(414, 15);
            this.labelAuthor.TabIndex = 0;
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.Controls.Add(this.groupBoxPrivil);
            this.tabPageSetting.Controls.Add(this.groupBoxArg);
            this.tabPageSetting.Controls.Add(this.groupBoxMinGWSrc);
            this.tabPageSetting.Location = new System.Drawing.Point(4, 25);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Size = new System.Drawing.Size(427, 562);
            this.tabPageSetting.TabIndex = 2;
            this.tabPageSetting.Text = "设置";
            this.tabPageSetting.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrivil
            // 
            this.groupBoxPrivil.Controls.Add(this.buttonAuth);
            this.groupBoxPrivil.Controls.Add(this.labelAuth);
            this.groupBoxPrivil.Location = new System.Drawing.Point(3, 99);
            this.groupBoxPrivil.Name = "groupBoxPrivil";
            this.groupBoxPrivil.Size = new System.Drawing.Size(421, 132);
            this.groupBoxPrivil.TabIndex = 6;
            this.groupBoxPrivil.TabStop = false;
            this.groupBoxPrivil.Text = "当前权限";
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(274, 55);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(141, 29);
            this.buttonAuth.TabIndex = 0;
            this.buttonAuth.Text = "使用管理员身份";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // labelAuth
            // 
            this.labelAuth.Location = new System.Drawing.Point(6, 21);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(262, 108);
            this.labelAuth.TabIndex = 1;
            // 
            // groupBoxArg
            // 
            this.groupBoxArg.Controls.Add(this.buttonArgDefault);
            this.groupBoxArg.Controls.Add(this.labelArgInstruction);
            this.groupBoxArg.Controls.Add(this.buttonSaveArgs);
            this.groupBoxArg.Controls.Add(this.labelArgWarning);
            this.groupBoxArg.Controls.Add(this.textBoxArgs);
            this.groupBoxArg.Location = new System.Drawing.Point(3, 237);
            this.groupBoxArg.Name = "groupBoxArg";
            this.groupBoxArg.Size = new System.Drawing.Size(421, 224);
            this.groupBoxArg.TabIndex = 1;
            this.groupBoxArg.TabStop = false;
            this.groupBoxArg.Text = "配置 g++ 编译参数";
            // 
            // buttonArgDefault
            // 
            this.buttonArgDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonArgDefault.Location = new System.Drawing.Point(6, 189);
            this.buttonArgDefault.Name = "buttonArgDefault";
            this.buttonArgDefault.Size = new System.Drawing.Size(84, 29);
            this.buttonArgDefault.TabIndex = 2;
            this.buttonArgDefault.Text = "恢复默认";
            this.buttonArgDefault.UseVisualStyleBackColor = true;
            this.buttonArgDefault.Click += new System.EventHandler(this.buttonArgDefault_Click);
            // 
            // labelArgInstruction
            // 
            this.labelArgInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelArgInstruction.Location = new System.Drawing.Point(186, 188);
            this.labelArgInstruction.Name = "labelArgInstruction";
            this.labelArgInstruction.Size = new System.Drawing.Size(226, 30);
            this.labelArgInstruction.TabIndex = 5;
            this.labelArgInstruction.Text = "每行一个参数；支持 VS Code 配置变量。";
            // 
            // buttonSaveArgs
            // 
            this.buttonSaveArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveArgs.Location = new System.Drawing.Point(96, 189);
            this.buttonSaveArgs.Name = "buttonSaveArgs";
            this.buttonSaveArgs.Size = new System.Drawing.Size(84, 29);
            this.buttonSaveArgs.TabIndex = 4;
            this.buttonSaveArgs.Text = "保存";
            this.buttonSaveArgs.UseVisualStyleBackColor = true;
            this.buttonSaveArgs.Click += new System.EventHandler(this.buttonSaveArgs_Click);
            // 
            // labelArgWarning
            // 
            this.labelArgWarning.AutoSize = true;
            this.labelArgWarning.ForeColor = System.Drawing.Color.Red;
            this.labelArgWarning.Location = new System.Drawing.Point(6, 21);
            this.labelArgWarning.Name = "labelArgWarning";
            this.labelArgWarning.Size = new System.Drawing.Size(367, 15);
            this.labelArgWarning.TabIndex = 3;
            this.labelArgWarning.Text = "除非您知道自己在做什么，否则不要改动这里的内容。";
            // 
            // textBoxArgs
            // 
            this.textBoxArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArgs.Location = new System.Drawing.Point(9, 49);
            this.textBoxArgs.Multiline = true;
            this.textBoxArgs.Name = "textBoxArgs";
            this.textBoxArgs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxArgs.Size = new System.Drawing.Size(406, 134);
            this.textBoxArgs.TabIndex = 2;
            // 
            // groupBoxMinGWSrc
            // 
            this.groupBoxMinGWSrc.Controls.Add(this.labelMinGWSrcInstruction);
            this.groupBoxMinGWSrc.Controls.Add(this.radioButtonOffical);
            this.groupBoxMinGWSrc.Controls.Add(this.radioButtonPKU);
            this.groupBoxMinGWSrc.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMinGWSrc.Name = "groupBoxMinGWSrc";
            this.groupBoxMinGWSrc.Size = new System.Drawing.Size(421, 90);
            this.groupBoxMinGWSrc.TabIndex = 0;
            this.groupBoxMinGWSrc.TabStop = false;
            this.groupBoxMinGWSrc.Text = "选择 MinGW 下载源";
            // 
            // labelMinGWSrcInstruction
            // 
            this.labelMinGWSrcInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinGWSrcInstruction.Location = new System.Drawing.Point(6, 57);
            this.labelMinGWSrcInstruction.Name = "labelMinGWSrcInstruction";
            this.labelMinGWSrcInstruction.Size = new System.Drawing.Size(409, 30);
            this.labelMinGWSrcInstruction.TabIndex = 2;
            this.labelMinGWSrcInstruction.Text = "北大网盘下载快速稳定，但有可能失效。官方下载长期有效，但速度受网络环境所限制。";
            // 
            // radioButtonOffical
            // 
            this.radioButtonOffical.AutoSize = true;
            this.radioButtonOffical.Location = new System.Drawing.Point(219, 24);
            this.radioButtonOffical.Name = "radioButtonOffical";
            this.radioButtonOffical.Size = new System.Drawing.Size(169, 19);
            this.radioButtonOffical.TabIndex = 1;
            this.radioButtonOffical.Text = "官方（SourceForge)";
            this.radioButtonOffical.UseVisualStyleBackColor = true;
            // 
            // radioButtonPKU
            // 
            this.radioButtonPKU.AutoSize = true;
            this.radioButtonPKU.Checked = true;
            this.radioButtonPKU.Location = new System.Drawing.Point(45, 24);
            this.radioButtonPKU.Name = "radioButtonPKU";
            this.radioButtonPKU.Size = new System.Drawing.Size(88, 19);
            this.radioButtonPKU.TabIndex = 1;
            this.radioButtonPKU.TabStop = true;
            this.radioButtonPKU.Text = "北大网盘";
            this.radioButtonPKU.UseVisualStyleBackColor = true;
            this.radioButtonPKU.CheckedChanged += new System.EventHandler(this.radioButtonPKU_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 621);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "VS Code C++配置工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            this.tabPageStart.PerformLayout();
            this.tabPageHelp.ResumeLayout(false);
            this.tabPageHelp.PerformLayout();
            this.tabPageSetting.ResumeLayout(false);
            this.groupBoxPrivil.ResumeLayout(false);
            this.groupBoxArg.ResumeLayout(false);
            this.groupBoxArg.PerformLayout();
            this.groupBoxMinGWSrc.ResumeLayout(false);
            this.groupBoxMinGWSrc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.TextBox textBoxMinGWPath;
        private System.Windows.Forms.Button buttonViewMinGW;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSetEnv;
        private System.Windows.Forms.Label labelPathState;
        private System.Windows.Forms.Label labelMinGWState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExtension;
        private System.Windows.Forms.Label labelExtensionHint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMinGWPathHint;
        private System.Windows.Forms.LinkLabel linkLabelVSCode;
        private System.Windows.Forms.LinkLabel linkLabelMinGW;
        private System.Windows.Forms.Label labelWorkspaceHint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonViewWorkspace;
        private System.Windows.Forms.TextBox textBoxWorkspacePath;
        private System.Windows.Forms.Label labelConfigState;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxHelp;
        private System.Windows.Forms.LinkLabel linkLabelManual;
        private System.Windows.Forms.Label labelFAQ;
        private System.Windows.Forms.Label labelManual;
        private System.Windows.Forms.Label labelWorkspaceStatus;
        private System.Windows.Forms.TabPage tabPageSetting;
        private System.Windows.Forms.GroupBox groupBoxArg;
        private System.Windows.Forms.GroupBox groupBoxMinGWSrc;
        private System.Windows.Forms.RadioButton radioButtonOffical;
        private System.Windows.Forms.RadioButton radioButtonPKU;
        private System.Windows.Forms.Button buttonSaveArgs;
        private System.Windows.Forms.Label labelArgWarning;
        private System.Windows.Forms.TextBox textBoxArgs;
        private System.Windows.Forms.Label labelMinGWSrcInstruction;
        private System.Windows.Forms.Label labelArgInstruction;
        private System.Windows.Forms.Button buttonArgDefault;
        private System.Windows.Forms.CheckBox checkBoxOpen;
        private System.Windows.Forms.GroupBox groupBoxPrivil;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.CheckBox checkBoxGenTest;
    }
}

