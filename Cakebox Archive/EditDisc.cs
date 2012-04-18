/*
 * Created by SharpDevelop.
 * User: Tefra
 * Date: 16/4/2012
 * Time: 10:47 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cakebox_Archive
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
			discCakebox.DataSource = app.selectCakeboxToStore.DataSource;
			discLabel.Text = label;
			discCakebox.SelectedValue = cid;
		}
		
		void saveDisc(object sender, EventArgs e)
		{
			String label = discLabel.Text.Trim();
			int cid = int.Parse(discCakebox.SelectedValue.ToString());
			if(label.Length > 0)
			{
				Model.Instance.saveDisc(_id, cid, label);
				app.showDiscs(sender, e);
				closeForm(sender, e);
			}
		}
		
		void closeForm(object sender, EventArgs e)
		{
			Dispose();
			
		}
	}
}