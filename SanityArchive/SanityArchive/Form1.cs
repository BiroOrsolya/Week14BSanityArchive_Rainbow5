using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SanityArchive
{
    public partial class Form1 : Form
    {
        //public DriveInfo CurrentDrive { get; protected set; }
        //public List<DriveInfo> AllDrives { get; protected set; }
        public DirectoryInfo CurrentDirectory { get; protected set; }
        public FileSystemInfo SelectedFileOrDir { get; protected set; }

        public List<FileSystemInfo> SelectedFilesAndDirs { get; protected set; }
        public List<FileSystemInfo> AllFilesAndDirs { get; protected set; }

        public Form1()
        {
            InitializeComponent();
            ShowNothing();
        }

        virtual protected void EnterDirectory(DirectoryInfo dir)
        {
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            FileSystemInfo[] filesAndDirs = new FileSystemInfo[dirs.Length + files.Length];
            dirs.CopyTo(filesAndDirs, 0);
            files.CopyTo(filesAndDirs, dirs.Length);
            filesOnDrive.DataSource = filesAndDirs;
            AllFilesAndDirs = new List<FileSystemInfo>();
            if (filesAndDirs.Length > 0)
                AllFilesAndDirs.AddRange(filesAndDirs.DefaultIfEmpty());
            CurrentDirectory = dir;
        }

        virtual protected void ShowNothing()
        {
            filesOnDrive.DataSource = null;
            CurrentDirectory = null;
            SelectedFileOrDir = null;
            SelectedFilesAndDirs = null;
            AllFilesAndDirs = null;
        }

        virtual protected void textBox_Leave(object sender, EventArgs e)
        {
            string path = textBox.Text;
            if (path.Length.Equals(0))
            {
                ShowNothing();
                return;
            }
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                ShowNothing();
                MessageBox.Show("The directory you have specified does not exist!", "Directory Not Found");
                return;
            }
            EnterDirectory(dir);
        }

        virtual protected void filesOnDrive_DoubleClick(object sender, EventArgs e)
        {

            FileSystemInfo fileOrDir = (FileSystemInfo)filesOnDrive.SelectedItem;
            if (fileOrDir is DirectoryInfo)
            {
                DirectoryInfo dir = (DirectoryInfo)fileOrDir;
                EnterDirectory(dir);
                textBox.Text = dir.FullName;
            }
        }

        virtual protected void filesOnDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedFileOrDir = (FileSystemInfo)filesOnDrive.SelectedItem;
            SelectedFilesAndDirs = new List<FileSystemInfo>(filesOnDrive.SelectedItems.Cast<FileSystemInfo>());
        }
    }
}
