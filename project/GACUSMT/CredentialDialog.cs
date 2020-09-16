using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsMigrationUtility
{
    public partial class CredentialDialog : Form
    {
        public CredentialDialog()
        {
            InitializeComponent();
        }

        private void UPOkButton_Click(object sender, EventArgs e)
        {
            
            this.Close(); 
        }

        private void UPCancelButtong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
