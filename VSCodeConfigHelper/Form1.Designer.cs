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
            this.linkLabelManual = new System.Windows.Forms.LinkLabel();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.checkBoxGenTest = new System.Windows.Forms.CheckBox();
            this.checkBoxOpen = new System.Windows.Forms.CheckBox();
            this.buttonExtension = new System.Windows.Forms.Button();
            this.labelMinGWState = new System.Windows.Forms.Label();
            this.linkLabelVSCode = new System.Windows.Forms.LinkLabel();
            this.labelWorkspaceStatus = new System.Windows.Forms.Label();
            this.buttonViewWorkspace = new System.Windows.Forms.Button();
            this.textBoxWorkspacePath = new System.Windows.Forms.TextBox();
            this.linkLabelMinGW = new System.Windows.Forms.LinkLabel();
            this.labelMinGWPathHint = new System.Windows.Forms.Label();
            this.textBoxMinGWPath = new System.Windows.Forms.TextBox();
            this.buttonViewMinGW = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageWelcome = new System.Windows.Forms.TabPage();
            this.labelWelcomeTitle = new System.Windows.Forms.Label();
            this.buttonWelcomCancel = new System.Windows.Forms.Button();
            this.buttonWelcomeNext = new System.Windows.Forms.Button();
            this.labelFolderHelp = new System.Windows.Forms.Label();
            this.labelFolderHint = new System.Windows.Forms.Label();
            this.labelWelcomeText = new System.Windows.Forms.Label();
            this.tabPageMinGW = new System.Windows.Forms.TabPage();
            this.labelMinGWTitle = new System.Windows.Forms.Label();
            this.panelMinGWTable = new System.Windows.Forms.Panel();
            this.buttonMinGWAdd = new System.Windows.Forms.Button();
            this.listViewMinGW = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMinGWHint = new System.Windows.Forms.Label();
            this.buttonMinGWPrev = new System.Windows.Forms.Button();
            this.buttonMinGWCancel = new System.Windows.Forms.Button();
            this.buttonMinGWNext = new System.Windows.Forms.Button();
            this.tabPageCode = new System.Windows.Forms.TabPage();
            this.labelCodeTitle = new System.Windows.Forms.Label();
            this.labelExtensionHint = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelCodeHint = new System.Windows.Forms.Label();
            this.buttonCodePrev = new System.Windows.Forms.Button();
            this.buttonCodeCancel = new System.Windows.Forms.Button();
            this.buttonCodeNext = new System.Windows.Forms.Button();
            this.tabPageStyle = new System.Windows.Forms.TabPage();
            this.pictureBoxExternal = new System.Windows.Forms.PictureBox();
            this.pictureBoxInternal = new System.Windows.Forms.PictureBox();
            this.labelExternalHint = new System.Windows.Forms.Label();
            this.labelInternalHint = new System.Windows.Forms.Label();
            this.radioButtonExternal = new System.Windows.Forms.RadioButton();
            this.radioButtonInternal = new System.Windows.Forms.RadioButton();
            this.labelStyleTitle = new System.Windows.Forms.Label();
            this.buttonConfigPrev = new System.Windows.Forms.Button();
            this.buttonConfigCancel = new System.Windows.Forms.Button();
            this.buttonConfigNext = new System.Windows.Forms.Button();
            this.tabPageFinish = new System.Windows.Forms.TabPage();
            this.checkBoxDesktopShortcut = new System.Windows.Forms.CheckBox();
            this.labelFinishHint = new System.Windows.Forms.Label();
            this.labelFinishTitle = new System.Windows.Forms.Label();
            this.buttonFinishAll = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelNavigate = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageWelcome.SuspendLayout();
            this.tabPageMinGW.SuspendLayout();
            this.panelMinGWTable.SuspendLayout();
            this.tabPageCode.SuspendLayout();
            this.tabPageStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExternal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInternal)).BeginInit();
            this.tabPageFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelManual
            // 
            this.linkLabelManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelManual.AutoSize = true;
            this.linkLabelManual.Location = new System.Drawing.Point(84, 366);
            this.linkLabelManual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelManual.Name = "linkLabelManual";
            this.linkLabelManual.Size = new System.Drawing.Size(67, 15);
            this.linkLabelManual.TabIndex = 4;
            this.linkLabelManual.TabStop = true;
            this.linkLabelManual.Text = "使用帮助";
            this.linkLabelManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelManual_LinkClicked);
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAuthor.Location = new System.Drawing.Point(183, 366);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(582, 21);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "版权";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBoxGenTest
            // 
            this.checkBoxGenTest.AutoSize = true;
            this.checkBoxGenTest.Checked = true;
            this.checkBoxGenTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGenTest.Location = new System.Drawing.Point(34, 108);
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
            this.checkBoxOpen.Location = new System.Drawing.Point(34, 133);
            this.checkBoxOpen.Name = "checkBoxOpen";
            this.checkBoxOpen.Size = new System.Drawing.Size(123, 19);
            this.checkBoxOpen.TabIndex = 25;
            this.checkBoxOpen.Text = "启动 VS Code";
            this.checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // buttonExtension
            // 
            this.buttonExtension.Location = new System.Drawing.Point(39, 184);
            this.buttonExtension.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExtension.Name = "buttonExtension";
            this.buttonExtension.Size = new System.Drawing.Size(100, 29);
            this.buttonExtension.TabIndex = 8;
            this.buttonExtension.Text = "安装扩展";
            this.buttonExtension.UseVisualStyleBackColor = true;
            this.buttonExtension.Click += new System.EventHandler(this.ButtonExtension_Click);
            // 
            // labelMinGWState
            // 
            this.labelMinGWState.Location = new System.Drawing.Point(60, 232);
            this.labelMinGWState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinGWState.Name = "labelMinGWState";
            this.labelMinGWState.Size = new System.Drawing.Size(411, 45);
            this.labelMinGWState.TabIndex = 4;
            this.labelMinGWState.Text = "     ";
            // 
            // linkLabelVSCode
            // 
            this.linkLabelVSCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelVSCode.Location = new System.Drawing.Point(445, 97);
            this.linkLabelVSCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelVSCode.Name = "linkLabelVSCode";
            this.linkLabelVSCode.Size = new System.Drawing.Size(91, 15);
            this.linkLabelVSCode.TabIndex = 16;
            this.linkLabelVSCode.TabStop = true;
            this.linkLabelVSCode.Text = "下载地址";
            this.linkLabelVSCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelVSCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelVSCode_LinkClicked);
            // 
            // labelWorkspaceStatus
            // 
            this.labelWorkspaceStatus.AutoSize = true;
            this.labelWorkspaceStatus.ForeColor = System.Drawing.Color.Red;
            this.labelWorkspaceStatus.Location = new System.Drawing.Point(31, 159);
            this.labelWorkspaceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorkspaceStatus.Name = "labelWorkspaceStatus";
            this.labelWorkspaceStatus.Size = new System.Drawing.Size(277, 15);
            this.labelWorkspaceStatus.TabIndex = 24;
            this.labelWorkspaceStatus.Text = "路径中不能包含中文或者其它特殊字符。";
            this.labelWorkspaceStatus.Visible = false;
            // 
            // buttonViewWorkspace
            // 
            this.buttonViewWorkspace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewWorkspace.Location = new System.Drawing.Point(461, 127);
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
            this.textBoxWorkspacePath.Location = new System.Drawing.Point(34, 130);
            this.textBoxWorkspacePath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWorkspacePath.Name = "textBoxWorkspacePath";
            this.textBoxWorkspacePath.Size = new System.Drawing.Size(419, 25);
            this.textBoxWorkspacePath.TabIndex = 19;
            this.textBoxWorkspacePath.TextChanged += new System.EventHandler(this.TextBoxWorkspacePath_TextChanged);
            // 
            // linkLabelMinGW
            // 
            this.linkLabelMinGW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelMinGW.Location = new System.Drawing.Point(476, 55);
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
            this.labelMinGWPathHint.Location = new System.Drawing.Point(28, 118);
            this.labelMinGWPathHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinGWPathHint.Name = "labelMinGWPathHint";
            this.labelMinGWPathHint.Size = new System.Drawing.Size(446, 56);
            this.labelMinGWPathHint.TabIndex = 14;
            this.labelMinGWPathHint.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxMinGWPath
            // 
            this.textBoxMinGWPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinGWPath.Location = new System.Drawing.Point(28, 192);
            this.textBoxMinGWPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinGWPath.Name = "textBoxMinGWPath";
            this.textBoxMinGWPath.Size = new System.Drawing.Size(421, 25);
            this.textBoxMinGWPath.TabIndex = 1;
            this.textBoxMinGWPath.TextChanged += new System.EventHandler(this.TextBoxMinGWPath_TextChanged);
            // 
            // buttonViewMinGW
            // 
            this.buttonViewMinGW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewMinGW.Location = new System.Drawing.Point(457, 192);
            this.buttonViewMinGW.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewMinGW.Name = "buttonViewMinGW";
            this.buttonViewMinGW.Size = new System.Drawing.Size(100, 25);
            this.buttonViewMinGW.TabIndex = 0;
            this.buttonViewMinGW.Text = "浏览...";
            this.buttonViewMinGW.UseVisualStyleBackColor = true;
            this.buttonViewMinGW.Click += new System.EventHandler(this.ButtonViewMinGW_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.Controls.Add(this.tabPageWelcome);
            this.tabControlMain.Controls.Add(this.tabPageMinGW);
            this.tabControlMain.Controls.Add(this.tabPageCode);
            this.tabControlMain.Controls.Add(this.tabPageStyle);
            this.tabControlMain.Controls.Add(this.tabPageFinish);
            this.tabControlMain.ItemSize = new System.Drawing.Size(20, 20);
            this.tabControlMain.Location = new System.Drawing.Point(175, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(594, 345);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageWelcome
            // 
            this.tabPageWelcome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageWelcome.Controls.Add(this.labelWelcomeTitle);
            this.tabPageWelcome.Controls.Add(this.buttonWelcomCancel);
            this.tabPageWelcome.Controls.Add(this.buttonWelcomeNext);
            this.tabPageWelcome.Controls.Add(this.labelFolderHelp);
            this.tabPageWelcome.Controls.Add(this.labelFolderHint);
            this.tabPageWelcome.Controls.Add(this.labelWorkspaceStatus);
            this.tabPageWelcome.Controls.Add(this.labelWelcomeText);
            this.tabPageWelcome.Controls.Add(this.buttonViewWorkspace);
            this.tabPageWelcome.Controls.Add(this.textBoxWorkspacePath);
            this.tabPageWelcome.Location = new System.Drawing.Point(4, 24);
            this.tabPageWelcome.Name = "tabPageWelcome";
            this.tabPageWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWelcome.Size = new System.Drawing.Size(586, 317);
            this.tabPageWelcome.TabIndex = 0;
            // 
            // labelWelcomeTitle
            // 
            this.labelWelcomeTitle.AutoSize = true;
            this.labelWelcomeTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWelcomeTitle.Location = new System.Drawing.Point(28, 3);
            this.labelWelcomeTitle.Name = "labelWelcomeTitle";
            this.labelWelcomeTitle.Size = new System.Drawing.Size(65, 32);
            this.labelWelcomeTitle.TabIndex = 27;
            this.labelWelcomeTitle.Text = "欢迎";
            // 
            // buttonWelcomCancel
            // 
            this.buttonWelcomCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWelcomCancel.Location = new System.Drawing.Point(480, 282);
            this.buttonWelcomCancel.Name = "buttonWelcomCancel";
            this.buttonWelcomCancel.Size = new System.Drawing.Size(100, 29);
            this.buttonWelcomCancel.TabIndex = 26;
            this.buttonWelcomCancel.Text = "退出";
            this.buttonWelcomCancel.UseVisualStyleBackColor = true;
            this.buttonWelcomCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonWelcomeNext
            // 
            this.buttonWelcomeNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWelcomeNext.Enabled = false;
            this.buttonWelcomeNext.Location = new System.Drawing.Point(374, 282);
            this.buttonWelcomeNext.Name = "buttonWelcomeNext";
            this.buttonWelcomeNext.Size = new System.Drawing.Size(100, 29);
            this.buttonWelcomeNext.TabIndex = 25;
            this.buttonWelcomeNext.Text = "下一步";
            this.buttonWelcomeNext.UseVisualStyleBackColor = true;
            this.buttonWelcomeNext.Click += new System.EventHandler(this.buttonWelcomeNext_Click);
            // 
            // labelFolderHelp
            // 
            this.labelFolderHelp.Location = new System.Drawing.Point(31, 194);
            this.labelFolderHelp.Name = "labelFolderHelp";
            this.labelFolderHelp.Size = new System.Drawing.Size(424, 38);
            this.labelFolderHelp.TabIndex = 2;
            this.labelFolderHelp.Text = "VS Code的配置大多在特定文件夹下生效，方便您为不同的语言和不同的需求个性化配置。点击下一步以继续。";
            // 
            // labelFolderHint
            // 
            this.labelFolderHint.AutoSize = true;
            this.labelFolderHint.Location = new System.Drawing.Point(31, 111);
            this.labelFolderHint.Name = "labelFolderHint";
            this.labelFolderHint.Size = new System.Drawing.Size(427, 15);
            this.labelFolderHint.TabIndex = 1;
            this.labelFolderHint.Text = "请选择一个工作文件夹。您将来的程序和代码都将存放在此处：";
            // 
            // labelWelcomeText
            // 
            this.labelWelcomeText.Location = new System.Drawing.Point(31, 57);
            this.labelWelcomeText.Name = "labelWelcomeText";
            this.labelWelcomeText.Size = new System.Drawing.Size(422, 36);
            this.labelWelcomeText.TabIndex = 0;
            this.labelWelcomeText.Text = "欢迎您使用 VS Code C/C++ 配置工具。本工具将帮助您完成 VS Code 的配置。";
            // 
            // tabPageMinGW
            // 
            this.tabPageMinGW.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageMinGW.Controls.Add(this.labelMinGWTitle);
            this.tabPageMinGW.Controls.Add(this.panelMinGWTable);
            this.tabPageMinGW.Controls.Add(this.labelMinGWHint);
            this.tabPageMinGW.Controls.Add(this.buttonMinGWPrev);
            this.tabPageMinGW.Controls.Add(this.buttonMinGWCancel);
            this.tabPageMinGW.Controls.Add(this.buttonMinGWNext);
            this.tabPageMinGW.Controls.Add(this.labelMinGWPathHint);
            this.tabPageMinGW.Controls.Add(this.buttonViewMinGW);
            this.tabPageMinGW.Controls.Add(this.textBoxMinGWPath);
            this.tabPageMinGW.Controls.Add(this.linkLabelMinGW);
            this.tabPageMinGW.Controls.Add(this.labelMinGWState);
            this.tabPageMinGW.Location = new System.Drawing.Point(4, 24);
            this.tabPageMinGW.Name = "tabPageMinGW";
            this.tabPageMinGW.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMinGW.Size = new System.Drawing.Size(586, 317);
            this.tabPageMinGW.TabIndex = 1;
            // 
            // labelMinGWTitle
            // 
            this.labelMinGWTitle.AutoSize = true;
            this.labelMinGWTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMinGWTitle.Location = new System.Drawing.Point(28, 3);
            this.labelMinGWTitle.Name = "labelMinGWTitle";
            this.labelMinGWTitle.Size = new System.Drawing.Size(162, 32);
            this.labelMinGWTitle.TabIndex = 33;
            this.labelMinGWTitle.Text = "配置 MinGW";
            // 
            // panelMinGWTable
            // 
            this.panelMinGWTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMinGWTable.Controls.Add(this.buttonMinGWAdd);
            this.panelMinGWTable.Controls.Add(this.listViewMinGW);
            this.panelMinGWTable.Location = new System.Drawing.Point(26, 100);
            this.panelMinGWTable.Name = "panelMinGWTable";
            this.panelMinGWTable.Size = new System.Drawing.Size(541, 182);
            this.panelMinGWTable.TabIndex = 32;
            this.panelMinGWTable.Visible = false;
            // 
            // buttonMinGWAdd
            // 
            this.buttonMinGWAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMinGWAdd.Location = new System.Drawing.Point(2, 153);
            this.buttonMinGWAdd.Name = "buttonMinGWAdd";
            this.buttonMinGWAdd.Size = new System.Drawing.Size(104, 23);
            this.buttonMinGWAdd.TabIndex = 32;
            this.buttonMinGWAdd.Text = "添加...";
            this.buttonMinGWAdd.UseVisualStyleBackColor = true;
            this.buttonMinGWAdd.Click += new System.EventHandler(this.buttonMinGWAdd_Click);
            // 
            // listViewMinGW
            // 
            this.listViewMinGW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMinGW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPath,
            this.columnHeaderVersion});
            this.listViewMinGW.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMinGW.FullRowSelect = true;
            this.listViewMinGW.HideSelection = false;
            this.listViewMinGW.Location = new System.Drawing.Point(3, 5);
            this.listViewMinGW.MultiSelect = false;
            this.listViewMinGW.Name = "listViewMinGW";
            this.listViewMinGW.ShowItemToolTips = true;
            this.listViewMinGW.Size = new System.Drawing.Size(528, 142);
            this.listViewMinGW.TabIndex = 31;
            this.listViewMinGW.UseCompatibleStateImageBehavior = false;
            this.listViewMinGW.View = System.Windows.Forms.View.Details;
            this.listViewMinGW.SelectedIndexChanged += new System.EventHandler(this.listViewMinGW_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "编译环境名称";
            this.columnHeaderName.Width = 145;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "路径";
            this.columnHeaderPath.Width = 256;
            // 
            // columnHeaderVersion
            // 
            this.columnHeaderVersion.Text = "版本信息";
            this.columnHeaderVersion.Width = 200;
            // 
            // labelMinGWHint
            // 
            this.labelMinGWHint.Location = new System.Drawing.Point(25, 55);
            this.labelMinGWHint.Name = "labelMinGWHint";
            this.labelMinGWHint.Size = new System.Drawing.Size(456, 42);
            this.labelMinGWHint.TabIndex = 30;
            this.labelMinGWHint.Text = "您还没有安装 MinGW，请您点击右侧链接下载。";
            // 
            // buttonMinGWPrev
            // 
            this.buttonMinGWPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinGWPrev.Location = new System.Drawing.Point(268, 282);
            this.buttonMinGWPrev.Name = "buttonMinGWPrev";
            this.buttonMinGWPrev.Size = new System.Drawing.Size(100, 29);
            this.buttonMinGWPrev.TabIndex = 29;
            this.buttonMinGWPrev.Text = "上一步";
            this.buttonMinGWPrev.UseVisualStyleBackColor = true;
            this.buttonMinGWPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonMinGWCancel
            // 
            this.buttonMinGWCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinGWCancel.Location = new System.Drawing.Point(480, 282);
            this.buttonMinGWCancel.Name = "buttonMinGWCancel";
            this.buttonMinGWCancel.Size = new System.Drawing.Size(100, 29);
            this.buttonMinGWCancel.TabIndex = 28;
            this.buttonMinGWCancel.Text = "退出";
            this.buttonMinGWCancel.UseVisualStyleBackColor = true;
            this.buttonMinGWCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonMinGWNext
            // 
            this.buttonMinGWNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinGWNext.Enabled = false;
            this.buttonMinGWNext.Location = new System.Drawing.Point(374, 282);
            this.buttonMinGWNext.Name = "buttonMinGWNext";
            this.buttonMinGWNext.Size = new System.Drawing.Size(100, 29);
            this.buttonMinGWNext.TabIndex = 27;
            this.buttonMinGWNext.Text = "下一步";
            this.buttonMinGWNext.UseVisualStyleBackColor = true;
            this.buttonMinGWNext.Click += new System.EventHandler(this.buttonMinGWNext_Click);
            // 
            // tabPageCode
            // 
            this.tabPageCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageCode.Controls.Add(this.labelCodeTitle);
            this.tabPageCode.Controls.Add(this.labelExtensionHint);
            this.tabPageCode.Controls.Add(this.buttonRefresh);
            this.tabPageCode.Controls.Add(this.labelCodeHint);
            this.tabPageCode.Controls.Add(this.buttonCodePrev);
            this.tabPageCode.Controls.Add(this.buttonCodeCancel);
            this.tabPageCode.Controls.Add(this.buttonCodeNext);
            this.tabPageCode.Controls.Add(this.linkLabelVSCode);
            this.tabPageCode.Controls.Add(this.buttonExtension);
            this.tabPageCode.Location = new System.Drawing.Point(4, 24);
            this.tabPageCode.Name = "tabPageCode";
            this.tabPageCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCode.Size = new System.Drawing.Size(586, 317);
            this.tabPageCode.TabIndex = 3;
            // 
            // labelCodeTitle
            // 
            this.labelCodeTitle.AutoSize = true;
            this.labelCodeTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCodeTitle.Location = new System.Drawing.Point(28, 3);
            this.labelCodeTitle.Name = "labelCodeTitle";
            this.labelCodeTitle.Size = new System.Drawing.Size(255, 32);
            this.labelCodeTitle.TabIndex = 34;
            this.labelCodeTitle.Text = "安装 VS Code 和扩展";
            // 
            // labelExtensionHint
            // 
            this.labelExtensionHint.Location = new System.Drawing.Point(146, 191);
            this.labelExtensionHint.Name = "labelExtensionHint";
            this.labelExtensionHint.Size = new System.Drawing.Size(292, 45);
            this.labelExtensionHint.TabIndex = 33;
            this.labelExtensionHint.Text = "请点击左侧按钮安装 C/C++ 扩展。";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(39, 90);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 29);
            this.buttonRefresh.TabIndex = 32;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelCodeHint
            // 
            this.labelCodeHint.Location = new System.Drawing.Point(145, 90);
            this.labelCodeHint.Name = "labelCodeHint";
            this.labelCodeHint.Size = new System.Drawing.Size(293, 67);
            this.labelCodeHint.TabIndex = 31;
            this.labelCodeHint.Text = "未检测到已安装的 VS Code。请点击右侧地址下载安装。";
            // 
            // buttonCodePrev
            // 
            this.buttonCodePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCodePrev.Location = new System.Drawing.Point(268, 282);
            this.buttonCodePrev.Name = "buttonCodePrev";
            this.buttonCodePrev.Size = new System.Drawing.Size(100, 29);
            this.buttonCodePrev.TabIndex = 29;
            this.buttonCodePrev.Text = "上一步";
            this.buttonCodePrev.UseVisualStyleBackColor = true;
            this.buttonCodePrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonCodeCancel
            // 
            this.buttonCodeCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCodeCancel.Location = new System.Drawing.Point(480, 282);
            this.buttonCodeCancel.Name = "buttonCodeCancel";
            this.buttonCodeCancel.Size = new System.Drawing.Size(100, 29);
            this.buttonCodeCancel.TabIndex = 28;
            this.buttonCodeCancel.Text = "退出";
            this.buttonCodeCancel.UseVisualStyleBackColor = true;
            this.buttonCodeCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCodeNext
            // 
            this.buttonCodeNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCodeNext.Enabled = false;
            this.buttonCodeNext.Location = new System.Drawing.Point(374, 282);
            this.buttonCodeNext.Name = "buttonCodeNext";
            this.buttonCodeNext.Size = new System.Drawing.Size(100, 29);
            this.buttonCodeNext.TabIndex = 27;
            this.buttonCodeNext.Text = "下一步";
            this.buttonCodeNext.UseVisualStyleBackColor = true;
            this.buttonCodeNext.Click += new System.EventHandler(this.buttonCodeNext_Click);
            // 
            // tabPageStyle
            // 
            this.tabPageStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageStyle.Controls.Add(this.pictureBoxExternal);
            this.tabPageStyle.Controls.Add(this.pictureBoxInternal);
            this.tabPageStyle.Controls.Add(this.labelExternalHint);
            this.tabPageStyle.Controls.Add(this.labelInternalHint);
            this.tabPageStyle.Controls.Add(this.radioButtonExternal);
            this.tabPageStyle.Controls.Add(this.radioButtonInternal);
            this.tabPageStyle.Controls.Add(this.labelStyleTitle);
            this.tabPageStyle.Controls.Add(this.buttonConfigPrev);
            this.tabPageStyle.Controls.Add(this.buttonConfigCancel);
            this.tabPageStyle.Controls.Add(this.buttonConfigNext);
            this.tabPageStyle.Location = new System.Drawing.Point(4, 24);
            this.tabPageStyle.Name = "tabPageStyle";
            this.tabPageStyle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStyle.Size = new System.Drawing.Size(586, 317);
            this.tabPageStyle.TabIndex = 4;
            // 
            // pictureBoxExternal
            // 
            this.pictureBoxExternal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExternal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExternal.Image")));
            this.pictureBoxExternal.Location = new System.Drawing.Point(461, 164);
            this.pictureBoxExternal.Name = "pictureBoxExternal";
            this.pictureBoxExternal.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxExternal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExternal.TabIndex = 41;
            this.pictureBoxExternal.TabStop = false;
            // 
            // pictureBoxInternal
            // 
            this.pictureBoxInternal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxInternal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInternal.Image")));
            this.pictureBoxInternal.Location = new System.Drawing.Point(461, 38);
            this.pictureBoxInternal.Name = "pictureBoxInternal";
            this.pictureBoxInternal.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxInternal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInternal.TabIndex = 40;
            this.pictureBoxInternal.TabStop = false;
            // 
            // labelExternalHint
            // 
            this.labelExternalHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExternalHint.Location = new System.Drawing.Point(33, 186);
            this.labelExternalHint.Name = "labelExternalHint";
            this.labelExternalHint.Size = new System.Drawing.Size(419, 93);
            this.labelExternalHint.TabIndex = 39;
            this.labelExternalHint.Text = "弹出窗口说明";
            // 
            // labelInternalHint
            // 
            this.labelInternalHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInternalHint.Location = new System.Drawing.Point(33, 60);
            this.labelInternalHint.Name = "labelInternalHint";
            this.labelInternalHint.Size = new System.Drawing.Size(419, 101);
            this.labelInternalHint.TabIndex = 38;
            this.labelInternalHint.Text = "内置终端说明";
            // 
            // radioButtonExternal
            // 
            this.radioButtonExternal.AutoSize = true;
            this.radioButtonExternal.Location = new System.Drawing.Point(36, 164);
            this.radioButtonExternal.Name = "radioButtonExternal";
            this.radioButtonExternal.Size = new System.Drawing.Size(223, 19);
            this.radioButtonExternal.TabIndex = 37;
            this.radioButtonExternal.Text = "外部弹窗样式（实验性功能）";
            this.radioButtonExternal.UseVisualStyleBackColor = true;
            // 
            // radioButtonInternal
            // 
            this.radioButtonInternal.AutoSize = true;
            this.radioButtonInternal.Checked = true;
            this.radioButtonInternal.Location = new System.Drawing.Point(36, 38);
            this.radioButtonInternal.Name = "radioButtonInternal";
            this.radioButtonInternal.Size = new System.Drawing.Size(118, 19);
            this.radioButtonInternal.TabIndex = 36;
            this.radioButtonInternal.TabStop = true;
            this.radioButtonInternal.Text = "内部终端样式";
            this.radioButtonInternal.UseVisualStyleBackColor = true;
            // 
            // labelStyleTitle
            // 
            this.labelStyleTitle.AutoSize = true;
            this.labelStyleTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStyleTitle.Location = new System.Drawing.Point(28, 3);
            this.labelStyleTitle.Name = "labelStyleTitle";
            this.labelStyleTitle.Size = new System.Drawing.Size(215, 32);
            this.labelStyleTitle.TabIndex = 35;
            this.labelStyleTitle.Text = "选择您喜欢的样式";
            // 
            // buttonConfigPrev
            // 
            this.buttonConfigPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigPrev.Location = new System.Drawing.Point(268, 282);
            this.buttonConfigPrev.Name = "buttonConfigPrev";
            this.buttonConfigPrev.Size = new System.Drawing.Size(100, 29);
            this.buttonConfigPrev.TabIndex = 29;
            this.buttonConfigPrev.Text = "上一步";
            this.buttonConfigPrev.UseVisualStyleBackColor = true;
            this.buttonConfigPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonConfigCancel
            // 
            this.buttonConfigCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigCancel.Location = new System.Drawing.Point(480, 282);
            this.buttonConfigCancel.Name = "buttonConfigCancel";
            this.buttonConfigCancel.Size = new System.Drawing.Size(100, 29);
            this.buttonConfigCancel.TabIndex = 28;
            this.buttonConfigCancel.Text = "退出";
            this.buttonConfigCancel.UseVisualStyleBackColor = true;
            this.buttonConfigCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfigNext
            // 
            this.buttonConfigNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigNext.Location = new System.Drawing.Point(374, 282);
            this.buttonConfigNext.Name = "buttonConfigNext";
            this.buttonConfigNext.Size = new System.Drawing.Size(100, 29);
            this.buttonConfigNext.TabIndex = 27;
            this.buttonConfigNext.Text = "下一步";
            this.buttonConfigNext.UseVisualStyleBackColor = true;
            this.buttonConfigNext.Click += new System.EventHandler(this.buttonConfigNext_Click);
            // 
            // tabPageFinish
            // 
            this.tabPageFinish.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPageFinish.Controls.Add(this.checkBoxDesktopShortcut);
            this.tabPageFinish.Controls.Add(this.labelFinishHint);
            this.tabPageFinish.Controls.Add(this.labelFinishTitle);
            this.tabPageFinish.Controls.Add(this.checkBoxGenTest);
            this.tabPageFinish.Controls.Add(this.checkBoxOpen);
            this.tabPageFinish.Controls.Add(this.buttonFinishAll);
            this.tabPageFinish.Location = new System.Drawing.Point(4, 24);
            this.tabPageFinish.Name = "tabPageFinish";
            this.tabPageFinish.Size = new System.Drawing.Size(586, 317);
            this.tabPageFinish.TabIndex = 5;
            // 
            // checkBoxDesktopShortcut
            // 
            this.checkBoxDesktopShortcut.AutoSize = true;
            this.checkBoxDesktopShortcut.Location = new System.Drawing.Point(34, 158);
            this.checkBoxDesktopShortcut.Name = "checkBoxDesktopShortcut";
            this.checkBoxDesktopShortcut.Size = new System.Drawing.Size(299, 19);
            this.checkBoxDesktopShortcut.TabIndex = 38;
            this.checkBoxDesktopShortcut.Text = "创建桌面快捷方式（建议“小白”勾选）";
            this.checkBoxDesktopShortcut.UseVisualStyleBackColor = true;
            // 
            // labelFinishHint
            // 
            this.labelFinishHint.AutoSize = true;
            this.labelFinishHint.Location = new System.Drawing.Point(25, 53);
            this.labelFinishHint.Name = "labelFinishHint";
            this.labelFinishHint.Size = new System.Drawing.Size(217, 15);
            this.labelFinishHint.TabIndex = 37;
            this.labelFinishHint.Text = "恭喜您，您已成功完成了配置。";
            // 
            // labelFinishTitle
            // 
            this.labelFinishTitle.AutoSize = true;
            this.labelFinishTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFinishTitle.Location = new System.Drawing.Point(28, 3);
            this.labelFinishTitle.Name = "labelFinishTitle";
            this.labelFinishTitle.Size = new System.Drawing.Size(165, 32);
            this.labelFinishTitle.TabIndex = 36;
            this.labelFinishTitle.Text = "配置成功完成";
            // 
            // buttonFinishAll
            // 
            this.buttonFinishAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinishAll.Location = new System.Drawing.Point(374, 282);
            this.buttonFinishAll.Name = "buttonFinishAll";
            this.buttonFinishAll.Size = new System.Drawing.Size(100, 29);
            this.buttonFinishAll.TabIndex = 30;
            this.buttonFinishAll.Text = "完成";
            this.buttonFinishAll.UseVisualStyleBackColor = true;
            this.buttonFinishAll.Click += new System.EventHandler(this.buttonFinishAll_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.Location = new System.Drawing.Point(30, 328);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(120, 29);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "设置";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelNavigate
            // 
            this.panelNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelNavigate.Location = new System.Drawing.Point(30, 157);
            this.panelNavigate.Name = "panelNavigate";
            this.panelNavigate.Size = new System.Drawing.Size(120, 165);
            this.panelNavigate.TabIndex = 5;
            this.panelNavigate.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNavigate_Paint);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(30, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 396);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelNavigate);
            this.Controls.Add(this.linkLabelManual);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "VS Code C++配置工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageWelcome.ResumeLayout(false);
            this.tabPageWelcome.PerformLayout();
            this.tabPageMinGW.ResumeLayout(false);
            this.tabPageMinGW.PerformLayout();
            this.panelMinGWTable.ResumeLayout(false);
            this.tabPageCode.ResumeLayout(false);
            this.tabPageCode.PerformLayout();
            this.tabPageStyle.ResumeLayout(false);
            this.tabPageStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExternal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInternal)).EndInit();
            this.tabPageFinish.ResumeLayout(false);
            this.tabPageFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMinGWPath;
        private System.Windows.Forms.Button buttonViewMinGW;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelMinGWState;
        private System.Windows.Forms.Button buttonExtension;
        private System.Windows.Forms.Label labelMinGWPathHint;
        private System.Windows.Forms.LinkLabel linkLabelVSCode;
        private System.Windows.Forms.LinkLabel linkLabelMinGW;
        private System.Windows.Forms.Button buttonViewWorkspace;
        private System.Windows.Forms.TextBox textBoxWorkspacePath;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.LinkLabel linkLabelManual;
        private System.Windows.Forms.Label labelWorkspaceStatus;
        private System.Windows.Forms.CheckBox checkBoxOpen;
        private System.Windows.Forms.CheckBox checkBoxGenTest;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageWelcome;
        private System.Windows.Forms.TabPage tabPageMinGW;
        private System.Windows.Forms.Label labelFolderHelp;
        private System.Windows.Forms.Label labelFolderHint;
        private System.Windows.Forms.Label labelWelcomeText;
        private System.Windows.Forms.Button buttonWelcomCancel;
        private System.Windows.Forms.Button buttonWelcomeNext;
        private System.Windows.Forms.Label labelMinGWHint;
        private System.Windows.Forms.Button buttonMinGWPrev;
        private System.Windows.Forms.Button buttonMinGWCancel;
        private System.Windows.Forms.Button buttonMinGWNext;
        private System.Windows.Forms.TabPage tabPageCode;
        private System.Windows.Forms.Button buttonCodePrev;
        private System.Windows.Forms.Button buttonCodeCancel;
        private System.Windows.Forms.Button buttonCodeNext;
        private System.Windows.Forms.TabPage tabPageStyle;
        private System.Windows.Forms.Button buttonConfigPrev;
        private System.Windows.Forms.Button buttonConfigCancel;
        private System.Windows.Forms.Button buttonConfigNext;
        private System.Windows.Forms.ListView listViewMinGW;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderVersion;
        private System.Windows.Forms.Panel panelMinGWTable;
        private System.Windows.Forms.Button buttonMinGWAdd;
        private System.Windows.Forms.Label labelCodeHint;
        private System.Windows.Forms.TabPage tabPageFinish;
        private System.Windows.Forms.Button buttonFinishAll;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelWelcomeTitle;
        private System.Windows.Forms.Label labelMinGWTitle;
        private System.Windows.Forms.Label labelExtensionHint;
        private System.Windows.Forms.Label labelCodeTitle;
        private System.Windows.Forms.Label labelStyleTitle;
        private System.Windows.Forms.Label labelFinishHint;
        private System.Windows.Forms.Label labelFinishTitle;
        private System.Windows.Forms.Panel panelNavigate;
        private System.Windows.Forms.RadioButton radioButtonExternal;
        private System.Windows.Forms.RadioButton radioButtonInternal;
        private System.Windows.Forms.Label labelExternalHint;
        private System.Windows.Forms.Label labelInternalHint;
        private System.Windows.Forms.PictureBox pictureBoxExternal;
        private System.Windows.Forms.PictureBox pictureBoxInternal;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.CheckBox checkBoxDesktopShortcut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

