namespace WindowsMigrationUtility
{
    partial class USMTForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USMTForm));
            this.SystemGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoteSystemHelpButton = new System.Windows.Forms.Button();
            this.RemoteSystemTextBox = new System.Windows.Forms.TextBox();
            this.RemoteSystemRadioButton = new System.Windows.Forms.RadioButton();
            this.LocalSystemRadioButton = new System.Windows.Forms.RadioButton();
            this.BackupOptionGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RestoreRadioButton = new System.Windows.Forms.RadioButton();
            this.CaptureRadioButton = new System.Windows.Forms.RadioButton();
            this.USMTGroupBox = new System.Windows.Forms.GroupBox();
            this.HardLinkCheckBox = new System.Windows.Forms.CheckBox();
            this.USMTStorePathTextBox = new System.Windows.Forms.TextBox();
            this.USMTPathLabel = new System.Windows.Forms.Label();
            this.DecryptionTextBox = new System.Windows.Forms.TextBox();
            this.DecryptionCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configFIleOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wMUHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSMTHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogLocationLabel = new System.Windows.Forms.Label();
            this.LogPathLabel = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ProcessProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SleepTimer = new System.Windows.Forms.Timer(this.components);
            this.RemoteLogPathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SystemGroupBox.SuspendLayout();
            this.BackupOptionGroupBox.SuspendLayout();
            this.USMTGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemGroupBox
            // 
            this.SystemGroupBox.Controls.Add(this.RemoteSystemHelpButton);
            this.SystemGroupBox.Controls.Add(this.RemoteSystemTextBox);
            this.SystemGroupBox.Controls.Add(this.RemoteSystemRadioButton);
            this.SystemGroupBox.Controls.Add(this.LocalSystemRadioButton);
            this.SystemGroupBox.Location = new System.Drawing.Point(12, 27);
            this.SystemGroupBox.Name = "SystemGroupBox";
            this.SystemGroupBox.Size = new System.Drawing.Size(428, 60);
            this.SystemGroupBox.TabIndex = 0;
            this.SystemGroupBox.TabStop = false;
            this.SystemGroupBox.Text = "System Type Information:";
            // 
            // RemoteSystemHelpButton
            // 
            this.RemoteSystemHelpButton.BackgroundImage = global::WindowsMigrationUtility.Properties.Resources.Help_icon;
            this.RemoteSystemHelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoteSystemHelpButton.Location = new System.Drawing.Point(393, 22);
            this.RemoteSystemHelpButton.Name = "RemoteSystemHelpButton";
            this.RemoteSystemHelpButton.Size = new System.Drawing.Size(29, 29);
            this.RemoteSystemHelpButton.TabIndex = 4;
            this.RemoteSystemHelpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RemoteSystemHelpButton.UseVisualStyleBackColor = true;
            this.RemoteSystemHelpButton.Click += new System.EventHandler(this.RemoteSystemHelpButton_Click);
            // 
            // RemoteSystemTextBox
            // 
            this.RemoteSystemTextBox.Location = new System.Drawing.Point(256, 27);
            this.RemoteSystemTextBox.Name = "RemoteSystemTextBox";
            this.RemoteSystemTextBox.Size = new System.Drawing.Size(133, 20);
            this.RemoteSystemTextBox.TabIndex = 2;
            // 
            // RemoteSystemRadioButton
            // 
            this.RemoteSystemRadioButton.AutoSize = true;
            this.RemoteSystemRadioButton.Location = new System.Drawing.Point(148, 28);
            this.RemoteSystemRadioButton.Name = "RemoteSystemRadioButton";
            this.RemoteSystemRadioButton.Size = new System.Drawing.Size(109, 20);
            this.RemoteSystemRadioButton.TabIndex = 1;
            this.RemoteSystemRadioButton.TabStop = true;
            this.RemoteSystemRadioButton.Text = "Remote System:";
            this.RemoteSystemRadioButton.UseVisualStyleBackColor = true;
            // 
            // LocalSystemRadioButton
            // 
            this.LocalSystemRadioButton.AutoSize = true;
            this.LocalSystemRadioButton.Location = new System.Drawing.Point(23, 28);
            this.LocalSystemRadioButton.Name = "LocalSystemRadioButton";
            this.LocalSystemRadioButton.Size = new System.Drawing.Size(95, 20);
            this.LocalSystemRadioButton.TabIndex = 0;
            this.LocalSystemRadioButton.TabStop = true;
            this.LocalSystemRadioButton.Text = "Local System";
            this.LocalSystemRadioButton.UseVisualStyleBackColor = true;
            this.LocalSystemRadioButton.CheckedChanged += new System.EventHandler(this.LocalSystemRadioButton_CheckedChanged);
            // 
            // BackupOptionGroupBox
            // 
            this.BackupOptionGroupBox.Controls.Add(this.label1);
            this.BackupOptionGroupBox.Controls.Add(this.RestoreRadioButton);
            this.BackupOptionGroupBox.Controls.Add(this.CaptureRadioButton);
            this.BackupOptionGroupBox.Location = new System.Drawing.Point(12, 93);
            this.BackupOptionGroupBox.Name = "BackupOptionGroupBox";
            this.BackupOptionGroupBox.Size = new System.Drawing.Size(428, 86);
            this.BackupOptionGroupBox.TabIndex = 1;
            this.BackupOptionGroupBox.TabStop = false;
            this.BackupOptionGroupBox.Text = "Select Your Option:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOTE: USMT DOES NOT SUPPORT MAPPED DRIVES";
            // 
            // RestoreRadioButton
            // 
            this.RestoreRadioButton.AutoSize = true;
            this.RestoreRadioButton.Location = new System.Drawing.Point(296, 28);
            this.RestoreRadioButton.Name = "RestoreRadioButton";
            this.RestoreRadioButton.Size = new System.Drawing.Size(69, 20);
            this.RestoreRadioButton.TabIndex = 1;
            this.RestoreRadioButton.TabStop = true;
            this.RestoreRadioButton.Text = "Restore";
            this.RestoreRadioButton.UseVisualStyleBackColor = true;
            this.RestoreRadioButton.CheckedChanged += new System.EventHandler(this.Restore_CheckedChanged);
            // 
            // CaptureRadioButton
            // 
            this.CaptureRadioButton.AutoSize = true;
            this.CaptureRadioButton.Location = new System.Drawing.Point(23, 28);
            this.CaptureRadioButton.Name = "CaptureRadioButton";
            this.CaptureRadioButton.Size = new System.Drawing.Size(69, 20);
            this.CaptureRadioButton.TabIndex = 0;
            this.CaptureRadioButton.TabStop = true;
            this.CaptureRadioButton.Text = "Capture";
            this.CaptureRadioButton.UseVisualStyleBackColor = true;
            this.CaptureRadioButton.CheckedChanged += new System.EventHandler(this.CaptureRadioButton_CheckedChanged);
            // 
            // USMTGroupBox
            // 
            this.USMTGroupBox.Controls.Add(this.HardLinkCheckBox);
            this.USMTGroupBox.Controls.Add(this.USMTStorePathTextBox);
            this.USMTGroupBox.Controls.Add(this.USMTPathLabel);
            this.USMTGroupBox.Controls.Add(this.DecryptionTextBox);
            this.USMTGroupBox.Controls.Add(this.DecryptionCheckBox);
            this.USMTGroupBox.Location = new System.Drawing.Point(12, 185);
            this.USMTGroupBox.Name = "USMTGroupBox";
            this.USMTGroupBox.Size = new System.Drawing.Size(428, 124);
            this.USMTGroupBox.TabIndex = 2;
            this.USMTGroupBox.TabStop = false;
            this.USMTGroupBox.Text = "USMT Options:";
            // 
            // HardLinkCheckBox
            // 
            this.HardLinkCheckBox.AutoSize = true;
            this.HardLinkCheckBox.Checked = global::WindowsMigrationUtility.Properties.Settings.Default.HardLink;
            this.HardLinkCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsMigrationUtility.Properties.Settings.Default, "HardLink", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.HardLinkCheckBox.Location = new System.Drawing.Point(6, 52);
            this.HardLinkCheckBox.Name = "HardLinkCheckBox";
            this.HardLinkCheckBox.Size = new System.Drawing.Size(79, 21);
            this.HardLinkCheckBox.TabIndex = 2;
            this.HardLinkCheckBox.Text = "Hard Link";
            this.HardLinkCheckBox.UseVisualStyleBackColor = true;
            this.HardLinkCheckBox.CheckedChanged += new System.EventHandler(this.HardLinkCheckBox_CheckedChanged);
            // 
            // USMTStorePathTextBox
            // 
            this.USMTStorePathTextBox.Location = new System.Drawing.Point(75, 82);
            this.USMTStorePathTextBox.Name = "USMTStorePathTextBox";
            this.USMTStorePathTextBox.Size = new System.Drawing.Size(339, 20);
            this.USMTStorePathTextBox.TabIndex = 3;
            // 
            // USMTPathLabel
            // 
            this.USMTPathLabel.AutoSize = true;
            this.USMTPathLabel.Location = new System.Drawing.Point(3, 85);
            this.USMTPathLabel.Name = "USMTPathLabel";
            this.USMTPathLabel.Size = new System.Drawing.Size(66, 13);
            this.USMTPathLabel.TabIndex = 2;
            this.USMTPathLabel.Text = "USMT Path:";
            // 
            // DecryptionTextBox
            // 
            this.DecryptionTextBox.Location = new System.Drawing.Point(148, 27);
            this.DecryptionTextBox.Name = "DecryptionTextBox";
            this.DecryptionTextBox.Size = new System.Drawing.Size(266, 20);
            this.DecryptionTextBox.TabIndex = 1;
            // 
            // DecryptionCheckBox
            // 
            this.DecryptionCheckBox.AutoSize = true;
            this.DecryptionCheckBox.Location = new System.Drawing.Point(6, 29);
            this.DecryptionCheckBox.Name = "DecryptionCheckBox";
            this.DecryptionCheckBox.Size = new System.Drawing.Size(146, 21);
            this.DecryptionCheckBox.TabIndex = 0;
            this.DecryptionCheckBox.Text = "Custom Decryption Key:";
            this.DecryptionCheckBox.UseVisualStyleBackColor = true;
            this.DecryptionCheckBox.CheckedChanged += new System.EventHandler(this.DecryptionCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configFIleOptionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "E&dit";
            // 
            // configFIleOptionsToolStripMenuItem
            // 
            this.configFIleOptionsToolStripMenuItem.Name = "configFIleOptionsToolStripMenuItem";
            this.configFIleOptionsToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.configFIleOptionsToolStripMenuItem.Text = "Configuration";
            this.configFIleOptionsToolStripMenuItem.Click += new System.EventHandler(this.configFIleOptionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wMUHelpToolStripMenuItem,
            this.uSMTHelpToolStripMenuItem,
            this.releaseNotesToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // wMUHelpToolStripMenuItem
            // 
            this.wMUHelpToolStripMenuItem.Name = "wMUHelpToolStripMenuItem";
            this.wMUHelpToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.wMUHelpToolStripMenuItem.Text = "WMU Help";
            this.wMUHelpToolStripMenuItem.Click += new System.EventHandler(this.wMUHelpToolStripMenuItem_Click);
            // 
            // uSMTHelpToolStripMenuItem
            // 
            this.uSMTHelpToolStripMenuItem.Name = "uSMTHelpToolStripMenuItem";
            this.uSMTHelpToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.uSMTHelpToolStripMenuItem.Text = "USMT Help";
            this.uSMTHelpToolStripMenuItem.Click += new System.EventHandler(this.uSMTHelpToolStripMenuItem_Click);
            // 
            // releaseNotesToolStripMenuItem
            // 
            this.releaseNotesToolStripMenuItem.Name = "releaseNotesToolStripMenuItem";
            this.releaseNotesToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.releaseNotesToolStripMenuItem.Text = "Release &Notes";
            this.releaseNotesToolStripMenuItem.Click += new System.EventHandler(this.releaseNotesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.aboutToolStripMenuItem.Text = "&About WMU";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LogLocationLabel
            // 
            this.LogLocationLabel.AutoSize = true;
            this.LogLocationLabel.Location = new System.Drawing.Point(9, 332);
            this.LogLocationLabel.Name = "LogLocationLabel";
            this.LogLocationLabel.Size = new System.Drawing.Size(209, 13);
            this.LogLocationLabel.TabIndex = 4;
            this.LogLocationLabel.Text = "Log Files are Stored in the Location Below:";
            // 
            // LogPathLabel
            // 
            this.LogPathLabel.AutoSize = true;
            this.LogPathLabel.Location = new System.Drawing.Point(104, 354);
            this.LogPathLabel.Name = "LogPathLabel";
            this.LogPathLabel.Size = new System.Drawing.Size(19, 13);
            this.LogPathLabel.TabIndex = 5;
            this.LogPathLabel.Text = "....";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(365, 327);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "&Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ProcessProgressBar1
            // 
            this.ProcessProgressBar1.Location = new System.Drawing.Point(12, 402);
            this.ProcessProgressBar1.Name = "ProcessProgressBar1";
            this.ProcessProgressBar1.Size = new System.Drawing.Size(428, 14);
            this.ProcessProgressBar1.TabIndex = 8;
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 432);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(458, 30);
            this.StatusStrip.TabIndex = 9;
            this.StatusStrip.Text = "Ready";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(84, 25);
            this.StatusLabel.Text = "<Ready>";
            // 
            // RemoteLogPathLabel
            // 
            this.RemoteLogPathLabel.AutoSize = true;
            this.RemoteLogPathLabel.Location = new System.Drawing.Point(104, 376);
            this.RemoteLogPathLabel.Name = "RemoteLogPathLabel";
            this.RemoteLogPathLabel.Size = new System.Drawing.Size(19, 13);
            this.RemoteLogPathLabel.TabIndex = 10;
            this.RemoteLogPathLabel.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Local System:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Remote System:";
            // 
            // USMTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoteLogPathLabel);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ProcessProgressBar1);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.LogPathLabel);
            this.Controls.Add(this.LogLocationLabel);
            this.Controls.Add(this.USMTGroupBox);
            this.Controls.Add(this.BackupOptionGroupBox);
            this.Controls.Add(this.SystemGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "USMTForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Migration Utility (WMU)";
            this.Load += new System.EventHandler(this.USMTForm_Load);
            this.SystemGroupBox.ResumeLayout(false);
            this.SystemGroupBox.PerformLayout();
            this.BackupOptionGroupBox.ResumeLayout(false);
            this.BackupOptionGroupBox.PerformLayout();
            this.USMTGroupBox.ResumeLayout(false);
            this.USMTGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SystemGroupBox;
        private System.Windows.Forms.TextBox RemoteSystemTextBox;
        private System.Windows.Forms.RadioButton RemoteSystemRadioButton;
        private System.Windows.Forms.RadioButton LocalSystemRadioButton;
        private System.Windows.Forms.GroupBox BackupOptionGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RestoreRadioButton;
        private System.Windows.Forms.RadioButton CaptureRadioButton;
        private System.Windows.Forms.GroupBox USMTGroupBox;
        private System.Windows.Forms.TextBox USMTStorePathTextBox;
        private System.Windows.Forms.Label USMTPathLabel;
        private System.Windows.Forms.TextBox DecryptionTextBox;
        private System.Windows.Forms.CheckBox DecryptionCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label LogLocationLabel;
        private System.Windows.Forms.Label LogPathLabel;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configFIleOptionsToolStripMenuItem;
        private System.Windows.Forms.ProgressBar ProcessProgressBar;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Timer SleepTimer;
        private System.Windows.Forms.Label RemoteLogPathLabel;
        private System.Windows.Forms.ToolStripMenuItem wMUHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSMTHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RemoteSystemHelpButton;
        private System.Windows.Forms.CheckBox HardLinkCheckBox;
        private System.Windows.Forms.ToolStripMenuItem releaseNotesToolStripMenuItem;
    }
}

