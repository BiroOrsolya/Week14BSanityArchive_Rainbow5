﻿//using System;
using System.Collections.Generic;
using System.IO;

namespace SanityArchive
{
    namespace Forms
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
                filesOnDrive.DataSource = dirs;
                AllFilesAndDirs = new List<FileSystemInfo>();
                if (dirs.Length > 0)
                    AllFilesAndDirs.AddRange(dirs);
                CurrentDirectory = dir;
            }
        }
    }
}
