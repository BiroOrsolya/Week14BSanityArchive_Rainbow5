using System;
//using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Windows.Forms;

using SanityArchive.Utils;

namespace SanityArchive
{
    namespace Forms
    {
        partial class MainForm
        {
            private void OnEncryptClick(object sender, EventArgs e)
            {
                var selectedFiles = filesOnDrive.SelectedItems.OfType<FileSystemInfo>().ToList();
                Encrypter.Encrypt(textBox.Text, selectedFiles);
            }

            private void OnDecryptClick(object sender, EventArgs e)
            {
                var selectedFiles = filesOnDrive.SelectedItems.OfType<FileSystemInfo>().ToList();
                Encrypter.Decrypt(textBox.Text, selectedFiles);
            }
        }
    }
}
