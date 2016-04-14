using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace SanityArchive
{
    public partial class MainForm : Form1
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            DestinationDialog destinationForm = new DestinationDialog();
            destinationForm.ShowDialog();
            DialogResult result = destinationForm.DialogResult;
            if (result.Equals(DialogResult.OK))
            {
                Console.Beep();
            }
        }
    }
}
