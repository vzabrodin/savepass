namespace SavePass.Forms
{
	partial class PasswordDialog
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lPromt = new System.Windows.Forms.Label();
			this.btnShowPassword = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(167, 51);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(86, 51);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 12;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(12, 25);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(202, 20);
			this.txtPassword.TabIndex = 9;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// lPromt
			// 
			this.lPromt.AutoSize = true;
			this.lPromt.Location = new System.Drawing.Point(12, 9);
			this.lPromt.Name = "lPromt";
			this.lPromt.Size = new System.Drawing.Size(164, 13);
			this.lPromt.TabIndex = 6;
			this.lPromt.Text = "Please enter database password:";
			// 
			// btnShowPassword
			// 
			this.btnShowPassword.Image = global::SavePass.Properties.Resources.B16x16_Lock;
			this.btnShowPassword.Location = new System.Drawing.Point(220, 24);
			this.btnShowPassword.Name = "btnShowPassword";
			this.btnShowPassword.Size = new System.Drawing.Size(22, 22);
			this.btnShowPassword.TabIndex = 10;
			this.btnShowPassword.UseVisualStyleBackColor = true;
			this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
			// 
			// PasswordDialog
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(254, 86);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnShowPassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lPromt);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PasswordDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Opening Database";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordDialog_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnShowPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lPromt;
	}
}