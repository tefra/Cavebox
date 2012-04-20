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
		string _label;
		MainForm app;
		
		public EditCakebox(MainForm form, int id = 0, string label = null)
		{
			InitializeComponent();
			app = form;
			_id = id;
			_label = label;
			if(id > 0)
			{
				this.Text += " #"+id;
			}
			
			cakeboxLabel.Text = label;
		}
		
		private void SaveCakebox(object sender, EventArgs e)
		{
			String label = cakeboxLabel.Text.Trim();
			if(label != _label && label.Length > 0)
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
				CloseForm(sender, e);
			}
		}
		
		private void CloseForm(object sender, EventArgs e)
		{
			Dispose();
		}
		
		private void CakeboxLabelTextChanged(object sender, EventArgs e)
		{
			string label = cakeboxLabel.Text.Trim();
			saveButton.Enabled = (label != _label && label.Length > 0);
		}
	}
}