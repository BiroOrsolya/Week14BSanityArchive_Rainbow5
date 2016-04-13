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
        public Form1()
        {

            InitializeComponent();
            
        }

        private void textBox_Leave(object sender, EventArgs e)
        {

            string path = textBox.Text;
            filesOnDrive.DataSource = Directory.GetFileSystemEntries(path);
        }

        private void filesOnDrive_DoubleClick(object sender, EventArgs e)
        {
            
            string path = (string)filesOnDrive.SelectedItem;
            if (new DirectoryInfo(path).Exists )
            {
                filesOnDrive.DataSource = Directory.GetFileSystemEntries(path);
                textBox.Text = path;
            }
        }
    }
}
