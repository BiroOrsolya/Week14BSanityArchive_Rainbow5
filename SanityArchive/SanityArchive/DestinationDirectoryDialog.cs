using System;
using System.Collections.Generic;
using System.IO;

namespace SanityArchive
{
    public partial class DestinationDirectoryDialog : DestinationDialog
    {
        public DestinationDirectoryDialog()
        {
            InitializeComponent();
        }

        protected override void EnterDirectory(DirectoryInfo dir)
        {
            FileSystemInfo[] dirs = dir.GetDirectories();
            allFilesAndDirs = new List<FileSystemInfo>();
            if (dirs.Length > 0)
                allFilesAndDirs.AddRange(dirs);
            currentDirectory = dir;
        }
    }
}
