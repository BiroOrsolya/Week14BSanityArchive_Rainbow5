using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SanityArchive {
	public class Encrypting {

		private const string SKey = "someshit";
		private static string _selectedDirPath;
		static DESCryptoServiceProvider DES = new DESCryptoServiceProvider {
				Key = Encoding.ASCII.GetBytes(SKey),
				IV = Encoding.ASCII.GetBytes(SKey) };
		private static readonly ICryptoTransform Transform = DES.CreateEncryptor();

		public static void Encrypt(string dirPath, IEnumerable<FileSystemInfo> files) {
			_selectedDirPath = dirPath + @"\";
			var successMsgEnc = new StringBuilder("The selected file(s) were encrypted successfully: ");
			successMsgEnc.AppendLine();
			successMsgEnc.AppendLine();
			
			foreach (var selectedFile in files) {
				string encFileName = selectedFile.Name + "ENC";
				FileStream fsInput = new FileStream(_selectedDirPath + selectedFile, FileMode.Open, FileAccess.Read);
				FileStream fsOutput = new FileStream(_selectedDirPath + encFileName, FileMode.Create, FileAccess.Write);
				CryptoStream crStream = new CryptoStream(fsOutput, Transform, CryptoStreamMode.Write);

				byte[] bytearrayinput = new byte[fsInput.Length - 1];
				fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
				crStream.Write(bytearrayinput, 0, bytearrayinput.Length);

				crStream.Close();
				fsOutput.Close();
				fsInput.Close();
				File.Delete(_selectedDirPath + selectedFile);
				successMsgEnc.AppendLine(selectedFile.Name); }
			MessageBox.Show(successMsgEnc.ToString()); }

		public static void Decrypt(string dirPath, IEnumerable<FileSystemInfo> files) {
			_selectedDirPath = dirPath + @"\";
			var successMsgDec = new StringBuilder("The selected file(s) were decrypted (un)successfully: ");
			successMsgDec.AppendLine();
			successMsgDec.AppendLine();

			foreach (var selectedFile in files) {
				string decFileName = selectedFile.Name.Substring(0, selectedFile.Name.Length - 3);
				FileStream fsInput = new FileStream(_selectedDirPath + selectedFile, FileMode.Open, FileAccess.Read);
				CryptoStream crStream = new CryptoStream(fsInput, Transform, CryptoStreamMode.Read);
				StreamWriter fsOutput = new StreamWriter(_selectedDirPath + decFileName);

				fsOutput.Write(new StreamReader(crStream).ReadToEnd());

				fsOutput.Close();
				crStream.Close();
				fsInput.Close();
				File.Delete(_selectedDirPath + selectedFile);
				successMsgDec.AppendLine(selectedFile.Name); }
			MessageBox.Show(successMsgDec.ToString()); }
	}
}