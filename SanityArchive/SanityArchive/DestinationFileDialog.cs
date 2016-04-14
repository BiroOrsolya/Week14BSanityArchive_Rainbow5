using System;
//using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SanityArchive
{
    public partial class DestinationFileDialog : DestinationDialog
    {
        public FileInfo DestinationFile { get; protected set; }

        public DestinationFileDialog()
        {
            InitializeComponent();
        }

        protected override void filesOnDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.filesOnDrive_SelectedIndexChanged(sender, e);
            if (SelectedFileOrDir is FileInfo)
            {
                DestinationFile = (FileInfo)SelectedFileOrDir;
                fileNameBox.Text = DestinationFile.Name;
            }
            else
            {
                DestinationFile = null;
                fileNameBox.Text = "";
            }
        }

        private void fileNameBox_Leave(object sender, EventArgs e)
        {
            if (fileNameBox.Text.Contains(Path.DirectorySeparatorChar.ToString()))
            {
                MessageBox.Show("File name cannot contain character '" + Path.DirectorySeparatorChar + "'!", "Directory-Separator in Filen Name");
            }
            DestinationFile = new FileInfo(CurrentDirectory.FullName + Path.DirectorySeparatorChar + fileNameBox.Text);
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            if (DestinationFile == null)
            {
                MessageBox.Show("You have to specify a file to click OK!", "No File Specified");
                return;
            }
            base.okButton_Click(sender, e);
        }
    }
}
