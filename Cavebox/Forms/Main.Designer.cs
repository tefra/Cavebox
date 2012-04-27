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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cakeboxDiscFileSplitContainer = new System.Windows.Forms.SplitContainer();
            this.cakeboxDiscSplitContainer = new System.Windows.Forms.SplitContainer();
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
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCakeboxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildTotalFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacuumDatabaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.scanLogGroupBox = new System.Windows.Forms.GroupBox();
            this.scanLog = new System.Windows.Forms.RichTextBox();
            this.scanLogActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanPathGroupBox = new System.Windows.Forms.GroupBox();
            this.stopScanButton = new System.Windows.Forms.Button();
            this.scanPathTextBox = new System.Windows.Forms.ComboBox();
            this.startScanButton = new System.Windows.Forms.Button();
            this.consoleTabPage = new System.Windows.Forms.TabPage();
            this.consoleGroupBox = new System.Windows.Forms.GroupBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.consoleActionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanWorker = new System.ComponentModel.BackgroundWorker();
            this.filterTextChangedTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cakeboxDiscFileSplitContainer)).BeginInit();
            this.cakeboxDiscFileSplitContainer.Panel1.SuspendLayout();
            this.cakeboxDiscFileSplitContainer.Panel2.SuspendLayout();
            this.cakeboxDiscFileSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cakeboxDiscSplitContainer)).BeginInit();
            this.cakeboxDiscSplitContainer.Panel1.SuspendLayout();
            this.cakeboxDiscSplitContainer.Panel2.SuspendLayout();
            this.cakeboxDiscSplitContainer.SuspendLayout();
            this.cakeboxesGroupBox.SuspendLayout();
            this.cakeboxesActionsMenu.SuspendLayout();
            this.discsGroupBox.SuspendLayout();
            this.discsActionsMenu.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.discFilesGroupBox.SuspendLayout();
            this.filesListActionMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.scanTabPage.SuspendLayout();
            this.saveNewDiscGroupBox.SuspendLayout();
            this.scanLogGroupBox.SuspendLayout();
            this.scanLogActionsMenu.SuspendLayout();
            this.scanPathGroupBox.SuspendLayout();
            this.consoleTabPage.SuspendLayout();
            this.consoleGroupBox.SuspendLayout();
            this.consoleActionsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cakeboxDiscFileSplitContainer
            // 
            resources.ApplyResources(this.cakeboxDiscFileSplitContainer, "cakeboxDiscFileSplitContainer");
            this.cakeboxDiscFileSplitContainer.Name = "cakeboxDiscFileSplitContainer";
            // 
            // cakeboxDiscFileSplitContainer.Panel1
            // 
            this.cakeboxDiscFileSplitContainer.Panel1.Controls.Add(this.cakeboxDiscSplitContainer);
            this.cakeboxDiscFileSplitContainer.Panel1.Controls.Add(this.filterGroupBox);
            resources.ApplyResources(this.cakeboxDiscFileSplitContainer.Panel1, "cakeboxDiscFileSplitContainer.Panel1");
            // 
            // cakeboxDiscFileSplitContainer.Panel2
            // 
            this.cakeboxDiscFileSplitContainer.Panel2.Controls.Add(this.discFilesGroupBox);
            resources.ApplyResources(this.cakeboxDiscFileSplitContainer.Panel2, "cakeboxDiscFileSplitContainer.Panel2");
            // 
            // cakeboxDiscSplitContainer
            // 
            resources.ApplyResources(this.cakeboxDiscSplitContainer, "cakeboxDiscSplitContainer");
            this.cakeboxDiscSplitContainer.Name = "cakeboxDiscSplitContainer";
            // 
            // cakeboxDiscSplitContainer.Panel1
            // 
            this.cakeboxDiscSplitContainer.Panel1.Controls.Add(this.cakeboxesGroupBox);
            resources.ApplyResources(this.cakeboxDiscSplitContainer.Panel1, "cakeboxDiscSplitContainer.Panel1");
            // 
            // cakeboxDiscSplitContainer.Panel2
            // 
            this.cakeboxDiscSplitContainer.Panel2.Controls.Add(this.discsGroupBox);
            resources.ApplyResources(this.cakeboxDiscSplitContainer.Panel2, "cakeboxDiscSplitContainer.Panel2");
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
            this.cakeboxesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cakeboxesListBox.ContextMenuStrip = this.cakeboxesActionsMenu;
            this.cakeboxesListBox.DisplayMember = "Value";
            resources.ApplyResources(this.cakeboxesListBox, "cakeboxesListBox");
            this.cakeboxesListBox.FormattingEnabled = true;
            this.cakeboxesListBox.Name = "cakeboxesListBox";
            this.cakeboxesListBox.ValueMember = "Id";
            this.cakeboxesListBox.SelectedValueChanged += new System.EventHandler(this.ShowDiscs);
            this.cakeboxesListBox.DoubleClick += new System.EventHandler(this.OpenEditCakeboxForm);
            this.cakeboxesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxMouseDown);
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
            this.editCakeboxMenuItem.Image = global::Cavebox.Properties.Resources.edit;
            this.editCakeboxMenuItem.Name = "editCakeboxMenuItem";
            resources.ApplyResources(this.editCakeboxMenuItem, "editCakeboxMenuItem");
            this.editCakeboxMenuItem.Click += new System.EventHandler(this.OpenEditCakeboxForm);
            // 
            // deleteCakeboxMenuItem
            // 
            this.deleteCakeboxMenuItem.Image = global::Cavebox.Properties.Resources.delete;
            this.deleteCakeboxMenuItem.Name = "deleteCakeboxMenuItem";
            resources.ApplyResources(this.deleteCakeboxMenuItem, "deleteCakeboxMenuItem");
            this.deleteCakeboxMenuItem.Click += new System.EventHandler(this.DeleteCakebox);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // massMoveDiscsMenuItem
            // 
            this.massMoveDiscsMenuItem.Image = global::Cavebox.Properties.Resources.move;
            this.massMoveDiscsMenuItem.Name = "massMoveDiscsMenuItem";
            resources.ApplyResources(this.massMoveDiscsMenuItem, "massMoveDiscsMenuItem");
            this.massMoveDiscsMenuItem.Click += new System.EventHandler(this.OpenMassMoveForm);
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
            this.discsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discsListBox.ContextMenuStrip = this.discsActionsMenu;
            this.discsListBox.DisplayMember = "Value";
            resources.ApplyResources(this.discsListBox, "discsListBox");
            this.discsListBox.FormattingEnabled = true;
            this.discsListBox.Name = "discsListBox";
            this.discsListBox.ValueMember = "Id";
            this.discsListBox.SelectedValueChanged += new System.EventHandler(this.ShowFiles);
            this.discsListBox.DoubleClick += new System.EventHandler(this.OpenEditDiscForm);
            this.discsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxMouseDown);
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
            this.discsActionsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.DiscsActionsMenuOpening);
            // 
            // editDiscMenuItem
            // 
            this.editDiscMenuItem.Image = global::Cavebox.Properties.Resources.edit;
            this.editDiscMenuItem.Name = "editDiscMenuItem";
            resources.ApplyResources(this.editDiscMenuItem, "editDiscMenuItem");
            this.editDiscMenuItem.Click += new System.EventHandler(this.OpenEditDiscForm);
            // 
            // deleteDiscMenuItem
            // 
            this.deleteDiscMenuItem.Image = global::Cavebox.Properties.Resources.delete;
            this.deleteDiscMenuItem.Name = "deleteDiscMenuItem";
            resources.ApplyResources(this.deleteDiscMenuItem, "deleteDiscMenuItem");
            this.deleteDiscMenuItem.Click += new System.EventHandler(this.DeleteDisc);
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
            this.sortDiscsMenuItem.Image = global::Cavebox.Properties.Resources.alt;
            this.sortDiscsMenuItem.Name = "sortDiscsMenuItem";
            resources.ApplyResources(this.sortDiscsMenuItem, "sortDiscsMenuItem");
            // 
            // sortDiscsByIdMenuItem
            // 
            this.sortDiscsByIdMenuItem.Name = "sortDiscsByIdMenuItem";
            resources.ApplyResources(this.sortDiscsByIdMenuItem, "sortDiscsByIdMenuItem");
            this.sortDiscsByIdMenuItem.Click += new System.EventHandler(this.SortDiscs);
            // 
            // sortDiscsByLabelMenuItem
            // 
            this.sortDiscsByLabelMenuItem.Checked = true;
            this.sortDiscsByLabelMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortDiscsByLabelMenuItem.Name = "sortDiscsByLabelMenuItem";
            resources.ApplyResources(this.sortDiscsByLabelMenuItem, "sortDiscsByLabelMenuItem");
            this.sortDiscsByLabelMenuItem.Click += new System.EventHandler(this.SortDiscs);
            // 
            // sortDiscsByFilesNoMenuItem
            // 
            this.sortDiscsByFilesNoMenuItem.Name = "sortDiscsByFilesNoMenuItem";
            resources.ApplyResources(this.sortDiscsByFilesNoMenuItem, "sortDiscsByFilesNoMenuItem");
            this.sortDiscsByFilesNoMenuItem.Click += new System.EventHandler(this.SortDiscs);
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
            this.sortDiscsAscendingMenuItem.Click += new System.EventHandler(this.SortDiscs);
            // 
            // sortDiscsDescendingMenuItem
            // 
            this.sortDiscsDescendingMenuItem.Name = "sortDiscsDescendingMenuItem";
            resources.ApplyResources(this.sortDiscsDescendingMenuItem, "sortDiscsDescendingMenuItem");
            this.sortDiscsDescendingMenuItem.Click += new System.EventHandler(this.SortDiscs);
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
            this.clearFilterButton.Image = global::Cavebox.Properties.Resources.cancel;
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.FilterOff);
            // 
            // filterTextBox
            // 
            resources.ApplyResources(this.filterTextBox, "filterTextBox");
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.TextChanged += new System.EventHandler(this.FilterTextBoxTextChanged);
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
            this.filesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyFilesListClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Image = global::Cavebox.Properties.Resources.google;
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            resources.ApplyResources(this.googleToolStripMenuItem, "googleToolStripMenuItem");
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
            // 
            // wikipediaToolStripMenuItem
            // 
            this.wikipediaToolStripMenuItem.Image = global::Cavebox.Properties.Resources.wikipedia;
            this.wikipediaToolStripMenuItem.Name = "wikipediaToolStripMenuItem";
            resources.ApplyResources(this.wikipediaToolStripMenuItem, "wikipediaToolStripMenuItem");
            this.wikipediaToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
            // 
            // anidbToolStripMenuItem
            // 
            this.anidbToolStripMenuItem.Image = global::Cavebox.Properties.Resources.anidb;
            this.anidbToolStripMenuItem.Name = "anidbToolStripMenuItem";
            resources.ApplyResources(this.anidbToolStripMenuItem, "anidbToolStripMenuItem");
            this.anidbToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
            // 
            // imdbToolStripMenuItem
            // 
            this.imdbToolStripMenuItem.Image = global::Cavebox.Properties.Resources.imdb;
            this.imdbToolStripMenuItem.Name = "imdbToolStripMenuItem";
            resources.ApplyResources(this.imdbToolStripMenuItem, "imdbToolStripMenuItem");
            this.imdbToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
            // 
            // lastfmToolStripMenuItem
            // 
            this.lastfmToolStripMenuItem.Image = global::Cavebox.Properties.Resources.lastFM;
            this.lastfmToolStripMenuItem.Name = "lastfmToolStripMenuItem";
            resources.ApplyResources(this.lastfmToolStripMenuItem, "lastfmToolStripMenuItem");
            this.lastfmToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Image = global::Cavebox.Properties.Resources.youtube;
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            resources.ApplyResources(this.youtubeToolStripMenuItem, "youtubeToolStripMenuItem");
            this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewMenuItem,
            this.toolsMenuItem,
            this.helpMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCakeboxMenuItem,
            this.restoreMenuItem,
            this.backupMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            resources.ApplyResources(this.fileMenuItem, "fileMenuItem");
            // 
            // newCakeboxMenuItem
            // 
            this.newCakeboxMenuItem.Image = global::Cavebox.Properties.Resources.database;
            this.newCakeboxMenuItem.Name = "newCakeboxMenuItem";
            resources.ApplyResources(this.newCakeboxMenuItem, "newCakeboxMenuItem");
            this.newCakeboxMenuItem.Click += new System.EventHandler(this.OpenEditCakeboxForm);
            // 
            // restoreMenuItem
            // 
            this.restoreMenuItem.Image = global::Cavebox.Properties.Resources.database_go;
            this.restoreMenuItem.Name = "restoreMenuItem";
            resources.ApplyResources(this.restoreMenuItem, "restoreMenuItem");
            this.restoreMenuItem.Click += new System.EventHandler(this.ImportXml);
            // 
            // backupMenuItem
            // 
            this.backupMenuItem.Image = global::Cavebox.Properties.Resources.database_save;
            this.backupMenuItem.Name = "backupMenuItem";
            resources.ApplyResources(this.backupMenuItem, "backupMenuItem");
            this.backupMenuItem.Click += new System.EventHandler(this.ExportXml);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
            this.exitMenuItem.Click += new System.EventHandler(this.ExitApplication);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopMenuItem,
            this.resetWindowMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            resources.ApplyResources(this.viewMenuItem, "viewMenuItem");
            // 
            // alwaysOnTopMenuItem
            // 
            this.alwaysOnTopMenuItem.Name = "alwaysOnTopMenuItem";
            resources.ApplyResources(this.alwaysOnTopMenuItem, "alwaysOnTopMenuItem");
            this.alwaysOnTopMenuItem.Click += new System.EventHandler(this.AlwaysOnTopMenuItemClick);
            // 
            // resetWindowMenuItem
            // 
            this.resetWindowMenuItem.Name = "resetWindowMenuItem";
            resources.ApplyResources(this.resetWindowMenuItem, "resetWindowMenuItem");
            this.resetWindowMenuItem.Click += new System.EventHandler(this.ResetWindow);
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rebuildTotalFilesMenuItem,
            this.vacuumDatabaseMenuItem});
            this.toolsMenuItem.Name = "toolsMenuItem";
            resources.ApplyResources(this.toolsMenuItem, "toolsMenuItem");
            // 
            // rebuildTotalFilesMenuItem
            // 
            this.rebuildTotalFilesMenuItem.Name = "rebuildTotalFilesMenuItem";
            resources.ApplyResources(this.rebuildTotalFilesMenuItem, "rebuildTotalFilesMenuItem");
            this.rebuildTotalFilesMenuItem.Click += new System.EventHandler(this.RebuildFileCounters);
            // 
            // vacuumDatabaseMenuItem
            // 
            this.vacuumDatabaseMenuItem.Name = "vacuumDatabaseMenuItem";
            resources.ApplyResources(this.vacuumDatabaseMenuItem, "vacuumDatabaseMenuItem");
            this.vacuumDatabaseMenuItem.Click += new System.EventHandler(this.VacuumTables);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changelogMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            resources.ApplyResources(this.helpMenuItem, "helpMenuItem");
            // 
            // changelogMenuItem
            // 
            this.changelogMenuItem.Name = "changelogMenuItem";
            resources.ApplyResources(this.changelogMenuItem, "changelogMenuItem");
            this.changelogMenuItem.Click += new System.EventHandler(this.ChangelogToolStripMenuItemClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cakeboxStatsLabel,
            this.discStatsLabel,
            this.fileStatsLabel,
            this.discAddedLabel,
            this.discAddedValueLabel});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // cakeboxStatsLabel
            // 
            this.cakeboxStatsLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.cakeboxStatsLabel.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.cakeboxStatsLabel.Name = "cakeboxStatsLabel";
            this.cakeboxStatsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            resources.ApplyResources(this.cakeboxStatsLabel, "cakeboxStatsLabel");
            // 
            // discStatsLabel
            // 
            this.discStatsLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.discStatsLabel.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.discStatsLabel.Name = "discStatsLabel";
            this.discStatsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            resources.ApplyResources(this.discStatsLabel, "discStatsLabel");
            // 
            // fileStatsLabel
            // 
            this.fileStatsLabel.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.fileStatsLabel.Name = "fileStatsLabel";
            this.fileStatsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            resources.ApplyResources(this.fileStatsLabel, "fileStatsLabel");
            // 
            // discAddedLabel
            // 
            this.discAddedLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.discAddedLabel.Margin = new System.Windows.Forms.Padding(0, 3, -5, 2);
            this.discAddedLabel.Name = "discAddedLabel";
            resources.ApplyResources(this.discAddedLabel, "discAddedLabel");
            // 
            // discAddedValueLabel
            // 
            this.discAddedValueLabel.Name = "discAddedValueLabel";
            resources.ApplyResources(this.discAddedValueLabel, "discAddedValueLabel");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainTabPage);
            this.tabControl.Controls.Add(this.scanTabPage);
            this.tabControl.Controls.Add(this.consoleTabPage);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // mainTabPage
            // 
            this.mainTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.mainTabPage.Controls.Add(this.cakeboxDiscFileSplitContainer);
            resources.ApplyResources(this.mainTabPage, "mainTabPage");
            this.mainTabPage.Name = "mainTabPage";
            // 
            // scanTabPage
            // 
            this.scanTabPage.Controls.Add(this.saveNewDiscGroupBox);
            this.scanTabPage.Controls.Add(this.scanLogGroupBox);
            this.scanTabPage.Controls.Add(this.scanPathGroupBox);
            resources.ApplyResources(this.scanTabPage, "scanTabPage");
            this.scanTabPage.Name = "scanTabPage";
            // 
            // saveNewDiscGroupBox
            // 
            resources.ApplyResources(this.saveNewDiscGroupBox, "saveNewDiscGroupBox");
            this.saveNewDiscGroupBox.Controls.Add(this.newDiscCakebox);
            this.saveNewDiscGroupBox.Controls.Add(this.saveNewDiscButton);
            this.saveNewDiscGroupBox.Controls.Add(this.newDiscLabelTextBox);
            this.saveNewDiscGroupBox.Controls.Add(this.newDiscCakeboxLabel);
            this.saveNewDiscGroupBox.Controls.Add(this.newDiscLabelLabel);
            this.saveNewDiscGroupBox.Name = "saveNewDiscGroupBox";
            this.saveNewDiscGroupBox.TabStop = false;
            // 
            // newDiscCakebox
            // 
            resources.ApplyResources(this.newDiscCakebox, "newDiscCakebox");
            this.newDiscCakebox.DisplayMember = "Value";
            this.newDiscCakebox.DropDownHeight = 150;
            this.newDiscCakebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newDiscCakebox.FormattingEnabled = true;
            this.newDiscCakebox.Name = "newDiscCakebox";
            this.newDiscCakebox.ValueMember = "Id";
            // 
            // saveNewDiscButton
            // 
            resources.ApplyResources(this.saveNewDiscButton, "saveNewDiscButton");
            this.saveNewDiscButton.Image = global::Cavebox.Properties.Resources.add;
            this.saveNewDiscButton.Name = "saveNewDiscButton";
            this.saveNewDiscButton.UseVisualStyleBackColor = true;
            this.saveNewDiscButton.Click += new System.EventHandler(this.SaveNewDisc);
            // 
            // newDiscLabelTextBox
            // 
            resources.ApplyResources(this.newDiscLabelTextBox, "newDiscLabelTextBox");
            this.newDiscLabelTextBox.Name = "newDiscLabelTextBox";
            // 
            // newDiscCakeboxLabel
            // 
            resources.ApplyResources(this.newDiscCakeboxLabel, "newDiscCakeboxLabel");
            this.newDiscCakeboxLabel.Name = "newDiscCakeboxLabel";
            // 
            // newDiscLabelLabel
            // 
            resources.ApplyResources(this.newDiscLabelLabel, "newDiscLabelLabel");
            this.newDiscLabelLabel.Name = "newDiscLabelLabel";
            // 
            // scanLogGroupBox
            // 
            resources.ApplyResources(this.scanLogGroupBox, "scanLogGroupBox");
            this.scanLogGroupBox.Controls.Add(this.scanLog);
            this.scanLogGroupBox.Name = "scanLogGroupBox";
            this.scanLogGroupBox.TabStop = false;
            // 
            // scanLog
            // 
            this.scanLog.BackColor = System.Drawing.SystemColors.Window;
            this.scanLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ScanWorkerReset);
            // 
            // scanPathGroupBox
            // 
            resources.ApplyResources(this.scanPathGroupBox, "scanPathGroupBox");
            this.scanPathGroupBox.Controls.Add(this.stopScanButton);
            this.scanPathGroupBox.Controls.Add(this.scanPathTextBox);
            this.scanPathGroupBox.Controls.Add(this.startScanButton);
            this.scanPathGroupBox.Name = "scanPathGroupBox";
            this.scanPathGroupBox.TabStop = false;
            // 
            // stopScanButton
            // 
            resources.ApplyResources(this.stopScanButton, "stopScanButton");
            this.stopScanButton.Image = global::Cavebox.Properties.Resources.stop;
            this.stopScanButton.Name = "stopScanButton";
            this.stopScanButton.UseVisualStyleBackColor = true;
            this.stopScanButton.Click += new System.EventHandler(this.ScanWorkerStop);
            // 
            // scanPathTextBox
            // 
            resources.ApplyResources(this.scanPathTextBox, "scanPathTextBox");
            this.scanPathTextBox.DataSource = this.discsListBox.CustomTabOffsets;
            this.scanPathTextBox.FormattingEnabled = true;
            this.scanPathTextBox.Name = "scanPathTextBox";
            // 
            // startScanButton
            // 
            resources.ApplyResources(this.startScanButton, "startScanButton");
            this.startScanButton.Image = global::Cavebox.Properties.Resources.start;
            this.startScanButton.Name = "startScanButton";
            this.startScanButton.UseVisualStyleBackColor = true;
            this.startScanButton.Click += new System.EventHandler(this.ScanWorkerStart);
            // 
            // consoleTabPage
            // 
            this.consoleTabPage.Controls.Add(this.consoleGroupBox);
            resources.ApplyResources(this.consoleTabPage, "consoleTabPage");
            this.consoleTabPage.Name = "consoleTabPage";
            // 
            // consoleGroupBox
            // 
            this.consoleGroupBox.Controls.Add(this.console);
            resources.ApplyResources(this.consoleGroupBox, "consoleGroupBox");
            this.consoleGroupBox.Name = "consoleGroupBox";
            this.consoleGroupBox.TabStop = false;
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.Window;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = global::Cavebox.Properties.Resources.database1;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.cakeboxDiscFileSplitContainer.Panel1.ResumeLayout(false);
            this.cakeboxDiscFileSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cakeboxDiscFileSplitContainer)).EndInit();
            this.cakeboxDiscFileSplitContainer.ResumeLayout(false);
            this.cakeboxDiscSplitContainer.Panel1.ResumeLayout(false);
            this.cakeboxDiscSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cakeboxDiscSplitContainer)).EndInit();
            this.cakeboxDiscSplitContainer.ResumeLayout(false);
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
            this.tabControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.scanTabPage.ResumeLayout(false);
            this.saveNewDiscGroupBox.ResumeLayout(false);
            this.saveNewDiscGroupBox.PerformLayout();
            this.scanLogGroupBox.ResumeLayout(false);
            this.scanLogActionsMenu.ResumeLayout(false);
            this.scanPathGroupBox.ResumeLayout(false);
            this.consoleTabPage.ResumeLayout(false);
            this.consoleGroupBox.ResumeLayout(false);
            this.consoleActionsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripMenuItem resetWindowMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vacuumDatabaseMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.Button stopScanButton;
		private System.Windows.Forms.Timer filterTextChangedTimer;
		private System.Windows.Forms.RichTextBox console;
		private System.ComponentModel.BackgroundWorker scanWorker;
		private System.Windows.Forms.ToolStripStatusLabel discAddedValueLabel;
		private System.Windows.Forms.ToolStripStatusLabel discAddedLabel;
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
		private System.Windows.Forms.ToolStripMenuItem backupMenuItem;
		private System.Windows.Forms.ToolStripMenuItem restoreMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newCakeboxMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.GroupBox consoleGroupBox;
		private System.Windows.Forms.TabPage consoleTabPage;
		private System.Windows.Forms.Button startScanButton;
		private System.Windows.Forms.ComboBox scanPathTextBox;
		private System.Windows.Forms.GroupBox scanPathGroupBox;
		private System.Windows.Forms.RichTextBox scanLog;
		private System.Windows.Forms.GroupBox scanLogGroupBox;
		private System.Windows.Forms.Label newDiscLabelLabel;
		private System.Windows.Forms.Label newDiscCakeboxLabel;
		private System.Windows.Forms.TextBox newDiscLabelTextBox;
		private System.Windows.Forms.Button saveNewDiscButton;
		public System.Windows.Forms.ComboBox newDiscCakebox;
		private System.Windows.Forms.GroupBox saveNewDiscGroupBox;
		private System.Windows.Forms.TabPage scanTabPage;
		private System.Windows.Forms.RichTextBox filesList;
		private System.Windows.Forms.GroupBox discFilesGroupBox;
		private System.Windows.Forms.TextBox filterTextBox;
		private System.Windows.Forms.Button clearFilterButton;
		private System.Windows.Forms.GroupBox filterGroupBox;
		public System.Windows.Forms.ListBox discsListBox;
		private System.Windows.Forms.GroupBox discsGroupBox;
		public System.Windows.Forms.ListBox cakeboxesListBox;
		private System.Windows.Forms.GroupBox cakeboxesGroupBox;
		private System.Windows.Forms.SplitContainer cakeboxDiscSplitContainer;
		private System.Windows.Forms.SplitContainer cakeboxDiscFileSplitContainer;
		private System.Windows.Forms.TabPage mainTabPage;
		private System.Windows.Forms.TabControl tabControl;
	}
}
