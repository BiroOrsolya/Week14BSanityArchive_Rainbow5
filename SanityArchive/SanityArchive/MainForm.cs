using System;
using System.IO;
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
            DestinationDialog destinationForm = new DestinationDialog();
            destinationForm.ShowDialog();
            DialogResult result = destinationForm.DialogResult;
            if (result.Equals(DialogResult.OK)) { }
        }

		private void encryptButton_Click (object sender, EventArgs e) {
			string ec = textBox.Text + @"\" + filesOnDrive.SelectedItems[0].ToString().Substring(0, filesOnDrive.SelectedItems[0].ToString().Length - 3) + "enc";
			string sKey = "dontknow";

			FileStream fsInput = new FileStream(textBox.Text + @"\" + filesOnDrive.SelectedItems[0], FileMode.Open, FileAccess.Read);
			FileStream fsEncrypted = new FileStream(ec, FileMode.Create, FileAccess.Write);

			DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
			DES.Key = Encoding.ASCII.GetBytes(sKey);
			DES.IV = Encoding.ASCII.GetBytes(sKey);

			ICryptoTransform transform = DES.CreateEncryptor();
			CryptoStream crStream = new CryptoStream(fsEncrypted, transform, CryptoStreamMode.Write);

			byte[] bytearrayinput = new byte[fsInput.Length - 1];
			fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
			crStream.Write(bytearrayinput, 0, bytearrayinput.Length);

			crStream.Close();
			fsEncrypted.Close();
			fsInput.Close();
			File.Delete(filesOnDrive.SelectedItems[0].ToString());
			MessageBox.Show(@"The selected file(s) were encrypted successfully\n" + filesOnDrive.SelectedItems[0]);
		}
	}
}