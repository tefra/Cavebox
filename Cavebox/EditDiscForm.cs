/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cavebox
{
	/// <summary>
	/// Description of EditDisc.
	/// </summary>
	public partial class EditDiscForm : Form
	{
		
		int _id;
		int _cid;
		string _label;
		MainForm app;
		
		public EditDiscForm(MainForm form, int id, int cid, string label)
		{
			InitializeComponent();
			app = form;
			_id = id;
			_cid = cid;
			_label = label;
			selectCakebox.DataSource = app.newDiscCakebox.DataSource;
			discLabel.Text = label;
			selectCakebox.SelectedValue = cid;
		}
		
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
		
		private void CloseForm(object sender, EventArgs e)
		{
			Dispose();
		}
		
		private void enableSaveButton(object sender, EventArgs e)
		{
			string label = discLabel.Text.Trim();
			saveButton.Enabled = ((label != _label && label.Length > 0) || getTargetCakeboxId() != _cid);
		}
		
		private int getTargetCakeboxId()
		{
			return Convert.ToInt32(selectCakebox.SelectedValue.ToString());
		}
		
	}
}