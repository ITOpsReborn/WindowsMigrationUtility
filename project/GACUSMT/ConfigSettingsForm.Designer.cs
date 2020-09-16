namespace WindowsMigrationUtility
{
    partial class ConfigSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigSettingsForm));
            this.USMTConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.USMTConfigPathTextBox = new System.Windows.Forms.TextBox();
            this.USMTFilesGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.USMT4TextBox = new System.Windows.Forms.TextBox();
            this.USMT3TextBox = new System.Windows.Forms.TextBox();
            this.USMT2TextBox = new System.Windows.Forms.TextBox();
            this.USMT1TextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CaptureCMDGroupBox = new System.Windows.Forms.GroupBox();
            this.CaptureHelpButton = new System.Windows.Forms.Button();
            this.CaptureCommandTextBox = new System.Windows.Forms.TextBox();
            this.CommandLabel = new System.Windows.Forms.Label();
            this.CaptureCMDCheckBox = new System.Windows.Forms.CheckBox();
            this.RestoreCMDGroupBox = new System.Windows.Forms.GroupBox();
            this.RestoreHelpButton = new System.Windows.Forms.Button();
            this.RestoreCommandTextBox = new System.Windows.Forms.TextBox();
            this.RestoreCommandLabel = new System.Windows.Forms.Label();
            this.RestoreCMDCheckBox = new System.Windows.Forms.CheckBox();
            this.ScanStateGroupBox = new System.Windows.Forms.GroupBox();
            this.ScanStateSyntaxTextBox = new System.Windows.Forms.TextBox();
            this.ScanStateSyntaxLabel = new System.Windows.Forms.Label();
            this.LoadStateGroupBox = new System.Windows.Forms.GroupBox();
            this.LoadStateSyntaxTextBox = new System.Windows.Forms.TextBox();
            this.LoadStateSyntaxLabel = new System.Windows.Forms.Label();
            this.USMTConfigGroupBox.SuspendLayout();
            this.USMTFilesGroupBox.SuspendLayout();
            this.CaptureCMDGroupBox.SuspendLayout();
            this.RestoreCMDGroupBox.SuspendLayout();
            this.ScanStateGroupBox.SuspendLayout();
            this.LoadStateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // USMTConfigGroupBox
            // 
            this.USMTConfigGroupBox.Controls.Add(this.USMTConfigPathTextBox);
            this.USMTConfigGroupBox.Location = new System.Drawing.Point(12, 127);
            this.USMTConfigGroupBox.Name = "USMTConfigGroupBox";
            this.USMTConfigGroupBox.Size = new System.Drawing.Size(327, 63);
            this.USMTConfigGroupBox.TabIndex = 0;
            this.USMTConfigGroupBox.TabStop = false;
            this.USMTConfigGroupBox.Text = "USMT Configuration File";
            // 
            // USMTConfigPathTextBox
            // 
            this.USMTConfigPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsMigrationUtility.Properties.Settings.Default, "USMTConfig", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.USMTConfigPathTextBox.Location = new System.Drawing.Point(9, 26);
            this.USMTConfigPathTextBox.Name = "USMTConfigPathTextBox";
            this.USMTConfigPathTextBox.Size = new System.Drawing.Size(301, 20);
            this.USMTConfigPathTextBox.TabIndex = 0;
            this.USMTConfigPathTextBox.Text = global::WindowsMigrationUtility.Properties.Settings.Default.USMTConfig;
            // 
            // USMTFilesGroupBox
            // 
            this.USMTFilesGroupBox.Controls.Add(this.label4);
            this.USMTFilesGroupBox.Controls.Add(this.label3);
            this.USMTFilesGroupBox.Controls.Add(this.label2);
            this.USMTFilesGroupBox.Controls.Add(this.label1);
            this.USMTFilesGroupBox.Controls.Add(this.USMT4TextBox);
            this.USMTFilesGroupBox.Controls.Add(this.USMT3TextBox);
            this.USMTFilesGroupBox.Controls.Add(this.USMT2TextBox);
            this.USMTFilesGroupBox.Controls.Add(this.USMT1TextBox);
            this.USMTFilesGroupBox.Location = new System.Drawing.Point(12, 196);
            this.USMTFilesGroupBox.Name = "USMTFilesGroupBox";
            this.USMTFilesGroupBox.Size = new System.Drawing.Size(327, 121);
            this.USMTFilesGroupBox.TabIndex = 1;
            this.USMTFilesGroupBox.TabStop = false;
            this.USMTFilesGroupBox.Text = "USMT Custom Files:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Config File 4:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Config File 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Config File 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Config File 1:";
            // 
            // USMT4TextBox
            // 
            this.USMT4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsMigrationUtility.Properties.Settings.Default, "USMT4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.USMT4TextBox.Location = new System.Drawing.Point(90, 94);
            this.USMT4TextBox.Name = "USMT4TextBox";
            this.USMT4TextBox.Size = new System.Drawing.Size(220, 20);
            this.USMT4TextBox.TabIndex = 3;
            this.USMT4TextBox.Text = global::WindowsMigrationUtility.Properties.Settings.Default.USMT4;
            // 
            // USMT3TextBox
            // 
            this.USMT3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsMigrationUtility.Properties.Settings.Default, "USMT3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.USMT3TextBox.Location = new System.Drawing.Point(90, 68);
            this.USMT3TextBox.Name = "USMT3TextBox";
            this.USMT3TextBox.Size = new System.Drawing.Size(220, 20);
            this.USMT3TextBox.TabIndex = 2;
            this.USMT3TextBox.Text = global::WindowsMigrationUtility.Properties.Settings.Default.USMT3;
            // 
            // USMT2TextBox
            // 
            this.USMT2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsMigrationUtility.Properties.Settings.Default, "USMT2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.USMT2TextBox.Location = new System.Drawing.Point(90, 42);
            this.USMT2TextBox.Name = "USMT2TextBox";
            this.USMT2TextBox.Size = new System.Drawing.Size(220, 20);
            this.USMT2TextBox.TabIndex = 1;
            this.USMT2TextBox.Text = global::WindowsMigrationUtility.Properties.Settings.Default.USMT2;
            // 
            // USMT1TextBox
            // 
            this.USMT1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsMigrationUtility.Properties.Settings.Default, "USMT1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.USMT1TextBox.Location = new System.Drawing.Point(90, 18);
            this.USMT1TextBox.Name = "USMT1TextBox";
            this.USMT1TextBox.Size = new System.Drawing.Size(220, 20);
            this.USMT1TextBox.TabIndex = 0;
            this.USMT1TextBox.Text = global::WindowsMigrationUtility.Properties.Settings.Default.USMT1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(671, 109);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(614, 403);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(452, 403);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(533, 403);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CaptureCMDGroupBox
            // 
            this.CaptureCMDGroupBox.Controls.Add(this.CaptureHelpButton);
            this.CaptureCMDGroupBox.Controls.Add(this.CaptureCommandTextBox);
            this.CaptureCMDGroupBox.Controls.Add(this.CommandLabel);
            this.CaptureCMDGroupBox.Controls.Add(this.CaptureCMDCheckBox);
            this.CaptureCMDGroupBox.Location = new System.Drawing.Point(356, 127);
            this.CaptureCMDGroupBox.Name = "CaptureCMDGroupBox";
            this.CaptureCMDGroupBox.Size = new System.Drawing.Size(327, 93);
            this.CaptureCMDGroupBox.TabIndex = 6;
            this.CaptureCMDGroupBox.TabStop = false;
            this.CaptureCMDGroupBox.Text = "Capture - Before Process Command:";
            // 
            // CaptureHelpButton
            // 
            this.CaptureHelpButton.BackgroundImage = global::WindowsMigrationUtility.Properties.Resources.Help_icon;
            this.CaptureHelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CaptureHelpButton.Location = new System.Drawing.Point(292, 21);
            this.CaptureHelpButton.Name = "CaptureHelpButton";
            this.CaptureHelpButton.Size = new System.Drawing.Size(29, 29);
            this.CaptureHelpButton.TabIndex = 3;
            this.CaptureHelpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CaptureHelpButton.UseVisualStyleBackColor = true;
            this.CaptureHelpButton.Click += new System.EventHandler(this.CaptureHelpButton_Click);
            // 
            // CaptureCommandTextBox
            // 
            this.CaptureCommandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsMigrationUtility.Properties.Settings.Default, "CaptureCMDCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CaptureCommandTextBox.Location = new System.Drawing.Point(96, 56);
            this.CaptureCommandTextBox.Name = "CaptureCommandTextBox";
            this.CaptureCommandTextBox.Size = new System.Drawing.Size(225, 20);
            this.CaptureCommandTextBox.TabIndex = 1;
            this.CaptureCommandTextBox.Text = global::WindowsMigrationUtility.Properties.Settings.Default.CaptureCMDCommand;
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.Location = new System.Drawing.Point(6, 59);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(84, 13);
            this.CommandLabel.TabIndex = 1;
            this.CommandLabel.Text = "CMD Command:";
            // 
            // CaptureCMDCheckBox
            // 
            this.CaptureCMDCheckBox.AutoSize = true;
            this.CaptureCMDCheckBox.Checked = global::WindowsMigrationUtility.Properties.Settings.Default.CaptureCMDCheckBox;
            this.CaptureCMDCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsMigrationUtility.Properties.Settings.Default, "CaptureCMDCheckBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CaptureCMDCheckBox.Location = new System.Drawing.Point(9, 33);
            this.CaptureCMDCheckBox.Name = "CaptureCMDCheckBox";
            this.CaptureCMDCheckBox.Size = new System.Drawing.Size(176, 17);
            this.CaptureCMDCheckBox.TabIndex = 0;
            this.CaptureCMDCheckBox.Text = "Run Command Before Capture?";
            this.CaptureCMDCheckBox.UseVisualStyleBackColor = true;
            // 
            // RestoreCMDGroupBox
            // 
            this.RestoreCMDGroupBox.Controls.Add(this.RestoreHelpButton);
            this.RestoreCMDGroupBox.Controls.Add(this.RestoreCommandTextBox);
            this.RestoreCMDGroupBox.Controls.Add(this.RestoreCommandLabel);
            this.RestoreCMDGroupBox.Controls.Add(this.RestoreCMDCheckBox);
            this.RestoreCMDGroupBox.Location = new System.Drawing.Point(356, 226);
            this.RestoreCMDGroupBox.Name = "RestoreCMDGroupBox";
            this.RestoreCMDGroupBox.Size = new System.Drawing.Size(327, 91);
            this.RestoreCMDGroupBox.TabIndex = 7;
            this.RestoreCMDGroupBox.TabStop = false;
            this.RestoreCMDGroupBox.Text = "Restore - After Process Command:";
            // 
            // RestoreHelpButton
            // 
            this.RestoreHelpButton.BackgroundImage = global::WindowsMigrationUtility.Properties.Resources.Help_icon;
            this.RestoreHelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RestoreHelpButton.Location = new System.Drawing.Point(292, 17);
            this.RestoreHelpButton.Name = "RestoreHelpButton";
            this.RestoreHelpButton.Size = new System.Drawing.Size(29, 29);
            this.RestoreHelpButton.TabIndex = 4;
            this.RestoreHelpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RestoreHelpButton.UseVisualStyleBackColor = true;
            this.RestoreHelpButton.Click += new System.EventHandler(this.RestoreHelpButton_Click);
            // 
            // RestoreCommandTextBox
            // 
            this.RestoreCommandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsMigrationUtility.Properties.Settings.Default, "RestoreCMDCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RestoreCommandTextBox.Location = new System.Drawing.Point(96, 52);
            this.RestoreCommandTextBox.Name = "RestoreCommandTextBox";
            this.RestoreCommandTextBox.Size = new System.Drawing.Size(225, 20);
            this.RestoreCommandTextBox.TabIndex = 1;
            this.RestoreCommandTextBox.Text = global::WindowsMigrationUtility.Properties.Settings.Default.RestoreCMDCommand;
            // 
            // RestoreCommandLabel
            // 
            this.RestoreCommandLabel.AutoSize = true;
            this.RestoreCommandLabel.Location = new System.Drawing.Point(6, 55);
            this.RestoreCommandLabel.Name = "RestoreCommandLabel";
            this.RestoreCommandLabel.Size = new System.Drawing.Size(84, 13);
            this.RestoreCommandLabel.TabIndex = 1;
            this.RestoreCommandLabel.Text = "CMD Command:";
            // 
            // RestoreCMDCheckBox
            // 
            this.RestoreCMDCheckBox.AutoSize = true;
            this.RestoreCMDCheckBox.Checked = global::WindowsMigrationUtility.Properties.Settings.Default.RestoreCMDCheckBox;
            this.RestoreCMDCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WindowsMigrationUtility.Properties.Settings.Default, "RestoreCMDCheckBox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RestoreCMDCheckBox.Location = new System.Drawing.Point(9, 29);
            this.RestoreCMDCheckBox.Name = "RestoreCMDCheckBox";
            this.RestoreCMDCheckBox.Size = new System.Drawing.Size(167, 17);
            this.RestoreCMDCheckBox.TabIndex = 0;
            this.RestoreCMDCheckBox.Text = "Run Command After Restore?";
            this.RestoreCMDCheckBox.UseVisualStyleBackColor = true;
            // 
            // ScanStateGroupBox
            // 
            this.ScanStateGroupBox.Controls.Add(this.ScanStateSyntaxTextBox);
            this.ScanStateGroupBox.Controls.Add(this.ScanStateSyntaxLabel);
            this.ScanStateGroupBox.Location = new System.Drawing.Point(12, 324);
            this.ScanStateGroupBox.Name = "ScanStateGroupBox";
            this.ScanStateGroupBox.Size = new System.Drawing.Size(327, 63);
            this.ScanStateGroupBox.TabIndex = 8;
            this.ScanStateGroupBox.TabStop = false;
            this.ScanStateGroupBox.Text = "ScanState:";
            // 
            // ScanStateSyntaxTextBox
            // 
            this.ScanStateSyntaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsMigrationUtility.Properties.Settings.Default, "ScanStateSyntax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ScanStateSyntaxTextBox.Location = new System.Drawing.Point(9, 37);
            this.ScanStateSyntaxTextBox.Name = "ScanStateSyntaxTextBox";
            this.ScanStateSyntaxTextBox.Size = new System.Drawing.Size(301, 20);
            this.ScanStateSyntaxTextBox.TabIndex = 0;
            this.ScanStateSyntaxTextBox.Text = global::WindowsMigrationUtility.Properties.Settings.Default.ScanStateSyntax;
            // 
            // ScanStateSyntaxLabel
            // 
            this.ScanStateSyntaxLabel.AutoSize = true;
            this.ScanStateSyntaxLabel.Location = new System.Drawing.Point(6, 16);
            this.ScanStateSyntaxLabel.Name = "ScanStateSyntaxLabel";
            this.ScanStateSyntaxLabel.Size = new System.Drawing.Size(95, 13);
            this.ScanStateSyntaxLabel.TabIndex = 0;
            this.ScanStateSyntaxLabel.Text = "ScanState Syntax:";
            // 
            // LoadStateGroupBox
            // 
            this.LoadStateGroupBox.Controls.Add(this.LoadStateSyntaxTextBox);
            this.LoadStateGroupBox.Controls.Add(this.LoadStateSyntaxLabel);
            this.LoadStateGroupBox.Location = new System.Drawing.Point(356, 324);
            this.LoadStateGroupBox.Name = "LoadStateGroupBox";
            this.LoadStateGroupBox.Size = new System.Drawing.Size(327, 63);
            this.LoadStateGroupBox.TabIndex = 9;
            this.LoadStateGroupBox.TabStop = false;
            this.LoadStateGroupBox.Text = "LoadState:";
            // 
            // LoadStateSyntaxTextBox
            // 
            this.LoadStateSyntaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsMigrationUtility.Properties.Settings.Default, "LoadStateSyntax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LoadStateSyntaxTextBox.Location = new System.Drawing.Point(9, 37);
            this.LoadStateSyntaxTextBox.Name = "LoadStateSyntaxTextBox";
            this.LoadStateSyntaxTextBox.Size = new System.Drawing.Size(312, 20);
            this.LoadStateSyntaxTextBox.TabIndex = 0;
            this.LoadStateSyntaxTextBox.Text = global::WindowsMigrationUtility.Properties.Settings.Default.LoadStateSyntax;
            // 
            // LoadStateSyntaxLabel
            // 
            this.LoadStateSyntaxLabel.AutoSize = true;
            this.LoadStateSyntaxLabel.Location = new System.Drawing.Point(6, 16);
            this.LoadStateSyntaxLabel.Name = "LoadStateSyntaxLabel";
            this.LoadStateSyntaxLabel.Size = new System.Drawing.Size(94, 13);
            this.LoadStateSyntaxLabel.TabIndex = 1;
            this.LoadStateSyntaxLabel.Text = "LoadState Syntax:";
            // 
            // ConfigSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 437);
            this.Controls.Add(this.LoadStateGroupBox);
            this.Controls.Add(this.ScanStateGroupBox);
            this.Controls.Add(this.RestoreCMDGroupBox);
            this.Controls.Add(this.CaptureCMDGroupBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.USMTFilesGroupBox);
            this.Controls.Add(this.USMTConfigGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Migration Utility - Configuration Settings";
            this.USMTConfigGroupBox.ResumeLayout(false);
            this.USMTConfigGroupBox.PerformLayout();
            this.USMTFilesGroupBox.ResumeLayout(false);
            this.USMTFilesGroupBox.PerformLayout();
            this.CaptureCMDGroupBox.ResumeLayout(false);
            this.CaptureCMDGroupBox.PerformLayout();
            this.RestoreCMDGroupBox.ResumeLayout(false);
            this.RestoreCMDGroupBox.PerformLayout();
            this.ScanStateGroupBox.ResumeLayout(false);
            this.ScanStateGroupBox.PerformLayout();
            this.LoadStateGroupBox.ResumeLayout(false);
            this.LoadStateGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox USMTConfigGroupBox;
        private System.Windows.Forms.TextBox USMTConfigPathTextBox;
        private System.Windows.Forms.GroupBox USMTFilesGroupBox;
        private System.Windows.Forms.TextBox USMT4TextBox;
        private System.Windows.Forms.TextBox USMT3TextBox;
        private System.Windows.Forms.TextBox USMT2TextBox;
        private System.Windows.Forms.TextBox USMT1TextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CaptureCMDGroupBox;
        private System.Windows.Forms.TextBox CaptureCommandTextBox;
        private System.Windows.Forms.Label CommandLabel;
        private System.Windows.Forms.CheckBox CaptureCMDCheckBox;
        private System.Windows.Forms.GroupBox RestoreCMDGroupBox;
        private System.Windows.Forms.TextBox RestoreCommandTextBox;
        private System.Windows.Forms.Label RestoreCommandLabel;
        private System.Windows.Forms.CheckBox RestoreCMDCheckBox;
        private System.Windows.Forms.Button CaptureHelpButton;
        private System.Windows.Forms.Button RestoreHelpButton;
        private System.Windows.Forms.GroupBox ScanStateGroupBox;
        private System.Windows.Forms.TextBox ScanStateSyntaxTextBox;
        private System.Windows.Forms.Label ScanStateSyntaxLabel;
        private System.Windows.Forms.GroupBox LoadStateGroupBox;
        private System.Windows.Forms.TextBox LoadStateSyntaxTextBox;
        private System.Windows.Forms.Label LoadStateSyntaxLabel;
    }
}