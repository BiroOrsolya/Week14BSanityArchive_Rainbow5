using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace SanityArchive
{
    partial class MainForm
    {
        private void CompressOne(FileSystemInfo src, FileInfo dest)
        {
            using (ZipArchive destArchiveObj = ZipFile.Open(dest.FullName, ZipArchiveMode.Update))
            {
                destArchiveObj.CreateEntryFromFile(src.FullName, src.Name);
            }
        }

        private void CompressMany(List<FileSystemInfo> src, FileInfo dest)
        {
            foreach (FileSystemInfo currentSourceFile in src)
            {
                using (ZipArchive destArchiveObj = ZipFile.Open(dest.FullName, ZipArchiveMode.Update))
                {
                    destArchiveObj.CreateEntryFromFile(currentSourceFile.FullName, currentSourceFile.Name);
                }
            }
        }

        private void CompressDirectory(DirectoryInfo src, FileInfo dest)
        {
            ZipFile.CreateFromDirectory(src.FullName, dest.FullName);
        }

        private void DecompressOne(ZipArchiveEntry src, DirectoryInfo dest)
        {
            src.ExtractToFile(dest.FullName + Path.DirectorySeparatorChar + src.FullName);
        }

        private void DecompressMany(List<ZipArchiveEntry> src, DirectoryInfo dest)
        {
            foreach (ZipArchiveEntry currentSourceArchiveEntry in src)
            {
                currentSourceArchiveEntry.ExtractToFile(dest.FullName + Path.DirectorySeparatorChar + currentSourceArchiveEntry.FullName);
            }
        }

        private void DecompressArchive(FileInfo src, DirectoryInfo dest)
        {
            ZipFile.ExtractToDirectory(src.FullName, dest.FullName);
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            DestinationFileDialog destinationForm = new DestinationFileDialog();
            destinationForm.ShowDialog();
            DialogResult result = destinationForm.DialogResult;
            if (result.Equals(DialogResult.OK))
            {
                CompressMany(SelectedFilesAndDirs, destinationForm.DestinationFile);
            }
        }

        private void DecompressButton_Click(object sender, EventArgs e)
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
                    DecompressArchive(sourceFile, destinationDialog.CurrentDirectory);
                }
            }
        }
    }
}
