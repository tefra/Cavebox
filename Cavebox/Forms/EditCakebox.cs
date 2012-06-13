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
	/// Edit cakebox information
	/// </summary>
	public partial class EditCakebox : Form
	{
		int id;
		string label;

		/// <summary>
		/// Initialize components and their values
		/// </summary>
		/// <param name="id">Cakebox id number (optional for edit/insert)</param>
		/// <param name="label">Cakebox label text</param>
		public EditCakebox(int id = 0, string label = null)
		{
			InitializeComponent();
			this.id = id;
			this.Text = (id > 0) ? Lang.GetString("_editCakebox", id) : Lang.GetString("_addNewCakebox");
			this.label = (id > 0) ? Model.FetchCakeboxLabelById(id) : string.Empty;
			cakeboxLabel.Text = this.label;
		}
		
		/// <summary>
		/// Insert/Update cakebox label notify main form to update
		/// </summary>
		private void SaveCakebox(object sender, EventArgs e)
		{
			String newLabel = cakeboxLabel.Text.Trim();
			if(label != newLabel && newLabel.Length > 0)
			{
				Console.WriteLine((id > 0) ? Lang.GetString("_updatedCakebox", id) : Lang.GetString("_addedNewCakebox", newLabel));
				Model.SaveCakebox(newLabel, id);
			}
		}
		
		/// <summary>
		/// Enable the save button when real changes were made
		/// </summary>
		private void CakeboxLabelTextChanged(object sender, EventArgs e)
		{
			string newLabel = cakeboxLabel.Text.Trim();
			saveButton.Enabled = (newLabel != label && newLabel.Length > 0);
		}
	}
}