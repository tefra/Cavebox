/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cakebox_Archive
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
		
		void saveCakebox(object sender, EventArgs e)
		{
			String label = cakeboxLabel.Text.Trim();
			if(label.Length > 0)
			{
				Model.Instance.saveCakebox(label, _id);
				app.refreshStatusBar(true, false);
				app.showCakeboxes(_id, true);
				closeForm(sender, e);
			}
		}
		
		void closeForm(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
