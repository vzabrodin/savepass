using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SavePass.Nodes;
using SavePass.Exceptions;
using System.IO;

namespace SavePass.Forms
{
	enum EntryState { None, Add, Edit }

	public partial class FormMain : Form
	{
		private bool _isFileSaved = true;
		private EntryState _entryState = EntryState.None;
		private SavePassFile _savepass = new SavePassFile();
		private Entry _selectedEntry;

		public FormMain()
		{
			InitializeComponent();
		}

		public FormMain(string filename) : this()
		{
			FileOpen_Helper(filename);
		}

		#region Helpers
		private void dgEntries_Refresh()
		{
			dgEntries.Rows.Clear();
			foreach (var item in _savepass.Root)
			{
				int index = dgEntries.Rows.Add(item.Name);
				if (_selectedEntry != null && item.Name == _selectedEntry.Name) dgEntries.Rows[index].Selected = true;
			}
		}

		private Entry GetSelectedEntry()
		{
			return _savepass.Root[dgEntries.SelectedCells[0].Value.ToString()];
		}

		private void EntryRefresh()
		{
			Entry tmp = GetSelectedEntry();
			if (tmp == null) return;
			btnEntryName.Text = tbxEntryName.Text = tmp.Name;
			btnUsername.Text = tbxUsername.Text = tmp.Username;
			btnPassword.Text = Regex.Replace(tmp.Password, ".", "●");
			tbxPassword.Text = tmp.Password;
			btnEmail.Text = tbxEmail.Text = tmp.Email;
			btnWebsite.Text = tbxWebsite.Text = tmp.Website;
			btnNotes.Text = tbxNotes.Text = tmp.Notes;
		}

		private void ControlsEnable(bool enable)
		{
			panEntriesList.Enabled = enable;
			miFileClose.Enabled = enable;
			miFileSave.Enabled = enable;
			miFileSaveAs.Enabled = enable;
			miDatabaseSettings.Enabled = enable;
			miEntryAdd.Enabled = enable;
			tsbtnFileSave.Enabled = enable;
			tsbtnEntryAdd.Enabled = enable;
			tsbtnCopyUsername.Enabled = enable;
			tsbtnCopyPassword.Enabled = enable;
			tsbtnOpenURL.Enabled = enable;

			//tsbtnEntryEdit.Enabled = enable; // fix
			//tsbtnEntryDelete.Enabled = enable;
			//miEntryEdit.Enabled = enable;
			//miEntryDelete.Enabled = enable;
		}
		#endregion Helpers

		#region Events
		private void dgEntries_SelectionChanged(object sender, EventArgs e)
		{
			if (dgEntries.SelectedCells.Count == 0 || dgEntries.SelectedCells[0].Value == null)
			{
				panEntryInfo.Enabled = false;
				tsbtnEntryEdit.Enabled = false;
				tsbtnEntryDelete.Enabled = false;
				miEntryEdit.Enabled = false;
				miEntryDelete.Enabled = false;
				btnEntryName.Text = "";
				btnUsername.Text = "";
				btnPassword.Text = "";
				btnEmail.Text = "";
				btnWebsite.Text = "";
				btnNotes.Text = "";
			}
			else
			{
				panEntryInfo.Enabled = true;
				tsbtnEntryEdit.Enabled = true;
				tsbtnEntryDelete.Enabled = true;
				miEntryEdit.Enabled = true;
				miEntryDelete.Enabled = true;
				EntryRefresh();
			}
		}

		private void EntryAdd_Click(object sender, EventArgs e)
		{
			_selectedEntry = new Entry("New entry");
			_savepass.Root.Add(_selectedEntry);
			dgEntries_Refresh();
			EntryEdit_Click(sender, e);
			_entryState = EntryState.Add;
		}

		private void EntryEdit_Click(object sender, EventArgs e)
		{
			_selectedEntry = GetSelectedEntry();
			EntryRefresh();
			panEntryEdit.Visible = true;
			panEntryInfo.Visible = false;
			panEntriesList.Enabled = false;
			menuStrip1.Enabled = false;
			toolStrip1.Enabled = false;
			_entryState = EntryState.Edit;
			tbxEntryName.Focus();
		}

