using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using SanityArchive.Utils;

namespace SanityArchive
{
    namespace Forms
    {
        partial class MainForm
        {
            private void OnCopyClick(object sender, EventArgs e)
            {
                var selectedFiles = SelectedFilesAndDirs.OfType<FileSystemInfo>().ToList();
                string sourceDir = CurrentDirectory.FullName;
                DestinationDirectoryDialog dialog = new DestinationDirectoryDialog();
                dialog.ShowDialog();
                if (dialog.DialogResult.Equals(DialogResult.OK))
                {
                    DirectoryInfo targetDir = dialog.CurrentDirectory;
                    Copyer.CopyFiles(selectedFiles, sourceDir, targetDir.FullName);
                }
            }

            private void OnMoveClick(object sender, EventArgs e)
            {
                DestinationDirectoryDialog dialog = new DestinationDirectoryDialog();
                dialog.ShowDialog();
                if (dialog.DialogResult.Equals(DialogResult.OK))
                {
                    DirectoryInfo dir = (DirectoryInfo)dialog.SelectedFileOrDir;
                    Console.Beep();
                }
            }
        }
    }
}
