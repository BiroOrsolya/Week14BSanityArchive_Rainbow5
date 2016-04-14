using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
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
            DestinationFileDialog destinationForm = new DestinationFileDialog();
            destinationForm.ShowDialog();
            DialogResult result = destinationForm.DialogResult;
            if (result.Equals(DialogResult.OK))
            {
                Console.Beep();
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string[] fileList = { "C:/GDrive/fixip.jpg", "C:/GDrive/train.wav" };
            string ec = fileList[0].Substring(0, fileList[0].Length - 3) + "ec";
            string sKey = "12345678";

            FileStream fsInput = new FileStream(fileList[0], FileMode.Open, FileAccess.Read);
            FileStream fsEncrypted = new FileStream(ec, FileMode.Create, FileAccess.Write);

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = Encoding.ASCII.GetBytes(sKey);
            DES.IV = Encoding.ASCII.GetBytes(sKey);

            ICryptoTransform transform = DES.CreateEncryptor();
            CryptoStream crStream = new CryptoStream(fsEncrypted, transform, CryptoStreamMode.Write);

            byte[] bytearrayinput = new byte[fsInput.Length - 1];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            crStream.Write(bytearrayinput, 0, bytearrayinput.Length);
        }
    }
}