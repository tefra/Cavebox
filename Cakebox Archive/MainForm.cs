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
using System.Windows.Forms;

namespace Cakebox_Archive
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Model model;
		List<Index> cakeboxes = null;

		string _filter;
		string _filterLike;
		int scanTotalFiles = 0;
		int discsOrderBy = 1;
		int discsOrderWay = 0;

		public MainForm()
		{
			InitializeComponent();
			Console.SetOut(new ConsoleWriter(console));
			Console.WriteLine("Application started...");
			model = Model.Instance;
			showCakeboxes(-1, true);
			scanDrive.DataSource = DriveInfo.GetDrives().Where(d => /*d.DriveType == DriveType.CDRom &&*/ d.IsReady == true).ToArray();

		}

		public void MainFormLoad(object sender, EventArgs e)
		{

		}
		
		public void buildCakeboxesCache()
		{
			cakeboxes = model.fetchCakeboxes();
			newDiscCakebox.DataSource = cakeboxes;
		}

		public void showCakeboxes(int selectValue = 0, Boolean refreshCakeboxesCache = false)
		{
			Console.WriteLine("showCakeboxes");

			if(refreshCakeboxesCache)
			{
				buildCakeboxesCache();
				refreshStatusBar(true, true);
			}

			List<Index> newDataSource = model.fetchCakeboxes(_filterLike);
			cakeboxesListBox.SelectedValueChanged -= showDiscs;
			cakeboxesListBox.DataSource = newDataSource;
			cakeboxesListBox.SelectedValueChanged += showDiscs;
			cakeboxesListBox.SelectedValue = selectValue;
			updateNumTitle(cakeboxesGroupBox, newDataSource.Count);
		}

		public void showDiscs(object sender, EventArgs e)
		{
			Console.WriteLine("showDiscs");
			List<Index> newDataSource = (cakeboxesListBox.SelectedIndex > -1) ? model.fetchDiscsByCakeboxId(cakeboxesListBox.SelectedValue.ToString(), _filterLike, discsOrderBy, discsOrderWay) : new List<Index>();
			discsListBox.SelectedValueChanged -= showFiles;
			discsListBox.DataSource = newDataSource;
			discsListBox.SelectedValue = 0;
			discsListBox.SelectedValueChanged += showFiles;
			showFiles(sender, e);
			updateNumTitle(discsGroupBox, newDataSource.Count);
		}

		public void showFiles(object sender, EventArgs e)
		{
			Console.WriteLine("showFiles");
			filesList.Clear();
			if(discsListBox.SelectedIndex > -1)
			{
				Tuple<string, int, int> result = model.fetchFilesListByDiscId(discsListBox.SelectedValue.ToString());
								filesList.Text = result.Item1;
				int start, pos, keyLength;
				int end = result.Item1.Length;
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
				
				
				string added = (result.Item3 > 0) ? new DateTime(1970, 1, 1).AddSeconds(result.Item3).ToLocalTime().ToString("dd/MM/yyyy HH:mm:ss") : "N/A";

				discAddedLabel.Visible = true;
				discAddedValueLabel.Visible = true;
				discAddedValueLabel.Text = added;
				

				
				updateNumTitle(discFilesGroupBox, result.Item2);
			}
			else
			{
				discAddedLabel.Visible = false;
				discAddedValueLabel.Visible = false;
				//discAddedValueLabel.Text = added;
				
				updateNumTitle(discFilesGroupBox, 0);
			}
		}

		public void filter(object sender, EventArgs e)
		{
			string filter = filterTextBox.Text.Trim();
			if(filter.Length > 0)
			{
				_filterLike = null;
				string[] tokens = filter.ToUpper().Split(' ');
				for(int i = 0; i < tokens.Length; i++)
				{
					_filterLike += "%" + tokens[i] + "%";
				}
				_filter = filter;
				clearFilterButton.Enabled = true;
			}
			else
			{
				clearFilterButton.Enabled = false;
				_filter = _filterLike = null;
			}

			showCakeboxes(0, false);
		}
		
		public void filterOff(object sender, EventArgs e)
		{
			filterTextBox.Text = null;
		}
		
		public void refreshStatusBar(Boolean cakebox = false, Boolean disc = false)
		{
			Console.WriteLine("refreshStatusBar");
			if(cakebox)
			{
				updateNumTitle(cakeboxStatsLabel, model.getTotalCakeboxes());
			}
			if(disc)
			{
				updateNumTitle(discStatsLabel, model.getTotalDiscs());
				updateNumTitle(fileStatsLabel, model.getTotalFiles());
			}
		}

		public void updateNumTitle(ToolStripLabel label, int num)
		{
			string title = label.Text.Split(':')[0].Trim();
			title += (num > 0) ? ": " + String.Format("{0:n0}", num) : null;
			label.Text = title;
		}

		public void updateNumTitle(GroupBox groupBox, int num)
		{
			string title = groupBox.Text.Split(':')[0].Trim();
			title += (num > 0) ? ": " + String.Format("{0:n0}", num) : null;
			groupBox.Text = title;
		}

		public void scanWorkerToggle(object sender, EventArgs e)
		{
			saveNewDiscButton.Enabled = false;
			if(scanWorker.IsBusy)
			{
				scanWorker.CancelAsync();
			}
			else
			{
				string drive = scanDrive.SelectedItem.ToString();
				if(new DriveInfo(drive).IsReady)
				{
					scanLog.Focus();
					scanWorker.RunWorkerAsync(drive);
					scanDrive.Enabled = false;
					scanLog.Text = null;
					newDiscLabelTextBox.Text = null;
					newDiscLabelTextBox.Enabled = false;
				}
				else
				{
					scanLog.Text = String.Format("Drive {0} is not ready...", drive);
				}
			}
		}

		public void scanWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			scanLog.ScrollToCaret();
			scanDrive.Enabled = true;
			if(e.Cancelled)
			{
				newDiscLabelTextBox.Text = null;
				newDiscLabelTextBox.Enabled = false;
				saveNewDiscButton.Enabled = false;
				scanLog.Text = "Scan was canceled...";
			}
			else
			{
				newDiscLabelTextBox.Text = new DriveInfo(scanDrive.SelectedItem.ToString()).VolumeLabel;
				newDiscLabelTextBox.Enabled = true;
				saveNewDiscButton.Enabled = true;
			}
		}

		public void scanWorkerReset(object sender, EventArgs e)
		{
			saveNewDiscButton.Enabled = false;
			if(scanWorker.IsBusy)
			{
				scanWorker.CancelAsync();
			}
			
			newDiscLabelTextBox.Text = null;
			newDiscLabelTextBox.Enabled = false;
			saveNewDiscButton.Enabled = false;
			scanLog.Clear();
		}
		
		public void scanWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs evt)
		{
			scanTotalFiles = 0;
			string drive = evt.Argument as string;

			foreach(string file in Directory.EnumerateFiles(drive, "*", SearchOption.AllDirectories))
			{
				if(scanWorker.CancellationPending)
				{
					evt.Cancel = true;
					return;
				}

				scanLog.Invoke(new MethodInvoker(delegate
				                                 {
				                                 	scanLog.AppendText(file.Substring(3)+"\n");
				                                 	scanTotalFiles++;
				                                 }));
			}
		}

		public void saveNewDisc(object sender, EventArgs e)
		{
			string label = newDiscLabelTextBox.Text.Trim();
			string files = scanLog.Text.Trim();
			
			if(newDiscCakebox.SelectedIndex == -1)
			{
				MessageBox.Show("You must select/create a cakebox before saving a new disc.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			else if(label.Length == 0)
			{
				MessageBox.Show("This disc label is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			else
			{
				DateTime Jan1st1970 = new DateTime (1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
				int added =  (int) (DateTime.UtcNow - Jan1st1970).TotalSeconds;
				string clabel = newDiscCakebox.Text;
				string cid = newDiscCakebox.SelectedValue.ToString();
				
				model.addDisc(label, files, scanTotalFiles.ToString(), cid, added.ToString());
				showCakeboxes();
				refreshStatusBar(false, true);
				scanLog.AppendText(String.Format("\nDisc '{0}' was added in cakebox '{1}'", label, clabel));
				scanLog.ScrollToCaret();
				newDiscLabelTextBox.Text = null;
				saveNewDiscButton.Enabled = false;
			}

		}

		public void ChangelogToolStripMenuItemClick(object sender, EventArgs e)
		{
			new Changelog().ShowDialog();
		}

		private void CakeboxesListBoxMouseDown(object sender, MouseEventArgs e)
		{
			cakeboxesListBox.SelectedIndex = cakeboxesListBox.IndexFromPoint(e.X, e.Y);
		}

		private void DiscsListBoxMouseDown(object sender, MouseEventArgs e)
		{
			discsListBox.SelectedIndex = discsListBox.IndexFromPoint(e.X, e.Y);
		}

		private void openNewCakeboxForm(object sender, EventArgs e)
		{
			new EditCakebox(this).ShowDialog();
		}

		private void openEditCakeboxForm(object sender, EventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				int id = Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString());
				string label = cakeboxesListBox.Text;
				new EditCakebox(this, id, label).ShowDialog();
			}
		}

		private void deleteCakebox(object sender, EventArgs e)
		{
			if(discsListBox.Items.Count > 0)
			{
				MessageBox.Show("You can't delete a cakebox which isn't empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

			}
			else if(MessageBox.Show("Are you sure you want to delete cakebox: "+cakeboxesListBox.Text,"Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				model.deleteCakebox(Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString()));
				showCakeboxes(-1, true);
				refreshStatusBar(true, false);
			}
		}
		
		void openMassMoveForm(object sender, EventArgs e)
		{
			if(cakeboxesListBox.SelectedIndex > -1)
			{
				int id = Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString());

				new MassMove(this, id).Show();
			}
		}
		private void openEditDiscForm(object sender, EventArgs e)
		{
			if(discsListBox.SelectedIndex > -1 && cakeboxesListBox.SelectedIndex > -1)
			{
				int id = Convert.ToInt32(discsListBox.SelectedValue.ToString());
				int cid = Convert.ToInt32(cakeboxesListBox.SelectedValue.ToString());
				//string label = discsListBox.Text;
				string label = model.fetchDiscLabelById(id);
				new EditDisc(this, id, cid, label).ShowDialog();
			}
		}

		private void deleteDisc(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to delete disc: "+discsListBox.Text,"Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				model.deleteDisc(Convert.ToInt32(discsListBox.SelectedValue.ToString()));
				showDiscs(sender, e);
				refreshStatusBar(false, true);
			}
		}

		private void listBoxDrawItem(object sender, DrawItemEventArgs e)
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
				/* Draw Background */
				g.FillRectangle(new SolidBrush(backcolor), e.Bounds);

				/* Draw Item Text */
				g.DrawString(listbox.Items[index].ToString(), e.Font, new SolidBrush(forecolor), e.Bounds, StringFormat.GenericDefault);

			}
			e.DrawFocusRectangle();
		}

		private void sortDiscs(object sender, EventArgs e)
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
				showDiscs(sender, e);
			}
		}
		
		private void clearConsole(object sender, EventArgs e)
		{
			console.Clear();
		}
		
		private void openSearchUrl(object sender, EventArgs e)
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
		
		private void FilesListActionMenuOpening(object sender, CancelEventArgs e)
		{
			if(filesList.SelectedText.Trim().Length == 0)
			{
				e.Cancel = true;
			}
		}
		
		void DiscsActionsMenuOpening(object sender, CancelEventArgs e)
		{
			if(discsListBox.SelectedIndex == -1)
			{
				e.Cancel = true;
			}
		}
		
		private void rebuildFileCounters(object sender, EventArgs e)
		{
			Console.WriteLine("rebuildFileCounters");
			model.rebuildFileCounters();
		}
		
		private void exportXml(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				string file = folderBrowserDialog.SelectedPath + Path.DirectorySeparatorChar + DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".xml";
				new XMLExport(file);
			}
		}
		
		private void importXml(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "XML Files|*.xml";
			openFileDialog.Title = "Select a backup File";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				new XMLImport(openFileDialog.FileName);
				showCakeboxes(0, true);
			}
		}
	}
}