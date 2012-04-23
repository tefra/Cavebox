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

namespace Cavebox
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<Index> cakeboxes = null;
		string _filter;
		string _filterLike;
		int scanTotalFiles = 0;
		int discsOrderBy = 1;
		int discsOrderWay = 0;
		DateTime stopWatch;

		public MainForm()
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
			ShowCakeboxes(0, true);
			scanPathTextBox.DataSource = DriveInfo.GetDrives().Where(d => d.Name != String.Empty  /*d.DriveType == DriveType.CDRom*/).ToArray();
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainFormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			Console.WriteLine(Lang.GetString("_applicationClosing"));
			Model.Close();
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitApplication(object sender, EventArgs e)
		{
			Dispose();
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public Boolean isFilterOn()
		{
			return _filter != null;
		}
		
		/// <summary>
		/// 
		/// </summary>
		private void BuildCakeboxesCache()
		{
			cakeboxes = Model.FetchCakeboxes();
			newDiscCakebox.DataSource = cakeboxes;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="selectValue"></param>
		/// <param name="refreshCakeboxesCache"></param>
		public void ShowCakeboxes(int selectValue = 0, Boolean refreshCakeboxesCache = false)
		{
			if(refreshCakeboxesCache)
			{
				BuildCakeboxesCache();
				RefreshStatusBar(true, true);
			}
			
			List<Index> newDataSource = Model.FetchCakeboxes(_filterLike);
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
		/// 
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ShowFiles(object sender, EventArgs e)
		{
			filesList.Clear();
			if(discsListBox.SelectedIndex > -1)
			{
				object[] result = Model.FetchFilesListByDiscId(discsListBox.SelectedValue.ToString());
				string files = result[0].ToString();
				int added = Convert.ToInt32(result[2]);
				int filesno = Convert.ToInt32(result[1]);
				filesList.Text = files;
				int start, pos, keyLength;
				int end = filesList.Text.Length;
				foreach(string key in filterTextBox.Text.Split(' '))
				{
					keyLength = key.Length;
					start = pos = 0;
					while((pos = filesList.Find(key, start, -1, RichTextBoxFinds.None)) > -1)
					{
						filesList.Select(pos, keyLength);
						filesList.SelectionBackColor = Color.Yellow;
						start = pos+keyLength;
					}
				}
				discAddedLabel.Visible = true;
				discAddedValueLabel.Visible = true;
				discAddedValueLabel.Text = (added > 0) ? new DateTime(1970, 1, 1).AddSeconds(added).ToLocalTime().ToString("dd/MM/yyyy HH:mm:ss") : Lang.GetString("_unknownDate");
				UpdateNumTitle(discFilesGroupBox, filesno);
			}
			else
			{
				discAddedLabel.Visible = false;
				discAddedValueLabel.Visible = false;
				UpdateNumTitle(discFilesGroupBox, 0);
			}
		}

		/// <summary>
		/// 
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
		/// 
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FilterOff(object sender, EventArgs e)
		{
			filterTextBox.TextChanged -= FilterTextBoxTextChanged;
			filterTextBox.Text = null;
			clearFilterButton.Enabled = false;
			_filter = _filterLike = null;
			ShowCakeboxes();
			filterTextBox.TextChanged += FilterTextBoxTextChanged;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cakebox"></param>
		/// <param name="disc"></param>
		public void RefreshStatusBar(Boolean cakebox = false, Boolean disc = false)
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
		/// 
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
		/// 
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScanWorkerStart(object sender, EventArgs e)
		{
			saveNewDiscButton.Enabled = false;
			if(!scanWorker.IsBusy)
			{
				string path = scanPathTextBox.Text;
				if(!path.EndsWith(Path.DirectorySeparatorChar.ToString()))
				{
					path += Path.DirectorySeparatorChar;
				}
				
				if(Directory.Exists(path))
				{
					Console.WriteLine(Lang.GetString("_scanStarting", path));
					stopWatch = DateTime.Now;
					scanLog.Focus();
					scanWorker.RunWorkerAsync(path);
					scanPathTextBox.Enabled = false;
					scanLog.Text = null;
					newDiscLabelTextBox.Text = null;
					newDiscLabelTextBox.Enabled = false;
					startScanButton.Enabled = false;
					stopScanButton.Enabled = true;
				}
				else
				{
					scanLog.Text = Lang.GetString("_pathXnotavailabe", path);
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScanWorkerStop(object sender, EventArgs e)
		{
			saveNewDiscButton.Enabled = false;
			if(scanWorker.IsBusy)
			{
				scanWorker.CancelAsync();
				startScanButton.Enabled = true;
				stopScanButton.Enabled = false;
			}
		}
		
		/// <summary>
		/// 
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
				newDiscLabelTextBox.Text = null;
				newDiscLabelTextBox.Enabled = false;
				saveNewDiscButton.Enabled = false;
				scanLog.Clear();
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="evt"></param>
		private void ScanWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs evt)
		{
			string root = evt.Argument as string;
			scanTotalFiles = 0;
			WalkTree(root, root.Length, evt);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="path"></param>
		/// <param name="substring"></param>
		/// <param name="e"></param>
		private void WalkTree(string path, int substring, DoWorkEventArgs e)
		{
			if(scanWorker.CancellationPending)
			{
				e.Cancel = true;
				return;
			}
			
			try
			{
				string[] files = Directory.GetFiles(path);
				StringBuilder buf = new StringBuilder();
				foreach(string file in files)
				{
					buf.AppendLine(file.Substring(substring));
				}
				scanLog.Invoke(new MethodInvoker(delegate
				                                 {
				                                 	scanLog.AppendText(buf.ToString());
				                                 	scanTotalFiles += files.Length;
				                                 }));

				string[] dirs = Directory.GetDirectories(path);
				foreach(string dir in dirs)
				{
					WalkTree(dir, substring, e);
				}
			}
			catch
			{
				
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ScanWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			scanLog.ScrollToCaret();
			scanPathTextBox.Enabled = true;
			startScanButton.Enabled = true;
			stopScanButton.Enabled = false;
			if(e.Cancelled)
			{
				scanLog.Clear();
				newDiscLabelTextBox.Text = null;
				newDiscLabelTextBox.Enabled = false;
				saveNewDiscButton.Enabled = false;
				Console.WriteLine(Lang.GetString("_scanWasCanceled"));
			}
			else
			{
				Console.WriteLine(Lang.GetString("_scanWasCompleted", scanTotalFiles, (DateTime.Now - stopWatch).TotalSeconds));
				newDiscLabelTextBox.Text = new DriveInfo(scanPathTextBox.Text).VolumeLabel;
				newDiscLabelTextBox.Enabled = true;
				saveNewDiscButton.Enabled = true;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveNewDisc(object sender, EventArgs e)
		{
			string label = newDiscLabelTextBox.Text.Trim();
			string files = scanLog.Text.Trim();
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
				scanLog.Text = Lang.GetString("_newDiscAdded", label, clabel);
				scanLog.ScrollToCaret();
				newDiscLabelTextBox.Text = null;
				saveNewDiscButton.Enabled = false;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChangelogToolStripMenuItemClick(object sender, EventArgs e)
		{
			new ChangelogForm().ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CakeboxesListBoxMouseDown(object sender, MouseEventArgs e)
		{
			cakeboxesListBox.SelectedIndex = cakeboxesListBox.IndexFromPoint(e.X, e.Y);
		}

		private void DiscsListBoxMouseDown(object sender, MouseEventArgs e)
		{
			discsListBox.SelectedIndex = discsListBox.IndexFromPoint(e.X, e.Y);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenNewCakeboxForm(object sender, EventArgs e)
		{
			new EditCakeboxForm(this).ShowDialog();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenEditCakeboxForm(object sender, EventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				int id = Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString());
				string label = cakeboxesListBox.Text;
				new EditCakeboxForm(this, id, label).ShowDialog();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteCakebox(object sender, EventArgs e)
		{
			if(discsListBox.Items.Count > 0)
			{
				MessageBox.Show(Lang.GetString("_cakeboxNotEmpty"), Lang.GetString("_error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			else if(MessageBox.Show(Lang.GetString("_confirmDeleteCakebox", cakeboxesListBox.Text), Lang.GetString("_confirmDelete"), MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Model.DeleteCakebox(Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString()));
				Console.WriteLine(Lang.GetString("_cakeboxDeleted", cakeboxesListBox.Text));
				ShowCakeboxes(0, true);
				RefreshStatusBar(true, false);
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenMassMoveForm(object sender, EventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				int id = Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString());
				new MassMoveForm(this, id).ShowDialog();
			}
		}
		
		/// <summary>
		/// 
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
				new EditDiscForm(this, id, cid, label).ShowDialog();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeleteDisc(object sender, EventArgs e)
		{
			if(MessageBox.Show(Lang.GetString("_confirmDeleteDisc", discsListBox.Text), Lang.GetString("_confirmDelete"), MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Model.DeleteDisc(Convert.ToInt32(discsListBox.SelectedValue.ToString()));
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearConsole(object sender, EventArgs e)
		{
			console.Clear();
		}
		
		/// <summary>
		/// 
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
			link  += String.Join("+", filesList.SelectedText.Trim().Replace("\n", " ").Split(' '));
			System.Diagnostics.Process.Start(link);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CakeboxesActionsMenuOpening(object sender, CancelEventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				deleteCakeboxMenuItem.Enabled = (discsListBox.Items.Count == 0);
			}
			else
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FilesListActionMenuOpening(object sender, CancelEventArgs e)
		{
			if(filesList.SelectedText.Trim().Length == 0)
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// 
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
		private void RebuildFileCounters(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			stopWatch = DateTime.Now;
			Model.RebuildFileCounters();
			Console.WriteLine(Lang.GetString("_rebuildingFileCountersCompleted", (DateTime.Now - stopWatch).TotalSeconds));
			Cursor.Current = Cursors.Default;
		}
		
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExportXml(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
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
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ImportXml(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = Lang.GetString("_xmlFilesDesc");
			openFileDialog.Title = Lang.GetString("_selectBackupFile");
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Cursor.Current = Cursors.WaitCursor;
				stopWatch = DateTime.Now;
				new XMLImport(openFileDialog.FileName);
				Console.WriteLine(Lang.GetString("_importCompleted", (DateTime.Now - stopWatch).TotalSeconds));
				Cursor.Current = Cursors.Default;
				ShowCakeboxes(0, true);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyFilesListClick(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(filesList, true);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AlwaysOnTopMenuItemClick(object sender, EventArgs e)
		{
			Boolean check = !alwaysOnTopToolStripMenuItem.Checked;
			this.TopMost = check;
			alwaysOnTopToolStripMenuItem.Checked = check;
		}
		
		/// <summary>
		/// 
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
					AcceptButton = saveNewDiscButton;
					break;
					
				case 2:
					AcceptButton = null;
					break;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ResetWindow(object sender, EventArgs e)
		{
			this.CenterToScreen();
			this.Height = 600;
			this.Width = 550;
			cakeboxDiscSplitContainer.SplitterDistance = (cakeboxDiscSplitContainer.Width - cakeboxDiscSplitContainer.SplitterWidth) / 2;
			cakeboxDiscFileSplitContainer.SplitterDistance = 310;
		}
	}
}

/*private void ListBoxDrawItem(object sender, DrawItemEventArgs e)
{
ListBox listbox = (ListBox) sender;
int index = e.Index;
if (index >= 0 && index < listbox.Items.Count)
{
Graphics g = e.Graphics;
Color backcolor, forecolor;
if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
{
backcolor = SystemColors.Highlight;
forecolor = SystemColors.HighlightText;
}
else
{
backcolor = (index % 2 == 0) ? Color.WhiteSmoke :  Color.White;
forecolor = SystemColors.WindowText;
}

g.FillRectangle(new SolidBrush(backcolor), e.Bounds);
g.DrawString(listbox.Items[index].ToString(), e.Font, new SolidBrush(forecolor), e.Bounds, StringFormat.GenericDefault);
}
e.DrawFocusRectangle();
}*/