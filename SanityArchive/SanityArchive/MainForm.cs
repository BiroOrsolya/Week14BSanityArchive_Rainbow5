using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SanityArchive
{
    public sealed partial class MainForm : Form1
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            OnCompressClick(sender, e);
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            OnExtractClick(sender, e);
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
	        var selectedFiles = filesOnDrive.SelectedItems.OfType<FileSystemInfo>().ToList();
	        Encrypting.Encrypt(textBox.Text, selectedFiles);
        }

		private void decryptButton_Click (object sender, EventArgs e) {
	        var selectedFiles = filesOnDrive.SelectedItems.OfType<FileSystemInfo>().ToList();
			Encrypting.Decrypt(textBox.Text, selectedFiles);
		}

        private void copyButton_Click(object sender, EventArgs e)
        {
            CopyButton_Click(sender, e);
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            MoveButton_Click(sender, e);
        }

		private void calcSpaceButton_Click (object sender, EventArgs e)
		{
	        var selectedFiles = filesOnDrive.SelectedItems.OfType<FileSystemInfo>().ToList();
			MessageBox.Show(CalcSpace.CalculateSizeOfFiles(textBox.Text  + Path.DirectorySeparatorChar, selectedFiles) + " bytes");
		}
	}
}