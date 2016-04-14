using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SanityArchive
{
    public partial class DestinationFileDialog : DestinationDialog
    {
        public FileInfo DestinationFile
        {
            get
            {
                return destinationFile;
            }
        }

        public DestinationFileDialog()
        {
            InitializeComponent();
        }

        protected override void filesOnDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.filesOnDrive_SelectedIndexChanged(sender, e);
            if (SelectedFileOrDir is FileInfo)
            {
                destinationFile = (FileInfo)SelectedFileOrDir;
                fileNameBox.Text = destinationFile.Name;
            }
            else
            {
                destinationFile = null;
                fileNameBox.Text = "";
            }
        }

        private void fileNameBox_Leave(object sender, EventArgs e)
        {
            if (fileNameBox.Text.Contains(Path.DirectorySeparatorChar.ToString()))
            {
                MessageBox.Show("File name cannot contain character '" + Path.DirectorySeparatorChar.ToString() + "'!", "Directory-Separator in Filen Name");
            }
            destinationFile = new FileInfo(CurrentDirectory.FullName + fileNameBox.Text);
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            if (destinationFile == null)
            {
                MessageBox.Show("You have to specify a file to click OK!", "No File Specified");
                return;
            }
            base.okButton_Click(sender, e);
        }

        private FileInfo destinationFile;
    }
}
