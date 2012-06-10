/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Cavebox.Lib;

namespace Cavebox.Forms
{
	public partial class Main : Form
	{
		private Cavebox.Properties.Settings Options = Cavebox.Properties.Settings.Default;
		private List<ControlBinding> controlBindings = new List<ControlBinding>();
		public string _filter;
		private string _filterLike;
		private int scanTotalFiles;
		private int ListBoxLastTip;
		private DateTime stopWatch;
		
		/// <summary>
		/// Initialize components and database connection
		/// </summary>
		public Main()
		{
			InitializeComponent();
			Console.SetOut(new ConsoleWriter(consoleTextBox));
			Console.WriteLine(Lang.GetString("_applicationStartingUp"));
			if(Model.Connect("Data Source=data.db"))
			{
				Console.WriteLine(Lang.GetString("_sqliteStartinUp", Model.SQLiteVersion()));
				Model.Install();
			}
			else
			{
				MessageBox.Show(Lang.GetString("_dbConnectionFailed"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				this.Dispose();
			}
		}
		
		/// <summary>
		/// Restore previous local session storage and initialize lists with data from database
		/// </summary>
		private void MainFormLoad(object sender, EventArgs e)
		{
			controlBindings.Add(new ControlBinding(this, "Size", "WindowSize"));
			controlBindings.Add(new ControlBinding(this, "Location", "WindowLocation"));
			controlBindings.Add(new ControlBinding(this, "TopMost", "AlwaysOnTop"));
			controlBindings.Add(new ControlBinding(alwaysOnTopMenuItem, "Checked", "AlwaysOnTop"));
			controlBindings.Add(new ControlBinding(FileListSplitContainer, "SplitterDistance", "FileListSplitterDistance"));
			controlBindings.Add(new ControlBinding(cakeboxDiscSplitContainer, "SplitterDistance", "CakeboxDiscSplitterDistance"));
			controlBindings.Add(new ControlBinding(tabControl, "SelectedIndex", "SelectedTabIndex"));
			controlBindings.Add(new ControlBinding(scanPathComboBox, "Text", "LastScanPath"));
			controlBindings.Add(new ControlBinding(SortDiscsMenu, "Tag", "SortDiscs"));
			controlBindings.Add(new ControlBinding(SortCakeboxesMenu, "Tag", "SortCakeboxes"));
			scanPathComboBox.Items.AddRange(DriveInfo.GetDrives());
			
			foreach(ControlBinding control in controlBindings)
			{
				control.ReadValue();
			}
			
			Options.LastBackupDir = (Options.LastBackupDir == String.Empty) ? Path.GetDirectoryName(Application.ExecutablePath) : Options.LastBackupDir;
			CheckSortOptions(SortDiscsMenu);
			CheckSortOptions(SortCakeboxesMenu);
			ShowCakeboxes(0, true, true);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="check"></param>
		private void CheckSortOptions(ToolStripMenuItem menu)
		{
			int sep = menu.DropDownItems.Count - 3;
			Point check = (Point) menu.Tag;
			check.X = (check.X < 0 || check.X >= sep) ? 0 : check.X;
			check.Y = (check.Y < 0 || check.Y > 1) ? 0 : check.Y; 
			menu.Tag = check;
			((ToolStripMenuItem) menu.DropDownItems[check.X]).Checked = true;
			((ToolStripMenuItem) menu.DropDownItems[check.Y + sep + 1]).Checked = true;
		}
		
		/// <summary>
		/// Close database connection, save session settings
		/// </summary>
		private void MainFormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			foreach(ControlBinding control in controlBindings)
			{
				control.WriteValue();
			}
			
			Options.Save();
			Model.Close();
			Console.WriteLine(Lang.GetString("_applicationClosing"));
		}
		
		/// <summary>
		/// Exit application
		/// </summary>
		private void ExitApplication(object sender, EventArgs e)
		{
			Dispose();
		}

		/// <summary>
		/// On startup or if cakeboxes changed update the datasource of the newDiscCakebox
		/// and the status bar stats labels. If filter is off cakeboxesListBox and newDiscCakebox
		/// share the same datasource, if it's on a new list of filtered cakeboxes is generated.
		/// To fix the way c# handles empty datasource and listbox selected value changed event
		/// we have to also call manually the showdiscs event. Optionaly if the selected value is > 0
		/// a cakebox is autoselected by the id number.
		/// </summary>
		/// <param name="selectValue">Cakebox id to auto select</param>
		/// <param name="refreshCakeboxesCache">Whether or not to refresh cakeboxes cache</param>
		/// <param name="refreshDiscStats">Refresh or not the discs/files stats</param>
		public void ShowCakeboxes(int selectValue = 0, Boolean refreshCakeboxesCache = false, Boolean refreshDiscStats = false)
		{
			if(refreshCakeboxesCache)
			{
				discCakeboxComboBox.DataSource = Model.FetchCakeboxes();
				RefreshStatusBar(true, refreshDiscStats);
			}

			Point sort = (Point) SortCakeboxesMenu.Tag;
			// Stupid controls sharing datasource behavior fix
			cakeboxesListBox.BindingContext = new BindingContext();
			cakeboxesListBox.SelectedValueChanged -= ShowDiscs;
			cakeboxesListBox.DataSource = Model.FetchCakeboxes(_filterLike, sort.X, sort.Y);
			cakeboxesListBox.SelectedValueChanged += ShowDiscs;
			cakeboxesGroupBox.InsertDesc(cakeboxesListBox.Items.Count);
			
			if(cakeboxesListBox.Items.Count == 0)
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
		/// To fix the way c# handles empty datasource and listbox selected value changed event
		/// we have to also call manually the ShowFiles event.
		/// </summary>
		public void ShowDiscs(object sender, EventArgs e)
		{
			Point sort = (Point) SortDiscsMenu.Tag;
			discsListBox.SelectedValueChanged -= ShowFiles;
			discsListBox.DataSource = (cakeboxesListBox.SelectedIndex > -1) ? Model.FetchDiscsByCakeboxId(cakeboxesListBox.SelectedValue.ToInt(), _filterLike, sort.X, sort.Y) : new List<Identity>();
			discsListBox.SelectedValue = 0;
			discsListBox.SelectedValueChanged += ShowFiles;
			ShowFiles(sender, e);
			discsGroupBox.InsertDesc(discsListBox.Items.Count);
		}
		
		/// <summary>
		/// Show disc files based on discs list box selection and highlight filter strings
		/// </summary>
		private void ShowFiles(object sender, EventArgs e)
		{
			filesTextBox.Clear();
			if(discsListBox.SelectedIndex > -1)
			{
				Cursor.Current = Cursors.WaitCursor;
				object[] result = Model.FetchFilesListByDiscId(discsListBox.SelectedValue.ToInt());
				int added = result[2].ToInt();
				discAddedLabel.InsertDesc((added > 0) ? added.Date() : Lang.GetString("_unknownDate"));
				discAddedLabel.Visible = true;
				filesGroupBox.InsertDesc(result[1].ToInt());
				filesTextBox.Text = result[0].ToString();

				if(_filter != null)
				{
					int start, pos, keyLength;
					int end = filesTextBox.Text.Length;
					foreach(string key in filterTextBox.Text.Split(' '))
					{
						keyLength = key.Length;
						start = pos = 0;
						while((pos = filesTextBox.Find(key, start, -1, RichTextBoxFinds.None)) > -1)
						{
							filesTextBox.Select(pos, keyLength);
							filesTextBox.SelectionBackColor = Color.Yellow;
							start = pos + keyLength;
						}
					}
				}
				Cursor.Current = Cursors.Default;
			}
			else
			{
				discAddedLabel.Visible = false;
				filesGroupBox.InsertDesc(0);
			}
		}
		
		/// <summary>
		/// Start/Reset filter timer while typing to avoid useless db queries
		/// </summary>
		private void FilterTextBoxTextChanged(object sender, EventArgs e)
		{
			if(filterTextChangedTimer.Enabled)
			{
				filterTextChangedTimer.Stop();
			}
			filterTextChangedTimer.Start();
		}
		
		/// <summary>
		/// Set the filelist selected text as the filter text
		/// </summary>
		private void FilterMenuItemClick(object sender, EventArgs e)
		{
			filterTextBox.Text = filesTextBox.SelectedText.Trim();
		}
		
		/// <summary>
		/// Stop filter timer, construct filterLike keywords and refresh cakeboxes if necessary
		/// </summary>
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
		/// <param name="cakebox">True or False to update cakeboxes total counter</param>
		/// <param name="disc">True or False to update discs and files total counter</param>
		private void RefreshStatusBar(Boolean cakebox = false, Boolean disc = false)
		{
			if(cakebox)
			{
				totalCakeboxesLabel.InsertDesc(Model.GetTotalCakeboxes());
			}
			if(disc)
			{
				totalDiscsLabel.InsertDesc(Model.GetTotalDiscs());
				totalFilesLabel.InsertDesc(Model.GetTotalFiles());
			}
		}

		/// <summary>
		/// Open a folder browseer dialog to set the scan path
		/// </summary>
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
		private void ScanWorkerToggle(object sender, EventArgs e)
		{
			saveDiscButton.Enabled = false;
			if(!scanWorker.IsBusy)
			{
				string path = scanPathComboBox.Text.Trim().TrimEnd(Path.DirectorySeparatorChar);
				if(Directory.Exists(path))
				{
					path = Path.GetFullPath(path + Path.DirectorySeparatorChar);
					scanPathComboBox.Text = path;
					Console.WriteLine(Lang.GetString("_scanStarting", path));
					stopWatch = DateTime.Now;
					scanFilesTextBox.Focus();
					scanWorker.RunWorkerAsync(path);
					scanFilesTextBox.Clear();
					discLabelTextBox.Clear();
					toggleScanPathButton.Image = Properties.Images.ui_stop;
					scanPathComboBox.Enabled = false;
					discLabelTextBox.Enabled = false;
					browseScanPathButton.Enabled = false;
				}
				else
				{
					scanFilesTextBox.Text = Lang.GetString("_pathXnotavailabe", path);
				}
			}
			else
			{
				scanWorker.CancelAsync();
				toggleScanPathButton.Image = Properties.Images.ui_play;
				browseScanPathButton.Enabled = true;
			}
		}
		
		/// <summary>
		/// Reset scan controls
		/// </summary>
		private void ScanWorkerReset(object sender, EventArgs e)
		{
			if(scanWorker.IsBusy)
			{
				scanWorker.CancelAsync();
			}
			else
			{
				discLabelTextBox.Clear();
				scanFilesTextBox.Clear();
				discLabelTextBox.Enabled = false;
				saveDiscButton.Enabled = false;
			}
		}
		
		/// <summary>
		/// Scan worker start walking the dir tree with stack push/pop
		/// Update UI every 100 found files
		/// </summary>
		private void ScanWorkerDoWork(object sender, DoWorkEventArgs e)
		{
			string root = e.Argument.ToString();
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
					e.Cancel = true;
					return;
				}
				
				string path = pending.Pop();
				string[] files = null;
				string[] dirs = null;
				try
				{
					files = Directory.GetFiles(path);
					dirs = Directory.GetDirectories(path);
					foreach(string dir in dirs.Reverse())
					{
						pending.Push(dir);
					}
					foreach(string file in files)
					{
						i++;
						buf.Append(file.Substring(rootLength) + "\n");
					}
					
					if(i > 100)
					{
						ScanWorkerUpdateRTB(buf, i);
						buf.Clear();
						i = 0;
					}
				}
				catch {}
			}
			if(i > 0)
			{
				ScanWorkerUpdateRTB(buf, i);
			}
		}

		/// <summary>
		/// Invoke update rtb with scanworker file lists
		/// </summary>
		/// <param name="buf">StringBuilder with the batch of files listed</param>
		/// <param name="files">Number of files listed</param>
		private void ScanWorkerUpdateRTB(StringBuilder buf, int files)
		{
			scanFilesTextBox.Invoke(new MethodInvoker(delegate
			                                          {
			                                          	scanFilesTextBox.AppendText(buf.ToString());
			                                          	scanTotalFiles += files;
			                                          }));
		}
		
		/// <summary>
		/// Show scan worker cancelled/completed results
		/// </summary>
		private void ScanWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			scanFilesTextBox.ScrollToCaret();
			scanPathComboBox.Enabled = true;
			browseScanPathButton.Enabled = true;
			toggleScanPathButton.Image = Properties.Images.ui_play;
			if(e.Cancelled)
			{
				scanFilesTextBox.Clear();
				discLabelTextBox.Clear();
				discLabelTextBox.Enabled = false;
				saveDiscButton.Enabled = false;
				Console.WriteLine(Lang.GetString("_scanWasCanceled"));
			}
			else
			{
				Console.WriteLine(Lang.GetString("_scanWasCompleted", scanTotalFiles, (DateTime.Now - stopWatch).TotalSeconds));
				discLabelTextBox.Text = new DriveInfo(scanPathComboBox.Text).VolumeLabel;
				discLabelTextBox.Enabled = true;
				saveDiscButton.Enabled = true;
			}
		}

