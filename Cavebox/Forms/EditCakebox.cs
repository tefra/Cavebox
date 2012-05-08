/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Cavebox.Lib;

namespace Cavebox.Forms
{
	/// <summary>
	/// Edit cakebox information
	/// </summary>
	public partial class EditCakebox : Form
	{
		int _id;
		string _label;
		Main app;

		/// <summary>
		/// Initialize components and their values from main form
		/// </summary>
		/// <param name="form">Main form instance</param>
		/// <param name="id">Cakebox id number (optional for edit/insert)</param>
		/// <param name="label">Cakebox label text</param>
		public EditCakebox(Main form, int id = 0, string label = null)
		{
			InitializeComponent();
			

			
			this.Text = (id > 0) ? Lang.GetString("_editCakebox", id.ToString()) : Lang.GetString("_addNewCakebox");
			
			app = form;
			_id = id;
			_label = label;
			cakeboxLabel.Text = label;
		}
		
		/// <summary>
		/// Insert/Update cakebox label notify main form to update
		/// </summary>
		private void SaveCakebox(object sender, EventArgs e)
		{
			String label = cakeboxLabel.Text.Trim();
			if(label != _label && label.Length > 0)
			{
				Console.WriteLine((_id > 0) ? Lang.GetString("_updatedCakebox", _id) : Lang.GetString("_addedNewCakebox", label));
				Model.SaveCakebox(label, _id);
				app.ShowCakeboxes(_id, true);
				CloseForm(sender, e);
			}
		}
		
		/// <summary>
		/// Displose form
		/// </summary>
		private void CloseForm(object sender, EventArgs e)
		{
			Dispose();
		}
		
		/// <summary>
		/// Enable the save button when real changes were made
		/// </summary>
		private void CakeboxLabelTextChanged(object sender, EventArgs e)
		{
			string label = cakeboxLabel.Text.Trim();
			saveButton.Enabled = (label != _label && label.Length > 0);
		}
	}
}