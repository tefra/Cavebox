/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
namespace Cavebox.Forms
{
	partial class Main
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.FileListSplitContainer = new System.Windows.Forms.SplitContainer();
			this.cakeboxDiscSplitContainer = new System.Windows.Forms.SplitContainer();
			this.cakeboxesGroupBox = new System.Windows.Forms.GroupBox();
			this.cakeboxesListBox = new System.Windows.Forms.ListBox();
			this.cakeboxesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyCakeboxLabelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.editCakeboxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteCakeboxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.massMoveDiscsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.discsGroupBox = new System.Windows.Forms.GroupBox();
			this.discsListBox = new System.Windows.Forms.ListBox();
			this.discsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyDiscLabelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.editDiscMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteDiscMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.DiscsOrderMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.DiscsOrderByIdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DiscsOrderByLabelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DiscsOrderByFilesNoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.DiscsOrderAscMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DiscsOrderDescMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filterGroupBox = new System.Windows.Forms.GroupBox();
			this.clearFilterButton = new System.Windows.Forms.Button();
			this.filterTextBox = new System.Windows.Forms.TextBox();
			this.fileListGroupBox = new System.Windows.Forms.GroupBox();
			this.fileList = new System.Windows.Forms.RichTextBox();
			this.filesListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyFileListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.googleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wikipediaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.anidbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imdbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lastfmMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.youtubeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.metacriticMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tvcomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newCakeboxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rebuildTotalFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vacuumDatabaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dropDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changelogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.cakeboxStatsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.discStatsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.fileStatsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.discAddedLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.discAddedValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.mainTabPage = new System.Windows.Forms.TabPage();
			this.scanTabPage = new System.Windows.Forms.TabPage();
			this.saveNewDiscGroupBox = new System.Windows.Forms.GroupBox();
			this.newDiscCakebox = new System.Windows.Forms.ComboBox();
			this.saveNewDiscButton = new System.Windows.Forms.Button();
			this.newDiscLabelTextBox = new System.Windows.Forms.TextBox();
			this.newDiscCakeboxLabel = new System.Windows.Forms.Label();
			this.newDiscLabelLabel = new System.Windows.Forms.Label();
			this.scanFileListGroupBox = new System.Windows.Forms.GroupBox();
			this.scanFileList = new System.Windows.Forms.RichTextBox();
			this.scanFileListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyScanFileListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.resetScanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scanPathGroupBox = new System.Windows.Forms.GroupBox();
			this.scanPathComboBox = new System.Windows.Forms.ComboBox();
			this.browseScanPathButton = new System.Windows.Forms.Button();
			this.toggleScanPathButton = new System.Windows.Forms.Button();
			this.consoleTabPage = new System.Windows.Forms.TabPage();
			this.consoleGroupBox = new System.Windows.Forms.GroupBox();
			this.console = new System.Windows.Forms.RichTextBox();
			this.consoleMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyConsoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scanWorker = new System.ComponentModel.BackgroundWorker();
			this.filterTextChangedTimer = new System.Windows.Forms.Timer(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.FileListSplitContainer)).BeginInit();
			this.FileListSplitContainer.Panel1.SuspendLayout();
			this.FileListSplitContainer.Panel2.SuspendLayout();
			this.FileListSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cakeboxDiscSplitContainer)).BeginInit();
			this.cakeboxDiscSplitContainer.Panel1.SuspendLayout();
			this.cakeboxDiscSplitContainer.Panel2.SuspendLayout();
			this.cakeboxDiscSplitContainer.SuspendLayout();
			this.cakeboxesGroupBox.SuspendLayout();
			this.cakeboxesMenu.SuspendLayout();
			this.discsGroupBox.SuspendLayout();
			this.discsMenu.SuspendLayout();
			this.filterGroupBox.SuspendLayout();
			this.fileListGroupBox.SuspendLayout();
			this.filesListMenu.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.mainTabPage.SuspendLayout();
			this.scanTabPage.SuspendLayout();
			this.saveNewDiscGroupBox.SuspendLayout();
			this.scanFileListGroupBox.SuspendLayout();
			this.scanFileListMenu.SuspendLayout();
			this.scanPathGroupBox.SuspendLayout();
			this.consoleTabPage.SuspendLayout();
			this.consoleGroupBox.SuspendLayout();
			this.consoleMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// FileListSplitContainer
			// 
			this.FileListSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FileListSplitContainer.Location = new System.Drawing.Point(3, 3);
			this.FileListSplitContainer.Name = "FileListSplitContainer";
			this.FileListSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// FileListSplitContainer.Panel1
			// 
			this.FileListSplitContainer.Panel1.Controls.Add(this.cakeboxDiscSplitContainer);
			this.FileListSplitContainer.Panel1.Controls.Add(this.filterGroupBox);
			this.FileListSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// FileListSplitContainer.Panel2
			// 
			this.FileListSplitContainer.Panel2.Controls.Add(this.fileListGroupBox);
			this.FileListSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.FileListSplitContainer.Size = new System.Drawing.Size(520, 482);
			this.FileListSplitContainer.SplitterDistance = 310;
			this.FileListSplitContainer.TabIndex = 0;
			// 
			// cakeboxDiscSplitContainer
			// 
			this.cakeboxDiscSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.cakeboxDiscSplitContainer.Location = new System.Drawing.Point(0, 61);
			this.cakeboxDiscSplitContainer.Name = "cakeboxDiscSplitContainer";
			// 
			// cakeboxDiscSplitContainer.Panel1
			// 
			this.cakeboxDiscSplitContainer.Panel1.Controls.Add(this.cakeboxesGroupBox);
			this.cakeboxDiscSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// cakeboxDiscSplitContainer.Panel2
			// 
			this.cakeboxDiscSplitContainer.Panel2.Controls.Add(this.discsGroupBox);
			this.cakeboxDiscSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cakeboxDiscSplitContainer.Size = new System.Drawing.Size(520, 249);
			this.cakeboxDiscSplitContainer.SplitterDistance = 258;
			this.cakeboxDiscSplitContainer.TabIndex = 1;
			// 
			// cakeboxesGroupBox
			// 
			this.cakeboxesGroupBox.Controls.Add(this.cakeboxesListBox);
			this.cakeboxesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cakeboxesGroupBox.Location = new System.Drawing.Point(0, 0);
			this.cakeboxesGroupBox.Name = "cakeboxesGroupBox";
			this.cakeboxesGroupBox.Size = new System.Drawing.Size(258, 249);
			this.cakeboxesGroupBox.TabIndex = 0;
			this.cakeboxesGroupBox.TabStop = false;
			this.cakeboxesGroupBox.Text = "Cakeboxes";
			// 
			// cakeboxesListBox
			// 
			this.cakeboxesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cakeboxesListBox.ContextMenuStrip = this.cakeboxesMenu;
			this.cakeboxesListBox.DisplayMember = "Value";
			this.cakeboxesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cakeboxesListBox.FormattingEnabled = true;
			this.cakeboxesListBox.Location = new System.Drawing.Point(3, 16);
			this.cakeboxesListBox.Name = "cakeboxesListBox";
			this.cakeboxesListBox.Size = new System.Drawing.Size(252, 230);
			this.cakeboxesListBox.TabIndex = 0;
			this.cakeboxesListBox.ValueMember = "Key";
			this.cakeboxesListBox.SelectedValueChanged += new System.EventHandler(this.ShowDiscs);
			this.cakeboxesListBox.DoubleClick += new System.EventHandler(this.OpenEditCakeboxForm);
			this.cakeboxesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxMouseDown);
			this.cakeboxesListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IdentityMouseMove);
			// 
			// cakeboxesMenu
			// 
			this.cakeboxesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyCakeboxLabelMenuItem,
									this.toolStripSeparator8,
									this.editCakeboxMenuItem,
									this.deleteCakeboxMenuItem,
									this.toolStripSeparator2,
									this.massMoveDiscsMenuItem});
			this.cakeboxesMenu.Name = "cakeboxesActionsMenu";
			this.cakeboxesMenu.Size = new System.Drawing.Size(135, 104);
			this.cakeboxesMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CakeboxesMenuOpening);
			// 
			// copyCakeboxLabelMenuItem
			// 
			this.copyCakeboxLabelMenuItem.Image = global::Cavebox.Properties.Images.ui_copy;
			this.copyCakeboxLabelMenuItem.Name = "copyCakeboxLabelMenuItem";
			this.copyCakeboxLabelMenuItem.Size = new System.Drawing.Size(152, 22);
			this.copyCakeboxLabelMenuItem.Text = "Copy";
			this.copyCakeboxLabelMenuItem.Click += new System.EventHandler(this.ContextCopyClick);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(131, 6);
			// 
			// editCakeboxMenuItem
			// 
			this.editCakeboxMenuItem.Image = global::Cavebox.Properties.Images.ui_edit;
			this.editCakeboxMenuItem.Name = "editCakeboxMenuItem";
			this.editCakeboxMenuItem.Size = new System.Drawing.Size(152, 22);
			this.editCakeboxMenuItem.Text = "Edit";
			this.editCakeboxMenuItem.Click += new System.EventHandler(this.OpenEditCakeboxForm);
			// 
			// deleteCakeboxMenuItem
			// 
			this.deleteCakeboxMenuItem.Image = global::Cavebox.Properties.Images.ui_delete;
			this.deleteCakeboxMenuItem.Name = "deleteCakeboxMenuItem";
			this.deleteCakeboxMenuItem.Size = new System.Drawing.Size(152, 22);
			this.deleteCakeboxMenuItem.Text = "Delete";
			this.deleteCakeboxMenuItem.Click += new System.EventHandler(this.DeleteCakebox);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
			// 
			// massMoveDiscsMenuItem
			// 
			this.massMoveDiscsMenuItem.Name = "massMoveDiscsMenuItem";
			this.massMoveDiscsMenuItem.Size = new System.Drawing.Size(134, 22);
			this.massMoveDiscsMenuItem.Text = "Mass Move";
			this.massMoveDiscsMenuItem.Click += new System.EventHandler(this.OpenMassMove);
			// 
			// discsGroupBox
			// 
			this.discsGroupBox.Controls.Add(this.discsListBox);
			this.discsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.discsGroupBox.Location = new System.Drawing.Point(0, 0);
			this.discsGroupBox.Name = "discsGroupBox";
			this.discsGroupBox.Size = new System.Drawing.Size(258, 249);
			this.discsGroupBox.TabIndex = 0;
			this.discsGroupBox.TabStop = false;
			this.discsGroupBox.Text = "Discs";
			// 
			// discsListBox
			// 
			this.discsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.discsListBox.ContextMenuStrip = this.discsMenu;
			this.discsListBox.DisplayMember = "Value";
			this.discsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.discsListBox.FormattingEnabled = true;
			this.discsListBox.Location = new System.Drawing.Point(3, 16);
			this.discsListBox.Name = "discsListBox";
			this.discsListBox.Size = new System.Drawing.Size(252, 230);
			this.discsListBox.TabIndex = 0;
			this.discsListBox.ValueMember = "Key";
			this.discsListBox.SelectedValueChanged += new System.EventHandler(this.ShowFiles);
			this.discsListBox.DoubleClick += new System.EventHandler(this.OpenEditDisc);
			this.discsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxMouseDown);
			this.discsListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IdentityMouseMove);
			// 
			// discsMenu
			// 
			this.discsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyDiscLabelMenuItem,
									this.toolStripSeparator9,
									this.editDiscMenuItem,
									this.deleteDiscMenuItem,
									this.toolStripSeparator3,
									this.DiscsOrderMenu});
			this.discsMenu.Name = "discsActionsMenu";
			this.discsMenu.Size = new System.Drawing.Size(108, 104);
			this.discsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.DiscsMenuOpening);
			// 
			// copyDiscLabelMenuItem
			// 
			this.copyDiscLabelMenuItem.Image = global::Cavebox.Properties.Images.ui_copy;
			this.copyDiscLabelMenuItem.Name = "copyDiscLabelMenuItem";
			this.copyDiscLabelMenuItem.Size = new System.Drawing.Size(152, 22);
			this.copyDiscLabelMenuItem.Text = "Copy";
			this.copyDiscLabelMenuItem.Click += new System.EventHandler(this.ContextCopyClick);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(149, 6);
			// 
			// editDiscMenuItem
			// 
			this.editDiscMenuItem.Image = global::Cavebox.Properties.Images.ui_edit;
			this.editDiscMenuItem.Name = "editDiscMenuItem";
			this.editDiscMenuItem.Size = new System.Drawing.Size(152, 22);
			this.editDiscMenuItem.Text = "Edit";
			this.editDiscMenuItem.Click += new System.EventHandler(this.OpenEditDisc);
			// 
			// deleteDiscMenuItem
			// 
			this.deleteDiscMenuItem.Image = global::Cavebox.Properties.Images.ui_delete;
			this.deleteDiscMenuItem.Name = "deleteDiscMenuItem";
			this.deleteDiscMenuItem.Size = new System.Drawing.Size(152, 22);
			this.deleteDiscMenuItem.Text = "Delete";
			this.deleteDiscMenuItem.Click += new System.EventHandler(this.DeleteDisc);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
			// 
			// DiscsOrderMenu
			// 
			this.DiscsOrderMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.DiscsOrderByIdMenuItem,
									this.DiscsOrderByLabelMenuItem,
									this.DiscsOrderByFilesNoMenuItem,
									this.toolStripSeparator4,
									this.DiscsOrderAscMenuItem,
									this.DiscsOrderDescMenuItem});
			this.DiscsOrderMenu.Image = global::Cavebox.Properties.Images.ui_sort;
			this.DiscsOrderMenu.Name = "DiscsOrderMenu";
			this.DiscsOrderMenu.Size = new System.Drawing.Size(152, 22);
			this.DiscsOrderMenu.Text = "Sort";
			// 
			// DiscsOrderByIdMenuItem
			// 
			this.DiscsOrderByIdMenuItem.Name = "DiscsOrderByIdMenuItem";
			this.DiscsOrderByIdMenuItem.Size = new System.Drawing.Size(136, 22);
			this.DiscsOrderByIdMenuItem.Tag = "0";
			this.DiscsOrderByIdMenuItem.Text = "Id";
			this.DiscsOrderByIdMenuItem.Click += new System.EventHandler(this.DiscsOrderBy);
			// 
			// DiscsOrderByLabelMenuItem
			// 
			this.DiscsOrderByLabelMenuItem.Checked = true;
			this.DiscsOrderByLabelMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.DiscsOrderByLabelMenuItem.Name = "DiscsOrderByLabelMenuItem";
			this.DiscsOrderByLabelMenuItem.Size = new System.Drawing.Size(136, 22);
			this.DiscsOrderByLabelMenuItem.Tag = "1";
			this.DiscsOrderByLabelMenuItem.Text = "Label";
			this.DiscsOrderByLabelMenuItem.Click += new System.EventHandler(this.DiscsOrderBy);
			// 
			// DiscsOrderByFilesNoMenuItem
			// 
			this.DiscsOrderByFilesNoMenuItem.Name = "DiscsOrderByFilesNoMenuItem";
			this.DiscsOrderByFilesNoMenuItem.Size = new System.Drawing.Size(136, 22);
			this.DiscsOrderByFilesNoMenuItem.Tag = "2";
			this.DiscsOrderByFilesNoMenuItem.Text = "No. Files";
			this.DiscsOrderByFilesNoMenuItem.Click += new System.EventHandler(this.DiscsOrderBy);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(133, 6);
			// 
			// DiscsOrderAscMenuItem
			// 
			this.DiscsOrderAscMenuItem.Checked = true;
			this.DiscsOrderAscMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.DiscsOrderAscMenuItem.Name = "DiscsOrderAscMenuItem";
			this.DiscsOrderAscMenuItem.Size = new System.Drawing.Size(136, 22);
			this.DiscsOrderAscMenuItem.Tag = "0";
			this.DiscsOrderAscMenuItem.Text = "Ascending";
			this.DiscsOrderAscMenuItem.Click += new System.EventHandler(this.DiscsOrderWay);
			// 
			// DiscsOrderDescMenuItem
			// 
			this.DiscsOrderDescMenuItem.Name = "DiscsOrderDescMenuItem";
			this.DiscsOrderDescMenuItem.Size = new System.Drawing.Size(136, 22);
			this.DiscsOrderDescMenuItem.Tag = "1";
			this.DiscsOrderDescMenuItem.Text = "Descending";
			this.DiscsOrderDescMenuItem.Click += new System.EventHandler(this.DiscsOrderWay);
			// 
			// filterGroupBox
			// 
			this.filterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.filterGroupBox.Controls.Add(this.clearFilterButton);
			this.filterGroupBox.Controls.Add(this.filterTextBox);
			this.filterGroupBox.Location = new System.Drawing.Point(0, 0);
			this.filterGroupBox.Name = "filterGroupBox";
			this.filterGroupBox.Size = new System.Drawing.Size(520, 55);
			this.filterGroupBox.TabIndex = 0;
			this.filterGroupBox.TabStop = false;
			this.filterGroupBox.Text = "Filter";
			// 
			// clearFilterButton
			// 
			this.clearFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clearFilterButton.Enabled = false;
			this.clearFilterButton.Image = global::Cavebox.Properties.Images.ui_delete;
			this.clearFilterButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.clearFilterButton.Location = new System.Drawing.Point(464, 20);
			this.clearFilterButton.Name = "clearFilterButton";
			this.clearFilterButton.Size = new System.Drawing.Size(50, 21);
			this.clearFilterButton.TabIndex = 0;
			this.toolTip.SetToolTip(this.clearFilterButton, "Clear Filter");
			this.clearFilterButton.Click += new System.EventHandler(this.FilterOff);
			// 
			// filterTextBox
			// 
			this.filterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.filterTextBox.Location = new System.Drawing.Point(7, 20);
			this.filterTextBox.Name = "filterTextBox";
			this.filterTextBox.Size = new System.Drawing.Size(451, 20);
			this.filterTextBox.TabIndex = 0;
			this.filterTextBox.TextChanged += new System.EventHandler(this.FilterTextBoxTextChanged);
			// 
			// fileListGroupBox
			// 
			this.fileListGroupBox.Controls.Add(this.fileList);
			this.fileListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileListGroupBox.Location = new System.Drawing.Point(0, 0);
			this.fileListGroupBox.Name = "fileListGroupBox";
			this.fileListGroupBox.Size = new System.Drawing.Size(520, 168);
			this.fileListGroupBox.TabIndex = 0;
			this.fileListGroupBox.TabStop = false;
			this.fileListGroupBox.Text = "Files";
			// 
			// fileList
			// 
			this.fileList.BackColor = System.Drawing.SystemColors.Window;
			this.fileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fileList.ContextMenuStrip = this.filesListMenu;
			this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileList.Location = new System.Drawing.Point(3, 16);
			this.fileList.Name = "fileList";
			this.fileList.ReadOnly = true;
			this.fileList.Size = new System.Drawing.Size(514, 149);
			this.fileList.TabIndex = 0;
			this.fileList.Text = "";
			this.fileList.WordWrap = false;
			// 
			// filesListMenu
			// 
			this.filesListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyFileListMenuItem,
									this.toolStripSeparator5,
									this.googleMenuItem,
									this.wikipediaMenuItem,
									this.anidbMenuItem,
									this.imdbMenuItem,
									this.lastfmMenuItem,
									this.youtubeMenuItem,
									this.metacriticMenuItem,
									this.tvcomMenuItem});
			this.filesListMenu.Name = "filesListActionMenu";
			this.filesListMenu.Size = new System.Drawing.Size(128, 208);
			this.filesListMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FilesListMenuOpening);
			// 
			// copyFileListMenuItem
			// 
			this.copyFileListMenuItem.Image = global::Cavebox.Properties.Images.ui_copy;
			this.copyFileListMenuItem.Name = "copyFileListMenuItem";
			this.copyFileListMenuItem.Size = new System.Drawing.Size(127, 22);
			this.copyFileListMenuItem.Text = "Copy";
			this.copyFileListMenuItem.Click += new System.EventHandler(this.ContextCopyClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(124, 6);
			// 
			// googleMenuItem
			// 
			this.googleMenuItem.Image = global::Cavebox.Properties.Images.google;
			this.googleMenuItem.Name = "googleMenuItem";
			this.googleMenuItem.Size = new System.Drawing.Size(127, 22);
			this.googleMenuItem.Tag = "http://www.google.com/search?site=&q={0}";
			this.googleMenuItem.Text = "Google";
			this.googleMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// wikipediaMenuItem
			// 
			this.wikipediaMenuItem.Image = global::Cavebox.Properties.Images.wikipedia;
			this.wikipediaMenuItem.Name = "wikipediaMenuItem";
			this.wikipediaMenuItem.Size = new System.Drawing.Size(127, 22);
			this.wikipediaMenuItem.Tag = "http://en.wikipedia.org/wiki/Special:Search?search={0}";
			this.wikipediaMenuItem.Text = "Wikipedia";
			this.wikipediaMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// anidbMenuItem
			// 
			this.anidbMenuItem.Image = global::Cavebox.Properties.Images.anidb;
			this.anidbMenuItem.Name = "anidbMenuItem";
			this.anidbMenuItem.Size = new System.Drawing.Size(127, 22);
			this.anidbMenuItem.Tag = "http://anidb.net/perl-bin/animedb.pl?show=animelist&do.search=search&adb.search={" +
			"0}";
			this.anidbMenuItem.Text = "Anidb";
			this.anidbMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// imdbMenuItem
			// 
			this.imdbMenuItem.Image = global::Cavebox.Properties.Images.imdb;
			this.imdbMenuItem.Name = "imdbMenuItem";
			this.imdbMenuItem.Size = new System.Drawing.Size(127, 22);
			this.imdbMenuItem.Tag = "http://www.imdb.com/find?s=all&q={0}";
			this.imdbMenuItem.Text = "Imdb";
			this.imdbMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// lastfmMenuItem
			// 
			this.lastfmMenuItem.Image = global::Cavebox.Properties.Images.lastFM;
			this.lastfmMenuItem.Name = "lastfmMenuItem";
			this.lastfmMenuItem.Size = new System.Drawing.Size(127, 22);
			this.lastfmMenuItem.Tag = "http://www.last.fm/music/{0}";
			this.lastfmMenuItem.Text = "Last.fm";
			this.lastfmMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// youtubeMenuItem
			// 
			this.youtubeMenuItem.Image = global::Cavebox.Properties.Images.youtube;
			this.youtubeMenuItem.Name = "youtubeMenuItem";
			this.youtubeMenuItem.Size = new System.Drawing.Size(127, 22);
			this.youtubeMenuItem.Tag = "http://www.youtube.com/results?search_query={0}";
			this.youtubeMenuItem.Text = "Youtube";
			this.youtubeMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// metacriticMenuItem
			// 
			this.metacriticMenuItem.Image = global::Cavebox.Properties.Images.metacritic;
			this.metacriticMenuItem.Name = "metacriticMenuItem";
			this.metacriticMenuItem.Size = new System.Drawing.Size(127, 22);
			this.metacriticMenuItem.Tag = "http://www.metacritic.com/search/all/{0}/results";
			this.metacriticMenuItem.Text = "Metacritic";
			this.metacriticMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// tvcomMenuItem
			// 
			this.tvcomMenuItem.Image = global::Cavebox.Properties.Images.tvcom;
			this.tvcomMenuItem.Name = "tvcomMenuItem";
			this.tvcomMenuItem.Size = new System.Drawing.Size(127, 22);
			this.tvcomMenuItem.Tag = "http://www.tv.com/search?q={0}";
			this.tvcomMenuItem.Text = "Tv.com";
			this.tvcomMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileMenuItem,
									this.viewMenuItem,
									this.toolsMenuItem,
									this.helpMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(534, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip";
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newCakeboxMenuItem,
									this.importMenuItem,
									this.exportMenuItem,
									this.toolStripSeparator1,
									this.exitMenuItem});
			this.fileMenuItem.Name = "fileMenuItem";
			this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileMenuItem.Text = "File";
			// 
			// newCakeboxMenuItem
			// 
			this.newCakeboxMenuItem.Image = global::Cavebox.Properties.Images.ui_add;
			this.newCakeboxMenuItem.Name = "newCakeboxMenuItem";
			this.newCakeboxMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newCakeboxMenuItem.Size = new System.Drawing.Size(189, 22);
			this.newCakeboxMenuItem.Text = "New Cakebox";
			this.newCakeboxMenuItem.Click += new System.EventHandler(this.OpenAddCakeboxForm);
			// 
			// importMenuItem
			// 
			this.importMenuItem.Image = global::Cavebox.Properties.Images.ui_import;
			this.importMenuItem.Name = "importMenuItem";
			this.importMenuItem.Size = new System.Drawing.Size(189, 22);
			this.importMenuItem.Text = "Import Data";
			this.importMenuItem.Click += new System.EventHandler(this.ImportXml);
			// 
			// exportMenuItem
			// 
			this.exportMenuItem.Image = global::Cavebox.Properties.Images.ui_export;
			this.exportMenuItem.Name = "exportMenuItem";
			this.exportMenuItem.Size = new System.Drawing.Size(189, 22);
			this.exportMenuItem.Text = "Export Data";
			this.exportMenuItem.Click += new System.EventHandler(this.ExportXml);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitMenuItem.Size = new System.Drawing.Size(189, 22);
			this.exitMenuItem.Text = "Exit";
			this.exitMenuItem.Click += new System.EventHandler(this.ExitApplication);
			// 
			// viewMenuItem
			// 
			this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.alwaysOnTopMenuItem,
									this.resetWindowMenuItem});
			this.viewMenuItem.Name = "viewMenuItem";
			this.viewMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewMenuItem.Text = "View";
			// 
			// alwaysOnTopMenuItem
			// 
			this.alwaysOnTopMenuItem.Name = "alwaysOnTopMenuItem";
			this.alwaysOnTopMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.alwaysOnTopMenuItem.Size = new System.Drawing.Size(193, 22);
			this.alwaysOnTopMenuItem.Text = "Always on Top";
			this.alwaysOnTopMenuItem.Click += new System.EventHandler(this.ToggleAlwaysOnTop);
			// 
			// resetWindowMenuItem
			// 
			this.resetWindowMenuItem.Name = "resetWindowMenuItem";
			this.resetWindowMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.resetWindowMenuItem.Size = new System.Drawing.Size(193, 22);
			this.resetWindowMenuItem.Text = "Reset Window";
			this.resetWindowMenuItem.Click += new System.EventHandler(this.ResetWindow);
			// 
			// toolsMenuItem
			// 
			this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.rebuildTotalFilesMenuItem,
									this.vacuumDatabaseMenuItem,
									this.dropDataMenuItem});
			this.toolsMenuItem.Name = "toolsMenuItem";
			this.toolsMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsMenuItem.Text = "Tools";
			// 
			// rebuildTotalFilesMenuItem
			// 
			this.rebuildTotalFilesMenuItem.Name = "rebuildTotalFilesMenuItem";
			this.rebuildTotalFilesMenuItem.Size = new System.Drawing.Size(170, 22);
			this.rebuildTotalFilesMenuItem.Text = "Rebuild Total Files";
			this.rebuildTotalFilesMenuItem.Click += new System.EventHandler(this.RebuildFileCounters);
			// 
			// vacuumDatabaseMenuItem
			// 
			this.vacuumDatabaseMenuItem.Name = "vacuumDatabaseMenuItem";
			this.vacuumDatabaseMenuItem.Size = new System.Drawing.Size(170, 22);
			this.vacuumDatabaseMenuItem.Text = "Vacuum Database";
			this.vacuumDatabaseMenuItem.ToolTipText = "Rebuild the entire database";
			this.vacuumDatabaseMenuItem.Click += new System.EventHandler(this.VacuumTables);
			// 
			// dropDataMenuItem
			// 
			this.dropDataMenuItem.Name = "dropDataMenuItem";
			this.dropDataMenuItem.Size = new System.Drawing.Size(170, 22);
			this.dropDataMenuItem.Text = "Drop Data";
			this.dropDataMenuItem.Click += new System.EventHandler(this.DropData);
			// 
			// helpMenuItem
			// 
			this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.changelogMenuItem});
			this.helpMenuItem.Name = "helpMenuItem";
			this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpMenuItem.Text = "Help";
			// 
			// changelogMenuItem
			// 
			this.changelogMenuItem.Name = "changelogMenuItem";
			this.changelogMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.changelogMenuItem.Size = new System.Drawing.Size(152, 22);
			this.changelogMenuItem.Text = "Changelog";
			this.changelogMenuItem.Click += new System.EventHandler(this.OpenChangelog);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cakeboxStatsLabel,
									this.discStatsLabel,
									this.fileStatsLabel,
									this.discAddedLabel,
									this.discAddedValueLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 538);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(534, 24);
			this.statusStrip.TabIndex = 3;
			this.statusStrip.Text = "statusStrip1";
			// 
			// cakeboxStatsLabel
			// 
			this.cakeboxStatsLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.cakeboxStatsLabel.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
			this.cakeboxStatsLabel.Name = "cakeboxStatsLabel";
			this.cakeboxStatsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
			this.cakeboxStatsLabel.Size = new System.Drawing.Size(72, 19);
			this.cakeboxStatsLabel.Text = "Cakeboxes";
			// 
			// discStatsLabel
			// 
			this.discStatsLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.discStatsLabel.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
			this.discStatsLabel.Name = "discStatsLabel";
			this.discStatsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
			this.discStatsLabel.Size = new System.Drawing.Size(43, 19);
			this.discStatsLabel.Text = "Discs";
			// 
			// fileStatsLabel
			// 
			this.fileStatsLabel.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
			this.fileStatsLabel.Name = "fileStatsLabel";
			this.fileStatsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
			this.fileStatsLabel.Size = new System.Drawing.Size(35, 19);
			this.fileStatsLabel.Text = "Files";
			// 
			// discAddedLabel
			// 
			this.discAddedLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.discAddedLabel.Margin = new System.Windows.Forms.Padding(0, 3, -5, 2);
			this.discAddedLabel.Name = "discAddedLabel";
			this.discAddedLabel.Size = new System.Drawing.Size(66, 19);
			this.discAddedLabel.Text = "Added on:";
			this.discAddedLabel.Visible = false;
			// 
			// discAddedValueLabel
			// 
			this.discAddedValueLabel.Name = "discAddedValueLabel";
			this.discAddedValueLabel.Size = new System.Drawing.Size(12, 19);
			this.discAddedValueLabel.Text = "-";
			this.discAddedValueLabel.Visible = false;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.mainTabPage);
			this.tabControl.Controls.Add(this.scanTabPage);
			this.tabControl.Controls.Add(this.consoleTabPage);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(534, 514);
			this.tabControl.TabIndex = 4;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
			// 
			// mainTabPage
			// 
			this.mainTabPage.BackColor = System.Drawing.SystemColors.Control;
			this.mainTabPage.Controls.Add(this.FileListSplitContainer);
			this.mainTabPage.Location = new System.Drawing.Point(4, 22);
			this.mainTabPage.Name = "mainTabPage";
			this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.mainTabPage.Size = new System.Drawing.Size(526, 488);
			this.mainTabPage.TabIndex = 0;
			this.mainTabPage.Text = "Main";
			// 
			// scanTabPage
			// 
			this.scanTabPage.Controls.Add(this.saveNewDiscGroupBox);
			this.scanTabPage.Controls.Add(this.scanFileListGroupBox);
			this.scanTabPage.Controls.Add(this.scanPathGroupBox);
			this.scanTabPage.Location = new System.Drawing.Point(4, 22);
			this.scanTabPage.Name = "scanTabPage";
			this.scanTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.scanTabPage.Size = new System.Drawing.Size(526, 488);
			this.scanTabPage.TabIndex = 1;
			this.scanTabPage.Text = "Scan";
			// 
			// saveNewDiscGroupBox
			// 
			this.saveNewDiscGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.saveNewDiscGroupBox.Controls.Add(this.newDiscCakebox);
			this.saveNewDiscGroupBox.Controls.Add(this.saveNewDiscButton);
			this.saveNewDiscGroupBox.Controls.Add(this.newDiscLabelTextBox);
			this.saveNewDiscGroupBox.Controls.Add(this.newDiscCakeboxLabel);
			this.saveNewDiscGroupBox.Controls.Add(this.newDiscLabelLabel);
			this.saveNewDiscGroupBox.Location = new System.Drawing.Point(3, 409);
			this.saveNewDiscGroupBox.Name = "saveNewDiscGroupBox";
			this.saveNewDiscGroupBox.Size = new System.Drawing.Size(520, 76);
			this.saveNewDiscGroupBox.TabIndex = 2;
			this.saveNewDiscGroupBox.TabStop = false;
			this.saveNewDiscGroupBox.Text = "Save";
			// 
			// newDiscCakebox
			// 
			this.newDiscCakebox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.newDiscCakebox.DisplayMember = "Value";
			this.newDiscCakebox.DropDownHeight = 150;
			this.newDiscCakebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.newDiscCakebox.FormattingEnabled = true;
			this.newDiscCakebox.IntegralHeight = false;
			this.newDiscCakebox.Location = new System.Drawing.Point(66, 47);
			this.newDiscCakebox.Name = "newDiscCakebox";
			this.newDiscCakebox.Size = new System.Drawing.Size(392, 21);
			this.newDiscCakebox.TabIndex = 0;
			this.newDiscCakebox.ValueMember = "Key";
			// 
			// saveNewDiscButton
			// 
			this.saveNewDiscButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveNewDiscButton.Enabled = false;
			this.saveNewDiscButton.Image = global::Cavebox.Properties.Images.ui_save;
			this.saveNewDiscButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.saveNewDiscButton.Location = new System.Drawing.Point(464, 19);
			this.saveNewDiscButton.Name = "saveNewDiscButton";
			this.saveNewDiscButton.Size = new System.Drawing.Size(50, 50);
			this.saveNewDiscButton.TabIndex = 0;
			this.toolTip.SetToolTip(this.saveNewDiscButton, "Add new Disc");
			this.saveNewDiscButton.Click += new System.EventHandler(this.SaveNewDisc);
			// 
			// newDiscLabelTextBox
			// 
			this.newDiscLabelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.newDiscLabelTextBox.Enabled = false;
			this.newDiscLabelTextBox.Location = new System.Drawing.Point(66, 20);
			this.newDiscLabelTextBox.Name = "newDiscLabelTextBox";
			this.newDiscLabelTextBox.Size = new System.Drawing.Size(392, 20);
			this.newDiscLabelTextBox.TabIndex = 0;
			// 
			// newDiscCakeboxLabel
			// 
			this.newDiscCakeboxLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.newDiscCakeboxLabel.Location = new System.Drawing.Point(4, 50);
			this.newDiscCakeboxLabel.Name = "newDiscCakeboxLabel";
			this.newDiscCakeboxLabel.Size = new System.Drawing.Size(56, 21);
			this.newDiscCakeboxLabel.TabIndex = 0;
			this.newDiscCakeboxLabel.Text = "Cakebox:";
			// 
			// newDiscLabelLabel
			// 
			this.newDiscLabelLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.newDiscLabelLabel.Location = new System.Drawing.Point(4, 23);
			this.newDiscLabelLabel.Name = "newDiscLabelLabel";
			this.newDiscLabelLabel.Size = new System.Drawing.Size(55, 20);
			this.newDiscLabelLabel.TabIndex = 0;
			this.newDiscLabelLabel.Text = "Label:";
			// 
			// scanFileListGroupBox
			// 
			this.scanFileListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.scanFileListGroupBox.Controls.Add(this.scanFileList);
			this.scanFileListGroupBox.Location = new System.Drawing.Point(3, 64);
			this.scanFileListGroupBox.Name = "scanFileListGroupBox";
			this.scanFileListGroupBox.Size = new System.Drawing.Size(520, 339);
			this.scanFileListGroupBox.TabIndex = 1;
			this.scanFileListGroupBox.TabStop = false;
			this.scanFileListGroupBox.Text = "File List";
			// 
			// scanFileList
			// 
			this.scanFileList.BackColor = System.Drawing.SystemColors.Window;
			this.scanFileList.ContextMenuStrip = this.scanFileListMenu;
			this.scanFileList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scanFileList.Location = new System.Drawing.Point(3, 16);
			this.scanFileList.Name = "scanFileList";
			this.scanFileList.ReadOnly = true;
			this.scanFileList.Size = new System.Drawing.Size(514, 320);
			this.scanFileList.TabIndex = 0;
			this.scanFileList.Text = "";
			this.scanFileList.WordWrap = false;
			// 
			// scanFileListMenu
			// 
			this.scanFileListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyScanFileListMenuItem,
									this.toolStripSeparator7,
									this.resetScanMenuItem});
			this.scanFileListMenu.Name = "scanLogActionsMenu";
			this.scanFileListMenu.Size = new System.Drawing.Size(153, 76);
			this.scanFileListMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ScanLogMenuOpening);
			// 
			// copyScanFileListMenuItem
			// 
			this.copyScanFileListMenuItem.Image = global::Cavebox.Properties.Images.ui_copy;
			this.copyScanFileListMenuItem.Name = "copyScanFileListMenuItem";
			this.copyScanFileListMenuItem.Size = new System.Drawing.Size(152, 22);
			this.copyScanFileListMenuItem.Text = "Copy";
			this.copyScanFileListMenuItem.Click += new System.EventHandler(this.ContextCopyClick);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(99, 6);
			// 
			// resetScanMenuItem
			// 
			this.resetScanMenuItem.Name = "resetScanMenuItem";
			this.resetScanMenuItem.Size = new System.Drawing.Size(102, 22);
			this.resetScanMenuItem.Text = "Reset";
			this.resetScanMenuItem.Click += new System.EventHandler(this.ScanWorkerReset);
			// 
			// scanPathGroupBox
			// 
			this.scanPathGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.scanPathGroupBox.Controls.Add(this.scanPathComboBox);
			this.scanPathGroupBox.Controls.Add(this.browseScanPathButton);
			this.scanPathGroupBox.Controls.Add(this.toggleScanPathButton);
			this.scanPathGroupBox.Location = new System.Drawing.Point(3, 3);
			this.scanPathGroupBox.Name = "scanPathGroupBox";
			this.scanPathGroupBox.Size = new System.Drawing.Size(520, 55);
			this.scanPathGroupBox.TabIndex = 0;
			this.scanPathGroupBox.TabStop = false;
			this.scanPathGroupBox.Text = "Scan Path";
			// 
			// scanPathComboBox
			// 
			this.scanPathComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.scanPathComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.scanPathComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.scanPathComboBox.Location = new System.Drawing.Point(7, 20);
			this.scanPathComboBox.Name = "scanPathComboBox";
			this.scanPathComboBox.Size = new System.Drawing.Size(419, 21);
			this.scanPathComboBox.TabIndex = 0;
			// 
			// browseScanPathButton
			// 
			this.browseScanPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.browseScanPathButton.Location = new System.Drawing.Point(432, 20);
			this.browseScanPathButton.Name = "browseScanPathButton";
			this.browseScanPathButton.Size = new System.Drawing.Size(26, 21);
			this.browseScanPathButton.TabIndex = 0;
			this.browseScanPathButton.Text = "...";
			this.toolTip.SetToolTip(this.browseScanPathButton, "Browse Folder");
			this.browseScanPathButton.Click += new System.EventHandler(this.BrowseScanPath);
			// 
			// toggleScanPathButton
			// 
			this.toggleScanPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.toggleScanPathButton.Image = global::Cavebox.Properties.Images.ui_play;
			this.toggleScanPathButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.toggleScanPathButton.Location = new System.Drawing.Point(464, 20);
			this.toggleScanPathButton.Name = "toggleScanPathButton";
			this.toggleScanPathButton.Size = new System.Drawing.Size(50, 21);
			this.toggleScanPathButton.TabIndex = 0;
			this.toolTip.SetToolTip(this.toggleScanPathButton, "Start/Stop Scan");
			this.toggleScanPathButton.Click += new System.EventHandler(this.ScanWorkerToggle);
			// 
			// consoleTabPage
			// 
			this.consoleTabPage.Controls.Add(this.consoleGroupBox);
			this.consoleTabPage.Location = new System.Drawing.Point(4, 22);
			this.consoleTabPage.Name = "consoleTabPage";
			this.consoleTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.consoleTabPage.Size = new System.Drawing.Size(526, 488);
			this.consoleTabPage.TabIndex = 2;
			this.consoleTabPage.Text = "Console";
			// 
			// consoleGroupBox
			// 
			this.consoleGroupBox.Controls.Add(this.console);
			this.consoleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleGroupBox.Location = new System.Drawing.Point(3, 3);
			this.consoleGroupBox.Name = "consoleGroupBox";
			this.consoleGroupBox.Size = new System.Drawing.Size(520, 482);
			this.consoleGroupBox.TabIndex = 0;
			this.consoleGroupBox.TabStop = false;
			this.consoleGroupBox.Text = "Console";
			// 
			// console
			// 
			this.console.BackColor = System.Drawing.SystemColors.Window;
			this.console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.console.ContextMenuStrip = this.consoleMenu;
			this.console.Dock = System.Windows.Forms.DockStyle.Fill;
			this.console.Location = new System.Drawing.Point(3, 16);
			this.console.Name = "console";
			this.console.ReadOnly = true;
			this.console.Size = new System.Drawing.Size(514, 463);
			this.console.TabIndex = 0;
			this.console.Text = "";
			this.console.WordWrap = false;
			// 
			// consoleMenu
			// 
			this.consoleMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyConsoleMenuItem,
									this.toolStripSeparator6,
									this.clearToolStripMenuItem});
			this.consoleMenu.Name = "consoleActionsMenu";
			this.consoleMenu.Size = new System.Drawing.Size(103, 54);
			this.consoleMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ConsoleMenuOpening);
			// 
			// copyConsoleMenuItem
			// 
			this.copyConsoleMenuItem.Image = global::Cavebox.Properties.Images.ui_copy;
			this.copyConsoleMenuItem.Name = "copyConsoleMenuItem";
			this.copyConsoleMenuItem.Size = new System.Drawing.Size(102, 22);
			this.copyConsoleMenuItem.Text = "Copy";
			this.copyConsoleMenuItem.Click += new System.EventHandler(this.ContextCopyClick);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(99, 6);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearConsole);
			// 
			// scanWorker
			// 
			this.scanWorker.WorkerSupportsCancellation = true;
			this.scanWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ScanWorkerDoWork);
			this.scanWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ScanWorkerCompleted);
			// 
			// filterTextChangedTimer
			// 
			this.filterTextChangedTimer.Interval = 250;
			this.filterTextChangedTimer.Tick += new System.EventHandler(this.Filter);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 562);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = global::Cavebox.Properties.Images.app;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "Main";
			this.Text = "Cavebox 2.1.2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.FileListSplitContainer.Panel1.ResumeLayout(false);
			this.FileListSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FileListSplitContainer)).EndInit();
			this.FileListSplitContainer.ResumeLayout(false);
			this.cakeboxDiscSplitContainer.Panel1.ResumeLayout(false);
			this.cakeboxDiscSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cakeboxDiscSplitContainer)).EndInit();
			this.cakeboxDiscSplitContainer.ResumeLayout(false);
			this.cakeboxesGroupBox.ResumeLayout(false);
			this.cakeboxesMenu.ResumeLayout(false);
			this.discsGroupBox.ResumeLayout(false);
			this.discsMenu.ResumeLayout(false);
			this.filterGroupBox.ResumeLayout(false);
			this.filterGroupBox.PerformLayout();
			this.fileListGroupBox.ResumeLayout(false);
			this.filesListMenu.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.mainTabPage.ResumeLayout(false);
			this.scanTabPage.ResumeLayout(false);
			this.saveNewDiscGroupBox.ResumeLayout(false);
			this.saveNewDiscGroupBox.PerformLayout();
			this.scanFileListGroupBox.ResumeLayout(false);
			this.scanFileListMenu.ResumeLayout(false);
			this.scanPathGroupBox.ResumeLayout(false);
			this.consoleTabPage.ResumeLayout(false);
			this.consoleGroupBox.ResumeLayout(false);
			this.consoleMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox cakeboxesGroupBox;
		public System.Windows.Forms.ListBox cakeboxesListBox;
		private System.Windows.Forms.GroupBox discsGroupBox;
		public System.Windows.Forms.ListBox discsListBox;
		private System.Windows.Forms.Button clearFilterButton;
		private System.Windows.Forms.TextBox filterTextBox;
		private System.Windows.Forms.GroupBox fileListGroupBox;
		private System.Windows.Forms.RichTextBox fileList;
		private System.Windows.Forms.Label newDiscLabelLabel;
		private System.Windows.Forms.GroupBox scanFileListGroupBox;
		private System.Windows.Forms.RichTextBox scanFileList;
		private System.Windows.Forms.ComboBox scanPathComboBox;
		private System.Windows.Forms.Button toggleScanPathButton;
		private System.Windows.Forms.Button browseScanPathButton;
		private System.Windows.Forms.ToolStripMenuItem tvcomMenuItem;
		private System.Windows.Forms.ToolStripMenuItem metacriticMenuItem;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem copyDiscLabelMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem copyCakeboxLabelMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem copyScanFileListMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem copyConsoleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dropDataMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetWindowMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vacuumDatabaseMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.Timer filterTextChangedTimer;
		private System.Windows.Forms.RichTextBox console;
		private System.ComponentModel.BackgroundWorker scanWorker;
		private System.Windows.Forms.ToolStripStatusLabel discAddedValueLabel;
		private System.Windows.Forms.ToolStripStatusLabel discAddedLabel;
		private System.Windows.Forms.ToolStripMenuItem resetScanMenuItem;
		private System.Windows.Forms.ContextMenuStrip scanFileListMenu;
		private System.Windows.Forms.ToolStripMenuItem youtubeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lastfmMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imdbMenuItem;
		private System.Windows.Forms.ToolStripMenuItem anidbMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wikipediaMenuItem;
		private System.Windows.Forms.ToolStripMenuItem googleMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem copyFileListMenuItem;
		private System.Windows.Forms.ContextMenuStrip filesListMenu;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip consoleMenu;
		private System.Windows.Forms.ToolStripMenuItem DiscsOrderDescMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DiscsOrderAscMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem DiscsOrderByFilesNoMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DiscsOrderByLabelMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DiscsOrderByIdMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DiscsOrderMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem deleteDiscMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editDiscMenuItem;
		private System.Windows.Forms.ContextMenuStrip discsMenu;
		private System.Windows.Forms.ToolStripMenuItem massMoveDiscsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem deleteCakeboxMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editCakeboxMenuItem;
		private System.Windows.Forms.ContextMenuStrip cakeboxesMenu;
		private System.Windows.Forms.ToolStripStatusLabel fileStatsLabel;
		private System.Windows.Forms.ToolStripStatusLabel discStatsLabel;
		private System.Windows.Forms.ToolStripStatusLabel cakeboxStatsLabel;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripMenuItem changelogMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rebuildTotalFilesMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exportMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newCakeboxMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.GroupBox consoleGroupBox;
		private System.Windows.Forms.TabPage consoleTabPage;
		private System.Windows.Forms.GroupBox scanPathGroupBox;
		private System.Windows.Forms.Label newDiscCakeboxLabel;
		private System.Windows.Forms.TextBox newDiscLabelTextBox;
		private System.Windows.Forms.Button saveNewDiscButton;
		public System.Windows.Forms.ComboBox newDiscCakebox;
		private System.Windows.Forms.GroupBox saveNewDiscGroupBox;
		private System.Windows.Forms.TabPage scanTabPage;
		private System.Windows.Forms.GroupBox filterGroupBox;
		private System.Windows.Forms.SplitContainer cakeboxDiscSplitContainer;
		private System.Windows.Forms.SplitContainer FileListSplitContainer;
		private System.Windows.Forms.TabPage mainTabPage;
		private System.Windows.Forms.TabControl tabControl;
	}
}
