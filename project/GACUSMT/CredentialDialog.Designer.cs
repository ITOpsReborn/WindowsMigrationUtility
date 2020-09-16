namespace WindowsMigrationUtility
{
    partial class CredentialDialog
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
            this.UPOkButton = new System.Windows.Forms.Button();
            this.UPCancelButtong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UPOkButton
            // 
            this.UPOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UPOkButton.Location = new System.Drawing.Point(154, 179);
            this.UPOkButton.Name = "UPOkButton";
            this.UPOkButton.Size = new System.Drawing.Size(75, 23);
            this.UPOkButton.TabIndex = 2;
            this.UPOkButton.Text = "OK";
            this.UPOkButton.UseVisualStyleBackColor = true;
            this.UPOkButton.Click += new System.EventHandler(this.UPOkButton_Click);
            // 
            // UPCancelButtong
            // 
            this.UPCancelButtong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UPCancelButtong.Location = new System.Drawing.Point(235, 179);
            this.UPCancelButtong.Name = "UPCancelButtong";
            this.UPCancelButtong.Size = new System.Drawing.Size(75, 23);
            this.UPCancelButtong.TabIndex = 3;
            this.UPCancelButtong.Text = "Cancel";
            this.UPCancelButtong.UseVisualStyleBackColor = true;
            this.UPCancelButtong.Click += new System.EventHandler(this.UPCancelButtong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(99, 103);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(208, 20);
            this.UserTextBox.TabIndex = 0;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(99, 138);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(208, 20);
            this.PassTextBox.TabIndex = 1;
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 66);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please enter a domain account with local admistrative privlages on the remote mac" +
    "hine. \r\n\r\nEnter domain information in the User Name field. ";
            // 
            // CredentialDialog
            // 
            this.AcceptButton = this.UPOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.UPCancelButtong;
            this.ClientSize = new System.Drawing.Size(322, 221);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UPCancelButtong);
            this.Controls.Add(this.UPOkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CredentialDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WMU Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UPOkButton;
        private System.Windows.Forms.Button UPCancelButtong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox UserTextBox;
        public System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label label3;
    }
}