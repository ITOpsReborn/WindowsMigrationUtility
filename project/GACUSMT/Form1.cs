using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.ComponentModel;



namespace WindowsMigrationUtility
{
  
    public partial class USMTForm : Form
    {
        ProgressBar ProcessProgressBar1 = new ProgressBar();
        string Env = Environment.GetEnvironmentVariable("WinDir");
        string USMTCommandLine = "";
        string CD = Directory.GetCurrentDirectory();
        String ScanStateSyntax = Properties.Settings.Default.ScanStateSyntax;
        String LoadStateSyntax = Properties.Settings.Default.LoadStateSyntax;
        String RemoteLogPath = "\\\\%RemoteSystem%\\Admin$\\Logs\\";
        

        public USMTForm()
        {
            String LogPath = Env + "\\Logs\\";
            InitializeComponent();
            DecryptionTextBox.Enabled = false;
            CaptureRadioButton.Checked = true;
            LogPathLabel.Text = LogPath;
            RemoteLogPathLabel.Text = RemoteLogPath;
            ProcessProgressBar1.Visible = false;
            HardLinkCheckBox.Enabled = false;

            
        }
        private void USMTForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Create == 0)
            {
                Properties.Settings.Default.Create = 1;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Create = 0;
                Properties.Settings.Default.Save();
            }

