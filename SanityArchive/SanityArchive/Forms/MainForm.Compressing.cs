using System;
using System.IO;
using System.Windows.Forms;

using SanityArchive.Utils;

namespace SanityArchive
{
    namespace Forms
    {
        partial class MainForm
        {
            private void OnCompressClick(object sender, EventArgs e)
            {
                DestinationFileDialog destinationForm = new DestinationFileDialog();
                destinationForm.ShowDialog();
                DialogResult result = destinationForm.DialogResult;
                if (result.Equals(DialogResult.OK))
                {
                    Compressor.CompressMany(SelectedFilesAndDirs, destinationForm.DestinationFile);
                }
            }

            private void OnExtractClick(object sender, EventArgs e)
            {
                if (!(SelectedFileOrDir is FileInfo))
                {
                    MessageBox.Show("The source you specified is not a file!", "Source Is No File");
                }
                else
                {
                    FileInfo sourceFile = (FileInfo)SelectedFileOrDir;
                    DestinationDirectoryDialog destinationDialog = new DestinationDirectoryDialog();
                    destinationDialog.ShowDialog();
                    if (destinationDialog.DialogResult.Equals(DialogResult.OK))
                    {
                        Compressor.DecompressArchive(sourceFile, destinationDialog.CurrentDirectory);
                    }
                }
            }
        } 
    }
}
