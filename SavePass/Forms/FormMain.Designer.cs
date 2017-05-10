namespace SavePass.Forms
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.miFile = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileClose = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileExportToJson = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miDatabaseSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.miEntryAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.miEntryEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.miEntryDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.dgEntries = new System.Windows.Forms.DataGridView();
			this.EntryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panEntryEdit = new System.Windows.Forms.Panel();
			this.btnEntryEditCancel = new System.Windows.Forms.Button();
			this.btnEntryEditDone = new System.Windows.Forms.Button();
			this.tbxNotes = new System.Windows.Forms.TextBox();
			this.tbxWebsite = new System.Windows.Forms.TextBox();
			this.tbxEmail = new System.Windows.Forms.TextBox();
			this.tbxPassword = new System.Windows.Forms.TextBox();
			this.lNotes = new System.Windows.Forms.Label();
			this.lWebsite = new System.Windows.Forms.Label();
			this.lEmail = new System.Windows.Forms.Label();
			this.tbxUsername = new System.Windows.Forms.TextBox();
			this.lPassword = new System.Windows.Forms.Label();
			this.lUsername = new System.Windows.Forms.Label();
			this.tbxEntryName = new System.Windows.Forms.TextBox();
			this.cmCopyToClipboard = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmiCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.panEntriesList = new System.Windows.Forms.Panel();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbtnFileNew = new System.Windows.Forms.ToolStripButton();
			this.tsbtnFileOpen = new System.Windows.Forms.ToolStripButton();
			this.tsbtnFileSave = new System.Windows.Forms.ToolStripButton();
			this.tsbtnEntryAdd = new System.Windows.Forms.ToolStripButton();
			this.tsbtnEntryEdit = new System.Windows.Forms.ToolStripButton();
			this.tsbtnEntryDelete = new System.Windows.Forms.ToolStripButton();
			this.tsbtnCopyUsername = new System.Windows.Forms.ToolStripButton();
			this.tsbtnCopyPassword = new System.Windows.Forms.ToolStripButton();
			this.tsbtnOpenURL = new System.Windows.Forms.ToolStripButton();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.toolTipCopyToClipboard = new System.Windows.Forms.ToolTip(this.components);
			this.btnWebsite = new System.Windows.Forms.Button();
			this.cmEntryList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmiEntryAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.cmiEntryEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.cmiEntryDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.panEntryInfo = new System.Windows.Forms.Panel();
			this.btnNotes = new System.Windows.Forms.Button();
			this.btnEmail = new System.Windows.Forms.Button();
			this.btnPassword = new System.Windows.Forms.Button();
			this.btnUsername = new System.Windows.Forms.Button();
			this.btnEntryName = new System.Windows.Forms.Button();
			this.lUsername2 = new System.Windows.Forms.Label();
			this.lNotes2 = new System.Windows.Forms.Label();
			this.lPassword2 = new System.Windows.Forms.Label();
			this.lWebsite2 = new System.Windows.Forms.Label();
			this.lEmail2 = new System.Windows.Forms.Label();
			this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgEntries)).BeginInit();
			this.panEntryEdit.SuspendLayout();
			this.cmCopyToClipboard.SuspendLayout();
			this.panEntriesList.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.cmEntryList.SuspendLayout();
			this.panEntryInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miEdit,
            this.miHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(584, 24);
			this.menuStrip1.Stretch = false;
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// miFile
			// 
			this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileNew,
            this.miFileOpen,
            this.miFileClose,
            this.toolStripMenuItem2,
            this.miFileSave,
            this.miFileSaveAs,
            this.miFileExportToJson,
            this.toolStripSeparator1,
            this.miDatabaseSettings,
            this.toolStripSeparator3,
            this.miExit});
			this.miFile.Name = "miFile";
			this.miFile.Size = new System.Drawing.Size(37, 20);
			this.miFile.Text = "File";
			// 
			// miFileNew
			// 
			this.miFileNew.Image = global::SavePass.Properties.Resources.B16x16_FileNew;
			this.miFileNew.Name = "miFileNew";
			this.miFileNew.ShortcutKeyDisplayString = "";
			this.miFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.miFileNew.Size = new System.Drawing.Size(216, 22);
			this.miFileNew.Text = "New...";
			this.miFileNew.Click += new System.EventHandler(this.FileNew_Click);
			// 
			// miFileOpen
			// 
			this.miFileOpen.Image = global::SavePass.Properties.Resources.B16x16_FileOpen;
			this.miFileOpen.Name = "miFileOpen";
			this.miFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.miFileOpen.Size = new System.Drawing.Size(216, 22);
			this.miFileOpen.Text = "Open...";
			this.miFileOpen.Click += new System.EventHandler(this.FileOpen_Click);
			// 
			// miFileClose
			// 
			this.miFileClose.Enabled = false;
			this.miFileClose.Name = "miFileClose";
			this.miFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.miFileClose.Size = new System.Drawing.Size(216, 22);
			this.miFileClose.Text = "Close";
			this.miFileClose.Click += new System.EventHandler(this.FileClose_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
			// 
			// miFileSave
			// 
			this.miFileSave.Enabled = false;
			this.miFileSave.Image = global::SavePass.Properties.Resources.B16x16_FileSave;
			this.miFileSave.Name = "miFileSave";
			this.miFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.miFileSave.Size = new System.Drawing.Size(216, 22);
			this.miFileSave.Text = "Save";
			this.miFileSave.Click += new System.EventHandler(this.FileSave_Click);
			// 
			// miFileSaveAs
			// 
			this.miFileSaveAs.Enabled = false;
			this.miFileSaveAs.Image = global::SavePass.Properties.Resources.B16x16_FileSaveAs;
			this.miFileSaveAs.Name = "miFileSaveAs";
			this.miFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.miFileSaveAs.Size = new System.Drawing.Size(216, 22);
			this.miFileSaveAs.Text = "Save as...";
			this.miFileSaveAs.Click += new System.EventHandler(this.FileSaveAs_Click);
			// 
			// miFileExportToJson
			// 
			this.miFileExportToJson.Enabled = false;
			this.miFileExportToJson.Name = "miFileExportToJson";
			this.miFileExportToJson.Size = new System.Drawing.Size(216, 22);
			this.miFileExportToJson.Text = "Export...";
			this.miFileExportToJson.Click += new System.EventHandler(this.miFileExportToJson_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
			// 
			// miDatabaseSettings
			// 
			this.miDatabaseSettings.Enabled = false;
			this.miDatabaseSettings.Image = global::SavePass.Properties.Resources.B16x16_Settings;
			this.miDatabaseSettings.Name = "miDatabaseSettings";
			this.miDatabaseSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.miDatabaseSettings.Size = new System.Drawing.Size(216, 22);
			this.miDatabaseSettings.Text = "Database settings...";
			this.miDatabaseSettings.Click += new System.EventHandler(this.DatabaseSettings_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(213, 6);
			// 
			// miExit
			// 
			this.miExit.Name = "miExit";
			this.miExit.Size = new System.Drawing.Size(216, 22);
			this.miExit.Text = "Exit";
			this.miExit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// miEdit
			// 
			this.miEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEntryAdd,
            this.miEntryEdit,
            this.miEntryDelete});
			this.miEdit.Name = "miEdit";
			this.miEdit.Size = new System.Drawing.Size(39, 20);
			this.miEdit.Text = "Edit";
			// 
			// miEntryAdd
			// 
			this.miEntryAdd.Enabled = false;
			this.miEntryAdd.Image = global::SavePass.Properties.Resources.B16x16_EntryAdd;
			this.miEntryAdd.Name = "miEntryAdd";
			this.miEntryAdd.Size = new System.Drawing.Size(137, 22);
			this.miEntryAdd.Text = "Add entry";
			this.miEntryAdd.Click += new System.EventHandler(this.EntryAdd_Click);
			// 
			// miEntryEdit
			// 
			this.miEntryEdit.Enabled = false;
			this.miEntryEdit.Image = global::SavePass.Properties.Resources.B16x16_EntryEdit;
			this.miEntryEdit.Name = "miEntryEdit";
			this.miEntryEdit.Size = new System.Drawing.Size(137, 22);
			this.miEntryEdit.Text = "Edit entry";
			this.miEntryEdit.Click += new System.EventHandler(this.EntryEdit_Click);
			// 
			// miEntryDelete
			// 
			this.miEntryDelete.Enabled = false;
			this.miEntryDelete.Image = global::SavePass.Properties.Resources.B16x16_EntryDelete;
			this.miEntryDelete.Name = "miEntryDelete";
			this.miEntryDelete.Size = new System.Drawing.Size(137, 22);
			this.miEntryDelete.Text = "Delete entry";
			this.miEntryDelete.Click += new System.EventHandler(this.EntryDelete_Click);
			// 
			// miHelp
			// 
			this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelpAbout});
			this.miHelp.Name = "miHelp";
			this.miHelp.Size = new System.Drawing.Size(44, 20);
			this.miHelp.Text = "Help";
			// 
			// miHelpAbout
			// 
			this.miHelpAbout.Name = "miHelpAbout";
			this.miHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.miHelpAbout.Size = new System.Drawing.Size(135, 22);
			this.miHelpAbout.Text = "About...";
			this.miHelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
			// 
			// dgEntries
			// 
			this.dgEntries.AllowUserToAddRows = false;
			this.dgEntries.AllowUserToDeleteRows = false;
			this.dgEntries.AllowUserToResizeColumns = false;
			this.dgEntries.AllowUserToResizeRows = false;
			this.dgEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgEntries.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgEntries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgEntries.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dgEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgEntries.ColumnHeadersVisible = false;
			this.dgEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EntryName});
			this.dgEntries.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgEntries.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgEntries.Location = new System.Drawing.Point(3, 3);
			this.dgEntries.MultiSelect = false;
			this.dgEntries.Name = "dgEntries";
			this.dgEntries.ReadOnly = true;
			this.dgEntries.RowHeadersVisible = false;
			this.dgEntries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgEntries.RowTemplate.ReadOnly = true;
			this.dgEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgEntries.ShowCellErrors = false;
			this.dgEntries.ShowCellToolTips = false;
			this.dgEntries.ShowEditingIcon = false;
			this.dgEntries.ShowRowErrors = false;
			this.dgEntries.Size = new System.Drawing.Size(168, 291);
			this.dgEntries.StandardTab = true;
			this.dgEntries.TabIndex = 1;
			this.dgEntries.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEntries_CellMouseClick);
			this.dgEntries.SelectionChanged += new System.EventHandler(this.dgEntries_SelectionChanged);
			this.dgEntries.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgEntries_MouseClick);
			// 
			// EntryName
			// 
			this.EntryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EntryName.DataPropertyName = "Name";
			this.EntryName.HeaderText = "EntryName";
			this.EntryName.Name = "EntryName";
			this.EntryName.ReadOnly = true;
			// 
			// panEntryEdit
			// 
			this.panEntryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panEntryEdit.Controls.Add(this.btnEntryEditCancel);
			this.panEntryEdit.Controls.Add(this.btnEntryEditDone);
			this.panEntryEdit.Controls.Add(this.tbxNotes);
			this.panEntryEdit.Controls.Add(this.tbxWebsite);
			this.panEntryEdit.Controls.Add(this.tbxEmail);
			this.panEntryEdit.Controls.Add(this.tbxPassword);
			this.panEntryEdit.Controls.Add(this.lNotes);
			this.panEntryEdit.Controls.Add(this.lWebsite);
			this.panEntryEdit.Controls.Add(this.lEmail);
			this.panEntryEdit.Controls.Add(this.tbxUsername);
			this.panEntryEdit.Controls.Add(this.lPassword);
			this.panEntryEdit.Controls.Add(this.lUsername);
			this.panEntryEdit.Controls.Add(this.tbxEntryName);
			this.panEntryEdit.Location = new System.Drawing.Point(192, 52);
			this.panEntryEdit.Name = "panEntryEdit";
			this.panEntryEdit.Size = new System.Drawing.Size(380, 297);
			this.panEntryEdit.TabIndex = 0;
			this.panEntryEdit.Visible = false;
			// 
			// btnEntryEditCancel
			// 
			this.btnEntryEditCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEntryEditCancel.Location = new System.Drawing.Point(302, 270);
			this.btnEntryEditCancel.Name = "btnEntryEditCancel";
			this.btnEntryEditCancel.Size = new System.Drawing.Size(75, 23);
			this.btnEntryEditCancel.TabIndex = 7;
			this.btnEntryEditCancel.Text = "Cancel";
			this.btnEntryEditCancel.UseVisualStyleBackColor = true;
			this.btnEntryEditCancel.Click += new System.EventHandler(this.EntryEditCancel_Click);
			// 
			// btnEntryEditDone
			// 
			this.btnEntryEditDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEntryEditDone.Location = new System.Drawing.Point(221, 270);
			this.btnEntryEditDone.Name = "btnEntryEditDone";
			this.btnEntryEditDone.Size = new System.Drawing.Size(75, 23);
			this.btnEntryEditDone.TabIndex = 6;
			this.btnEntryEditDone.Text = "Save";
			this.btnEntryEditDone.UseVisualStyleBackColor = true;
			this.btnEntryEditDone.Click += new System.EventHandler(this.EntryEditDone_Click);
			// 
			// tbxNotes
			// 
			this.tbxNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxNotes.Location = new System.Drawing.Point(78, 154);
			this.tbxNotes.Multiline = true;
			this.tbxNotes.Name = "tbxNotes";
			this.tbxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxNotes.Size = new System.Drawing.Size(299, 111);
			this.tbxNotes.TabIndex = 5;
			// 
			// tbxWebsite
			// 
			this.tbxWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxWebsite.Location = new System.Drawing.Point(78, 126);
			this.tbxWebsite.Name = "tbxWebsite";
			this.tbxWebsite.Size = new System.Drawing.Size(299, 22);
			this.tbxWebsite.TabIndex = 4;
			// 
			// tbxEmail
			// 
			this.tbxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxEmail.Location = new System.Drawing.Point(78, 99);
			this.tbxEmail.Name = "tbxEmail";
			this.tbxEmail.Size = new System.Drawing.Size(299, 22);
			this.tbxEmail.TabIndex = 3;
			// 
			// tbxPassword
			// 
			this.tbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxPassword.Location = new System.Drawing.Point(78, 72);
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.Size = new System.Drawing.Size(299, 22);
			this.tbxPassword.TabIndex = 2;
			// 
			// lNotes
			// 
			this.lNotes.AutoSize = true;
			this.lNotes.Location = new System.Drawing.Point(7, 157);
			this.lNotes.Name = "lNotes";
			this.lNotes.Size = new System.Drawing.Size(40, 13);
			this.lNotes.TabIndex = 0;
			this.lNotes.Text = "Notes:";
			// 
			// lWebsite
			// 
			this.lWebsite.AutoSize = true;
			this.lWebsite.Location = new System.Drawing.Point(7, 129);
			this.lWebsite.Name = "lWebsite";
			this.lWebsite.Size = new System.Drawing.Size(52, 13);
			this.lWebsite.TabIndex = 0;
			this.lWebsite.Text = "Website:";
			// 
			// lEmail
			// 
			this.lEmail.AutoSize = true;
			this.lEmail.Location = new System.Drawing.Point(7, 102);
			this.lEmail.Name = "lEmail";
			this.lEmail.Size = new System.Drawing.Size(41, 13);
			this.lEmail.TabIndex = 0;
			this.lEmail.Text = "E-mail:";
			// 
			// tbxUsername
			// 
			this.tbxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxUsername.Location = new System.Drawing.Point(78, 44);
			this.tbxUsername.Name = "tbxUsername";
			this.tbxUsername.Size = new System.Drawing.Size(299, 22);
			this.tbxUsername.TabIndex = 1;
			// 
			// lPassword
			// 
			this.lPassword.AutoSize = true;
			this.lPassword.Location = new System.Drawing.Point(7, 75);
			this.lPassword.Name = "lPassword";
			this.lPassword.Size = new System.Drawing.Size(59, 13);
			this.lPassword.TabIndex = 0;
			this.lPassword.Text = "Password:";
			// 
			// lUsername
			// 
			this.lUsername.AutoSize = true;
			this.lUsername.Location = new System.Drawing.Point(7, 47);
			this.lUsername.Name = "lUsername";
			this.lUsername.Size = new System.Drawing.Size(61, 13);
			this.lUsername.TabIndex = 0;
			this.lUsername.Text = "Username:";
			// 
			// tbxEntryName
			// 
			this.tbxEntryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbxEntryName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxEntryName.Location = new System.Drawing.Point(10, 3);
			this.tbxEntryName.Name = "tbxEntryName";
			this.tbxEntryName.Size = new System.Drawing.Size(367, 33);
			this.tbxEntryName.TabIndex = 0;
			// 
			// cmCopyToClipboard
			// 
			this.cmCopyToClipboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiCopy});
			this.cmCopyToClipboard.Name = "cmCopyToClipboard";
			this.cmCopyToClipboard.Size = new System.Drawing.Size(103, 26);
			// 
			// cmiCopy
			// 
			this.cmiCopy.Name = "cmiCopy";
			this.cmiCopy.Size = new System.Drawing.Size(102, 22);
			this.cmiCopy.Text = "Copy";
			this.cmiCopy.Click += new System.EventHandler(this.CopyToClipboard_Click);
			// 
			// panEntriesList
			// 
			this.panEntriesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panEntriesList.Controls.Add(this.dgEntries);
			this.panEntriesList.Enabled = false;
			this.panEntriesList.Location = new System.Drawing.Point(12, 52);
			this.panEntriesList.Name = "panEntriesList";
			this.panEntriesList.Size = new System.Drawing.Size(174, 297);
			this.panEntriesList.TabIndex = 0;
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFileNew,
            this.tsbtnFileOpen,
            this.tsbtnFileSave,
            this.toolStripSeparator,
            this.tsbtnEntryAdd,
            this.tsbtnEntryEdit,
            this.tsbtnEntryDelete,
            this.toolStripSeparator2,
            this.tsbtnCopyUsername,
            this.tsbtnCopyPassword,
            this.tsbtnOpenURL});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.toolStrip1.Size = new System.Drawing.Size(584, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbtnFileNew
			// 
			this.tsbtnFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnFileNew.Image = global::SavePass.Properties.Resources.B16x16_FileNew;
			this.tsbtnFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnFileNew.Name = "tsbtnFileNew";
			this.tsbtnFileNew.Size = new System.Drawing.Size(23, 22);
			this.tsbtnFileNew.Text = "New";
			this.tsbtnFileNew.Click += new System.EventHandler(this.FileNew_Click);
			// 
			// tsbtnFileOpen
			// 
			this.tsbtnFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnFileOpen.Image = global::SavePass.Properties.Resources.B16x16_FileOpen;
			this.tsbtnFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnFileOpen.Name = "tsbtnFileOpen";
			this.tsbtnFileOpen.Size = new System.Drawing.Size(23, 22);
			this.tsbtnFileOpen.Text = "Open";
			this.tsbtnFileOpen.Click += new System.EventHandler(this.FileOpen_Click);
			// 
			// tsbtnFileSave
			// 
			this.tsbtnFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnFileSave.Enabled = false;
			this.tsbtnFileSave.Image = global::SavePass.Properties.Resources.B16x16_FileSave;
			this.tsbtnFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnFileSave.Name = "tsbtnFileSave";
			this.tsbtnFileSave.Size = new System.Drawing.Size(23, 22);
			this.tsbtnFileSave.Text = "Save";
			this.tsbtnFileSave.Click += new System.EventHandler(this.FileSave_Click);
			// 
			// tsbtnEntryAdd
			// 
			this.tsbtnEntryAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnEntryAdd.Enabled = false;
			this.tsbtnEntryAdd.Image = global::SavePass.Properties.Resources.B16x16_EntryAdd;
			this.tsbtnEntryAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnEntryAdd.Name = "tsbtnEntryAdd";
			this.tsbtnEntryAdd.Size = new System.Drawing.Size(23, 22);
			this.tsbtnEntryAdd.Text = "Add entry";
			this.tsbtnEntryAdd.Click += new System.EventHandler(this.EntryAdd_Click);
			// 
			// tsbtnEntryEdit
			// 
			this.tsbtnEntryEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnEntryEdit.Enabled = false;
			this.tsbtnEntryEdit.Image = global::SavePass.Properties.Resources.B16x16_EntryEdit;
			this.tsbtnEntryEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnEntryEdit.Name = "tsbtnEntryEdit";
			this.tsbtnEntryEdit.Size = new System.Drawing.Size(23, 22);
			this.tsbtnEntryEdit.Text = "Edit entry";
			this.tsbtnEntryEdit.Click += new System.EventHandler(this.EntryEdit_Click);
			// 
			// tsbtnEntryDelete
			// 
			this.tsbtnEntryDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnEntryDelete.Enabled = false;
			this.tsbtnEntryDelete.Image = global::SavePass.Properties.Resources.B16x16_EntryDelete;
			this.tsbtnEntryDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnEntryDelete.Name = "tsbtnEntryDelete";
			this.tsbtnEntryDelete.Size = new System.Drawing.Size(23, 22);
			this.tsbtnEntryDelete.Text = "Delete entry";
			this.tsbtnEntryDelete.Click += new System.EventHandler(this.EntryDelete_Click);
			// 
			// tsbtnCopyUsername
			// 
			this.tsbtnCopyUsername.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnCopyUsername.Enabled = false;
			this.tsbtnCopyUsername.Image = global::SavePass.Properties.Resources.B16x16_CopyUsername;
			this.tsbtnCopyUsername.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnCopyUsername.Name = "tsbtnCopyUsername";
			this.tsbtnCopyUsername.Size = new System.Drawing.Size(23, 22);
			this.tsbtnCopyUsername.Text = "Copy username to clipboard";
			this.tsbtnCopyUsername.Click += new System.EventHandler(this.tsbtnCopyUsername_Click);
			// 
			// tsbtnCopyPassword
			// 
			this.tsbtnCopyPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnCopyPassword.Enabled = false;
			this.tsbtnCopyPassword.Image = global::SavePass.Properties.Resources.B16x16_CopyPassword;
			this.tsbtnCopyPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnCopyPassword.Name = "tsbtnCopyPassword";
			this.tsbtnCopyPassword.Size = new System.Drawing.Size(23, 22);
			this.tsbtnCopyPassword.Text = "Copy password to clipboard";
			this.tsbtnCopyPassword.Click += new System.EventHandler(this.tsbtnCopyPassword_Click);
			// 
			// tsbtnOpenURL
			// 
			this.tsbtnOpenURL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnOpenURL.Enabled = false;
			this.tsbtnOpenURL.Image = global::SavePass.Properties.Resources.B16x16_Browser;
			this.tsbtnOpenURL.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnOpenURL.Name = "tsbtnOpenURL";
			this.tsbtnOpenURL.Size = new System.Drawing.Size(23, 22);
			this.tsbtnOpenURL.Text = "Open URL";
			this.tsbtnOpenURL.Click += new System.EventHandler(this.OpenURL_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "SavePass file (*.savepass)|*.savepass|All files (*.*)|*.*";
			this.saveFileDialog1.SupportMultiDottedExtensions = true;
			this.saveFileDialog1.Title = "Save";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "SavePass file (*.savepass)|*.savepass|All files (*.*)|*.*";
			this.openFileDialog1.SupportMultiDottedExtensions = true;
			// 
			// btnWebsite
			// 
			this.btnWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnWebsite.ContextMenuStrip = this.cmCopyToClipboard;
			this.btnWebsite.FlatAppearance.BorderSize = 0;
			this.btnWebsite.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnWebsite.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWebsite.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnWebsite.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btnWebsite.Location = new System.Drawing.Point(74, 125);
			this.btnWebsite.Name = "btnWebsite";
			this.btnWebsite.Size = new System.Drawing.Size(303, 22);
			this.btnWebsite.TabIndex = 4;
			this.btnWebsite.TabStop = false;
			this.btnWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTipCopyToClipboard.SetToolTip(this.btnWebsite, "Open URL");
			this.btnWebsite.UseVisualStyleBackColor = true;
			this.btnWebsite.Click += new System.EventHandler(this.OpenURL_Click);
			// 
			// cmEntryList
			// 
			this.cmEntryList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiEntryAdd,
            this.cmiEntryEdit,
            this.cmiEntryDelete});
			this.cmEntryList.Name = "cmEntryList";
			this.cmEntryList.Size = new System.Drawing.Size(138, 70);
			// 
			// cmiEntryAdd
			// 
			this.cmiEntryAdd.Image = global::SavePass.Properties.Resources.B16x16_EntryAdd;
			this.cmiEntryAdd.Name = "cmiEntryAdd";
			this.cmiEntryAdd.Size = new System.Drawing.Size(137, 22);
			this.cmiEntryAdd.Text = "Add entry";
			this.cmiEntryAdd.Click += new System.EventHandler(this.EntryAdd_Click);
			// 
			// cmiEntryEdit
			// 
			this.cmiEntryEdit.Image = global::SavePass.Properties.Resources.B16x16_EntryEdit;
			this.cmiEntryEdit.Name = "cmiEntryEdit";
			this.cmiEntryEdit.Size = new System.Drawing.Size(137, 22);
			this.cmiEntryEdit.Text = "Edit entry";
			this.cmiEntryEdit.Click += new System.EventHandler(this.EntryEdit_Click);
			// 
			// cmiEntryDelete
			// 
			this.cmiEntryDelete.Image = global::SavePass.Properties.Resources.B16x16_EntryDelete;
			this.cmiEntryDelete.Name = "cmiEntryDelete";
			this.cmiEntryDelete.Size = new System.Drawing.Size(137, 22);
			this.cmiEntryDelete.Text = "Delete entry";
			this.cmiEntryDelete.Click += new System.EventHandler(this.EntryDelete_Click);
			// 
			// panEntryInfo
			// 
			this.panEntryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panEntryInfo.Controls.Add(this.btnNotes);
			this.panEntryInfo.Controls.Add(this.btnWebsite);
			this.panEntryInfo.Controls.Add(this.btnEmail);
			this.panEntryInfo.Controls.Add(this.btnPassword);
			this.panEntryInfo.Controls.Add(this.btnUsername);
			this.panEntryInfo.Controls.Add(this.btnEntryName);
			this.panEntryInfo.Controls.Add(this.lUsername2);
			this.panEntryInfo.Controls.Add(this.lNotes2);
			this.panEntryInfo.Controls.Add(this.lPassword2);
			this.panEntryInfo.Controls.Add(this.lWebsite2);
			this.panEntryInfo.Controls.Add(this.lEmail2);
			this.panEntryInfo.Enabled = false;
			this.panEntryInfo.Location = new System.Drawing.Point(192, 52);
			this.panEntryInfo.Name = "panEntryInfo";
			this.panEntryInfo.Size = new System.Drawing.Size(380, 297);
			this.panEntryInfo.TabIndex = 1;
			// 
			// btnNotes
			// 
			this.btnNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNotes.ContextMenuStrip = this.cmCopyToClipboard;
			this.btnNotes.FlatAppearance.BorderSize = 0;
			this.btnNotes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnNotes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNotes.Location = new System.Drawing.Point(74, 153);
			this.btnNotes.Name = "btnNotes";
			this.btnNotes.Size = new System.Drawing.Size(303, 131);
			this.btnNotes.TabIndex = 5;
			this.btnNotes.TabStop = false;
			this.btnNotes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			// 
			// btnEmail
			// 
			this.btnEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEmail.ContextMenuStrip = this.cmCopyToClipboard;
			this.btnEmail.FlatAppearance.BorderSize = 0;
			this.btnEmail.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnEmail.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmail.Location = new System.Drawing.Point(74, 98);
			this.btnEmail.Name = "btnEmail";
			this.btnEmail.Size = new System.Drawing.Size(303, 22);
			this.btnEmail.TabIndex = 3;
			this.btnEmail.TabStop = false;
			this.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEmail.UseVisualStyleBackColor = true;
			// 
			// btnPassword
			// 
			this.btnPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPassword.ContextMenuStrip = this.cmCopyToClipboard;
			this.btnPassword.FlatAppearance.BorderSize = 0;
			this.btnPassword.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnPassword.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPassword.Location = new System.Drawing.Point(74, 71);
			this.btnPassword.Name = "btnPassword";
			this.btnPassword.Size = new System.Drawing.Size(303, 22);
			this.btnPassword.TabIndex = 2;
			this.btnPassword.TabStop = false;
			this.btnPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPassword.UseVisualStyleBackColor = true;
			// 
			// btnUsername
			// 
			this.btnUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUsername.ContextMenuStrip = this.cmCopyToClipboard;
			this.btnUsername.FlatAppearance.BorderSize = 0;
			this.btnUsername.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnUsername.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUsername.Location = new System.Drawing.Point(74, 43);
			this.btnUsername.Name = "btnUsername";
			this.btnUsername.Size = new System.Drawing.Size(303, 22);
			this.btnUsername.TabIndex = 1;
			this.btnUsername.TabStop = false;
			this.btnUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUsername.UseVisualStyleBackColor = true;
			// 
			// btnEntryName
			// 
			this.btnEntryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEntryName.ContextMenuStrip = this.cmCopyToClipboard;
			this.btnEntryName.FlatAppearance.BorderSize = 0;
			this.btnEntryName.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnEntryName.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
			this.btnEntryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntryName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEntryName.Location = new System.Drawing.Point(4, 2);
			this.btnEntryName.Name = "btnEntryName";
			this.btnEntryName.Size = new System.Drawing.Size(373, 35);
			this.btnEntryName.TabIndex = 0;
			this.btnEntryName.TabStop = false;
			this.btnEntryName.Text = "Title";
			this.btnEntryName.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnEntryName.UseVisualStyleBackColor = true;
			// 
			// lUsername2
			// 
			this.lUsername2.AutoSize = true;
			this.lUsername2.Location = new System.Drawing.Point(7, 47);
			this.lUsername2.Name = "lUsername2";
			this.lUsername2.Size = new System.Drawing.Size(61, 13);
			this.lUsername2.TabIndex = 0;
			this.lUsername2.Text = "Username:";
			// 
			// lNotes2
			// 
			this.lNotes2.AutoSize = true;
			this.lNotes2.Location = new System.Drawing.Point(7, 157);
			this.lNotes2.Name = "lNotes2";
			this.lNotes2.Size = new System.Drawing.Size(40, 13);
			this.lNotes2.TabIndex = 0;
			this.lNotes2.Text = "Notes:";
			// 
			// lPassword2
			// 
			this.lPassword2.AutoSize = true;
			this.lPassword2.Location = new System.Drawing.Point(7, 75);
			this.lPassword2.Name = "lPassword2";
			this.lPassword2.Size = new System.Drawing.Size(59, 13);
			this.lPassword2.TabIndex = 0;
			this.lPassword2.Text = "Password:";
			// 
			// lWebsite2
			// 
			this.lWebsite2.AutoSize = true;
			this.lWebsite2.Location = new System.Drawing.Point(7, 129);
			this.lWebsite2.Name = "lWebsite2";
			this.lWebsite2.Size = new System.Drawing.Size(52, 13);
			this.lWebsite2.TabIndex = 0;
			this.lWebsite2.Text = "Website:";
			// 
			// lEmail2
			// 
			this.lEmail2.AutoSize = true;
			this.lEmail2.Location = new System.Drawing.Point(7, 102);
			this.lEmail2.Name = "lEmail2";
			this.lEmail2.Size = new System.Drawing.Size(41, 13);
			this.lEmail2.TabIndex = 0;
			this.lEmail2.Text = "E-mail:";
			// 
			// saveFileDialog2
			// 
			this.saveFileDialog2.Filter = "JSON file (*.json)|*.json|All files (*.*)|*.*";
			this.saveFileDialog2.SupportMultiDottedExtensions = true;
			this.saveFileDialog2.Title = "Save";
			// 
			// FormMain
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.panEntryInfo);
			this.Controls.Add(this.panEntriesList);
			this.Controls.Add(this.panEntryEdit);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.Text = "Password Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgEntries)).EndInit();
			this.panEntryEdit.ResumeLayout(false);
			this.panEntryEdit.PerformLayout();
			this.cmCopyToClipboard.ResumeLayout(false);
			this.panEntriesList.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.cmEntryList.ResumeLayout(false);
			this.panEntryInfo.ResumeLayout(false);
			this.panEntryInfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem miFile;
		private System.Windows.Forms.ToolStripMenuItem miHelp;
		private System.Windows.Forms.DataGridView dgEntries;
		private System.Windows.Forms.ToolStripMenuItem miFileNew;
		private System.Windows.Forms.ToolStripMenuItem miFileOpen;
		private System.Windows.Forms.ToolStripMenuItem miFileClose;
		private System.Windows.Forms.ToolStripMenuItem miEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem miFileSave;
		private System.Windows.Forms.ToolStripMenuItem miFileSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem miDatabaseSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem miExit;
		private System.Windows.Forms.ToolStripMenuItem miEntryAdd;
		private System.Windows.Forms.ToolStripMenuItem miEntryDelete;
		private System.Windows.Forms.Panel panEntryEdit;
		private System.Windows.Forms.TextBox tbxEntryName;
		private System.Windows.Forms.TextBox tbxUsername;
		private System.Windows.Forms.Label lUsername;
		private System.Windows.Forms.TextBox tbxPassword;
		private System.Windows.Forms.Label lPassword;
		private System.Windows.Forms.TextBox tbxEmail;
		private System.Windows.Forms.Label lEmail;
		private System.Windows.Forms.TextBox tbxWebsite;
		private System.Windows.Forms.Label lWebsite;
		private System.Windows.Forms.TextBox tbxNotes;
		private System.Windows.Forms.Label lNotes;
		private System.Windows.Forms.Panel panEntriesList;
		private System.Windows.Forms.ToolStripButton tsbtnFileNew;
		private System.Windows.Forms.ToolStripButton tsbtnFileOpen;
		private System.Windows.Forms.ToolStripButton tsbtnFileSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton tsbtnEntryAdd;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbtnCopyUsername;
		private System.Windows.Forms.ToolStripButton tsbtnCopyPassword;
		private System.Windows.Forms.ToolStripButton tsbtnOpenURL;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnEntryEditDone;
		private System.Windows.Forms.ToolStripMenuItem miEntryEdit;
		private System.Windows.Forms.ToolTip toolTipCopyToClipboard;
		private System.Windows.Forms.ContextMenuStrip cmEntryList;
		private System.Windows.Forms.ToolStripMenuItem cmiEntryAdd;
		private System.Windows.Forms.ToolStripMenuItem cmiEntryEdit;
		private System.Windows.Forms.ToolStripMenuItem cmiEntryDelete;
		private System.Windows.Forms.ToolStripButton tsbtnEntryEdit;
		private System.Windows.Forms.ToolStripButton tsbtnEntryDelete;
		private System.Windows.Forms.ContextMenuStrip cmCopyToClipboard;
		private System.Windows.Forms.ToolStripMenuItem cmiCopy;
		private System.Windows.Forms.ToolStripMenuItem miHelpAbout;
		private System.Windows.Forms.Button btnEntryEditCancel;
		private System.Windows.Forms.Panel panEntryInfo;
		private System.Windows.Forms.Button btnNotes;
		private System.Windows.Forms.Button btnWebsite;
		private System.Windows.Forms.Button btnEmail;
		private System.Windows.Forms.Button btnPassword;
		private System.Windows.Forms.Button btnUsername;
		private System.Windows.Forms.Button btnEntryName;
		private System.Windows.Forms.Label lUsername2;
		private System.Windows.Forms.Label lNotes2;
		private System.Windows.Forms.Label lPassword2;
		private System.Windows.Forms.Label lWebsite2;
		private System.Windows.Forms.Label lEmail2;
		private System.Windows.Forms.DataGridViewTextBoxColumn EntryName;
		private System.Windows.Forms.ToolStripMenuItem miFileExportToJson;
		private System.Windows.Forms.SaveFileDialog saveFileDialog2;
	}
}

