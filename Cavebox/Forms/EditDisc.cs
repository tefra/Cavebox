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
		
		/// <summary>
		/// Initialize components and their values
		/// </summary>
		/// <param name="id">Disc id number</param>
		/// <param name="cakeboxes">Cakeboxes Identity List</param>
		public EditDisc(int id, int cid, object cakeboxes)
		{
			InitializeComponent();
			this.Text += " #" + id;
			this.id = id;
			discLabel.Text = this.label = Model.FetchDiscLabelById(id);
			selectCakebox.DataSource = cakeboxes;
			selectCakebox.SelectedValue = this.cid = cid;
		}
		
		/// <summary>
		/// Update disc notify main form to update either discs or cakeboxes list
		/// </summary>
		private void SaveDisc(object sender, EventArgs e)
		{
			string newLabel = discLabel.Text.Trim();
			int newCid = selectCakebox.SelectedValue.ToInt();
			if((label != newLabel && newLabel.Length > 0) || cid != newCid)
			{
				Model.UpdateDisc(id, newCid, newLabel);
				Console.WriteLine(Lang.GetString("_updatedDisc", id));
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
			saveButton.Enabled = ((label != newLabel && newLabel.Length > 0) || selectCakebox.SelectedValue.ToInt() != cid);
		}
	}
}