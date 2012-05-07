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
			this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wikipediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.anidbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imdbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lastfmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.stopStartImageList = new System.Windows.Forms.ImageList(this.components);
			this.consoleTabPage = new System.Windows.Forms.TabPage();
			this.consoleGroupBox = new System.Windows.Forms.GroupBox();
			this.console = new System.Windows.Forms.RichTextBox();
			this.consoleMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyConsoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scanWorker = new System.ComponentModel.BackgroundWorker();
			this.filterTextChangedTimer = new System.Windows.Forms.Timer(this.components);
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
			resources.ApplyResources(this.FileListSplitContainer, "FileListSplitContainer");
			this.FileListSplitContainer.Name = "FileListSplitContainer";
			// 
			// FileListSplitContainer.Panel1
			// 
			this.FileListSplitContainer.Panel1.Controls.Add(this.cakeboxDiscSplitContainer);
			this.FileListSplitContainer.Panel1.Controls.Add(this.filterGroupBox);
			resources.ApplyResources(this.FileListSplitContainer.Panel1, "FileListSplitContainer.Panel1");
			// 
			// FileListSplitContainer.Panel2
			// 
			this.FileListSplitContainer.Panel2.Controls.Add(this.fileListGroupBox);
			resources.ApplyResources(this.FileListSplitContainer.Panel2, "FileListSplitContainer.Panel2");
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
			this.cakeboxesListBox.ContextMenuStrip = this.cakeboxesMenu;
			this.cakeboxesListBox.DisplayMember = "Value";
			resources.ApplyResources(this.cakeboxesListBox, "cakeboxesListBox");
			this.cakeboxesListBox.FormattingEnabled = true;
			this.cakeboxesListBox.Name = "cakeboxesListBox";
			this.cakeboxesListBox.ValueMember = "Key";
			this.cakeboxesListBox.SelectedValueChanged += new System.EventHandler(this.ShowDiscs);
			this.cakeboxesListBox.DoubleClick += new System.EventHandler(this.OpenEditCakeboxForm);
			this.cakeboxesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxMouseDown);
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
			resources.ApplyResources(this.cakeboxesMenu, "cakeboxesMenu");
			this.cakeboxesMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CakeboxesMenuOpening);
			// 
			// copyCakeboxLabelMenuItem
			// 
			this.copyCakeboxLabelMenuItem.Image = global::Cavebox.Properties.Images.copy;
			this.copyCakeboxLabelMenuItem.Name = "copyCakeboxLabelMenuItem";
			resources.ApplyResources(this.copyCakeboxLabelMenuItem, "copyCakeboxLabelMenuItem");
			this.copyCakeboxLabelMenuItem.Click += new System.EventHandler(this.ContextCopyClick);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
			// 
			// editCakeboxMenuItem
			// 
			this.editCakeboxMenuItem.Image = global::Cavebox.Properties.Images.edit;
			this.editCakeboxMenuItem.Name = "editCakeboxMenuItem";
			resources.ApplyResources(this.editCakeboxMenuItem, "editCakeboxMenuItem");
			this.editCakeboxMenuItem.Click += new System.EventHandler(this.OpenEditCakeboxForm);
			// 
			// deleteCakeboxMenuItem
			// 
			this.deleteCakeboxMenuItem.Image = global::Cavebox.Properties.Images.delete;
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
			this.massMoveDiscsMenuItem.Image = global::Cavebox.Properties.Images.move;
			this.massMoveDiscsMenuItem.Name = "massMoveDiscsMenuItem";
			resources.ApplyResources(this.massMoveDiscsMenuItem, "massMoveDiscsMenuItem");
			this.massMoveDiscsMenuItem.Click += new System.EventHandler(this.OpenMassMove);
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
			this.discsListBox.ContextMenuStrip = this.discsMenu;
			this.discsListBox.DisplayMember = "Value";
			resources.ApplyResources(this.discsListBox, "discsListBox");
			this.discsListBox.FormattingEnabled = true;
			this.discsListBox.Name = "discsListBox";
			this.discsListBox.ValueMember = "Key";
			this.discsListBox.SelectedValueChanged += new System.EventHandler(this.ShowFiles);
			this.discsListBox.DoubleClick += new System.EventHandler(this.OpenEditDisc);
			this.discsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxMouseDown);
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
			resources.ApplyResources(this.discsMenu, "discsMenu");
			this.discsMenu.Opening += new System.ComponentModel.CancelEventHandler(this.DiscsMenuOpening);
			// 
			// copyDiscLabelMenuItem
			// 
			this.copyDiscLabelMenuItem.Image = global::Cavebox.Properties.Images.copy;
			this.copyDiscLabelMenuItem.Name = "copyDiscLabelMenuItem";
			resources.ApplyResources(this.copyDiscLabelMenuItem, "copyDiscLabelMenuItem");
			this.copyDiscLabelMenuItem.Click += new System.EventHandler(this.ContextCopyClick);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
			// 
			// editDiscMenuItem
			// 
			this.editDiscMenuItem.Image = global::Cavebox.Properties.Images.edit;
			this.editDiscMenuItem.Name = "editDiscMenuItem";
			resources.ApplyResources(this.editDiscMenuItem, "editDiscMenuItem");
			this.editDiscMenuItem.Click += new System.EventHandler(this.OpenEditDisc);
			// 
			// deleteDiscMenuItem
			// 
			this.deleteDiscMenuItem.Image = global::Cavebox.Properties.Images.delete;
			this.deleteDiscMenuItem.Name = "deleteDiscMenuItem";
			resources.ApplyResources(this.deleteDiscMenuItem, "deleteDiscMenuItem");
			this.deleteDiscMenuItem.Click += new System.EventHandler(this.DeleteDisc);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
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
			this.DiscsOrderMenu.Image = global::Cavebox.Properties.Images.alt;
			this.DiscsOrderMenu.Name = "DiscsOrderMenu";
			resources.ApplyResources(this.DiscsOrderMenu, "DiscsOrderMenu");
			// 
			// DiscsOrderByIdMenuItem
			// 
			this.DiscsOrderByIdMenuItem.Name = "DiscsOrderByIdMenuItem";
			resources.ApplyResources(this.DiscsOrderByIdMenuItem, "DiscsOrderByIdMenuItem");
			this.DiscsOrderByIdMenuItem.Tag = "0";
			this.DiscsOrderByIdMenuItem.Click += new System.EventHandler(this.DiscsOrderBy);
			// 
			// DiscsOrderByLabelMenuItem
			// 
			this.DiscsOrderByLabelMenuItem.Checked = true;
			this.DiscsOrderByLabelMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.DiscsOrderByLabelMenuItem.Name = "DiscsOrderByLabelMenuItem";
			resources.ApplyResources(this.DiscsOrderByLabelMenuItem, "DiscsOrderByLabelMenuItem");
			this.DiscsOrderByLabelMenuItem.Tag = "1";
			this.DiscsOrderByLabelMenuItem.Click += new System.EventHandler(this.DiscsOrderBy);
			// 
			// DiscsOrderByFilesNoMenuItem
			// 
			this.DiscsOrderByFilesNoMenuItem.Name = "DiscsOrderByFilesNoMenuItem";
			resources.ApplyResources(this.DiscsOrderByFilesNoMenuItem, "DiscsOrderByFilesNoMenuItem");
			this.DiscsOrderByFilesNoMenuItem.Tag = "2";
			this.DiscsOrderByFilesNoMenuItem.Click += new System.EventHandler(this.DiscsOrderBy);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
			// 
			// DiscsOrderAscMenuItem
			// 
			this.DiscsOrderAscMenuItem.Checked = true;
			this.DiscsOrderAscMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.DiscsOrderAscMenuItem.Name = "DiscsOrderAscMenuItem";
			resources.ApplyResources(this.DiscsOrderAscMenuItem, "DiscsOrderAscMenuItem");
			this.DiscsOrderAscMenuItem.Tag = "0";
			this.DiscsOrderAscMenuItem.Click += new System.EventHandler(this.DiscsOrderWay);
			// 
			// DiscsOrderDescMenuItem
			// 
			this.DiscsOrderDescMenuItem.Name = "DiscsOrderDescMenuItem";
			resources.ApplyResources(this.DiscsOrderDescMenuItem, "DiscsOrderDescMenuItem");
			this.DiscsOrderDescMenuItem.Tag = "1";
			this.DiscsOrderDescMenuItem.Click += new System.EventHandler(this.DiscsOrderWay);
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
			this.clearFilterButton.Image = global::Cavebox.Properties.Images.cancel;
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
			// fileListGroupBox
			// 
			this.fileListGroupBox.Controls.Add(this.fileList);
			resources.ApplyResources(this.fileListGroupBox, "fileListGroupBox");
			this.fileListGroupBox.Name = "fileListGroupBox";
			this.fileListGroupBox.TabStop = false;
			// 
			// fileList
			// 
			this.fileList.BackColor = System.Drawing.SystemColors.Window;
			this.fileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fileList.ContextMenuStrip = this.filesListMenu;
			resources.ApplyResources(this.fileList, "fileList");
			this.fileList.Name = "fileList";
			this.fileList.ReadOnly = true;
			// 
			// filesListMenu
			// 
			this.filesListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyFileListMenuItem,
									this.toolStripSeparator5,
									this.googleToolStripMenuItem,
									this.wikipediaToolStripMenuItem,
									this.anidbToolStripMenuItem,
									this.imdbToolStripMenuItem,
									this.lastfmToolStripMenuItem,
									this.youtubeToolStripMenuItem});
			this.filesListMenu.Name = "filesListActionMenu";
			resources.ApplyResources(this.filesListMenu, "filesListMenu");
			this.filesListMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FilesListMenuOpening);
			// 
			// copyFileListMenuItem
			// 
			this.copyFileListMenuItem.Image = global::Cavebox.Properties.Images.copy;
			this.copyFileListMenuItem.Name = "copyFileListMenuItem";
			resources.ApplyResources(this.copyFileListMenuItem, "copyFileListMenuItem");
			this.copyFileListMenuItem.Click += new System.EventHandler(this.ContextCopyClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
			// 
			// googleToolStripMenuItem
			// 
			this.googleToolStripMenuItem.Image = global::Cavebox.Properties.Images.google;
			this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
			resources.ApplyResources(this.googleToolStripMenuItem, "googleToolStripMenuItem");
			this.googleToolStripMenuItem.Tag = "http://www.google.com/search?site=&q=";
			this.googleToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// wikipediaToolStripMenuItem
			// 
			this.wikipediaToolStripMenuItem.Image = global::Cavebox.Properties.Images.wikipedia;
			this.wikipediaToolStripMenuItem.Name = "wikipediaToolStripMenuItem";
			resources.ApplyResources(this.wikipediaToolStripMenuItem, "wikipediaToolStripMenuItem");
			this.wikipediaToolStripMenuItem.Tag = "http://en.wikipedia.org/wiki/Special:Search?search=";
			this.wikipediaToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// anidbToolStripMenuItem
			// 
			this.anidbToolStripMenuItem.Image = global::Cavebox.Properties.Images.anidb;
			this.anidbToolStripMenuItem.Name = "anidbToolStripMenuItem";
			resources.ApplyResources(this.anidbToolStripMenuItem, "anidbToolStripMenuItem");
			this.anidbToolStripMenuItem.Tag = "http://anidb.net/perl-bin/animedb.pl?show=animelist&do.search=search&adb.search=";
			this.anidbToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// imdbToolStripMenuItem
			// 
			this.imdbToolStripMenuItem.Image = global::Cavebox.Properties.Images.imdb;
			this.imdbToolStripMenuItem.Name = "imdbToolStripMenuItem";
			resources.ApplyResources(this.imdbToolStripMenuItem, "imdbToolStripMenuItem");
			this.imdbToolStripMenuItem.Tag = "http://www.imdb.com/find?s=all&q=";
			this.imdbToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// lastfmToolStripMenuItem
			// 
			this.lastfmToolStripMenuItem.Image = global::Cavebox.Properties.Images.lastFM;
			this.lastfmToolStripMenuItem.Name = "lastfmToolStripMenuItem";
			resources.ApplyResources(this.lastfmToolStripMenuItem, "lastfmToolStripMenuItem");
			this.lastfmToolStripMenuItem.Tag = "http://www.last.fm/music/";
			this.lastfmToolStripMenuItem.Click += new System.EventHandler(this.OpenSearchUrl);
			// 
			// youtubeToolStripMenuItem
			// 
			this.youtubeToolStripMenuItem.Image = global::Cavebox.Properties.Images.youtube;
			this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
			resources.ApplyResources(this.youtubeToolStripMenuItem, "youtubeToolStripMenuItem");
			this.youtubeToolStripMenuItem.Tag = "http://www.youtube.com/results?search_query=";
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
									this.importMenuItem,
									this.exportMenuItem,
									this.toolStripSeparator1,
									this.exitMenuItem});
			this.fileMenuItem.Name = "fileMenuItem";
			resources.ApplyResources(this.fileMenuItem, "fileMenuItem");
			// 
			// newCakeboxMenuItem
			// 
			this.newCakeboxMenuItem.Image = global::Cavebox.Properties.Images._new;
			this.newCakeboxMenuItem.Name = "newCakeboxMenuItem";
			resources.ApplyResources(this.newCakeboxMenuItem, "newCakeboxMenuItem");
			this.newCakeboxMenuItem.Click += new System.EventHandler(this.OpenAddCakeboxForm);
			// 
			// importMenuItem
			// 
			this.importMenuItem.Image = global::Cavebox.Properties.Images.import;
			this.importMenuItem.Name = "importMenuItem";
			resources.ApplyResources(this.importMenuItem, "importMenuItem");
			this.importMenuItem.Click += new System.EventHandler(this.ImportXml);
			// 
			// exportMenuItem
			// 
			this.exportMenuItem.Image = global::Cavebox.Properties.Images.export;
			this.exportMenuItem.Name = "exportMenuItem";
			resources.ApplyResources(this.exportMenuItem, "exportMenuItem");
			this.exportMenuItem.Click += new System.EventHandler(this.ExportXml);
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
			this.alwaysOnTopMenuItem.Click += new System.EventHandler(this.ToggleAlwaysOnTop);
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
									this.vacuumDatabaseMenuItem,
									this.dropDataMenuItem});
			this.toolsMenuItem.Name = "toolsMenuItem";
			resources.ApplyResources(this.toolsMenuItem, "toolsMenuItem");
			// 
			// rebuildTotalFilesMenuItem
			// 
			this.rebuildTotalFilesMenuItem.Image = global::Cavebox.Properties.Images.reload;
			this.rebuildTotalFilesMenuItem.Name = "rebuildTotalFilesMenuItem";
			resources.ApplyResources(this.rebuildTotalFilesMenuItem, "rebuildTotalFilesMenuItem");
			this.rebuildTotalFilesMenuItem.Click += new System.EventHandler(this.RebuildFileCounters);
			// 
			// vacuumDatabaseMenuItem
			// 
			this.vacuumDatabaseMenuItem.Image = global::Cavebox.Properties.Images.reload;
			this.vacuumDatabaseMenuItem.Name = "vacuumDatabaseMenuItem";
			resources.ApplyResources(this.vacuumDatabaseMenuItem, "vacuumDatabaseMenuItem");
			this.vacuumDatabaseMenuItem.Click += new System.EventHandler(this.VacuumTables);
			// 
			// dropDataMenuItem
			// 
			this.dropDataMenuItem.Image = global::Cavebox.Properties.Images.drop;
			this.dropDataMenuItem.Name = "dropDataMenuItem";
			resources.ApplyResources(this.dropDataMenuItem, "dropDataMenuItem");
			this.dropDataMenuItem.Click += new System.EventHandler(this.DropData);
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
			this.mainTabPage.Controls.Add(this.FileListSplitContainer);
			resources.ApplyResources(this.mainTabPage, "mainTabPage");
			this.mainTabPage.Name = "mainTabPage";
			// 
			// scanTabPage
			// 
			this.scanTabPage.Controls.Add(this.saveNewDiscGroupBox);
			this.scanTabPage.Controls.Add(this.scanFileListGroupBox);
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
			this.newDiscCakebox.ValueMember = "Key";
			// 
			// saveNewDiscButton
			// 
			resources.ApplyResources(this.saveNewDiscButton, "saveNewDiscButton");
			this.saveNewDiscButton.Image = global::Cavebox.Properties.Images.new32;
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
			// scanFileListGroupBox
			// 
			resources.ApplyResources(this.scanFileListGroupBox, "scanFileListGroupBox");
			this.scanFileListGroupBox.Controls.Add(this.scanFileList);
			this.scanFileListGroupBox.Name = "scanFileListGroupBox";
			this.scanFileListGroupBox.TabStop = false;
			// 
			// scanFileList
			// 
			this.scanFileList.BackColor = System.Drawing.SystemColors.Window;
			this.scanFileList.ContextMenuStrip = this.scanFileListMenu;
			resources.ApplyResources(this.scanFileList, "scanFileList");
			this.scanFileList.Name = "scanFileList";
			this.scanFileList.ReadOnly = true;
			// 
			// scanFileListMenu
			// 
			this.scanFileListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyScanFileListMenuItem,
									this.toolStripSeparator7,
									this.resetScanMenuItem});
			this.scanFileListMenu.Name = "scanLogActionsMenu";
			resources.ApplyResources(this.scanFileListMenu, "scanFileListMenu");
			this.scanFileListMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ScanLogMenuOpening);
			// 
			// copyScanFileListMenuItem
			// 
			this.copyScanFileListMenuItem.Image = global::Cavebox.Properties.Images.copy;
			this.copyScanFileListMenuItem.Name = "copyScanFileListMenuItem";
			resources.ApplyResources(this.copyScanFileListMenuItem, "copyScanFileListMenuItem");
			this.copyScanFileListMenuItem.Click += new System.EventHandler(this.ContextCopyClick);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
			// 
			// resetScanMenuItem
			// 
			this.resetScanMenuItem.Name = "resetScanMenuItem";
			resources.ApplyResources(this.resetScanMenuItem, "resetScanMenuItem");
			this.resetScanMenuItem.Click += new System.EventHandler(this.ScanWorkerReset);
			// 
			// scanPathGroupBox
			// 
			resources.ApplyResources(this.scanPathGroupBox, "scanPathGroupBox");
			this.scanPathGroupBox.Controls.Add(this.scanPathComboBox);
			this.scanPathGroupBox.Controls.Add(this.browseScanPathButton);
			this.scanPathGroupBox.Controls.Add(this.toggleScanPathButton);
			this.scanPathGroupBox.Name = "scanPathGroupBox";
			this.scanPathGroupBox.TabStop = false;
			// 
			// scanPathComboBox
			// 
			resources.ApplyResources(this.scanPathComboBox, "scanPathComboBox");
			this.scanPathComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.scanPathComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.scanPathComboBox.Name = "scanPathComboBox";
			// 
			// browseScanPathButton
			// 
			resources.ApplyResources(this.browseScanPathButton, "browseScanPathButton");
			this.browseScanPathButton.Image = global::Cavebox.Properties.Images.browse;
			this.browseScanPathButton.Name = "browseScanPathButton";
			this.browseScanPathButton.UseVisualStyleBackColor = true;
			this.browseScanPathButton.Click += new System.EventHandler(this.BrowseScanPath);
			// 
			// toggleScanPathButton
			// 
			resources.ApplyResources(this.toggleScanPathButton, "toggleScanPathButton");
			this.toggleScanPathButton.ImageList = this.stopStartImageList;
			this.toggleScanPathButton.Name = "toggleScanPathButton";
			this.toggleScanPathButton.UseVisualStyleBackColor = true;
			this.toggleScanPathButton.Click += new System.EventHandler(this.ScanWorkerToggle);
			// 
			// stopStartImageList
			// 
			this.stopStartImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("stopStartImageList.ImageStream")));
			this.stopStartImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.stopStartImageList.Images.SetKeyName(0, "start");
			this.stopStartImageList.Images.SetKeyName(1, "stop");
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
			this.console.ContextMenuStrip = this.consoleMenu;
			resources.ApplyResources(this.console, "console");
			this.console.Name = "console";
			this.console.ReadOnly = true;
			// 
			// consoleMenu
			// 
			this.consoleMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.copyConsoleMenuItem,
									this.toolStripSeparator6,
									this.clearToolStripMenuItem});
			this.consoleMenu.Name = "consoleActionsMenu";
			resources.ApplyResources(this.consoleMenu, "consoleMenu");
			this.consoleMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ConsoleMenuOpening);
			// 
			// copyConsoleMenuItem
			// 
			this.copyConsoleMenuItem.Image = global::Cavebox.Properties.Images.copy;
			this.copyConsoleMenuItem.Name = "copyConsoleMenuItem";
			resources.ApplyResources(this.copyConsoleMenuItem, "copyConsoleMenuItem");
			this.copyConsoleMenuItem.Click += new System.EventHandler(this.ContextCopyClick);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
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
			// Main
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = global::Cavebox.Properties.Images.app;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "Main";
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
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem copyDiscLabelMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem copyCakeboxLabelMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem copyScanFileListMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem copyConsoleMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dropDataMenuItem;
		private System.Windows.Forms.Button browseScanPathButton;
		private System.Windows.Forms.ImageList stopStartImageList;
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
		private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lastfmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imdbToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem anidbToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wikipediaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
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
		private System.Windows.Forms.Button toggleScanPathButton;
		private System.Windows.Forms.ComboBox scanPathComboBox;
		private System.Windows.Forms.GroupBox scanPathGroupBox;
		private System.Windows.Forms.RichTextBox scanFileList;
		private System.Windows.Forms.GroupBox scanFileListGroupBox;
		private System.Windows.Forms.Label newDiscLabelLabel;
		private System.Windows.Forms.Label newDiscCakeboxLabel;
		private System.Windows.Forms.TextBox newDiscLabelTextBox;
		private System.Windows.Forms.Button saveNewDiscButton;
		public System.Windows.Forms.ComboBox newDiscCakebox;
		private System.Windows.Forms.GroupBox saveNewDiscGroupBox;
		private System.Windows.Forms.TabPage scanTabPage;
		private System.Windows.Forms.RichTextBox fileList;
		private System.Windows.Forms.GroupBox fileListGroupBox;
		private System.Windows.Forms.TextBox filterTextBox;
		private System.Windows.Forms.Button clearFilterButton;
		private System.Windows.Forms.GroupBox filterGroupBox;
		public System.Windows.Forms.ListBox discsListBox;
		private System.Windows.Forms.GroupBox discsGroupBox;
		public System.Windows.Forms.ListBox cakeboxesListBox;
		private System.Windows.Forms.GroupBox cakeboxesGroupBox;
		private System.Windows.Forms.SplitContainer cakeboxDiscSplitContainer;
		private System.Windows.Forms.SplitContainer FileListSplitContainer;
		private System.Windows.Forms.TabPage mainTabPage;
		private System.Windows.Forms.TabControl tabControl;
	}
}
