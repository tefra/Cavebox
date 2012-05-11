/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Windows.Forms;
using Cavebox.Lib;

namespace Cavebox.Forms
{
	/// <summary>
	/// Edit disc information form
	/// </summary>
	public partial class EditDisc : Form
	{
		int id;
		int cid;
		string label;
		Main app;
		
		/// <summary>
		/// Initialize components and their values from main form
		/// </summary>
		/// <param name="form">Main form instance</param>
		/// <param name="id">Disc id number</param>
		/// <param name="cid">Disc's cakebox id number</param>
		public EditDisc(Main form, int id, int cid)
		{
			InitializeComponent();
			app = form;
			this.Text += " #" + id;
			this.id = id;
			this.cid = cid;
			selectCakebox.DataSource = app.newDiscCakebox.DataSource;
			discLabel.Text = this.label = Model.FetchDiscLabelById(id);
			selectCakebox.SelectedValue = cid;
		}
		
		/// <summary>
		/// Update disc notify main form to update either discs or cakeboxes list
		/// </summary>
		private void SaveDisc(object sender, EventArgs e)
		{
			string newLabel = discLabel.Text.Trim();
			int newCid = selectCakebox.SelectedIntValue();
			if((label != newLabel && newLabel.Length > 0) || cid != newCid)
			{
				Model.UpdateDisc(id, newCid, newLabel);
				Console.WriteLine(Lang.GetString("_updatedDisc", id));
				if(app._filter != null)
				{
					app.ShowCakeboxes();
				}
				else
				{
					app.ShowDiscs(sender, e);
				}
				CloseForm(sender, e);
			}
		}
		
		/// <summary>
		/// Dispose the form
		/// </summary>
		private void CloseForm(object sender, EventArgs e)
		{
			Dispose();
		}
		
		/// <summary>
		/// Enable the save button when real changes were made
		/// </summary>
		private void enableSaveButton(object sender, EventArgs e)
		{
			string newLabel = discLabel.Text.Trim();
			saveButton.Enabled = ((label != newLabel && newLabel.Length > 0) || selectCakebox.SelectedIntValue() != cid);
		}
	}
}