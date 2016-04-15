using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SanityArchive {
	public class Encrypting : Form1 {

		private const string SKey = "someshit";
		private static readonly string SelectedDirPath = textBox.Text + @"\";
		static DESCryptoServiceProvider DES = new DESCryptoServiceProvider {
				Key = Encoding.ASCII.GetBytes(SKey),
				IV = Encoding.ASCII.GetBytes(SKey) };
		private static readonly ICryptoTransform Transform = DES.CreateEncryptor();

		public static void Encrypt() {
			foreach (var selectedFile in filesOnDrive.SelectedItems) {
				string encFileName = selectedFile.ToString().Substring(0, selectedFile.ToString().Length - 3) + "enc";
				FileStream fsInput = new FileStream(SelectedDirPath + selectedFile, FileMode.Open, FileAccess.Read);
				FileStream fsOutput = new FileStream(SelectedDirPath + encFileName, FileMode.Create, FileAccess.Write);
				CryptoStream crStream = new CryptoStream(fsOutput, Transform, CryptoStreamMode.Write);

				byte[] bytearrayinput = new byte[fsInput.Length - 1];
				fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
				crStream.Write(bytearrayinput, 0, bytearrayinput.Length);

				crStream.Close();
				fsOutput.Close();
				fsInput.Close();
				File.Delete(SelectedDirPath + selectedFile); }
			MessageBox.Show(@"The selected file(s) were encrypted successfully:" + @"\n\n" + filesOnDrive.SelectedItems); }

		public static void Decrypt() {
			foreach (var selectedFile in filesOnDrive.SelectedItems) {
				FileStream fsInput = new FileStream(SelectedDirPath + selectedFile, FileMode.Open, FileAccess.Read);
				CryptoStream crStream = new CryptoStream(fsInput, Transform, CryptoStreamMode.Read);
				StreamWriter fsOutput = new StreamWriter(selectedFile.ToString());

				fsOutput.Write(new StreamReader(crStream).ReadToEnd());

				fsOutput.Close();
				crStream.Close();
				fsInput.Close(); }
			MessageBox.Show(@"The selected file(s) were decrypted successfully:" + @"\n\n" + filesOnDrive.SelectedItems); }
	}
}