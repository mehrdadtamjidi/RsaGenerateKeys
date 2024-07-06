using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsaGenerateKeys
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnGenerateKeys_Click(object sender, EventArgs e)
		{
			try
			{
				// Create an instance of the RSACryptoServiceProvider class with a key size of 2048 bits
				RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

				// Export the public and private keys in XML format
				string publicKeyXml = rsa.ToXmlString(false);
				string privateKeyXml = rsa.ToXmlString(true);

				// Display the keys in the respective TextBox controls
				publicKeyTextBox.Text = publicKeyXml;
				privateKeyTextBox.Text = privateKeyXml;

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error generating keys: " + ex.Message);
			}
		}
	}
}
