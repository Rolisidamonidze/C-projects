namespace Notepad_2 {
	partial class NotepadForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadForm));
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.file = new System.Windows.Forms.ToolStripMenuItem();
         this.newFileFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.openFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.saveFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAsFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.printFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.printPreviewFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.exitFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.undoFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.cutFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.copyFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.pasteFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
         this.selectAllFromMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.opetionsMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.font = new System.Windows.Forms.ToolStripMenuItem();
         this.sizeIncrease = new System.Windows.Forms.ToolStripMenuItem();
         this.sizeDecrease = new System.Windows.Forms.ToolStripMenuItem();
         this.fontsList = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
         this.about = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.newFile = new System.Windows.Forms.ToolStripButton();
         this.open = new System.Windows.Forms.ToolStripButton();
         this.save = new System.Windows.Forms.ToolStripButton();
         this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
         this.cut = new System.Windows.Forms.ToolStripButton();
         this.copy = new System.Windows.Forms.ToolStripButton();
         this.paste = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
         this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
         this._textBox = new System.Windows.Forms.RichTextBox();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.menuStrip1.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.font,
            this.helpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(800, 24);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // file
         // 
         this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileFromMenu,
            this.openFromMenu,
            this.toolStripSeparator,
            this.saveFromMenu,
            this.saveAsFromMenu,
            this.toolStripSeparator1,
            this.printFromMenu,
            this.printPreviewFromMenu,
            this.toolStripSeparator2,
            this.exitFromMenu});
         this.file.Name = "file";
         this.file.Size = new System.Drawing.Size(37, 20);
         this.file.Text = "&File";
         // 
         // newFileFromMenu
         // 
         this.newFileFromMenu.Image = ((System.Drawing.Image)(resources.GetObject("newFileFromMenu.Image")));
         this.newFileFromMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.newFileFromMenu.Name = "newFileFromMenu";
         this.newFileFromMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
         this.newFileFromMenu.Size = new System.Drawing.Size(146, 22);
         this.newFileFromMenu.Text = "&New";
         this.newFileFromMenu.Click += new System.EventHandler(this.newFileFromMenu_Click);
         // 
         // openFromMenu
         // 
         this.openFromMenu.Image = ((System.Drawing.Image)(resources.GetObject("openFromMenu.Image")));
         this.openFromMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.openFromMenu.Name = "openFromMenu";
         this.openFromMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.openFromMenu.Size = new System.Drawing.Size(146, 22);
         this.openFromMenu.Text = "&Open";
         this.openFromMenu.Click += new System.EventHandler(this.openFromMenu_Click);
         // 
         // toolStripSeparator
         // 
         this.toolStripSeparator.Name = "toolStripSeparator";
         this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
         // 
         // saveFromMenu
         // 
         this.saveFromMenu.Image = ((System.Drawing.Image)(resources.GetObject("saveFromMenu.Image")));
         this.saveFromMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.saveFromMenu.Name = "saveFromMenu";
         this.saveFromMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.saveFromMenu.Size = new System.Drawing.Size(146, 22);
         this.saveFromMenu.Text = "&Save";
         this.saveFromMenu.Click += new System.EventHandler(this.saveFromMenu_Click);
         // 
         // saveAsFromMenu
         // 
         this.saveAsFromMenu.Name = "saveAsFromMenu";
         this.saveAsFromMenu.Size = new System.Drawing.Size(146, 22);
         this.saveAsFromMenu.Text = "Save &As";
         this.saveAsFromMenu.Click += new System.EventHandler(this.saveAsFromMenu_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
         // 
         // printFromMenu
         // 
         this.printFromMenu.Image = ((System.Drawing.Image)(resources.GetObject("printFromMenu.Image")));
         this.printFromMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.printFromMenu.Name = "printFromMenu";
         this.printFromMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
         this.printFromMenu.Size = new System.Drawing.Size(146, 22);
         this.printFromMenu.Text = "&Print";
         // 
         // printPreviewFromMenu
         // 
         this.printPreviewFromMenu.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewFromMenu.Image")));
         this.printPreviewFromMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.printPreviewFromMenu.Name = "printPreviewFromMenu";
         this.printPreviewFromMenu.Size = new System.Drawing.Size(146, 22);
         this.printPreviewFromMenu.Text = "Print Pre&view";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
         // 
         // exitFromMenu
         // 
         this.exitFromMenu.Name = "exitFromMenu";
         this.exitFromMenu.Size = new System.Drawing.Size(146, 22);
         this.exitFromMenu.Text = "E&xit";
         // 
         // editToolStripMenuItem
         // 
         this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoFromMenu,
            this.toolStripSeparator3,
            this.cutFromMenu,
            this.copyFromMenu,
            this.pasteFromMenu,
            this.toolStripSeparator4,
            this.selectAllFromMenu});
         this.editToolStripMenuItem.Name = "editToolStripMenuItem";
         this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
         this.editToolStripMenuItem.Text = "&Edit";
         // 
         // undoFromMenu
         // 
         this.undoFromMenu.Name = "undoFromMenu";
         this.undoFromMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
         this.undoFromMenu.Size = new System.Drawing.Size(180, 22);
         this.undoFromMenu.Text = "&Undo";
         this.undoFromMenu.Click += new System.EventHandler(this.undoFromMenu_Click);
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
         // 
         // cutFromMenu
         // 
         this.cutFromMenu.Image = ((System.Drawing.Image)(resources.GetObject("cutFromMenu.Image")));
         this.cutFromMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.cutFromMenu.Name = "cutFromMenu";
         this.cutFromMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
         this.cutFromMenu.Size = new System.Drawing.Size(180, 22);
         this.cutFromMenu.Text = "Cu&t";
         this.cutFromMenu.Click += new System.EventHandler(this.cutFromMenu_Click);
         // 
         // copyFromMenu
         // 
         this.copyFromMenu.Image = ((System.Drawing.Image)(resources.GetObject("copyFromMenu.Image")));
         this.copyFromMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.copyFromMenu.Name = "copyFromMenu";
         this.copyFromMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
         this.copyFromMenu.Size = new System.Drawing.Size(180, 22);
         this.copyFromMenu.Text = "&Copy";
         this.copyFromMenu.Click += new System.EventHandler(this.copyFromMenu_Click);
         // 
         // pasteFromMenu
         // 
         this.pasteFromMenu.Image = ((System.Drawing.Image)(resources.GetObject("pasteFromMenu.Image")));
         this.pasteFromMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.pasteFromMenu.Name = "pasteFromMenu";
         this.pasteFromMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
         this.pasteFromMenu.Size = new System.Drawing.Size(180, 22);
         this.pasteFromMenu.Text = "&Paste";
         this.pasteFromMenu.Click += new System.EventHandler(this.pasteFromMenu_Click);
         // 
         // toolStripSeparator4
         // 
         this.toolStripSeparator4.Name = "toolStripSeparator4";
         this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
         // 
         // selectAllFromMenu
         // 
         this.selectAllFromMenu.Name = "selectAllFromMenu";
         this.selectAllFromMenu.Size = new System.Drawing.Size(180, 22);
         this.selectAllFromMenu.Text = "Select &All";
         this.selectAllFromMenu.Click += new System.EventHandler(this.selectAllFromMenu_Click);
         // 
         // toolsToolStripMenuItem
         // 
         this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.opetionsMenu});
         this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
         this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
         this.toolsToolStripMenuItem.Text = "&Tools";
         // 
         // customizeToolStripMenuItem
         // 
         this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
         this.customizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.customizeToolStripMenuItem.Text = "&Customize";
         // 
         // opetionsMenu
         // 
         this.opetionsMenu.Name = "opetionsMenu";
         this.opetionsMenu.Size = new System.Drawing.Size(180, 22);
         this.opetionsMenu.Text = "&Options";
         // 
         // font
         // 
         this.font.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeIncrease,
            this.sizeDecrease,
            this.fontsList});
         this.font.Name = "font";
         this.font.Size = new System.Drawing.Size(43, 20);
         this.font.Text = "Font";
         // 
         // sizeIncrease
         // 
         this.sizeIncrease.Name = "sizeIncrease";
         this.sizeIncrease.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
         this.sizeIncrease.Size = new System.Drawing.Size(167, 22);
         this.sizeIncrease.Text = "Size +";
         this.sizeIncrease.Click += new System.EventHandler(this.sizeIncrease_Click);
         // 
         // sizeDecrease
         // 
         this.sizeDecrease.Name = "sizeDecrease";
         this.sizeDecrease.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
         this.sizeDecrease.Size = new System.Drawing.Size(167, 22);
         this.sizeDecrease.Text = "Size -";
         this.sizeDecrease.Click += new System.EventHandler(this.sizeDecrease_Click);
         // 
         // fontsList
         // 
         this.fontsList.Name = "fontsList";
         this.fontsList.Size = new System.Drawing.Size(167, 22);
         this.fontsList.Text = "Fonts";
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.about});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.helpToolStripMenuItem.Text = "&Help";
         // 
         // contentsToolStripMenuItem
         // 
         this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
         this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
         this.contentsToolStripMenuItem.Text = "&Contents";
         // 
         // indexToolStripMenuItem
         // 
         this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
         this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
         this.indexToolStripMenuItem.Text = "&Index";
         // 
         // searchToolStripMenuItem
         // 
         this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
         this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
         this.searchToolStripMenuItem.Text = "&Search";
         // 
         // toolStripSeparator5
         // 
         this.toolStripSeparator5.Name = "toolStripSeparator5";
         this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
         // 
         // about
         // 
         this.about.Name = "about";
         this.about.Size = new System.Drawing.Size(122, 22);
         this.about.Text = "&About...";
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.open,
            this.save,
            this.printToolStripButton,
            this.toolStripSeparator6,
            this.cut,
            this.copy,
            this.paste,
            this.toolStripSeparator7,
            this.helpToolStripButton});
         this.toolStrip1.Location = new System.Drawing.Point(0, 24);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(800, 25);
         this.toolStrip1.TabIndex = 1;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // newFile
         // 
         this.newFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.newFile.Image = ((System.Drawing.Image)(resources.GetObject("newFile.Image")));
         this.newFile.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.newFile.Name = "newFile";
         this.newFile.Size = new System.Drawing.Size(23, 22);
         this.newFile.Text = "&New";
         this.newFile.Click += new System.EventHandler(this.newFile_Click);
         // 
         // open
         // 
         this.open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
         this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.open.Name = "open";
         this.open.Size = new System.Drawing.Size(23, 22);
         this.open.Text = "&Open";
         this.open.Click += new System.EventHandler(this.open_Click);
         // 
         // save
         // 
         this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
         this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.save.Name = "save";
         this.save.Size = new System.Drawing.Size(23, 22);
         this.save.Text = "&Save";
         this.save.Click += new System.EventHandler(this.save_Click);
         // 
         // printToolStripButton
         // 
         this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
         this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.printToolStripButton.Name = "printToolStripButton";
         this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
         this.printToolStripButton.Text = "&Print";
         // 
         // toolStripSeparator6
         // 
         this.toolStripSeparator6.Name = "toolStripSeparator6";
         this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
         // 
         // cut
         // 
         this.cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.cut.Image = ((System.Drawing.Image)(resources.GetObject("cut.Image")));
         this.cut.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.cut.Name = "cut";
         this.cut.Size = new System.Drawing.Size(23, 22);
         this.cut.Text = "C&ut";
         this.cut.Click += new System.EventHandler(this.cut_Click);
         // 
         // copy
         // 
         this.copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.copy.Image = ((System.Drawing.Image)(resources.GetObject("copy.Image")));
         this.copy.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.copy.Name = "copy";
         this.copy.Size = new System.Drawing.Size(23, 22);
         this.copy.Text = "&Copy";
         this.copy.Click += new System.EventHandler(this.copy_Click);
         // 
         // paste
         // 
         this.paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.paste.Image = ((System.Drawing.Image)(resources.GetObject("paste.Image")));
         this.paste.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.paste.Name = "paste";
         this.paste.Size = new System.Drawing.Size(23, 22);
         this.paste.Text = "&Paste";
         this.paste.Click += new System.EventHandler(this.paste_Click);
         // 
         // toolStripSeparator7
         // 
         this.toolStripSeparator7.Name = "toolStripSeparator7";
         this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
         // 
         // helpToolStripButton
         // 
         this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
         this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.helpToolStripButton.Name = "helpToolStripButton";
         this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
         this.helpToolStripButton.Text = "He&lp";
         // 
         // _textBox
         // 
         this._textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this._textBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this._textBox.Location = new System.Drawing.Point(0, 49);
         this._textBox.Name = "_textBox";
         this._textBox.Size = new System.Drawing.Size(800, 401);
         this._textBox.TabIndex = 2;
         this._textBox.Text = "";
         this._textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._textBox_KeyPress);
         // 
         // statusStrip1
         // 
         this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
         this.statusStrip1.Location = new System.Drawing.Point(0, 428);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(800, 22);
         this.statusStrip1.TabIndex = 3;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
         this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
         // 
         // NotepadForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this._textBox);
         this.Controls.Add(this.toolStrip1);
         this.Controls.Add(this.menuStrip1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "NotepadForm";
         this.Text = "Notepad - Untitled";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotepadForm_FormClosing);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem file;
		private System.Windows.Forms.ToolStripMenuItem newFileFromMenu;
		private System.Windows.Forms.ToolStripMenuItem openFromMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveFromMenu;
		private System.Windows.Forms.ToolStripMenuItem saveAsFromMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem printFromMenu;
		private System.Windows.Forms.ToolStripMenuItem printPreviewFromMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitFromMenu;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoFromMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem cutFromMenu;
		private System.Windows.Forms.ToolStripMenuItem copyFromMenu;
		private System.Windows.Forms.ToolStripMenuItem pasteFromMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem selectAllFromMenu;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem opetionsMenu;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem about;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton newFile;
		private System.Windows.Forms.ToolStripButton open;
		private System.Windows.Forms.ToolStripButton save;
		private System.Windows.Forms.ToolStripButton printToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton cut;
		private System.Windows.Forms.ToolStripButton copy;
		private System.Windows.Forms.ToolStripButton paste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private System.Windows.Forms.RichTextBox _textBox;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem font;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.ToolStripMenuItem sizeIncrease;
      private System.Windows.Forms.ToolStripMenuItem sizeDecrease;
      private System.Windows.Forms.ToolStripMenuItem fontsList;
   }
}

