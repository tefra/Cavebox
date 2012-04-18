/*
 * Created by SharpDevelop.
 * User: Tefra
 * Date: 16/4/2012
 * Time: 8:25 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cakebox_Archive
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.boxDiscSplitContainer = new System.Windows.Forms.SplitContainer();
			this.cakeboxesGroupBox = new System.Windows.Forms.GroupBox();
			this.cakeboxesListBox = new System.Windows.Forms.ListBox();
			this.cakeboxesActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editCakeboxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteCakeboxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.massMoveDiscsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.discsGroupBox = new System.Windows.Forms.GroupBox();
			this.discsListBox = new System.Windows.Forms.ListBox();
			this.discsActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editDiscMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteDiscMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.sortDiscsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortDiscsByIdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortDiscsByLabelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortDiscsByFilesNoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.sortDiscsAscendingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sortDiscsDescendingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filterGroupBox = new System.Windows.Forms.GroupBox();
			this.clearFilterButton = new System.Windows.Forms.Button();
			this.filterTextBox = new System.Windows.Forms.TextBox();
			this.discFilesGroupBox = new System.Windows.Forms.GroupBox();
			this.filesList = new System.Windows.Forms.RichTextBox();
			this.filesListActionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wikipediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.anidbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imdbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lastfmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.newCakeboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.rebuildFileCountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.cakeboxStatsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.discStatsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.fileStatsLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.selectCakeboxToStore = new System.Windows.Forms.ComboBox();
			this.saveNewDiscButton = new System.Windows.Forms.Button();
			this.newDiscLabelTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.scanLog = new System.Windows.Forms.RichTextBox();
			this.scanLogActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scanDriveGroupBox = new System.Windows.Forms.GroupBox();
			this.scanDrive = new System.Windows.Forms.ComboBox();
			this.scanDriveButton = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.console = new System.Windows.Forms.RichTextBox();
			this.consoleActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scanWorker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.boxDiscSplitContainer)).BeginInit();
			this.boxDiscSplitContainer.Panel1.SuspendLayout();
			this.boxDiscSplitContainer.Panel2.SuspendLayout();
			this.boxDiscSplitContainer.SuspendLayout();
			this.cakeboxesGroupBox.SuspendLayout();
			this.cakeboxesActionsMenu.SuspendLayout();
			this.discsGroupBox.SuspendLayout();
			this.discsActionsMenu.SuspendLayout();
			this.filterGroupBox.SuspendLayout();
			this.discFilesGroupBox.SuspendLayout();
			this.filesListActionMenu.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.scanLogActionsMenu.SuspendLayout();
			this.scanDriveGroupBox.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.consoleActionsMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.boxDiscSplitContainer);
			this.splitContainer1.Panel1.Controls.Add(this.filterGroupBox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.discFilesGroupBox);
			// 
			// boxDiscSplitContainer
			// 
			resources.ApplyResources(this.boxDiscSplitContainer, "boxDiscSplitContainer");
			this.boxDiscSplitContainer.Name = "boxDiscSplitContainer";
			// 
			// boxDiscSplitContainer.Panel1
			// 
			this.boxDiscSplitContainer.Panel1.Controls.Add(this.cakeboxesGroupBox);
			// 
			// boxDiscSplitContainer.Panel2
			// 
			this.boxDiscSplitContainer.Panel2.Controls.Add(this.discsGroupBox);
			// 
			// cakeboxesGroupBox
			// 
			this.cakeboxesGroupBox.Controls.Add(this.cakeboxesListBox);
			resources.ApplyResources(this.cakeboxesGroupBox, "cakeboxesGroupBox");
			this.cakeboxesGroupBox.Name = "cakeboxesGroupBox";
			this.cakeboxesGroupBox.TabStop = false;
			// 
			// cakeboxesListBox
			// 
			this.cakeboxesListBox.ContextMenuStrip = this.cakeboxesActionsMenu;
			this.cakeboxesListBox.DisplayMember = "Value";
			resources.ApplyResources(this.cakeboxesListBox, "cakeboxesListBox");
			this.cakeboxesListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cakeboxesListBox.FormattingEnabled = true;
			this.cakeboxesListBox.Name = "cakeboxesListBox";
			this.cakeboxesListBox.ValueMember = "Id";
			this.cakeboxesListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxDrawItem);
			this.cakeboxesListBox.SelectedValueChanged += new System.EventHandler(this.showDiscs);
			this.cakeboxesListBox.DoubleClick += new System.EventHandler(this.openEditCakeboxForm);
			this.cakeboxesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CakeboxesListBoxMouseDown);
			// 
			// cakeboxesActionsMenu
			// 
			this.cakeboxesActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.editCakeboxMenuItem,
									this.deleteCakeboxMenuItem,
									this.toolStripSeparator2,
									this.massMoveDiscsMenuItem});
			this.cakeboxesActionsMenu.Name = "cakeboxesActionsMenu";
			resources.ApplyResources(this.cakeboxesActionsMenu, "cakeboxesActionsMenu");
			this.cakeboxesActionsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CakeboxesActionsMenuOpening);
			// 
			// editCakeboxMenuItem
			// 
			resources.ApplyResources(this.editCakeboxMenuItem, "editCakeboxMenuItem");
			this.editCakeboxMenuItem.Name = "editCakeboxMenuItem";
			this.editCakeboxMenuItem.Click += new System.EventHandler(this.openEditCakeboxForm);
			// 
			// deleteCakeboxMenuItem
			// 
			resources.ApplyResources(this.deleteCakeboxMenuItem, "deleteCakeboxMenuItem");
			this.deleteCakeboxMenuItem.Name = "deleteCakeboxMenuItem";
			this.deleteCakeboxMenuItem.Click += new System.EventHandler(this.deleteCakebox);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			// 
			// massMoveDiscsMenuItem
			// 
			resources.ApplyResources(this.massMoveDiscsMenuItem, "massMoveDiscsMenuItem");
			this.massMoveDiscsMenuItem.Name = "massMoveDiscsMenuItem";
			// 
			// discsGroupBox
			// 
			this.discsGroupBox.Controls.Add(this.discsListBox);
			resources.ApplyResources(this.discsGroupBox, "discsGroupBox");
			this.discsGroupBox.Name = "discsGroupBox";
			this.discsGroupBox.TabStop = false;
			// 
			// discsListBox
			// 
			this.discsListBox.ContextMenuStrip = this.discsActionsMenu;
			this.discsListBox.DisplayMember = "Value";
			resources.ApplyResources(this.discsListBox, "discsListBox");
			this.discsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.discsListBox.FormattingEnabled = true;
			this.discsListBox.Name = "discsListBox";
			this.discsListBox.ValueMember = "Id";
			this.discsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxDrawItem);
			this.discsListBox.SelectedValueChanged += new System.EventHandler(this.showFiles);
			this.discsListBox.DoubleClick += new System.EventHandler(this.openEditDiscForm);
			this.discsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DiscsListBoxMouseDown);
			// 
			// discsActionsMenu
			// 
			this.discsActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.editDiscMenuItem,
									this.deleteDiscMenuItem,
									this.toolStripSeparator3,
									this.sortDiscsMenuItem});
			this.discsActionsMenu.Name = "discsActionsMenu";
			resources.ApplyResources(this.discsActionsMenu, "discsActionsMenu");
			// 
			// editDiscMenuItem
			// 
			resources.ApplyResources(this.editDiscMenuItem, "editDiscMenuItem");
			this.editDiscMenuItem.Name = "editDiscMenuItem";
			this.editDiscMenuItem.Click += new System.EventHandler(this.openEditDiscForm);
			// 
			// deleteDiscMenuItem
			// 
			resources.ApplyResources(this.deleteDiscMenuItem, "deleteDiscMenuItem");
			this.deleteDiscMenuItem.Name = "deleteDiscMenuItem";
			this.deleteDiscMenuItem.Click += new System.EventHandler(this.deleteDisc);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			// 
			// sortDiscsMenuItem
			// 
			this.sortDiscsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.sortDiscsByIdMenuItem,
									this.sortDiscsByLabelMenuItem,
									this.sortDiscsByFilesNoMenuItem,
									this.toolStripSeparator4,
									this.sortDiscsAscendingMenuItem,
									this.sortDiscsDescendingMenuItem});
			resources.ApplyResources(this.sortDiscsMenuItem, "sortDiscsMenuItem");
			this.sortDiscsMenuItem.Name = "sortDiscsMenuItem";
			// 
			// sortDiscsByIdMenuItem
			// 
			this.sortDiscsByIdMenuItem.Name = "sortDiscsByIdMenuItem";
			resources.ApplyResources(this.sortDiscsByIdMenuItem, "sortDiscsByIdMenuItem");
			this.sortDiscsByIdMenuItem.Click += new System.EventHandler(this.sortDiscs);
			// 
			// sortDiscsByLabelMenuItem
			// 
			this.sortDiscsByLabelMenuItem.Checked = true;
			this.sortDiscsByLabelMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.sortDiscsByLabelMenuItem.Name = "sortDiscsByLabelMenuItem";
			resources.ApplyResources(this.sortDiscsByLabelMenuItem, "sortDiscsByLabelMenuItem");
			this.sortDiscsByLabelMenuItem.Click += new System.EventHandler(this.sortDiscs);
			// 
			// sortDiscsByFilesNoMenuItem
			// 
			this.sortDiscsByFilesNoMenuItem.Name = "sortDiscsByFilesNoMenuItem";
			resources.ApplyResources(this.sortDiscsByFilesNoMenuItem, "sortDiscsByFilesNoMenuItem");
			this.sortDiscsByFilesNoMenuItem.Click += new System.EventHandler(this.sortDiscs);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
			// 
			// sortDiscsAscendingMenuItem
			// 
			this.sortDiscsAscendingMenuItem.Checked = true;
			this.sortDiscsAscendingMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.sortDiscsAscendingMenuItem.Name = "sortDiscsAscendingMenuItem";
			resources.ApplyResources(this.sortDiscsAscendingMenuItem, "sortDiscsAscendingMenuItem");
			this.sortDiscsAscendingMenuItem.Click += new System.EventHandler(this.sortDiscs);
			// 
			// sortDiscsDescendingMenuItem
			// 
			this.sortDiscsDescendingMenuItem.Name = "sortDiscsDescendingMenuItem";
			resources.ApplyResources(this.sortDiscsDescendingMenuItem, "sortDiscsDescendingMenuItem");
			this.sortDiscsDescendingMenuItem.Click += new System.EventHandler(this.sortDiscs);
			// 
			// filterGroupBox
			// 
			resources.ApplyResources(this.filterGroupBox, "filterGroupBox");
			this.filterGroupBox.Controls.Add(this.clearFilterButton);
			this.filterGroupBox.Controls.Add(this.filterTextBox);
			this.filterGroupBox.Name = "filterGroupBox";
			this.filterGroupBox.TabStop = false;
			// 
			// clearFilterButton
			// 
			resources.ApplyResources(this.clearFilterButton, "clearFilterButton");
			this.clearFilterButton.Name = "clearFilterButton";
			this.clearFilterButton.UseVisualStyleBackColor = true;
			this.clearFilterButton.Click += new System.EventHandler(this.filterOff);
			// 
			// filterTextBox
			// 
			resources.ApplyResources(this.filterTextBox, "filterTextBox");
			this.filterTextBox.Name = "filterTextBox";
			this.filterTextBox.TextChanged += new System.EventHandler(this.filter);
			// 
			// discFilesGroupBox
			// 
			this.discFilesGroupBox.Controls.Add(this.filesList);
			resources.ApplyResources(this.discFilesGroupBox, "discFilesGroupBox");
			this.discFilesGroupBox.Name = "discFilesGroupBox";
			this.discFilesGroupBox.TabStop = false;
			// 
			// filesList
			// 
			this.filesList.BackColor = System.Drawing.SystemColors.Window;
			this.filesList.ContextMenuStrip = this.filesListActionMenu;
			resources.ApplyResources(this.filesList, "filesList");
			this.filesList.Name = "filesList";
			this.filesList.ReadOnly = true;
			// 
			// filesListActionMenu
			// 
			this.filesListActionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyToolStripMenuItem,
									this.toolStripSeparator5,
									this.googleToolStripMenuItem,
									this.wikipediaToolStripMenuItem,
									this.anidbToolStripMenuItem,
									this.imdbToolStripMenuItem,
									this.lastfmToolStripMenuItem,
									this.youtubeToolStripMenuItem});
			this.filesListActionMenu.Name = "filesListActionMenu";
			resources.ApplyResources(this.filesListActionMenu, "filesListActionMenu");
			this.filesListActionMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FilesListActionMenuOpening);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
			// 
			// googleToolStripMenuItem
			// 
			resources.ApplyResources(this.googleToolStripMenuItem, "googleToolStripMenuItem");
			this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
			this.googleToolStripMenuItem.Click += new System.EventHandler(this.openSearchUrl);
			// 
			// wikipediaToolStripMenuItem
			// 
			resources.ApplyResources(this.wikipediaToolStripMenuItem, "wikipediaToolStripMenuItem");
			this.wikipediaToolStripMenuItem.Name = "wikipediaToolStripMenuItem";
			this.wikipediaToolStripMenuItem.Click += new System.EventHandler(this.openSearchUrl);
			// 
			// anidbToolStripMenuItem
			// 
			resources.ApplyResources(this.anidbToolStripMenuItem, "anidbToolStripMenuItem");
			this.anidbToolStripMenuItem.Name = "anidbToolStripMenuItem";
			this.anidbToolStripMenuItem.Click += new System.EventHandler(this.openSearchUrl);
			// 
			// imdbToolStripMenuItem
			// 
			resources.ApplyResources(this.imdbToolStripMenuItem, "imdbToolStripMenuItem");
			this.imdbToolStripMenuItem.Name = "imdbToolStripMenuItem";
			this.imdbToolStripMenuItem.Click += new System.EventHandler(this.openSearchUrl);
			// 
			// lastfmToolStripMenuItem
			// 
			resources.ApplyResources(this.lastfmToolStripMenuItem, "lastfmToolStripMenuItem");
			this.lastfmToolStripMenuItem.Name = "lastfmToolStripMenuItem";
			this.lastfmToolStripMenuItem.Click += new System.EventHandler(this.openSearchUrl);
			// 
			// youtubeToolStripMenuItem
			// 
			resources.ApplyResources(this.youtubeToolStripMenuItem, "youtubeToolStripMenuItem");
			this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
			this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.openSearchUrl);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem1,
									this.viewToolStripMenuItem,
									this.helpToolStripMenuItem});
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.Name = "menuStrip";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newCakeboxToolStripMenuItem,
									this.importToolStripMenuItem,
									this.exportToolStripMenuItem,
									this.toolStripSeparator1,
									this.rebuildFileCountersToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			// 
			// newCakeboxToolStripMenuItem
			// 
			resources.ApplyResources(this.newCakeboxToolStripMenuItem, "newCakeboxToolStripMenuItem");
			this.newCakeboxToolStripMenuItem.Name = "newCakeboxToolStripMenuItem";
			this.newCakeboxToolStripMenuItem.Click += new System.EventHandler(this.openNewCakeboxForm);
			// 
			// importToolStripMenuItem
			// 
			resources.ApplyResources(this.importToolStripMenuItem, "importToolStripMenuItem");
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Click += new System.EventHandler(this.importXml);
			// 
			// exportToolStripMenuItem
			// 
			resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportXml);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// rebuildFileCountersToolStripMenuItem
			// 
			resources.ApplyResources(this.rebuildFileCountersToolStripMenuItem, "rebuildFileCountersToolStripMenuItem");
			this.rebuildFileCountersToolStripMenuItem.Name = "rebuildFileCountersToolStripMenuItem";
			this.rebuildFileCountersToolStripMenuItem.Click += new System.EventHandler(this.rebuildFileCounters);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.alwaysOnTopToolStripMenuItem,
									this.resetWindowToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			resources.ApplyResources(this.alwaysOnTopToolStripMenuItem, "alwaysOnTopToolStripMenuItem");
			// 
			// resetWindowToolStripMenuItem
			// 
			this.resetWindowToolStripMenuItem.Name = "resetWindowToolStripMenuItem";
			resources.ApplyResources(this.resetWindowToolStripMenuItem, "resetWindowToolStripMenuItem");
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.changelogToolStripMenuItem,
									this.sQLiteToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// changelogToolStripMenuItem
			// 
			this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
			resources.ApplyResources(this.changelogToolStripMenuItem, "changelogToolStripMenuItem");
			this.changelogToolStripMenuItem.Click += new System.EventHandler(this.ChangelogToolStripMenuItemClick);
			// 
			// sQLiteToolStripMenuItem
			// 
			this.sQLiteToolStripMenuItem.Name = "sQLiteToolStripMenuItem";
			resources.ApplyResources(this.sQLiteToolStripMenuItem, "sQLiteToolStripMenuItem");
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cakeboxStatsLabel,
									this.discStatsLabel,
									this.fileStatsLabel});
			resources.ApplyResources(this.statusStrip, "statusStrip");
			this.statusStrip.Name = "statusStrip";
			// 
			// cakeboxStatsLabel
			// 
			this.cakeboxStatsLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.cakeboxStatsLabel.Name = "cakeboxStatsLabel";
			resources.ApplyResources(this.cakeboxStatsLabel, "cakeboxStatsLabel");
			// 
			// discStatsLabel
			// 
			this.discStatsLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.discStatsLabel.Name = "discStatsLabel";
			resources.ApplyResources(this.discStatsLabel, "discStatsLabel");
			// 
			// fileStatsLabel
			// 
			this.fileStatsLabel.Name = "fileStatsLabel";
			resources.ApplyResources(this.fileStatsLabel, "fileStatsLabel");
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			resources.ApplyResources(this.tabPage1, "tabPage1");
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.scanDriveGroupBox);
			resources.ApplyResources(this.tabPage2, "tabPage2");
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			resources.ApplyResources(this.groupBox3, "groupBox3");
			this.groupBox3.Controls.Add(this.selectCakeboxToStore);
			this.groupBox3.Controls.Add(this.saveNewDiscButton);
			this.groupBox3.Controls.Add(this.newDiscLabelTextBox);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			// 
			// selectCakeboxToStore
			// 
			resources.ApplyResources(this.selectCakeboxToStore, "selectCakeboxToStore");
			this.selectCakeboxToStore.DisplayMember = "Value";
			this.selectCakeboxToStore.DropDownHeight = 150;
			this.selectCakeboxToStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectCakeboxToStore.FormattingEnabled = true;
			this.selectCakeboxToStore.Name = "selectCakeboxToStore";
			this.selectCakeboxToStore.ValueMember = "Id";
			// 
			// saveNewDiscButton
			// 
			resources.ApplyResources(this.saveNewDiscButton, "saveNewDiscButton");
			this.saveNewDiscButton.Name = "saveNewDiscButton";
			this.saveNewDiscButton.UseVisualStyleBackColor = true;
			this.saveNewDiscButton.Click += new System.EventHandler(this.saveNewDisc);
			// 
			// newDiscLabelTextBox
			// 
			resources.ApplyResources(this.newDiscLabelTextBox, "newDiscLabelTextBox");
			this.newDiscLabelTextBox.Name = "newDiscLabelTextBox";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// groupBox2
			// 
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Controls.Add(this.scanLog);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// scanLog
			// 
			this.scanLog.BackColor = System.Drawing.SystemColors.Window;
			this.scanLog.ContextMenuStrip = this.scanLogActionsMenu;
			resources.ApplyResources(this.scanLog, "scanLog");
			this.scanLog.Name = "scanLog";
			this.scanLog.ReadOnly = true;
			// 
			// scanLogActionsMenu
			// 
			this.scanLogActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.resetToolStripMenuItem});
			this.scanLogActionsMenu.Name = "scanLogActionsMenu";
			resources.ApplyResources(this.scanLogActionsMenu, "scanLogActionsMenu");
			// 
			// resetToolStripMenuItem
			// 
			this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
			resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
			this.resetToolStripMenuItem.Click += new System.EventHandler(this.scanWorkerReset);
			// 
			// scanDriveGroupBox
			// 
			resources.ApplyResources(this.scanDriveGroupBox, "scanDriveGroupBox");
			this.scanDriveGroupBox.Controls.Add(this.scanDrive);
			this.scanDriveGroupBox.Controls.Add(this.scanDriveButton);
			this.scanDriveGroupBox.Name = "scanDriveGroupBox";
			this.scanDriveGroupBox.TabStop = false;
			// 
			// scanDrive
			// 
			resources.ApplyResources(this.scanDrive, "scanDrive");
			this.scanDrive.DataSource = this.discsListBox.CustomTabOffsets;
			this.scanDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.scanDrive.FormattingEnabled = true;
			this.scanDrive.Name = "scanDrive";
			// 
			// scanDriveButton
			// 
			resources.ApplyResources(this.scanDriveButton, "scanDriveButton");
			this.scanDriveButton.Name = "scanDriveButton";
			this.scanDriveButton.UseVisualStyleBackColor = true;
			this.scanDriveButton.Click += new System.EventHandler(this.scanWorkerToggle);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox4);
			resources.ApplyResources(this.tabPage3, "tabPage3");
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			resources.ApplyResources(this.groupBox4, "groupBox4");
			this.groupBox4.Controls.Add(this.console);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.TabStop = false;
			// 
			// console
			// 
			this.console.BackColor = System.Drawing.SystemColors.Window;
			this.console.ContextMenuStrip = this.consoleActionsMenu;
			resources.ApplyResources(this.console, "console");
			this.console.Name = "console";
			this.console.ReadOnly = true;
			// 
			// consoleActionsMenu
			// 
			this.consoleActionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.clearToolStripMenuItem});
			this.consoleActionsMenu.Name = "consoleActionsMenu";
			resources.ApplyResources(this.consoleActionsMenu, "consoleActionsMenu");
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearConsole);
			// 
			// scanWorker
			// 
			this.scanWorker.WorkerSupportsCancellation = true;
			this.scanWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.scanWorkerDoWork);
			this.scanWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.scanWorkerCompleted);
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Name = "MainForm";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.boxDiscSplitContainer.Panel1.ResumeLayout(false);
			this.boxDiscSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.boxDiscSplitContainer)).EndInit();
			this.boxDiscSplitContainer.ResumeLayout(false);
			this.cakeboxesGroupBox.ResumeLayout(false);
			this.cakeboxesActionsMenu.ResumeLayout(false);
			this.discsGroupBox.ResumeLayout(false);
			this.discsActionsMenu.ResumeLayout(false);
			this.filterGroupBox.ResumeLayout(false);
			this.filterGroupBox.PerformLayout();
			this.discFilesGroupBox.ResumeLayout(false);
			this.filesListActionMenu.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.scanLogActionsMenu.ResumeLayout(false);
			this.scanDriveGroupBox.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.consoleActionsMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip scanLogActionsMenu;
		private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lastfmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imdbToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem anidbToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wikipediaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip filesListActionMenu;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip consoleActionsMenu;
		private System.Windows.Forms.ToolStripMenuItem resetWindowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortDiscsDescendingMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortDiscsAscendingMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem sortDiscsByFilesNoMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortDiscsByLabelMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortDiscsByIdMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortDiscsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem deleteDiscMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editDiscMenuItem;
		private System.Windows.Forms.ContextMenuStrip discsActionsMenu;
		private System.Windows.Forms.ToolStripMenuItem massMoveDiscsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem deleteCakeboxMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editCakeboxMenuItem;
		private System.Windows.Forms.ContextMenuStrip cakeboxesActionsMenu;
		private System.ComponentModel.BackgroundWorker scanWorker;
		private System.Windows.Forms.ToolStripStatusLabel fileStatsLabel;
		private System.Windows.Forms.ToolStripStatusLabel discStatsLabel;
		private System.Windows.Forms.ToolStripStatusLabel cakeboxStatsLabel;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripMenuItem sQLiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rebuildFileCountersToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newCakeboxToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.RichTextBox console;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button scanDriveButton;
		private System.Windows.Forms.ComboBox scanDrive;
		private System.Windows.Forms.GroupBox scanDriveGroupBox;
		private System.Windows.Forms.RichTextBox scanLog;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox newDiscLabelTextBox;
		private System.Windows.Forms.Button saveNewDiscButton;
		public System.Windows.Forms.ComboBox selectCakeboxToStore;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.RichTextBox filesList;
		private System.Windows.Forms.GroupBox discFilesGroupBox;
		private System.Windows.Forms.TextBox filterTextBox;
		private System.Windows.Forms.Button clearFilterButton;
		private System.Windows.Forms.GroupBox filterGroupBox;
		public System.Windows.Forms.ListBox discsListBox;
		private System.Windows.Forms.GroupBox discsGroupBox;
		public System.Windows.Forms.ListBox cakeboxesListBox;
		private System.Windows.Forms.GroupBox cakeboxesGroupBox;
		private System.Windows.Forms.SplitContainer boxDiscSplitContainer;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
