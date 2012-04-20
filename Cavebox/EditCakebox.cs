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
	/// Description of EditCakebox.
	/// </summary>
	public partial class EditCakebox : Form
	{
		int _id;
		MainForm app;
		
		public EditCakebox(MainForm form, int id = 0, string label = null)
		{
			InitializeComponent();
			app = form;
			_id = id;
			cakeboxLabel.Text = label;
		}
		
		private void saveCakebox(object sender, EventArgs e)
		{
			String label = cakeboxLabel.Text.Trim();
			if(label.Length > 0)
			{
				if(_id > 0)
				{
					Console.WriteLine(Lang.GetString("_updatedCakebox", _id));
				}
				else
				{
					Console.WriteLine(Lang.GetString("_addedNewCakebox", label));
				}
				Model.SaveCakebox(label, _id);
				app.RefreshStatusBar(true, false);
				app.ShowCakeboxes(_id, true);
				closeForm(sender, e);
			}
		}
		
		private void closeForm(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}