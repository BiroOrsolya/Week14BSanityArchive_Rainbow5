using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SanityArchive {
    public partial class MainForm : Form1 {


        public MainForm() { InitializeComponent(); }

		private void EncryptButton (object sender, EventArgs e) {
			List<FileInfo> selectedFiles = new List<FileInfo>();
			selectedFiles.Add(new FileInfo("C:/GDrive/fixip.jpg"));
	        MessageBox.Show(selectedFiles[0].ToString());

			Stream stream = new FileStream("C:/GDrive/fixip.jpg", FileMode.Create);
			Rijndael rijAlg = Rijndael.Create();

			rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);
			CryptoStream crStream = new CryptoStream(stream, );
		}

	    public byte[] Key { get; set; }
    }
}