		private void EntryEditDone_Click(object sender, EventArgs e)
		{
			if (_savepass.Root[tbxEntryName.Text] != null && _selectedEntry.Name != tbxEntryName.Text)
			{
				MessageBox.Show("Entry with this name is already exists", Application.ProductName);
				return;
			}

			_selectedEntry.Name = tbxEntryName.Text;
			_selectedEntry.Username = tbxUsername.Text;
			_selectedEntry.Password = tbxPassword.Text;
			_selectedEntry.Email = tbxEmail.Text;
			_selectedEntry.Website = tbxWebsite.Text;
			_selectedEntry.Notes = tbxNotes.Text;

			EntryRefresh();

			panEntryInfo.Visible = true;
			panEntryEdit.Visible = false;
			panEntriesList.Enabled = true;
			menuStrip1.Enabled = true;
			toolStrip1.Enabled = true;
			_entryState = EntryState.None;

			_isFileSaved = false;
			this.Text = string.Format("{0} * Password Manager", _savepass.Root.Name);

			_savepass.Root.Sort();

			dgEntries_Refresh();
		}

		private void EntryEditCancel_Click(object sender, EventArgs e)
		{
			if (_entryState == EntryState.Add)
			{
				_savepass.Root.Remove(_selectedEntry);
			}
			panEntryInfo.Visible = true;
			panEntryEdit.Visible = false;
			panEntriesList.Enabled = true;
			menuStrip1.Enabled = true;
			toolStrip1.Enabled = true;
			_entryState = EntryState.None;

			dgEntries_Refresh();
		}

		private void EntryDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to delete entry?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
			_savepass.Root.Remove(GetSelectedEntry());
			dgEntries_Refresh();

			_isFileSaved = false;
			this.Text = string.Format("{0} * Password Manager", _savepass.Root.Name);
		}

		private void OpenURL_Click(object sender, EventArgs e)
		{
			try
			{
				string website = GetSelectedEntry().Website;
				if (string.IsNullOrEmpty(website)) return;
				if (!website.StartsWith(@"http://") && !website.StartsWith(@"https://"))
				{
					website = "http://" + website;
				}
				Process.Start(website);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void CopyToClipboard_Click(object sender, EventArgs e)
		{
			Button control = (Button)(((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl);
			Entry tmp = GetSelectedEntry();
			string strToCopied = string.Empty;
			if (control == btnEntryName)
			{
				strToCopied = tmp.Name;
			}
			else if (control == btnUsername)
			{
				strToCopied = tmp.Username;
			}
			else if (control == btnPassword)
			{
				strToCopied = tmp.Password;
			}
			else if (control == btnEmail)
			{
				strToCopied = tmp.Email;
			}
			else if (control == btnWebsite)
			{
				strToCopied = tmp.Website;
			}
			else if (control == btnNotes)
			{
				strToCopied = tmp.Notes;
			}
			if (string.IsNullOrEmpty(strToCopied)) return;
			Clipboard.SetText(strToCopied);
		}

		private void tsbtnCopyUsername_Click(object sender, EventArgs e)
		{
			Entry tmp = GetSelectedEntry();
			if (string.IsNullOrEmpty(tmp.Username)) return;
			Clipboard.SetText(tmp.Username);
		}

		private void tsbtnCopyPassword_Click(object sender, EventArgs e)
		{
			Entry tmp = GetSelectedEntry();
			if (string.IsNullOrEmpty(tmp.Password)) return;
			Clipboard.SetText(tmp.Password);
		}

		private void dgEntries_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				dgEntries[e.ColumnIndex, e.RowIndex].Selected = true;
				cmiEntryEdit.Enabled = true;
				cmiEntryDelete.Enabled = true;
				cmEntryList.Show(MousePosition);
			}
		}

		private void dgEntries_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				cmiEntryEdit.Enabled = false;
				cmiEntryDelete.Enabled = false;
				cmEntryList.Show(MousePosition);
			}
		}

