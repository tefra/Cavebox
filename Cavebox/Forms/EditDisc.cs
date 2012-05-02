/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using Cavebox.Lib;

namespace Cavebox.Forms
{
	/// <summary>
	/// Description of EditDisc.
	/// </summary>
	public partial class EditDisc : Form
	{
		int _id;
		int _cid;
		string _label;
		Main app;
		
		/// <summary>
		/// Initialize components and values
		/// </summary>
		/// <param name="form"></param>
		/// <param name="id"></param>
		/// <param name="cid"></param>
		/// <param name="label"></param>
		public EditDisc(Main form, int id, int cid, string label)
		{
			InitializeComponent();
			app = form;
			this.Text += " #" + id;
			_id = id;
			_cid = cid;
			_label = label;
			selectCakebox.DataSource = app.newDiscCakebox.DataSource;
			discLabel.Text = label;
			selectCakebox.SelectedValue = cid;
		}
		
		/// <summary>
		/// Update disc notify main form to update either discs or cakeboxes list
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveDisc(object sender, EventArgs e)
		{
			String label = discLabel.Text.Trim();
			int cid = getTargetCakeboxId();
			if((label != _label && label.Length > 0) || getTargetCakeboxId() != _cid)
			{
				Model.UpdateDisc(_id, cid, label);
				Console.WriteLine(Lang.GetString("_updatedDisc", _id));
				if(app.isFilterOn())
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
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseForm(object sender, EventArgs e)
		{
			Dispose();
		}
		
		/// <summary>
		/// Enable the save button when changes were made
		/// Disable otherwrise
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void enableSaveButton(object sender, EventArgs e)
		{
			string label = discLabel.Text.Trim();
			saveButton.Enabled = ((label != _label && label.Length > 0) || getTargetCakeboxId() != _cid);
		}
		
		/// <summary>
		/// Get the id of the selected cakebox
		/// </summary>
		/// <returns></returns>
		private int getTargetCakeboxId()
		{
			return Convert.ToInt32(selectCakebox.SelectedValue.ToString());
		}
		
	}
}