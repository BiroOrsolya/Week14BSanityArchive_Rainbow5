using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace SanityArchive
{
    partial class MainForm
    {
        private void compressOne(FileSystemInfo src, FileInfo dest)
        {
            using (ZipArchive destArchiveObj = ZipFile.Open(dest.FullName, ZipArchiveMode.Update))
            {
                destArchiveObj.CreateEntryFromFile(src.FullName, src.Name);
            }
        }

        private void compressMany(List<FileSystemInfo> src, FileInfo dest)
        {
            foreach (FileSystemInfo currentSourceFile in src)
            {
                using (ZipArchive destArchiveObj = ZipFile.Open(dest.FullName, ZipArchiveMode.Update))
                {
                    destArchiveObj.CreateEntryFromFile(currentSourceFile.FullName, currentSourceFile.Name);
                }
            }
        }

        private void compressDirectory(DirectoryInfo src, FileInfo dest)
        {
            ZipFile.CreateFromDirectory(src.FullName, dest.FullName);
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            DestinationFileDialog destinationForm = new DestinationFileDialog();
            destinationForm.ShowDialog();
            DialogResult result = destinationForm.DialogResult;
            if (result.Equals(DialogResult.OK))
            {
                compressMany(SelectedFilesAndDirs, destinationForm.DestinationFile);
            }
        }
    }
}
