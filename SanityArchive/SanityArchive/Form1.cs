using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchive
{
    public partial class Form1 : Form
    {
        //public DriveInfo CurrentDrive { get; }
        //public List<DriveInfo> AllDrives { get; }
        public DirectoryInfo CurrentDirectory
        {
            get
            {
                return currentDirectory;
            }
        }

        public FileSystemInfo SelectedFileOrDir
        {
            get
            {
                return selectedFileOrDir;
            }
        }

        public List<FileSystemInfo> SelectedFilesAndDirs
        {
            get
            {
                return selectedFilesAndDirs;
            }
        }
        public List<FileSystemInfo> AllFilesAndDirs
        {
            get
            {
                return selectedFilesAndDirs;
            }
        }

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
            allFilesAndDirs = new List<FileSystemInfo>();
            if (filesAndDirs.Length > 0)
                allFilesAndDirs.AddRange(filesAndDirs.DefaultIfEmpty());
            currentDirectory = dir;
        }

        virtual protected void ShowNothing()
        {
            filesOnDrive.DataSource = null;
            currentDirectory = null;
            selectedFileOrDir = null;
            selectedFilesAndDirs = null;
            allFilesAndDirs = null;
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
            selectedFileOrDir = (FileSystemInfo)filesOnDrive.SelectedItem;
            selectedFilesAndDirs = new List<FileSystemInfo>(filesOnDrive.SelectedItems.Cast<FileSystemInfo>());
        }

        //private DriveInfo currentDrive;
        //private List<DriveInfo> allDrives;
        protected DirectoryInfo currentDirectory;
        protected FileSystemInfo selectedFileOrDir;
        protected List<FileSystemInfo> selectedFilesAndDirs;
        protected List<FileSystemInfo> allFilesAndDirs;
    }
}
