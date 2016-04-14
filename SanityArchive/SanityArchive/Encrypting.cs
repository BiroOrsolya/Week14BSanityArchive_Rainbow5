using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SanityArchive {
	public class Encrypting : Form1 {

		public static void Encrypt(TextBox textBox, ListBox filesOnDrive) {
			string selectedDirPath = textBox.Text + @"\";
			DESCryptoServiceProvider DES = new DESCryptoServiceProvider {
				Key = Encoding.ASCII.GetBytes("dontknow"),
				IV = Encoding.ASCII.GetBytes("dontknow") };
			ICryptoTransform transform = DES.CreateEncryptor();

			foreach (var selectedFile in filesOnDrive.SelectedItems) {
				string encFileName = selectedFile.ToString().Substring(0, selectedFile.ToString().Length - 3) + "enc";

				FileStream fsInput = new FileStream(selectedDirPath + selectedFile, FileMode.Open, FileAccess.Read);
				FileStream fsOutput = new FileStream(selectedDirPath + encFileName, FileMode.Create, FileAccess.Write);
				CryptoStream crStream = new CryptoStream(fsOutput, transform, CryptoStreamMode.Write);

				byte[] bytearrayinput = new byte[fsInput.Length - 1];
				fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
				crStream.Write(bytearrayinput, 0, bytearrayinput.Length);

				crStream.Close();
				fsOutput.Close();
				fsInput.Close();
				File.Delete(selectedDirPath + selectedFile); }
			MessageBox.Show(@"The selected file(s) were encrypted successfully:" + @"\n\n" + filesOnDrive.SelectedItems);
		}
	}
}