            LocalSystemRadioButton.Checked = true;
            
        }
        private void LocalSystemRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LocalSystemRadioButton.Checked == true)
            {
                RemoteSystemTextBox.Clear();
                RemoteSystemTextBox.Enabled = false;
                RemoteSystemHelpButton.Enabled = false;
            }
            if (RemoteSystemRadioButton.Checked == true)
            {
                RemoteSystemTextBox.Enabled = true;
                RemoteSystemHelpButton.Enabled = true;
            }
        }

        private void CaptureRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CaptureRadioButton.Checked == true)
            {
                DecryptionCheckBox.Checked = false;
                DecryptionCheckBox.Enabled = false;   
            }

            if (CaptureRadioButton.Checked == true)
            {
                HardLinkCheckBox.Checked = false;
                HardLinkCheckBox.Enabled = false;
            }
        }

        private void Restore_CheckedChanged(object sender, EventArgs e)
        {
            if (RestoreRadioButton.Checked == true)
            {
                DecryptionCheckBox.Enabled = true;
                HardLinkCheckBox.Enabled = true;

            }

            if (CaptureRadioButton.Checked == true)
            {
                HardLinkCheckBox.Checked = false;
                HardLinkCheckBox.Enabled = false;
                DecryptionCheckBox.Checked = false;
                DecryptionCheckBox.Enabled = false; 
            }
        }

        private void DecryptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DecryptionCheckBox.Checked == true)
            {
                DecryptionTextBox.Enabled = true;
                HardLinkCheckBox.Checked = false;
                HardLinkCheckBox.Enabled = false;
            }

            if (DecryptionCheckBox.Checked == false)
            {
                DecryptionTextBox.Clear();
                DecryptionTextBox.Enabled = false;
                HardLinkCheckBox.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AboutFormShow = new AboutBox1();
            AboutFormShow.Show();
        }



        private void configFIleOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ConfigFormShow = new ConfigSettingsForm();
            ConfigFormShow.Show();
        }

        public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            ProcessProgressBar1.Minimum = 1;
            ProcessProgressBar1.Maximum = sourceDirName.Length;
            ProcessProgressBar1.Value = 1;
            ProcessProgressBar1.Step = 1;
            
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }
            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }
            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
                ProcessProgressBar1.PerformStep(); 
            }
            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                    }
            }            
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            //this.Update();
            this.Refresh();
            byte ConfigFile = Properties.Settings.Default.USMTConfigSetting;
            byte CustomFiles = Properties.Settings.Default.CASESetting;
            string CD = Directory.GetCurrentDirectory();
            string USMTConfigFile = Properties.Settings.Default.USMTConfig;
            string USMT01 = Properties.Settings.Default.USMT1;
            string USMT02 = Properties.Settings.Default.USMT2;
            string USMT03 = Properties.Settings.Default.USMT3;
            string USMT04 = Properties.Settings.Default.USMT4;
            string CaptureCMD = Properties.Settings.Default.CaptureCMDCommand;
            string RestoreCMD = Properties.Settings.Default.RestoreCMDCommand;
            string ArcFolder = "";
            string ExeFile = "";
            string EncryptionCommand = "";
            string StorePath = USMTStorePathTextBox.Text;
            string ComputerName = System.Environment.GetEnvironmentVariable("ComputerName");
            string USMTBaseCommand = "";
            string USMTArguments = "";
            string SysDrive = System.Environment.GetEnvironmentVariable("SystemDrive");
            bool CaptureAfterCommandBool = Properties.Settings.Default.CaptureCMDCheckBox;
            bool RestaoreAfterCommandBool = Properties.Settings.Default.RestoreCMDCheckBox;
            ScanStateSyntax = Properties.Settings.Default.ScanStateSyntax;
            LoadStateSyntax = Properties.Settings.Default.LoadStateSyntax;
            
            if (LocalSystemRadioButton.Checked == true)
            {
             

                if (System.IntPtr.Size == 4)
                {
                    ArcFolder = "x86";
                }
                if (System.IntPtr.Size == 8)
                {
                    ArcFolder = "amd64";
                }

                string USMTCustLocal = " /i:" + CD + "\\Source\\" + ArcFolder + "\\";
                string USMTConfigLocal = " /config:" + CD + "\\Source\\" + ArcFolder + "\\";

                if (CaptureRadioButton.Checked == true)
                {
                    
                    ExeFile = "scanstate.exe";
                    EncryptionCommand = "/encrypt /key:U$MT3ncrypt10n";
                    USMTBaseCommand = CD + "\\Source\\" + ArcFolder + "\\" + ExeFile;
                    USMTArguments = StorePath + " " + EncryptionCommand + " /l:" + SysDrive + "\\Windows\\Logs\\" + ComputerName + "_scanstate.log /progress:" + SysDrive + "\\Windows\\Logs\\" + ComputerName + "_scanprogress.log " + ScanStateSyntax;
                    
                    if (CustomFiles == 0)
                    {
                        if (ConfigFile == 0)
                        {
                            USMTCommandLine = USMTArguments;
                        }
                        if (ConfigFile == 1)
                        {
                            USMTCommandLine = USMTArguments + USMTConfigLocal + USMTConfigFile;
                        }
                    }
                    if (CustomFiles == 1)
                    {
                        if (ConfigFile == 0)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01;
                        }
                        if (ConfigFile == 1)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTConfigLocal + USMTConfigFile;
                        }
                    }
                    if (CustomFiles == 2)
                    {
                        if (ConfigFile == 0)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02;
                        }
                        if (ConfigFile == 1)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02 + USMTConfigLocal + USMTConfigFile;
                        }
                    }
                    if (CustomFiles == 3)
                    {
                        if (ConfigFile == 0)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02 + USMTCustLocal + USMT03;
                        }
                        if (ConfigFile == 1)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02 + USMTCustLocal + USMT03 + USMTConfigLocal + USMTConfigFile;
                        }
                    }
                    if (CustomFiles == 4)
                    {
                        if (ConfigFile == 0)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02 + USMTCustLocal + USMT03 + USMTCustLocal + USMT04;
                        }
                        if (ConfigFile == 1)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02 + USMTCustLocal + USMT03 + USMTCustLocal + USMT04 + USMTConfigLocal + USMTConfigFile;
                        }
                    }

                }
                if (RestoreRadioButton.Checked == true)
                {
                    
                    ExeFile = "loadstate.exe";

                    if (DecryptionCheckBox.Checked == true)
                    {
                        string Key = DecryptionTextBox.Text;
                        string KeyPath = CD + "\\key.txt";
                        File.WriteAllText(KeyPath, Key);
                        EncryptionCommand = "/decrypt /keyfile:" + KeyPath;
                    }
                    else
                    {
                        EncryptionCommand = "/decrypt /key:U$MT3ncrypt10n";
                    }

                    USMTBaseCommand = CD + "\\Source\\" + ArcFolder + "\\" + ExeFile;

                    if (HardLinkCheckBox.Checked == true)
                    {
                        USMTArguments = StorePath + " /hardlink /nocompress /l:" + SysDrive + "\\Windows\\Logs\\" + ComputerName + "_loadstate.log /progress:" + SysDrive + "\\Windows\\Logs\\" + ComputerName + "_loadprogress.log " + LoadStateSyntax;
                    }
                    else
                    {
                        USMTArguments = StorePath + " " + EncryptionCommand + "  /l:" + SysDrive + "\\Windows\\Logs\\" + ComputerName + "_loadstate.log /progress:" + SysDrive + "\\Windows\\Logs\\" + ComputerName + "_loadprogress.log " + LoadStateSyntax;
                    }
                    if (CustomFiles == 0)
                    {
                        if (ConfigFile == 0)
                        {
                            USMTCommandLine = USMTArguments;
                        }
                        if (ConfigFile == 1)
                        {
                            USMTCommandLine = USMTArguments + USMTConfigLocal + USMTConfigFile;
                        }
                    }
                    if (CustomFiles == 1)
                    {
                        if (ConfigFile == 0)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01;
                        }
                        if (ConfigFile == 1)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTConfigLocal + USMTConfigFile;
                        }
                    }
                    if (CustomFiles == 2)
                    {
                        if (ConfigFile == 0)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02;
                        }
                        if (ConfigFile == 1)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02 + USMTConfigLocal + USMTConfigFile;
                        }
                    }
                    if (CustomFiles == 3)
                    {
                        if (ConfigFile == 0)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02 + USMTCustLocal + USMT03;
                        }
                        if (ConfigFile == 1)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02 + USMTCustLocal + USMT03 + USMTConfigLocal + USMTConfigFile;
                        }
                    }
                    if (CustomFiles == 4)
                    {
                        if (ConfigFile == 0)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02 + USMTCustLocal + USMT03 + USMTCustLocal + USMT04;
                        }
                        if (ConfigFile == 1)
                        {
                            USMTCommandLine = USMTArguments + USMTCustLocal + USMT01 + USMTCustLocal + USMT02 + USMTCustLocal + USMT03 + USMTCustLocal + USMT04 + USMTConfigLocal + USMTConfigFile;
                        }
                    }
                }
                if (CaptureRadioButton.Checked == true)
                {
                    if (CaptureAfterCommandBool == true)
                    {
                        ProcessStartInfo CapAfterInfo = new ProcessStartInfo();
                        CapAfterInfo.FileName = "cmd.exe";
                        CapAfterInfo.Arguments = "/c " + Properties.Settings.Default.CaptureCMDCommand;

                        try
                        {
                            StatusLabel.Text = "Running before capture command..";
                            this.Update();
                            using (Process CapAfterEXE = Process.Start(CapAfterInfo))
                            {
                                CapAfterEXE.WaitForExit();
                            }
                            StatusLabel.Text = "<Ready>";
                        }
                        catch (System.Exception x)
                        {
                            MessageBox.Show("There was an error with your custom command.  Make sure your configuration is set up right. " +
                                Environment.NewLine + Environment.NewLine + x, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            StatusLabel.Text = "<Ready>";
                            return;
                        }
                    }
                }

                ProcessStartInfo ProcessInfo = new ProcessStartInfo();
                ProcessInfo.FileName = USMTBaseCommand;
                ProcessInfo.Arguments = USMTCommandLine;
                //ProcessInfo.RedirectStandardError = true;

                try
                {
                    StatusLabel.Text = "Running USMT Process";
                    this.Update();
                    using (Process StartEXE = Process.Start(ProcessInfo))
                    {
                        StartEXE.WaitForExit();
                        StatusLabel.Text = "<Ready>";
                    }
                }
                catch (System.Exception x)
                {
                    MessageBox.Show("There was an error with " + ExeFile + ".  Please consult the log location in C:\\Windows\\Logs\\" + Environment.NewLine +
                    Environment.NewLine + x, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StatusLabel.Text = "<Ready>";
                    return;
                }

                

                if (RestoreRadioButton.Checked == true)
                {
                    if (RestaoreAfterCommandBool == true)
                    {
                        ProcessStartInfo ResAfterInfo = new ProcessStartInfo();
                        ResAfterInfo.FileName = "cmd.exe";
                        ResAfterInfo.Arguments = "/c " + Properties.Settings.Default.RestoreCMDCommand;
                        //ResAfterInfo.RedirectStandardError = true;

                        try
                        {
                            StatusLabel.Text = "Running after restore command..";
                            this.Update();
                            using (Process ResAfterEXE = Process.Start(ResAfterInfo))
                            {
                                ResAfterEXE.WaitForExit();
                                StatusLabel.Text = "<Ready>";
                            }
                        }
                        catch (System.Exception x)
                        {
                            MessageBox.Show("There was an error with your custom command.  Make sure your configuration is set up right. " +
                                Environment.NewLine + Environment.NewLine + x, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            if (RemoteSystemRadioButton.Checked == true)
            {
                
                string RemotePC = RemoteSystemTextBox.Text;
                string SysWow64 = "\\\\" + RemotePC + "\\Admin$\\SysWOW64";
                string AdminUSMT = "\\\\" + RemotePC + "\\Admin$\\Temp\\USMT";

                using (CredentialDialog CDIalog = new CredentialDialog())
                {
                    DialogResult WMUCred =  CDIalog.ShowDialog();
                    if (WMUCred == DialogResult.OK)
                    
                    {

                        try
                        {
                            string CDIalogU = CDIalog.UserTextBox.Text;
                            string CDIalogP = CDIalog.PassTextBox.Text;
                            try
                            {
                                if (Directory.Exists(SysWow64))
                                {
                                    ArcFolder = "amd64";
                                }
                                else
                                {
                                    ArcFolder = "x86";
                                }
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.Message, Application.ProductName);

                            }
                            try
                            {
                                if (Directory.Exists(AdminUSMT))
                                {
                                    DialogResult AdminUSMTExists = MessageBox.Show("It seems the USMT Directory already exists on " + RemoteSystemTextBox.Text +
                                        "." + Environment.NewLine + Environment.NewLine +
                                        "Would you like to remove the directory and copy your '\\Source' folder?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    if (AdminUSMTExists == DialogResult.Yes)
                                    {
                                        Directory.Delete(AdminUSMT, true);
                                    }

                                }
                                else
                                {
                                    Directory.CreateDirectory(AdminUSMT);
                                }
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.Message);

                            }

                            string USMTCustRemote = " /i:%systemdrive%\\Windows\\Temp\\USMT\\" + ArcFolder + "\\";
                            string USMTConfigRemote = " /config:%systemdrive%\\Windows\\Temp\\USMT\\" + ArcFolder + "\\";
                            try
                            {

                                if (Directory.Exists(AdminUSMT + "\\x86"))
                                {
                                    DialogResult USMTFilesExist = MessageBox.Show("The path " + AdminUSMT + "Already contains files." + Environment.NewLine + Environment.NewLine +
                                        "Would you like to remove these files from this directory?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                    if (USMTFilesExist == DialogResult.Yes)
                                    {
                                        Directory.Delete(AdminUSMT);
                                        Directory.CreateDirectory(AdminUSMT);
                                        StatusLabel.Text = "Copying USMT Files to " + AdminUSMT;
                                        this.Update();
                                        ProcessProgressBar1.Visible = true;
                                        DirectoryCopy(CD + "\\Source\\", AdminUSMT, true);
                                        ProcessProgressBar1.Visible = false;
                                        StatusLabel.Text = "<Ready>";
                                    }

                                }

                                if (!(Directory.Exists(AdminUSMT + "\\x86")))
                                {
                                    Directory.CreateDirectory(AdminUSMT);
                                    StatusLabel.Text = "Copying USMT Files to " + AdminUSMT;
                                    this.Update();
                                    ProcessProgressBar1.Visible = true;
                                    DirectoryCopy(CD + "\\Source\\", AdminUSMT, true);
                                    ProcessProgressBar1.Visible = false;
                                    StatusLabel.Text = "<Ready>";
                                }

                            }
                            catch (System.Exception x)
                            {
                                MessageBox.Show("There was error in the operation" + Environment.NewLine + Environment.NewLine + x.Message,
                                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }



                            if (CaptureRadioButton.Checked == true)
                            {
                                
                                ExeFile = "scanstate.exe";
                                EncryptionCommand = "/encrypt /key:U$MT3ncrypt10n";
                                USMTBaseCommand = "%systemdrive%\\Windows\\Temp\\USMT\\" + ArcFolder + "\\" + ExeFile;
                                USMTArguments = StorePath + " " + EncryptionCommand + " /l:%systemdrive%\\Windows\\Logs\\" + RemotePC + "_scanstate.log /progress:%systemdrive%\\Windows\\Logs\\" + RemotePC + "_scanprogress.log " + ScanStateSyntax;

                                if (CustomFiles == 0)
                                {
                                    if (ConfigFile == 0)
                                    {
                                        USMTCommandLine = USMTArguments;
                                    }
                                    if (ConfigFile == 1)
                                    {
                                        USMTCommandLine = USMTArguments + USMTConfigRemote + USMTConfigFile;
                                    }
                                }
                                if (CustomFiles == 1)
                                {
                                    if (ConfigFile == 0)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01;
                                    }
                                    if (ConfigFile == 1)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTConfigRemote + USMTConfigFile;
                                    }
                                }
                                if (CustomFiles == 2)
                                {
                                    if (ConfigFile == 0)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02;
                                    }
                                    if (ConfigFile == 1)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02 + USMTConfigRemote + USMTConfigFile;
                                    }
                                }
                                if (CustomFiles == 3)
                                {
                                    if (ConfigFile == 0)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02 + USMTCustRemote + USMT03;
                                    }
                                    if (ConfigFile == 1)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02 + USMTCustRemote + USMT03 + USMTConfigRemote + USMTConfigFile;
                                    }
                                }
                                if (CustomFiles == 4)
                                {
                                    if (ConfigFile == 0)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02 + USMTCustRemote + USMT03 + USMTCustRemote + USMT04;
                                    }
                                    if (ConfigFile == 1)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02 + USMTCustRemote + USMT03 + USMTCustRemote + USMT04 + USMTConfigRemote + USMTConfigFile;
                                    }
                                }
                            }

                            if (RestoreRadioButton.Checked == true)
                            {
                               
                                ExeFile = "loadstate.exe";

                                if (DecryptionCheckBox.Checked == true)
                                {
                                    string Key = DecryptionTextBox.Text;
                                    string KeyPath = AdminUSMT + "\\key.txt";
                                    File.WriteAllText(KeyPath, Key);
                                    EncryptionCommand = "/decrypt /keyfile:" + KeyPath;
                                }
                                else
                                {
                                    EncryptionCommand = "/decrypt /key:U$MT3ncrypt10n";
                                }

                                USMTBaseCommand = "%systemdrive%\\Windows\\Temp\\USMT\\" + ArcFolder + "\\" + ExeFile;

                                if (HardLinkCheckBox.Checked == true)
                                {
                                    USMTArguments = StorePath + " /hardlink /nocompress /l:%systemdrive%\\Windows\\Logs\\" + RemotePC + "_loadstate.log /progress:%systemdrive%\\Windows\\Logs\\" + RemotePC + "_loadprogress.log " + LoadStateSyntax;
                                }
                                else
                                {
                                    USMTArguments = StorePath + " " + EncryptionCommand + " /l:%systemdrive%\\Windows\\Logs\\" + RemotePC + "_loadstate.log /progress:%systemdrive%\\Windows\\Logs\\" + RemotePC + "_loadprogress.log " + LoadStateSyntax;
                                }
                                
                                if (CustomFiles == 0)
                                {
                                    if (ConfigFile == 0)
                                    {
                                        USMTCommandLine = USMTArguments;
                                    }
                                    if (ConfigFile == 1)
                                    {
                                        USMTCommandLine = USMTArguments + USMTConfigRemote + USMTConfigFile;
                                    }
                                }
                                if (CustomFiles == 1)
                                {
                                    if (ConfigFile == 0)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01;
                                    }
                                    if (ConfigFile == 1)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTConfigRemote + USMTConfigFile;
                                    }
                                }
                                if (CustomFiles == 2)
                                {
                                    if (ConfigFile == 0)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02;
                                    }
                                    if (ConfigFile == 1)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02 + USMTConfigRemote + USMTConfigFile;
                                    }
                                }
                                if (CustomFiles == 3)
                                {
                                    if (ConfigFile == 0)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02 + USMTCustRemote + USMT03;
                                    }
                                    if (ConfigFile == 1)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02 + USMTCustRemote + USMT03 + USMTConfigRemote + USMTConfigFile;
                                    }
                                }
                                if (CustomFiles == 4)
                                {
                                    if (ConfigFile == 0)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02 + USMTCustRemote + USMT03 + USMTCustRemote + USMT04;
                                    }
                                    if (ConfigFile == 1)
                                    {
                                        USMTCommandLine = USMTArguments + USMTCustRemote + USMT01 + USMTCustRemote + USMT02 + USMTCustRemote + USMT03 + USMTCustRemote + USMT04 + USMTConfigRemote + USMTConfigFile;
                                    }
                                }
                            }
                            if (CaptureRadioButton.Checked == true)
                            {
                                if (CaptureAfterCommandBool == true)
                                {
                                    ProcessStartInfo RemoteCaptAfterCommand = new ProcessStartInfo();
                                    RemoteCaptAfterCommand.FileName = CD + "\\PSTools\\PSExec.exe";
                                    RemoteCaptAfterCommand.Arguments = "\\\\" + RemoteSystemTextBox.Text + " " + Properties.Settings.Default.CaptureCMDCommand;

                                    try
                                    {
                                        StatusLabel.Text = "Running remote before capture command..";
                                        this.Update();
                                        using (Process RemoteAfterCapExe = Process.Start(RemoteCaptAfterCommand))
                                        {
                                            RemoteAfterCapExe.WaitForExit();
                                        }
                                        StatusLabel.Text = "<Ready>";
                                    }
                                    catch (System.Exception x)
                                    {
                                        MessageBox.Show("There was an error processing the after capture command on the remote system." + Environment.NewLine +
                                            Environment.NewLine + x, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        StatusLabel.Text = "<Ready>";
                                        return;
                                        
                                    }
                                }
                            }
                            try
                            {
                                StatusLabel.Text = "Running USMT Process";
                                this.Update();
                                Process p = new Process();;
                                p.StartInfo.FileName = CD + "\\PSTools\\PSExec.exe";
                                p.StartInfo.Arguments = "\\\\" + RemoteSystemTextBox.Text + " -u \"" + CDIalogU + "\" -p \"" + CDIalogP + "\" -h cmd.exe /c " + USMTBaseCommand + " " + USMTCommandLine;
                                p.Start();
                                p.WaitForExit();
                                this.Update();
                                StatusLabel.Text = "<Ready>";
                            }
                            catch (System.Exception x)
                            {
                                MessageBox.Show("The process has reported an error.  Please consult the log files for more information" + Environment.NewLine +
                                   x, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                StatusLabel.Text = "<Ready>";
                                return;

                            }


                            if (RestoreRadioButton.Checked == true)
                            {
                                bool RestoreAfterCommandBool = Properties.Settings.Default.RestoreCMDCheckBox;

                                if (RestoreAfterCommandBool == true)
                                {

                                    ProcessStartInfo RemoteRestAfterCommand = new ProcessStartInfo();
                                    RemoteRestAfterCommand.FileName = CD + "\\PSTools\\PSExec.exe";
                                    RemoteRestAfterCommand.Arguments = "\\\\" + RemoteSystemTextBox.Text + " " + Properties.Settings.Default.RestoreCMDCommand;

                                    try
                                    {
                                        StatusLabel.Text = "Running remote after restore command..";
                                        this.Update();
                                        using (Process RemoteAfterResExe = Process.Start(RemoteRestAfterCommand))
                                        {
                                            RemoteAfterResExe.WaitForExit();
                                        }
                                        StatusLabel.Text = "<Ready>";
                                    }
                                    catch (System.Exception x)
                                    {
                                        MessageBox.Show("There was an error processing the after capture command on the remote system." + Environment.NewLine +
                                                Environment.NewLine + x, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        StatusLabel.Text = "<Ready>";
                                        return;
                                    }
                                }
                            }
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("There was an error saving your credentials" + Environment.NewLine + Environment.NewLine +
                                    x.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            DialogResult OpenLogFile = MessageBox.Show("The PSExec Command Completed." + Environment.NewLine + Environment.NewLine +
                "Would you like to open the log folder location to verify your Capture /or/ Restore completed successfully?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (OpenLogFile == DialogResult.Yes)
            {
                if (LocalSystemRadioButton.Checked == true)
                {
                    Process n = new Process();
                    n.StartInfo.FileName = "explorer.exe";
                    n.StartInfo.Arguments = Env + "\\Logs";
                    n.Start();
                }

                if (RemoteSystemRadioButton.Checked == true)
                {
                    Process n = new Process();
                    n.StartInfo.FileName = "explorer.exe";
                    n.StartInfo.Arguments = "\\\\" + RemoteSystemTextBox.Text + "\\Admin$\\Logs";
                    n.Start();
                }
            }

            if (OpenLogFile == DialogResult.No)
            {
                this.Refresh();
            }
        }

        private void wMUHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo OpenWMUHelp = new ProcessStartInfo();
                OpenWMUHelp.FileName = CD + "\\WMU_Help.chm";
                Process.Start(OpenWMUHelp);
            }
            catch (System.Exception x)
            {
                MessageBox.Show("Error opening help file." + Environment.NewLine + Environment.NewLine + x.Message,
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void uSMTHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://technet.microsoft.com/en-us/library/hh825256.aspx");
            }
            catch (System.Exception x)
            {
                MessageBox.Show("There was error opening up the web page.  Please see the message below" + Environment.NewLine + Environment.NewLine +
                    x.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RemoteSystemHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is important to remeber the nature of PSExec.  If you are capturing the remote system the remote system " +
                "account must have write permissions to the path, and if you are restoring the remote system account must have read permissions" +
                Environment.NewLine + Environment.NewLine +
                "To get buy this on UNC path, give Everyone read/write permissions",
                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HardLinkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HardLinkCheckBox.Checked == true)
            {
                DecryptionCheckBox.Checked = false;
                DecryptionCheckBox.Enabled = false;
                DecryptionTextBox.Clear();
                DecryptionTextBox.Enabled = false;
            }

            if (HardLinkCheckBox.Checked == false)
            {
                DecryptionCheckBox.Enabled = true;
            }
        }

        private void releaseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ReleaseNotes = new ReleaseNotes();
            ReleaseNotes.Show();
        }
    }
}
