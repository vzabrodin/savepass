using System;
using System.Windows.Forms;

namespace SavePass.Forms
{
	public partial class PasswordDialog : Form
	{
		public string Password { get; set; }

		public PasswordDialog()
		{
			InitializeComponent();

		}

		private void btnShowPassword_Click(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
		}

		private void PasswordDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult == DialogResult.OK)
			{
				Password = txtPassword.Text;
			}
		}
	}
}