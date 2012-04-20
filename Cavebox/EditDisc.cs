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
	public partial class EditDisc : Form
	{
		
		int _id;
		MainForm app;
		
		public EditDisc(MainForm form, int id, int cid, string label)
		{
			InitializeComponent();
			app = form;
			_id = id;
			discCakebox.DataSource = app.newDiscCakebox.DataSource;
			discLabel.Text = label;
			discCakebox.SelectedValue = cid;
		}
		
		private void saveDisc(object sender, EventArgs e)
		{
			String label = discLabel.Text.Trim();
			int cid = Convert.ToInt32(discCakebox.SelectedValue.ToString());
			if(label.Length > 0)
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
				closeForm(sender, e);
			}
		}
		
		private void closeForm(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}