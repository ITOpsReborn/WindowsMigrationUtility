using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsMigrationUtility
{
    public partial class ReleaseNotes : Form
    {
        public ReleaseNotes()
        {
            InitializeComponent();
        }

        private void ReleaseNotes_Load(object sender, EventArgs e)
        {
            this.richTextBox1.LoadFile(Application.StartupPath + "\\WMU.rtf", RichTextBoxStreamType.RichText);
        }


    }
}
