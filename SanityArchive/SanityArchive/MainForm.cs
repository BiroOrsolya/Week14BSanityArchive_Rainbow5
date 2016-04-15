using System;

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
            CompressButton_Click(sender, e);
        }

        private void decompressButton_Click(object sender, EventArgs e)
        {
            DecompressButton_Click(sender, e);
        }

        private void encryptButton_Click(object sender, EventArgs e) {
            Encrypting.Encrypt(); }

		private void decryptButton_Click (object sender, EventArgs e) {
			Encrypting.Decrypt(); }

        private void copyButton_Click(object sender, EventArgs e)
        {
            CopyButton_Click(sender, e);
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            MoveButton_Click(sender, e);
        }
	}
}