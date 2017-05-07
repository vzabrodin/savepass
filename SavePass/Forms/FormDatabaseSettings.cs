using System;
using System.Windows.Forms;

namespace SavePass.Forms
{
	public partial class FormDatabaseSettings : Form
	{
		public string DatabaseName { get; set; }

		public string Password { get; set; }

		public FormDatabaseSettings()
		{
			InitializeComponent();
		}

		public FormDatabaseSettings(string databaseName, string password) : this()
		{
			txtDatabaseName.Text = databaseName;
			txtPassword.Text = txtPasswordRepeat.Text = password;
		}

		private void btnShowPassword_Click(object sender, EventArgs e)
		{
			if (txtPassword.UseSystemPasswordChar)
			{
				txtPassword.UseSystemPasswordChar = false;
				txtPasswordRepeat.Enabled = false;
			}
			else
			{
				txtPassword.UseSystemPasswordChar = true;
				txtPasswordRepeat.Enabled = true;
			}
		}

		private void FormDatabaseSettings_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult == DialogResult.OK)
			{
				if (txtDatabaseName.Text == "")
				{
					MessageBox.Show("Database name field cannot be blank", Application.ProductName);
					e.Cancel = true;
					return;
				}
				if (txtPassword.UseSystemPasswordChar && txtPassword.Text != txtPasswordRepeat.Text)
				{
					MessageBox.Show("Passwords do not match", Application.ProductName);
					e.Cancel = true;
					return;
				}
				if (txtPassword.Text == "")
				{
					if (MessageBox.Show("You have selected to use an empty password\n\nAre you sure you want to use an empty master password?",
						Application.ProductName,
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button2) == DialogResult.No)
					{
						e.Cancel = true;
						return;
					}
				}
				DatabaseName = txtDatabaseName.Text;
				Password = txtPassword.Text;
			}
		}
	}
}