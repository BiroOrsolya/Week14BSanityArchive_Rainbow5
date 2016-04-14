using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SanityArchive
{
    public partial class DestinationDialog : Form1
    {
        public DestinationDialog()
        {
            InitializeComponent();
        }
        
        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
