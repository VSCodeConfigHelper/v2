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
            this.radioButtonPKU = new System.Windows.Forms.RadioButton();
            this.linkLabelLicense = new System.Windows.Forms.LinkLabel();
            this.pictureGitHub = new System.Windows.Forms.PictureBox();
            this.groupBoxPrivil.SuspendLayout();
            this.groupBoxArg.SuspendLayout();
            this.groupBoxMinGWSrc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPrivil
            // 
            this.groupBoxPrivil.Controls.Add(this.buttonAuth);
            this.groupBoxPrivil.Controls.Add(this.labelAuth);
            this.groupBoxPrivil.Location = new System.Drawing.Point(12, 108);
            this.groupBoxPrivil.Name = "groupBoxPrivil";
            this.groupBoxPrivil.Size = new System.Drawing.Size(421, 132);
            this.groupBoxPrivil.TabIndex = 9;
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
            this.groupBoxArg.Location = new System.Drawing.Point(12, 246);
            this.groupBoxArg.Name = "groupBoxArg";
            this.groupBoxArg.Size = new System.Drawing.Size(421, 234);
            this.groupBoxArg.TabIndex = 8;
            this.groupBoxArg.TabStop = false;
            this.groupBoxArg.Text = "配置编译参数";
            // 
            // buttonArgDefault
            // 
            this.buttonArgDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonArgDefault.Location = new System.Drawing.Point(6, 199);
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
            this.labelArgInstruction.Location = new System.Drawing.Point(186, 198);
            this.labelArgInstruction.Name = "labelArgInstruction";
            this.labelArgInstruction.Size = new System.Drawing.Size(226, 30);
            this.labelArgInstruction.TabIndex = 5;
            this.labelArgInstruction.Text = "每行一个参数；支持 VS Code 配置变量。";
            // 
            // buttonSaveArgs
            // 
            this.buttonSaveArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveArgs.Location = new System.Drawing.Point(96, 199);
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
            this.textBoxArgs.Size = new System.Drawing.Size(406, 144);
            this.textBoxArgs.TabIndex = 2;
            // 
            // groupBoxMinGWSrc
            // 
            this.groupBoxMinGWSrc.Controls.Add(this.labelMinGWSrcInstruction);
            this.groupBoxMinGWSrc.Controls.Add(this.radioButtonOffical);
            this.groupBoxMinGWSrc.Controls.Add(this.radioButtonPKU);
            this.groupBoxMinGWSrc.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMinGWSrc.Name = "groupBoxMinGWSrc";
            this.groupBoxMinGWSrc.Size = new System.Drawing.Size(421, 90);
            this.groupBoxMinGWSrc.TabIndex = 7;
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
            // 
            // linkLabelLicense
            // 
            this.linkLabelLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabelLicense.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelLicense.Location = new System.Drawing.Point(18, 500);
            this.linkLabelLicense.Name = "linkLabelLicense";
            this.linkLabelLicense.Size = new System.Drawing.Size(346, 30);
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
            this.pictureGitHub.Location = new System.Drawing.Point(383, 486);
            this.pictureGitHub.Name = "pictureGitHub";
            this.pictureGitHub.Size = new System.Drawing.Size(50, 50);
            this.pictureGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGitHub.TabIndex = 11;
            this.pictureGitHub.TabStop = false;
            this.pictureGitHub.Click += new System.EventHandler(this.pictureGitHub_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 539);
            this.Controls.Add(this.pictureGitHub);
            this.Controls.Add(this.linkLabelLicense);
            this.Controls.Add(this.groupBoxPrivil);
            this.Controls.Add(this.groupBoxArg);
            this.Controls.Add(this.groupBoxMinGWSrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.RadioButton radioButtonPKU;
        private System.Windows.Forms.LinkLabel linkLabelLicense;
        private System.Windows.Forms.PictureBox pictureGitHub;
    }
}