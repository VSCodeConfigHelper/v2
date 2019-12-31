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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
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
            this.tabPageMore = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.labelWorkspaceHint = new System.Windows.Forms.Label();
            this.textBoxWorkspacePath = new System.Windows.Forms.TextBox();
            this.buttonViewWorkspace = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.labelConfigState = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            this.tabPageMore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStart);
            this.tabControlMain.Controls.Add(this.tabPageMore);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(307, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageStart
            // 
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
            this.tabPageStart.Location = new System.Drawing.Point(4, 22);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStart.Size = new System.Drawing.Size(299, 424);
            this.tabPageStart.TabIndex = 0;
            this.tabPageStart.Text = "开始";
            this.tabPageStart.UseVisualStyleBackColor = true;
            // 
            // linkLabelVSCode
            // 
            this.linkLabelVSCode.AutoSize = true;
            this.linkLabelVSCode.Location = new System.Drawing.Point(222, 216);
            this.linkLabelVSCode.Name = "linkLabelVSCode";
            this.linkLabelVSCode.Size = new System.Drawing.Size(71, 12);
            this.linkLabelVSCode.TabIndex = 16;
            this.linkLabelVSCode.TabStop = true;
            this.linkLabelVSCode.Text = "下载地址...";
            this.linkLabelVSCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelVSCode_LinkClicked);
            // 
            // linkLabelMinGW
            // 
            this.linkLabelMinGW.AutoSize = true;
            this.linkLabelMinGW.Location = new System.Drawing.Point(222, 23);
            this.linkLabelMinGW.Name = "linkLabelMinGW";
            this.linkLabelMinGW.Size = new System.Drawing.Size(71, 12);
            this.linkLabelMinGW.TabIndex = 15;
            this.linkLabelMinGW.TabStop = true;
            this.linkLabelMinGW.Text = "下载地址...";
            this.linkLabelMinGW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMinGW_LinkClicked);
            // 
            // labelMinGWPathHint
            // 
            this.labelMinGWPathHint.Location = new System.Drawing.Point(6, 68);
            this.labelMinGWPathHint.Name = "labelMinGWPathHint";
            this.labelMinGWPathHint.Size = new System.Drawing.Size(287, 25);
            this.labelMinGWPathHint.TabIndex = 14;
            this.labelMinGWPathHint.Text = "输入你刚刚下载（或者安装）得到的 mingw64 这个文件夹的路径：";
            // 
            // labelExtensionHint
            // 
            this.labelExtensionHint.Location = new System.Drawing.Point(102, 252);
            this.labelExtensionHint.Name = "labelExtensionHint";
            this.labelExtensionHint.Size = new System.Drawing.Size(191, 29);
            this.labelExtensionHint.TabIndex = 11;
            this.labelExtensionHint.Text = "点击右侧按钮，选择 Install 。如失败，请检查 VS Code 是否安装。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "第五步：安装插件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "第四步：下载 VS Code 并安装";
            // 
            // buttonExtension
            // 
            this.buttonExtension.Location = new System.Drawing.Point(6, 252);
            this.buttonExtension.Name = "buttonExtension";
            this.buttonExtension.Size = new System.Drawing.Size(85, 23);
            this.buttonExtension.TabIndex = 8;
            this.buttonExtension.Text = "安装插件...";
            this.buttonExtension.UseVisualStyleBackColor = true;
            this.buttonExtension.Click += new System.EventHandler(this.ButtonExtension_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "第三步：设置环境变量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "第二步：输入 MinGW 路径";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "第一步：下载 MinGW(-w64)";
            // 
            // labelMinGWState
            // 
            this.labelMinGWState.Location = new System.Drawing.Point(4, 120);
            this.labelMinGWState.Name = "labelMinGWState";
            this.labelMinGWState.Size = new System.Drawing.Size(289, 36);
            this.labelMinGWState.TabIndex = 4;
            this.labelMinGWState.Text = "     ";
            // 
            // labelPathState
            // 
            this.labelPathState.Location = new System.Drawing.Point(97, 185);
            this.labelPathState.Name = "labelPathState";
            this.labelPathState.Size = new System.Drawing.Size(196, 12);
            this.labelPathState.TabIndex = 3;
            this.labelPathState.Text = "     ";
            // 
            // buttonSetEnv
            // 
            this.buttonSetEnv.Location = new System.Drawing.Point(6, 180);
            this.buttonSetEnv.Name = "buttonSetEnv";
            this.buttonSetEnv.Size = new System.Drawing.Size(85, 23);
            this.buttonSetEnv.TabIndex = 2;
            this.buttonSetEnv.Text = "设置环境变量";
            this.buttonSetEnv.UseVisualStyleBackColor = true;
            this.buttonSetEnv.Click += new System.EventHandler(this.ButtonSetEnv_Click);
            // 
            // textBoxMinGWPath
            // 
            this.textBoxMinGWPath.Location = new System.Drawing.Point(6, 94);
            this.textBoxMinGWPath.Name = "textBoxMinGWPath";
            this.textBoxMinGWPath.Size = new System.Drawing.Size(208, 21);
            this.textBoxMinGWPath.TabIndex = 1;
            this.textBoxMinGWPath.TextChanged += new System.EventHandler(this.TextBoxMinGWPath_TextChanged);
            // 
            // buttonViewMinGW
            // 
            this.buttonViewMinGW.Location = new System.Drawing.Point(220, 94);
            this.buttonViewMinGW.Name = "buttonViewMinGW";
            this.buttonViewMinGW.Size = new System.Drawing.Size(73, 21);
            this.buttonViewMinGW.TabIndex = 0;
            this.buttonViewMinGW.Text = "浏览...";
            this.buttonViewMinGW.UseVisualStyleBackColor = true;
            this.buttonViewMinGW.Click += new System.EventHandler(this.ButtonViewMinGW_Click);
            // 
            // tabPageMore
            // 
            this.tabPageMore.Controls.Add(this.labelAuthor);
            this.tabPageMore.Location = new System.Drawing.Point(4, 22);
            this.tabPageMore.Name = "tabPageMore";
            this.tabPageMore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMore.Size = new System.Drawing.Size(299, 424);
            this.tabPageMore.TabIndex = 1;
            this.tabPageMore.Text = "更多";
            this.tabPageMore.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "第六步：选择工作文件夹";
            // 
            // labelWorkspaceHint
            // 
            this.labelWorkspaceHint.AutoSize = true;
            this.labelWorkspaceHint.Location = new System.Drawing.Point(3, 312);
            this.labelWorkspaceHint.Name = "labelWorkspaceHint";
            this.labelWorkspaceHint.Size = new System.Drawing.Size(257, 12);
            this.labelWorkspaceHint.TabIndex = 18;
            this.labelWorkspaceHint.Text = "选择一个文件夹，将来你的程序都存放在此处：";
            // 
            // textBoxWorkspacePath
            // 
            this.textBoxWorkspacePath.Location = new System.Drawing.Point(6, 327);
            this.textBoxWorkspacePath.Name = "textBoxWorkspacePath";
            this.textBoxWorkspacePath.Size = new System.Drawing.Size(208, 21);
            this.textBoxWorkspacePath.TabIndex = 19;
            // 
            // buttonViewWorkspace
            // 
            this.buttonViewWorkspace.Location = new System.Drawing.Point(220, 327);
            this.buttonViewWorkspace.Name = "buttonViewWorkspace";
            this.buttonViewWorkspace.Size = new System.Drawing.Size(73, 21);
            this.buttonViewWorkspace.TabIndex = 20;
            this.buttonViewWorkspace.Text = "浏览...";
            this.buttonViewWorkspace.UseVisualStyleBackColor = true;
            this.buttonViewWorkspace.Click += new System.EventHandler(this.ButtonViewWorkspace_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "第七步：一键配置";
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(6, 376);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(85, 23);
            this.buttonConfig.TabIndex = 22;
            this.buttonConfig.Text = "一键配置";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // labelConfigState
            // 
            this.labelConfigState.Location = new System.Drawing.Point(97, 381);
            this.labelConfigState.Name = "labelConfigState";
            this.labelConfigState.Size = new System.Drawing.Size(196, 40);
            this.labelConfigState.TabIndex = 23;
            this.labelConfigState.Text = "     ";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(6, 409);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(197, 12);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "谷雨同学制作 guyutongxue@163.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 474);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "VS Code C++配置工具";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            this.tabPageStart.PerformLayout();
            this.tabPageMore.ResumeLayout(false);
            this.tabPageMore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.TextBox textBoxMinGWPath;
        private System.Windows.Forms.Button buttonViewMinGW;
        private System.Windows.Forms.TabPage tabPageMore;
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
    }
}

