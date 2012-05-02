/**
 * @version	$Id$
 * @author	Christodoulos Tsoulloftas
 * @link	http://www.t3-design.com
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Cavebox.Lib;

namespace Cavebox.Forms
{
	/// <summary>
	/// Mass move discs from one cakebox to another
	/// </summary>
	public partial class MassMove : Form
	{
		Main app;
		Boolean checkFlag = false;
		int source;
		
		/// <summary>
		/// Initialize components and their values from main form
		/// </summary>
		/// <param name="form">Main form instance</param>
		/// <param name="cid">Cakebox id number</param>
		public MassMove(Main form, int cid)
		{
			InitializeComponent();
			app = form;
			source = cid;
			selectDiscs.DisplayMember = "Value";
			selectDiscs.ValueMember = "Id";
			selectDiscs.DataSource = app.discsListBox.DataSource;
			selectCakebox.DataSource = app.newDiscCakebox.DataSource;
			selectCakebox.SelectedValue = source;
		}
	
		/// <summary>
		/// Displose form
		/// </summary>
		private void closeForm(object sender, EventArgs e)
		{
			Dispose();
		}
		
		/// <summary>
		/// Move selected discs to selected cakebox
		/// </summary>
		private void MoveButtonClick(object sender, EventArgs e)
		{
			int target = getTargetCakeboxId();
			if(target != source && selectDiscs.CheckedItems.Count > 0)
			{
				Console.WriteLine(Lang.GetString("_movingDiscs", selectCakebox.SelectedItem));
				List<int> discs = new List<int>();
				foreach(object itemChecked in selectDiscs.CheckedItems)
				{
					Identity item = (Identity) itemChecked;
					discs.Add(item.Key);
					Console.Write(item.Value+"\n");
				}
				Model.MoveDiscs(target, discs);
				app.ShowCakeboxes();
				closeForm(sender, e);
			}
		}
		
		/// <summary>
		/// Enable the move button when we have something to move
		/// </summary>
		private void enableMoveButton(object sender, EventArgs e)
		{
			moveButton.Enabled = (selectDiscs.CheckedItems.Count > 0 && getTargetCakeboxId() != source);
		}
		
		/// <summary>
		/// Fetch the cakebox Id from the listbox
		/// </summary>
		private int getTargetCakeboxId()
		{
			return Convert.ToInt32(selectCakebox.SelectedValue.ToString());
		}
		
		/// <summary>
		/// Select/Deselect all items
		/// </summary>
		private void ToggleButtonClick(object sender, EventArgs e)
		{
			checkFlag = !checkFlag;
			for(int i = 0; i < selectDiscs.Items.Count; i++)
			{
				selectDiscs.SetItemChecked(i, checkFlag);
			}
			enableMoveButton(sender, e);
		}
	}
}