		private void FileNew_Click(object sender, EventArgs e)
		{
			//if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

			FormDatabaseSettings dbsett = new FormDatabaseSettings();
			if (dbsett.ShowDialog() != DialogResult.OK) return;

			_savepass.New(dbsett.DatabaseName, dbsett.Password);
			_isFileSaved = false;
			this.Text = string.Format("{0} * Password Manager", _savepass.Root.Name);

			ControlsEnable(true);
			miEntryEdit.Enabled = false;
			miEntryDelete.Enabled = false;
			tsbtnEntryEdit.Enabled = false;
			tsbtnEntryDelete.Enabled = false;
			dgEntries_Refresh();
		}

		private void FileOpen_Helper(string filename)
		{
			PasswordDialog passwdDialog = new PasswordDialog();
			if (passwdDialog.ShowDialog() != DialogResult.OK) return;
			try
			{
				_savepass.Open(filename, passwdDialog.Password);
				_isFileSaved = true;
				this.Text = string.Format("{0} - Password Manager", _savepass.Root.Name);
				ControlsEnable(true);
				dgEntries_Refresh();
			}
			catch (FileCorruptException)
			{
				MessageBox.Show("File is corrupt", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (WrongPasswordException)
			{
				MessageBox.Show("Password is wrong", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				FileOpen_Helper(filename);
			}
		}

		private void FileOpen_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "";
			if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
			FileOpen_Helper(openFileDialog1.FileName);
		}

		private void FileSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_savepass.FileName))
			{
				saveFileDialog1.FileName = _savepass.Root.Name;
				FileSaveAs_Click(sender, e);
			}
			else
			{
				_savepass.Save();
				_isFileSaved = true;
				this.Text = string.Format("{0} - Password Manager", _savepass.Root.Name);
			}
		}

		private void FileSaveAs_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(_savepass.FileName)) saveFileDialog1.FileName = new FileInfo(_savepass.FileName).Name;
			if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
			_savepass.Save(saveFileDialog1.FileName);
			_isFileSaved = true;
			this.Text = string.Format("{0} - Password Manager", _savepass.Root.Name);
		}

		private void FileClose_Click(object sender, EventArgs e)
		{
			if (!_isFileSaved)
			{
				var question = MessageBox.Show("Do you want to save changes?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (question == DialogResult.Cancel) return;
				if (question == DialogResult.Yes)
				{
					if (string.IsNullOrEmpty(_savepass.FileName))
					{
						if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
						_savepass.Save(saveFileDialog1.FileName);
					}
					else
					{
						_savepass.Save();
					}
				}
			}
			_isFileSaved = true;
			this.Text = string.Format("Password Manager");
			ControlsEnable(false);

			dgEntries.Rows.Clear();
			btnEntryName.Text = "Title";
			btnUsername.Text = "";
			btnPassword.Text = "";
			btnEmail.Text = "";
			btnWebsite.Text = "";
			btnNotes.Text = "";
			_savepass.Close();
		}

		private void DatabaseSettings_Click(object sender, EventArgs e)
		{
			FormDatabaseSettings dbsetts = new FormDatabaseSettings(_savepass.Root.Name, _savepass.Password);
			if (dbsetts.ShowDialog() != DialogResult.OK) return;
			_savepass.Root.Name = dbsetts.DatabaseName;
			_savepass.Password = dbsetts.Password;
			_isFileSaved = false;
			this.Text = string.Format("{0} * Password Manager", _savepass.Root.Name);
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void HelpAbout_Click(object sender, EventArgs e)
		{
			new FormAbout().ShowDialog();
		}

		private void FormMain_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void FormMain_DragDrop(object sender, DragEventArgs e)
		{
			string[] dragDropFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (dragDropFiles.Length != 1) return;
			FileOpen_Helper(dragDropFiles[0]);
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!_isFileSaved)
			{
				var question = MessageBox.Show("Do you want to save changes?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (question == DialogResult.Cancel)
				{
					e.Cancel = true;
					return;
				}
				if (question == DialogResult.Yes)
				{
					if (string.IsNullOrEmpty(_savepass.FileName))
					{
						if (saveFileDialog1.ShowDialog() != DialogResult.OK)
						{
							e.Cancel = true;
							return;
						}
						_savepass.Save(saveFileDialog1.FileName);
					}
					else
					{
						_savepass.Save();
					}
				}
			}
		}

		#endregion Events
	}
}