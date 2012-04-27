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
	public partial class EditCakeboxForm : Form
	{
		int _id;
		string _label;
		MainForm app;
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="form"></param>
		/// <param name="id"></param>
		/// <param name="label"></param>
		public EditCakeboxForm(MainForm form, int id = 0, string label = null)
		{
			InitializeComponent();
			if(id > 0)
			{
				this.Text += " #"+id;
			}
			app = form;
			_id = id;
			_label = label;
			cakeboxLabel.Text = label;
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseForm(object sender, EventArgs e)
		{
			Dispose();
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CakeboxLabelTextChanged(object sender, EventArgs e)
		{
			string label = cakeboxLabel.Text.Trim();
			saveButton.Enabled = (label != _label && label.Length > 0);
		}
	}
}