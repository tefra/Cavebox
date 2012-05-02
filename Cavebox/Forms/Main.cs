/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cavebox.Lib;

namespace Cavebox.Forms
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Main : Form
	{
		List<ControlBinding> controlBindings = null;
		List<Index> cakeboxes = null;
		string _filter;
		string _filterLike;
		int scanTotalFiles = 0;
		int discsOrderBy = 1;
		int discsOrderWay = 0;
		DateTime stopWatch;

		/// <summary>
		/// Initialize components and database connection
		/// </summary>
		public Main()
		{
			InitializeComponent();
			Console.SetOut(new ConsoleWriter(console));
			Console.WriteLine(Lang.GetString("_applicationStartingUp"));
			if(Model.Connect("Data Source=data.db"))
			{
				Console.WriteLine(Lang.GetString("_sqliteStartinUp", Model.SQLiteVersion(), Model.Status()));
				Model.Install();
			}
			else
			{
				MessageBox.Show(Lang.GetString("_dbConnectionFailed"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				this.Dispose();
			}
		}

		/// <summary>
		/// Restore previous session storage and initialize lists with data from database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainFormLoad(object sender, EventArgs e)
		{
			controlBindings = new List<ControlBinding>();
			controlBindings.Add(new ControlBinding(this, "Size", "WindowSize"));
			controlBindings.Add(new ControlBinding(this, "Location", "WindowLocation"));
			controlBindings.Add(new ControlBinding(this, "TopMost", "AlwaysOnTop"));
			controlBindings.Add(new ControlBinding(FileListSplitContainer, "SplitterDistance", "FileListSplitterDistance"));
			controlBindings.Add(new ControlBinding(cakeboxDiscSplitContainer, "SplitterDistance", "CakeboxDiscSplitterDistance"));
			controlBindings.Add(new ControlBinding(tabControl, "SelectedIndex", "SelectedTabIndex"));
			controlBindings.Add(new ControlBinding(scanPathComboBox, "Text", "LastScanPath"));
			
			foreach(ControlBinding control in controlBindings)
			{
				control.ReadValue();
			}
			
			alwaysOnTopMenuItem.Checked = this.TopMost;
			scanPathComboBox.Items.AddRange(DriveInfo.GetDrives());
			ShowCakeboxes(0, true);
		}
		
		/// <summary>
		/// Close database connection, save session settings
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainFormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			foreach(ControlBinding control in controlBindings)
			{
				control.WriteValue();
			}

			Properties.Settings.Default.Restarts = Properties.Settings.Default.Restarts + 1;
			Properties.Settings.Default.Save();
			Model.Close();
			Console.WriteLine(Lang.GetString("_applicationClosing"));
		}
		
		/// <summary>
		/// Exit application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitApplication(object sender, EventArgs e)
		{
			Dispose();
		}

		/// <summary>
		/// Get filter status
		/// </summary>
		/// <returns></returns>
		public Boolean isFilterOn()
		{
			return _filter != null;
		}

		/// <summary>
		/// Refresh cakeboxes lists and status bar stats on
		/// - Cakebox add/edit/delete
		/// - Filtering results
		/// </summary>
		/// <param name="selectValue"></param>
		/// <param name="refreshCakeboxesCache"></param>
		public void ShowCakeboxes(int selectValue = 0, Boolean refreshCakeboxesCache = false)
		{
			if(refreshCakeboxesCache)
			{
				cakeboxes = Model.FetchCakeboxes();
				newDiscCakebox.DataSource = cakeboxes.ToList();
				RefreshStatusBar(true, true);
			}
			
			List<Index> newDataSource = (_filterLike == null) ? cakeboxes.ToList() : Model.FetchCakeboxes(_filterLike);
			cakeboxesListBox.SelectedValueChanged -= ShowDiscs;
			cakeboxesListBox.DataSource = newDataSource;
			cakeboxesListBox.SelectedValueChanged += ShowDiscs;
			UpdateNumTitle(cakeboxesGroupBox, newDataSource.Count);
			
			if(newDataSource.Count == 0)
			{
				ShowDiscs(null, EventArgs.Empty);
			}
			else
			{
				cakeboxesListBox.SelectedValue = selectValue;
			}
		}

		/// <summary>
		/// Show discs based on the cakeboxes list box selection and filter
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void ShowDiscs(object sender, EventArgs e)
		{
			List<Index> newDataSource = (cakeboxesListBox.SelectedIndex > -1) ? Model.FetchDiscsByCakeboxId(cakeboxesListBox.SelectedValue.ToString(), _filterLike, discsOrderBy, discsOrderWay) : new List<Index>();
			discsListBox.SelectedValueChanged -= ShowFiles;
			discsListBox.DataSource = newDataSource;
			discsListBox.SelectedValue = 0;
			discsListBox.SelectedValueChanged += ShowFiles;
			ShowFiles(sender, e);
			UpdateNumTitle(discsGroupBox, newDataSource.Count);
		}
		
		/// <summary>
		/// Show disc files based on discs list box selection and highlight filter strings
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ShowFiles(object sender, EventArgs e)
		{
			fileList.Clear();
			if(discsListBox.SelectedIndex > -1)
			{
				object[] result = Model.FetchFilesListByDiscId(discsListBox.SelectedValue.ToString());
				string files = result[0].ToString();
				int added = Convert.ToInt32(result[2]);
				int filesno = Convert.ToInt32(result[1]);
				fileList.Text = files;
				int start, pos, keyLength;
				int end = fileList.Text.Length;
				foreach(string key in filterTextBox.Text.Split(' '))
				{
					keyLength = key.Length;
					start = pos = 0;
					while((pos = fileList.Find(key, start, -1, RichTextBoxFinds.None)) > -1)
					{
						fileList.Select(pos, keyLength);
						fileList.SelectionBackColor = Color.Yellow;
						start = pos+keyLength;
					}
				}
				discAddedLabel.Visible = true;
				discAddedValueLabel.Visible = true;
				discAddedValueLabel.Text = (added > 0) ? new DateTime(1970, 1, 1).AddSeconds(added).ToLocalTime().ToString("dd/MM/yyyy HH:mm:ss") : Lang.GetString("_unknownDate");
				UpdateNumTitle(fileListGroupBox, filesno);
			}
			else
			{
				discAddedLabel.Visible = false;
				discAddedValueLabel.Visible = false;
				UpdateNumTitle(fileListGroupBox, 0);
			}
		}

		/// <summary>
		/// Start/Reset filter timer while typing to avoid useless db queries
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FilterTextBoxTextChanged(object sender, EventArgs e)
		{
			if(filterTextChangedTimer.Enabled)
			{
				filterTextChangedTimer.Stop();
			}
			filterTextChangedTimer.Start();
		}

		/// <summary>
		/// Stop filter timer, construct filterLike keywords and refresh cakeboxes if necessary
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Filter(object sender, EventArgs e)
		{
			filterTextChangedTimer.Stop();
			string filter = filterTextBox.Text.Trim();
			if(filter.Length > 0)
			{
				if(filter != _filter)
				{
					_filterLike = String.Format("%{0}%", String.Join("%", filter.ToLower().Split(' ')));
					_filter = filter;
					clearFilterButton.Enabled = true;
					ShowCakeboxes();
				}
			}
			else
			{
				clearFilterButton.Enabled = false;
				_filter = _filterLike = null;
				ShowCakeboxes();
			}
		}
		
		/// <summary>
		/// Immediately set filter off
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FilterOff(object sender, EventArgs e)
		{
			filterTextBox.TextChanged -= FilterTextBoxTextChanged;
			filterTextBox.Clear();
			clearFilterButton.Enabled = false;
			_filter = _filterLike = null;
			ShowCakeboxes();
			filterTextBox.TextChanged += FilterTextBoxTextChanged;
		}
		
		/// <summary>
		/// Refress cakeboxes, discs, files total status bar labels
		/// </summary>
		/// <param name="cakebox"></param>
		/// <param name="disc"></param>
		private void RefreshStatusBar(Boolean cakebox = false, Boolean disc = false)
		{
			if(cakebox)
			{
				UpdateNumTitle(cakeboxStatsLabel, Model.GetTotalCakeboxes());
			}
			if(disc)
			{
				UpdateNumTitle(discStatsLabel, Model.GetTotalDiscs());
				UpdateNumTitle(fileStatsLabel, Model.GetTotalFiles());
			}
		}

		/// <summary>
		/// Update total label
		/// </summary>
		/// <param name="label"></param>
		/// <param name="num"></param>
		private void UpdateNumTitle(ToolStripLabel label, int num)
		{
			string title = label.Text.Split(':')[0].Trim();
			title += (num > 0) ? ": " + String.Format("{0:n0}", num) : null;
			label.Text = title;
		}

		/// <summary>
		/// Update total label
		/// </summary>
		/// <param name="groupBox"></param>
		/// <param name="num"></param>
		public void UpdateNumTitle(GroupBox groupBox, int num)
		{
			string title = groupBox.Text.Split(':')[0].Trim();
			title += (num > 0) ? ": " + String.Format("{0:n0}", num) : null;
			groupBox.Text = title;
		}
		
		/// <summary>
		/// Open browse folder dialog to set the scan path
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BrowseScanPath(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = false;
			if(Directory.Exists(scanPathComboBox.Text))
			{
				folderBrowserDialog.SelectedPath = scanPathComboBox.Text;
			}
			if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				scanPathComboBox.Text = folderBrowserDialog.SelectedPath;
			}
		}
		
		/// <summary>
		/// Start/Stop scan path procedure if path exists
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScanWorkerToggle(object sender, EventArgs e)
		{
			saveNewDiscButton.Enabled = false;
			if(!scanWorker.IsBusy)
			{
				string path = scanPathComboBox.Text;
				if(!path.EndsWith(Path.DirectorySeparatorChar.ToString()))
				{
					path += Path.DirectorySeparatorChar;
				}
				
				if(Directory.Exists(path))
				{
					Console.WriteLine(Lang.GetString("_scanStarting", path));
					stopWatch = DateTime.Now;
					scanFileList.Focus();
					scanWorker.RunWorkerAsync(path);
					scanPathComboBox.Enabled = false;
					scanFileList.Clear();
					newDiscLabelTextBox.Clear();
					newDiscLabelTextBox.Enabled = false;
					toggleScanPathButton.ImageKey = "stop";
					browseScanPathButton.Enabled = false;
				}
				else
				{
					scanFileList.Text = Lang.GetString("_pathXnotavailabe", path);
				}
			}
			else
			{
				scanWorker.CancelAsync();
				toggleScanPathButton.ImageKey = "start";
				browseScanPathButton.Enabled = true;
			}
		}
		
		/// <summary>
		/// Reset scan controls
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScanWorkerReset(object sender, EventArgs e)
		{
			if(scanWorker.IsBusy)
			{
				scanWorker.CancelAsync();
			}
			else
			{
				newDiscLabelTextBox.Clear();
				newDiscLabelTextBox.Enabled = false;
				saveNewDiscButton.Enabled = false;
				scanFileList.Clear();
			}
		}
		
		/// <summary>
		/// Scan worker start walking the dir tree with stack push/pop
		/// Update UI every 100 found files
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="evt"></param>
		private void ScanWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs evt)
		{
			string root = evt.Argument as string;
			int rootLength = root.Length;
			int i = 0;
			scanTotalFiles = 0;
			StringBuilder buf = new StringBuilder();
			Stack<string> pending = new Stack<string>();
			pending.Push(root);
			while (pending.Count != 0)
			{
				if(scanWorker.CancellationPending)
				{
					evt.Cancel = true;
					return;
				}
				
				string path = pending.Pop();
				string[] files = null;
				string[] dirs = null;
				try
				{
					dirs = Directory.GetDirectories(path);
					foreach(string dir in dirs.Reverse())
					{
						pending.Push(dir);
					}
					files = Directory.GetFiles(path);
					foreach(string file in files)
					{
						i++;
						buf.AppendLine(file.Substring(rootLength));
					}
					
					if(i > 100)
					{
						ScanWorkerUpdateRTB(buf, i);
						buf.Clear();
						i = 0;
					}
				}
				catch { }
			}
			if(i > 0)
			{
				ScanWorkerUpdateRTB(buf, i);
			}
		}

		/// <summary>
		/// Invoke update rtb with scanworker file lists
		/// </summary>
		/// <param name="buf"></param>
		/// <param name="files"></param>
		private void ScanWorkerUpdateRTB(StringBuilder buf, int files)
		{
			scanFileList.Invoke(new MethodInvoker(delegate
			                                      {
			                                      	scanFileList.AppendText(buf.ToString());
			                                      	scanTotalFiles += files;
			                                      }));
		}
		
		/// <summary>
		/// Show scan worker cancelled/completed results
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScanWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			scanFileList.ScrollToCaret();
			scanPathComboBox.Enabled = true;
			browseScanPathButton.Enabled = true;
			toggleScanPathButton.ImageKey = "start";
			if(e.Cancelled)
			{
				scanFileList.Clear();
				newDiscLabelTextBox.Clear();
				newDiscLabelTextBox.Enabled = false;
				saveNewDiscButton.Enabled = false;
				Console.WriteLine(Lang.GetString("_scanWasCanceled"));
			}
			else
			{
				Console.WriteLine(Lang.GetString("_scanWasCompleted", scanTotalFiles, (DateTime.Now - stopWatch).TotalSeconds));
				newDiscLabelTextBox.Text = new DriveInfo(scanPathComboBox.Text).VolumeLabel;
				newDiscLabelTextBox.Enabled = true;
				saveNewDiscButton.Enabled = true;
			}
		}

		/// <summary>
		/// Add new disc with the scan worker results
		/// New disc label and cakebox are required fields
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveNewDisc(object sender, EventArgs e)
		{
			string label = newDiscLabelTextBox.Text.Trim();
			string files = scanFileList.Text.Trim();
			if(newDiscCakebox.SelectedIndex == -1)
			{
				MessageBox.Show(Lang.GetString("_newDiscMissingCakebox"), Lang.GetString("_error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			else if(label.Length == 0)
			{
				MessageBox.Show(Lang.GetString("_discLabelMissing"), Lang.GetString("_error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			else
			{
				DateTime Jan1st1970 = new DateTime (1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
				int added =  (int) (DateTime.UtcNow - Jan1st1970).TotalSeconds;
				string clabel = newDiscCakebox.Text;
				string cid = newDiscCakebox.SelectedValue.ToString();
				
				Model.AddDisc(label, files, scanTotalFiles.ToString(), cid, added.ToString());
				ShowCakeboxes();
				RefreshStatusBar(false, true);
				scanFileList.Clear();
				scanFileList.Text = Lang.GetString("_newDiscAdded", label, clabel);
				newDiscLabelTextBox.Clear();
				saveNewDiscButton.Enabled = false;
			}
		}
		

		/// <summary>
		/// Delete cakebox, with confirmation dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteCakebox(object sender, EventArgs e)
		{
			if(discsListBox.Items.Count > 0)
			{
				MessageBox.Show(Lang.GetString("_cakeboxNotEmpty"), Lang.GetString("_error"), MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
			}
			else if(MessageBox.Show(Lang.GetString("_confirmDeleteCakebox", cakeboxesListBox.Text), Lang.GetString("_confirmTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				Model.DeleteCakebox(Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString()));
				Console.WriteLine(Lang.GetString("_cakeboxDeleted", cakeboxesListBox.Text));
				ShowCakeboxes(0, true);
				RefreshStatusBar(true, false);
			}
		}
		
		/// <summary>
		/// Open mass move discs dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenMassMoveForm(object sender, EventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				int id = Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString());
				new MassMove(this, id).ShowDialog();
			}
		}
		
		/// <summary>
		/// Open edit disc dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenEditDiscForm(object sender, EventArgs e)
		{
			if(discsListBox.SelectedIndex > -1 && cakeboxesListBox.SelectedIndex > -1)
			{
				int id = Convert.ToInt32(discsListBox.SelectedValue.ToString());
				int cid = Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString());
				string label = Model.FetchDiscLabelById(id); // <-- stupid sorting methods change the disc label
				new EditDisc(this, id, cid, label).ShowDialog();
			}
		}

		/// <summary>
		/// Delete disc, with confirmation dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteDisc(object sender, EventArgs e)
		{
			if(MessageBox.Show(Lang.GetString("_confirmDeleteDisc", discsListBox.Text), Lang.GetString("_confirmTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				Model.DeleteDisc(Convert.ToInt32(discsListBox.SelectedValue.ToString()));
				Console.WriteLine(Lang.GetString("_discDeleted", discsListBox.Text));
				ShowDiscs(sender, e);
				RefreshStatusBar(false, true);
			}
		}

		/// <summary>
		/// Change sorting rules on discs listbox and refresh
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SortDiscs(object sender, EventArgs e)
		{
			ToolStripMenuItem source = (ToolStripMenuItem) sender;
			int prevBy = discsOrderBy;
			int prevWay = discsOrderWay;
			if(source == sortDiscsByIdMenuItem)
			{
				discsOrderBy = 0;
				sortDiscsByIdMenuItem.Checked = true;
				sortDiscsByLabelMenuItem.Checked = false;
				sortDiscsByFilesNoMenuItem.Checked = false;
			}
			else if(source == sortDiscsByLabelMenuItem)
			{
				discsOrderBy = 1;
				sortDiscsByIdMenuItem.Checked = false;
				sortDiscsByLabelMenuItem.Checked = true;
				sortDiscsByFilesNoMenuItem.Checked = false;
			}
			else if(source == sortDiscsByFilesNoMenuItem)
			{
				discsOrderBy = 2;
				sortDiscsByIdMenuItem.Checked = false;
				sortDiscsByLabelMenuItem.Checked = false;
				sortDiscsByFilesNoMenuItem.Checked = true;
			}
			else if(source == sortDiscsAscendingMenuItem)
			{
				discsOrderWay = 0;
				sortDiscsAscendingMenuItem.Checked = true;
				sortDiscsDescendingMenuItem.Checked = false;
				
			}
			else if(source == sortDiscsDescendingMenuItem)
			{
				discsOrderWay = 1;
				sortDiscsAscendingMenuItem.Checked = false;
				sortDiscsDescendingMenuItem.Checked = true;
			}
			if(prevBy != discsOrderBy || prevWay != discsOrderWay)
			{
				ShowDiscs(sender, e);
			}
		}
		
		/// <summary>
		/// Clear console text
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearConsole(object sender, EventArgs e)
		{
			console.Clear();
		}
		
		/// <summary>
		/// Open search url with selected file list text
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenSearchUrl(object sender, EventArgs e)
		{
			string link = null;
			ToolStripMenuItem source = (ToolStripMenuItem) sender;
			if(source == googleToolStripMenuItem)
			{
				link = "http://www.google.com/search?site=&q=";
			}
			else if(source == imdbToolStripMenuItem)
			{
				link = "http://www.imdb.com/find?s=all&q=";
			}
			else if(source == wikipediaToolStripMenuItem)
			{
				link = "http://en.wikipedia.org/wiki/Special:Search?search=";
			}
			else if(source == anidbToolStripMenuItem)
			{
				link = "http://anidb.net/perl-bin/animedb.pl?show=animelist&do.search=search&adb.search=";
			}
			else if(source == lastfmToolStripMenuItem)
			{
				link = "http://www.last.fm/music/";
			}
			else if(source == youtubeToolStripMenuItem)
			{
				link = "http://www.youtube.com/results?search_query=";
			}
			link  += String.Join("+", fileList.SelectedText.Trim().Replace("\n", " ").Split(' '));
			System.Diagnostics.Process.Start(link);
		}
		
		/// <summary>
		/// Globalized Copy command
		/// - So far only for richtextbox but it can be extended if such need appears
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ContextCopyClick(object sender, EventArgs e)
		{
			ToolStripMenuItem source = sender as ToolStripMenuItem;
			ContextMenuStrip parent = source.GetCurrentParent() as ContextMenuStrip;
			if(parent.SourceControl is RichTextBox)
			{
				RichTextBox rtb = parent.SourceControl as RichTextBox;
				rtb.Copy();
			}
			else if(parent.SourceControl is ListBox)
			{
				ListBox lb = parent.SourceControl as ListBox;
				if(lb.SelectedIndex > -1)
				{
					Clipboard.SetText(lb.Text);
				}
			}
		}
		
		/***********************************************************
							Menu Strip Action
		 ***********************************************************/
		
		/// <summary>
		/// Open add new cakebox dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenAddCakeboxForm(object sender, EventArgs e)
		{
			new EditCakebox(this).ShowDialog();
		}
		
		/// <summary>
		/// Open edit cakebox dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenEditCakeboxForm(object sender, EventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				int id = Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString());
				string label = cakeboxesListBox.Text;
				new EditCakebox(this, id, label).ShowDialog();
			}
		}

		/// <summary>
		/// Rebuild file counters (Deprecated)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RebuildFileCounters(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			stopWatch = DateTime.Now;
			Model.RebuildFileCounters();
			Console.WriteLine(Lang.GetString("_rebuildingFileCountersCompleted", (DateTime.Now - stopWatch).TotalSeconds));
			Cursor.Current = Cursors.Default;
		}
		
		/// <summary>
		/// Run sqlite vacuum procedure to rebuild database to save database and speed up things
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void VacuumTables(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			stopWatch = DateTime.Now;
			Model.Vacuum();
			Console.WriteLine(Lang.GetString("_vacuumTables", (DateTime.Now - stopWatch).TotalSeconds));
			Cursor.Current = Cursors.Default;
		}
		
		/// <summary>
		/// Drop/Recreate database tables, with confirmation dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DropData(object sender, EventArgs e)
		{
			if(MessageBox.Show(Lang.GetString("_confirmDropData"), Lang.GetString("_confirmTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				Cursor.Current = Cursors.WaitCursor;
				stopWatch = DateTime.Now;
				Model.DropTables();
				Model.Install();
				Console.WriteLine(Lang.GetString("_dropData", (DateTime.Now - stopWatch).TotalSeconds));
				Cursor.Current = Cursors.Default;
				ShowCakeboxes(0, true);
			}
		}
		
		/// <summary>
		/// Export xml database backup
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExportXml(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.SelectedPath = Path.GetDirectoryName(Application.ExecutablePath);
			if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				Cursor.Current = Cursors.WaitCursor;
				string file = folderBrowserDialog.SelectedPath + Path.DirectorySeparatorChar + DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".xml";
				stopWatch = DateTime.Now;
				new XMLExport(file);
				Console.WriteLine(Lang.GetString("_exportCompleted", (DateTime.Now - stopWatch).TotalSeconds));
				Cursor.Current = Cursors.Default;
			}
		}
		
		/// <summary>
		/// Import xml database backup
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ImportXml(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
			openFileDialog.Filter = Lang.GetString("_xmlFilesDesc");
			openFileDialog.Title = Lang.GetString("_selectBackupFile");
			
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Cursor.Current = Cursors.WaitCursor;
				stopWatch = DateTime.Now;
				XMLImport i = new XMLImport(openFileDialog.FileName);
				Console.WriteLine(Lang.GetString("_importCompleted", (DateTime.Now - stopWatch).TotalSeconds));
				foreach (KeyValuePair<string, int> pair in i.imported)
				{
					Console.Write(Lang.GetString("_importTableRows", pair.Key, pair.Value));
				}
				Cursor.Current = Cursors.Default;
				ShowCakeboxes(0, true);
			}
		}
		
		/// <summary>
		/// Toggle always on top window option
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AlwaysOnTopMenuItemClick(object sender, EventArgs e)
		{
			Boolean check = !alwaysOnTopMenuItem.Checked;
			this.TopMost = check;
			alwaysOnTopMenuItem.Checked = check;
		}
		
		/// <summary>
		/// Reset window size/potion and split containers splitter distance
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetWindow(object sender, EventArgs e)
		{
			this.Size = Properties.Settings.Default.DefaultWindowSize;
			cakeboxDiscSplitContainer.SplitterDistance = (cakeboxDiscSplitContainer.Width - cakeboxDiscSplitContainer.SplitterWidth) / 2;
			FileListSplitContainer.SplitterDistance = 310;
			this.CenterToScreen();
		}
		
		/// <summary>
		/// Show changelog dialog
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChangelogToolStripMenuItemClick(object sender, EventArgs e)
		{
			new Changelog().ShowDialog();
		}
		
		/***********************************************************
			UI Behavior things, small stuff to enhance experience
		 ***********************************************************/

		/// <summary>
		/// Listbox select item on mouse down no matter what button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ListBoxMouseDown(object sender, MouseEventArgs e)
		{
			ListBox listbox = (ListBox) sender;
			listbox.SelectedIndex = listbox.IndexFromPoint(e.X, e.Y);
		}

		/// <summary>
		/// Based on what tab is selected
		/// - Change accept button to save new disc button or toggle scan path button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TabControlSelectedIndexChanged(object sender, EventArgs e)
		{
			switch(tabControl.SelectedIndex)
			{
				case 0:
					AcceptButton = null;
					break;
					
				case 1:
					AcceptButton = saveNewDiscButton.Enabled ? saveNewDiscButton : toggleScanPathButton;
					break;
					
				case 2:
					AcceptButton = null;
					break;
			}
		}
		
		/// <summary>
		/// Hide delete option on cakeboxes listbox if it containns discs
		/// or cancel menu opening if nothing is selected
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CakeboxesActionsMenuOpening(object sender, CancelEventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				deleteCakeboxMenuItem.Enabled = discsListBox.Items.Count == 0;
			}
			else
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// Cancel files list action menu if nothing is selected
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FilesListActionMenuOpening(object sender, CancelEventArgs e)
		{
			if(fileList.SelectedText.Trim().Length == 0)
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// Cancel discs list box action menu if nothing is selected
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DiscsActionsMenuOpening(object sender, CancelEventArgs e)
		{
			if(discsListBox.SelectedIndex == -1)
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ConsoleActionsMenuOpening(object sender, CancelEventArgs e)
		{
			copyConsoleMenuItem.Enabled = console.SelectedText.Trim().Length > 0;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScanLogActionsMenuOpening(object sender, CancelEventArgs e)
		{
			copyScanFileListMenuItem.Enabled = scanFileList.SelectedText.Trim().Length > 0;
		}
	}
}