		/// <summary>
		/// Add new disc with the scan worker results
		/// New disc label and cakebox are required fields
		/// </summary>
		private void SaveNewDisc(object sender, EventArgs e)
		{
			string label = discLabelTextBox.Text.Trim();
			if(discCakeboxComboBox.SelectedIndex == -1)
			{
				MessageBox.Show(Lang.GetString("_newDiscMissingCakebox"), Lang.GetString("_error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			else if(label.Length == 0)
			{
				MessageBox.Show(Lang.GetString("_discLabelMissing"), Lang.GetString("_error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			else
			{
				Cursor.Current = Cursors.WaitCursor;
				Model.AddDisc(label, scanFilesTextBox.Text.Trim(), scanTotalFiles, discCakeboxComboBox.SelectedValue.ToInt(), DateTime.UtcNow.ToUnix());
				Cursor.Current = Cursors.Default;
				ShowCakeboxes();
				RefreshStatusBar(false, true);
				discLabelTextBox.Clear();
				scanFilesTextBox.Clear();
				scanFilesTextBox.Text = Lang.GetString("_newDiscAdded", label, discCakeboxComboBox.Text);
				saveDiscButton.Enabled = false;
			}
		}
		
		/// <summary>
		/// Delete cakebox, with confirmation dialog
		/// </summary>
		private void DeleteCakebox(object sender, EventArgs e)
		{
			if(discsListBox.Items.Count > 0)
			{
				MessageBox.Show(Lang.GetString("_cakeboxNotEmpty"), Lang.GetString("_error"), MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
			}
			else if(MessageBox.Show(Lang.GetString("_confirmDeleteCakebox", cakeboxesListBox.Text), Lang.GetString("_confirmTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				Model.DeleteCakebox(cakeboxesListBox.SelectedValue.ToInt());
				Console.WriteLine(Lang.GetString("_cakeboxDeleted", cakeboxesListBox.Text));
				ShowCakeboxes(0, true);
				RefreshStatusBar(true, false);
			}
		}
		
		/// <summary>
		/// Open mass move discs dialog
		/// </summary>
		private void OpenMassMove(object sender, EventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				int source = cakeboxesListBox.SelectedValue.ToInt();
				if(new MassMove(source, discsListBox.DataSource, discCakeboxComboBox.DataSource).ShowDialog(this) == DialogResult.OK)
				{
					ShowCakeboxes();
				}
			}
		}
		
		/// <summary>
		/// Open edit disc dialog
		/// </summary>
		private void OpenEditDisc(object sender, EventArgs e)
		{
			// Just making sure we have a disc list with a selected cakebox
			if(discsListBox.SelectedIndex > -1 && cakeboxesListBox.SelectedIndex > -1)
			{
				int id = discsListBox.SelectedValue.ToInt();
				int boxId = cakeboxesListBox.SelectedValue.ToInt();
				if(new EditDisc(id, boxId, discCakeboxComboBox.DataSource).ShowDialog(this) == DialogResult.OK)
				{
					if(_filter != null)
					{
						ShowCakeboxes();
					}
					else
					{
						ShowDiscs(sender, e);
					}
				}
			}
		}

		/// <summary>
		/// Delete disc, with confirmation dialog
		/// </summary>
		private void DeleteDisc(object sender, EventArgs e)
		{
			if(MessageBox.Show(Lang.GetString("_confirmDeleteDisc", discsListBox.Text), Lang.GetString("_confirmTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				Model.DeleteDisc(discsListBox.SelectedValue.ToInt());
				Console.WriteLine(Lang.GetString("_discDeleted", discsListBox.Text));
				ShowDiscs(sender, e);
				RefreshStatusBar(false, true);
			}
		}
		
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SortMenuChanged(object sender, EventArgs e)
		{
			ToolStripMenuItem source = (ToolStripMenuItem) sender;
			ToolStripMenuItem parent = (ToolStripMenuItem) source.OwnerItem;
			
			int total = parent.DropDownItems.Count;
			int separator = total - 3;
			int index = parent.DropDownItems.IndexOf(source);
			int start = (index < separator) ? 0 : separator + 1;
			int end = (index < separator) ? separator : total;
			
			for(int i = start; i < end; i++)
			{
				ToolStripMenuItem item = (ToolStripMenuItem) parent.DropDownItems[i];
				item.Checked = (source == item);
			}
			
			Point p = (Point) parent.Tag;
			if(index < separator)
			{
				p.X = source.Tag.ToInt();
			}
			else
			{
				p.Y = source.Tag.ToInt();
			}
			parent.Tag = p;
			
			if(parent == SortCakeboxesMenu)
			{
				ShowCakeboxes();
			}
			else
			{
				ShowDiscs(null, EventArgs.Empty);
			}
		}
		
		/// <summary>
		/// Clear console text
		/// </summary>
		private void ClearConsole(object sender, EventArgs e)
		{
			consoleTextBox.Clear();
		}
		
		/// <summary>
		/// Get the search engine url from the ToolStripMenuItem's Tag property
		/// combine it with the file list processed selected text and open link in
		/// the default browser
		/// </summary>
		private void OpenSearchUrl(object sender, EventArgs e)
		{
			ToolStripMenuItem source = (ToolStripMenuItem) sender;
			string link = String.Format(source.Tag.ToString(), Regex.Replace(filesTextBox.SelectedText.Trim(), @"\s+", "+"));
			System.Diagnostics.Process.Start(link);
		}
		
		/// <summary>
		/// Globalized Copy command for richtextboxes and listboxes
		/// It can be extended to work with more controls if needed
		/// </summary>
		private void ContextCopyClick(object sender, EventArgs e)
		{
			ToolStripMenuItem source = (ToolStripMenuItem) sender;
			ContextMenuStrip parent = (ContextMenuStrip) source.GetCurrentParent();
			if(parent.SourceControl is RichTextBox)
			{
				RichTextBox rtb = (RichTextBox) parent.SourceControl;
				rtb.Copy();
			}
			else if(parent.SourceControl is ListBox)
			{
				ListBox lb = (ListBox) parent.SourceControl;
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
		private void OpenAddCakeboxForm(object sender, EventArgs e)
		{
			if(new EditCakebox().ShowDialog(this) == DialogResult.OK)
			{
				ShowCakeboxes(0, true);
			}
		}
		
		/// <summary>
		/// Open edit cakebox dialog
		/// </summary>
		private void OpenEditCakeboxForm(object sender, EventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				int id = cakeboxesListBox.SelectedValue.ToInt();
				if(new EditCakebox(id, cakeboxesListBox.Text).ShowDialog(this) == DialogResult.OK)
				{
					ShowCakeboxes(id, true);
				}
			}
		}

		/// <summary>
		/// Open changelog dialog
		/// </summary>
		private void OpenChangelog(object sender, EventArgs e)
		{
			new Changelog().ShowDialog(this);
		}
		
		/// <summary>
		/// Rebuild file counters (Deprecated)
		/// </summary>
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
		private void DropData(object sender, EventArgs e)
		{
			if(MessageBox.Show(Lang.GetString("_confirmDropData"), Lang.GetString("_confirmTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				Cursor.Current = Cursors.WaitCursor;
				stopWatch = DateTime.Now;
				Model.DropTables();
				Model.Install();
				ShowCakeboxes(0, true, true);
				Cursor.Current = Cursors.Default;
				Console.WriteLine(Lang.GetString("_dropData", (DateTime.Now - stopWatch).TotalSeconds));
			}
		}
		
		/// <summary>
		/// Export xml database backup
		/// </summary>
		private void ExportXml(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.SelectedPath = Options.LastBackupDir;
			if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				Cursor.Current = Cursors.WaitCursor;
				stopWatch = DateTime.Now;
				SQLiteXmlFile.Save(Path.Combine(folderBrowserDialog.SelectedPath, DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".xml"));
				Options.LastBackupDir = folderBrowserDialog.SelectedPath;
				Cursor.Current = Cursors.Default;
				Console.WriteLine(Lang.GetString("_exportCompleted", (DateTime.Now - stopWatch).TotalSeconds));
			}
		}
		
		/// <summary>
		/// Import xml database backup
		/// </summary>
		private void ImportXml(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Options.LastBackupDir;
			openFileDialog.Filter = Lang.GetString("_xmlFilesDesc");
			openFileDialog.Title = Lang.GetString("_selectBackupFile");
			
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Cursor.Current = Cursors.WaitCursor;
				stopWatch = DateTime.Now;
				int records = SQLiteXmlFile.Load(openFileDialog.FileName);
				ShowCakeboxes(0, true, true);
				Options.LastBackupDir = Path.GetDirectoryName(openFileDialog.FileName);
				Cursor.Current = Cursors.Default;
				Console.WriteLine(Lang.GetString("_importCompleted", records, (DateTime.Now - stopWatch).TotalSeconds));
			}
		}
		
		/// <summary>
		/// Toggle always on top window option
		/// </summary>
		private void ToggleAlwaysOnTop(object sender, EventArgs e)
		{
			this.TopMost = alwaysOnTopMenuItem.Checked = !this.TopMost;
		}
		
		/// <summary>
		/// Get every control property binding are set value to the application default setting
		/// </summary>
		private void ResetWindow(object sender, EventArgs e)
		{
			foreach(ControlBinding control in controlBindings)
			{
				control.ResetValue();
			}
		}
		
		/***********************************************************
			UI Behavior things, small stuff to enhance experience
		 ***********************************************************/

		/// <summary>
		/// Listbox select item on mouse down no matter what button
		/// </summary>
		private void ListBoxMouseDown(object sender, MouseEventArgs e)
		{
			ListBox listbox = (ListBox) sender;
			listbox.SelectedIndex = listbox.IndexFromPoint(e.X, e.Y);
		}
		
		/// <summary>
		/// Hide delete option on cakeboxes listbox if it containns discs
		/// or cancel menu opening if nothing is selected
		/// </summary>
		private void CakeboxesMenuOpening(object sender, CancelEventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				deleteCakeboxMenuItem.Enabled = discsListBox.Items.Count == 0;
				massMoveDiscsMenuItem.Enabled = discsListBox.Items.Count > 0;
			}
			else
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// Cancel files list action menu if nothing is selected
		/// </summary>
		private void FilesListMenuOpening(object sender, CancelEventArgs e)
		{
			if(filesTextBox.SelectedText.Trim().Length == 0)
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// Cancel discs list box action menu if nothing is selected
		/// </summary>
		private void DiscsMenuOpening(object sender, CancelEventArgs e)
		{
			if(discsListBox.SelectedIndex == -1)
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// Set enabled status for copy menu item based on console selectedtext length
		/// </summary>
		private void ConsoleMenuOpening(object sender, CancelEventArgs e)
		{
			copyConsoleMenuItem.Enabled = consoleTextBox.SelectedText.Trim().Length > 0;
		}
		
		/// <summary>
		/// Set enabled status for copy menu item based on scan file list selectedtext length
		/// </summary>
		private void ScanLogMenuOpening(object sender, CancelEventArgs e)
		{
			copyScanFileListMenuItem.Enabled = scanFilesTextBox.SelectedText.Trim().Length > 0;
		}
		
		/// <summary>
		/// Display in a tooltip the Identity Key when you mouse over listboxes
		/// </summary>
		private void IdentityMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ListBox source = (ListBox) sender;
			int index = source.IndexFromPoint(e.X, e.Y);
			if (index >= 0)
			{
				if(ListBoxLastTip != index)
				{
					Identity item = (Identity) source.Items[index];
					toolTip.SetToolTip(source, Lang.GetString("_itemX", item.Key));
					ListBoxLastTip = index;
				}
			}
			else
			{
				toolTip.Hide(source);
			}
		}
		
		private void RebuildDiscCounters(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			stopWatch = DateTime.Now;
			Model.RebuildDiscCounters();
			Console.WriteLine(Lang.GetString("_rebuildingFileCountersCompleted", (DateTime.Now - stopWatch).TotalSeconds));
			Cursor.Current = Cursors.Default;
		}

	}
}