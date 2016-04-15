using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using SanityArchive.Utils;

namespace SanityArchive
{
    namespace Forms
    {
        public sealed partial class MainForm : BaseForm
        {
            public MainForm()
            {
                InitializeComponent();
            }

            private void calcSpaceButton_Click(object sender, EventArgs e)
            {
                var selectedFiles = filesOnDrive.SelectedItems.OfType<FileSystemInfo>().ToList();
                MessageBox.Show(Calculator.CalculateSizeOfFiles(textBox.Text + Path.DirectorySeparatorChar, selectedFiles) + " bytes");
            }

            private void copyButton_Click(object sender, EventArgs e)
            {
                OnCopyClick(sender, e);
            }

            private void moveButton_Click(object sender, EventArgs e)
            {
                OnMoveClick(sender, e);
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
                OnEncryptClick(sender, e);
            }

            private void decryptButton_Click(object sender, EventArgs e)
            {
                OnDecryptClick(sender, e);
            }
        } 
    }
}
