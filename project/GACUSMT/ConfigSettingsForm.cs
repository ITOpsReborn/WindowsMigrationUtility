using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsMigrationUtility
{
    public partial class ConfigSettingsForm : Form
    {

        public ConfigSettingsForm()
        {
            InitializeComponent();
        }

        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            CASESetting();
            USMTConfigSetting();
            Properties.Settings.Default.Save();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            CASESetting();
            USMTConfigSetting();
            Properties.Settings.Default.Save();
            Close();
        }

        public void CASESetting()
        {
            

            if (!(USMT1TextBox.Text == ""))
            {
                Properties.Settings.Default.CASESetting = 1;
            }

            if (USMT1TextBox.Text == "")
            {
                Properties.Settings.Default.CASESetting = 0;
            }
            if ((!(USMT2TextBox.Text == "")) && (!(USMT1TextBox.Text == "")))
            {
                Properties.Settings.Default.CASESetting = 2;
            }
            if ((!(USMT3TextBox.Text == "")) && (!(USMT2TextBox.Text == "")) && (!(USMT1TextBox.Text == "")))
            {
                Properties.Settings.Default.CASESetting = 3;
            }
            if ((!(USMT4TextBox.Text == "")) && (!(USMT3TextBox.Text == "")) && (!(USMT2TextBox.Text == "")) && (!(USMT1TextBox.Text == "")))
            {
                Properties.Settings.Default.CASESetting = 4;
            }

            
        }

        public void USMTConfigSetting()
        {
            if (USMTConfigPathTextBox.Text == null)
            {
                Properties.Settings.Default.USMTConfigSetting = 0;
            }

            if (USMTConfigPathTextBox.Text != null)
            {
                Properties.Settings.Default.USMTConfigSetting = 1;
            }
        }

        private void CaptureHelpButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("To run a command before the capture process is ran, " + 
            "place eirther the bat, cmd, or powershell file inside the '.\\Source\\Config' folder. " + 
            "Especially if you plan on using this on a remote machine.  If you place this there any copy operations " +
            "of the source folder the commands will be there." +
            "" + Environment.NewLine +
            "i.e. CustomScript.bat, CustomScript.cmd, CustomScript.ps1" +
            "" + Environment.NewLine + Environment.NewLine +
            "If you are using a PowerShell it is important that you please put, " + Environment.NewLine +
            "'powershell.exe -ExecutionPolicy ByPass -noprofile -file .\\'" + Environment.NewLine +
            "in the command box", Application.ProductName);
        }

        private void RestoreHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To run a command after the restore process is complete, " +
            "place either the bat, cmd, or powershell file inside the '.\\Source\\Config' folder.  " + 
            "Especially if you plan on using this on a remote machine.  If you place this there any copy operations of the source folder " + 
            "the commands will be there." +
            "" + Environment.NewLine +
            "i.e. CustomScript.bat, CustomScript.cmd, CustomScript.ps1" +
            "" + Environment.NewLine + Environment.NewLine +
            "If you are using a PowerShell it is important that you please put, " + Environment.NewLine +
            "'powershell.exe -ExecutionPolicy ByPass -noprofile -file .\\'" + Environment.NewLine +
            "in the command box", Application.ProductName);
        }


    }
}
