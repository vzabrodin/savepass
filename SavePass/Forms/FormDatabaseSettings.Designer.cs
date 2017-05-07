namespace SavePass.Forms
{
	partial class FormDatabaseSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabaseSettings));
			this.lDatabaseName = new System.Windows.Forms.Label();
			this.lPassword = new System.Windows.Forms.Label();
			this.lPasswordRepeat = new System.Windows.Forms.Label();
			this.txtDatabaseName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtPasswordRepeat = new System.Windows.Forms.TextBox();
			this.btnShowPassword = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lDatabaseName
			// 
			this.lDatabaseName.AutoSize = true;
			this.lDatabaseName.Location = new System.Drawing.Point(12, 15);
			this.lDatabaseName.Name = "lDatabaseName";
			this.lDatabaseName.Size = new System.Drawing.Size(85, 13);
			this.lDatabaseName.TabIndex = 0;
			this.lDatabaseName.Text = "Database name:";
			// 
			// lPassword
			// 
			this.lPassword.AutoSize = true;
			this.lPassword.Location = new System.Drawing.Point(12, 41);
			this.lPassword.Name = "lPassword";
			this.lPassword.Size = new System.Drawing.Size(56, 13);
			this.lPassword.TabIndex = 0;
			this.lPassword.Text = "Password:";
			// 
			// lPasswordRepeat
			// 
			this.lPasswordRepeat.AutoSize = true;
			this.lPasswordRepeat.Location = new System.Drawing.Point(12, 67);
			this.lPasswordRepeat.Name = "lPasswordRepeat";
			this.lPasswordRepeat.Size = new System.Drawing.Size(93, 13);
			this.lPasswordRepeat.TabIndex = 0;
			this.lPasswordRepeat.Text = "Repeat password:";
			// 
			// txtDatabaseName
			// 
			this.txtDatabaseName.Location = new System.Drawing.Point(111, 12);
			this.txtDatabaseName.Name = "txtDatabaseName";
			this.txtDatabaseName.Size = new System.Drawing.Size(228, 20);
			this.txtDatabaseName.TabIndex = 0;
			this.txtDatabaseName.Text = "New Database";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(111, 38);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(201, 20);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtPasswordRepeat
			// 
			this.txtPasswordRepeat.Location = new System.Drawing.Point(111, 64);
			this.txtPasswordRepeat.Name = "txtPasswordRepeat";
			this.txtPasswordRepeat.Size = new System.Drawing.Size(228, 20);
			this.txtPasswordRepeat.TabIndex = 3;
			this.txtPasswordRepeat.UseSystemPasswordChar = true;
			// 
			// btnShowPassword
			// 
			this.btnShowPassword.Image = global::SavePass.Properties.Resources.B16x16_Lock;
			this.btnShowPassword.Location = new System.Drawing.Point(318, 37);
			this.btnShowPassword.Name = "btnShowPassword";
			this.btnShowPassword.Size = new System.Drawing.Size(22, 22);
			this.btnShowPassword.TabIndex = 2;
			this.btnShowPassword.UseVisualStyleBackColor = true;
			this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(183, 90);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(264, 90);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// FormDatabaseSettings
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(351, 125);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnShowPassword);
			this.Controls.Add(this.txtPasswordRepeat);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtDatabaseName);
			this.Controls.Add(this.lPasswordRepeat);
			this.Controls.Add(this.lPassword);
			this.Controls.Add(this.lDatabaseName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormDatabaseSettings";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Database Settings";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDatabaseSettings_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lDatabaseName;
		private System.Windows.Forms.Label lPassword;
		private System.Windows.Forms.Label lPasswordRepeat;
		private System.Windows.Forms.TextBox txtDatabaseName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtPasswordRepeat;
		private System.Windows.Forms.Button btnShowPassword;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
	}
}